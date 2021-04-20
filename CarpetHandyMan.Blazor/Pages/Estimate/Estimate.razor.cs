using Blazored.Modal;
using Blazored.Modal.Services;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Blazor.Pages.Modals;
using CarpetHandyMan.Shared.Carpets;
using CarpetHandyMan.Shared.Rooms;
using CarpetHandyMan.Shared.Staircases;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Estimate
{
    public class EstimateBase : ComponentBase
    {
        [Inject] ICarpetService CarpetService { get; set; }
        [Inject] IRoomService RoomService { get; set; }
        [Inject] IStaircaseService StaircaseService { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        public Guid BuildingId = Guid.Parse("bac8fdb0-1232-4232-a586-596b6cc05415");
        public List<RoomListResponse> Rooms;
        public List<StaircaseListResponse> Staircases;
        public List<CarpetListReponse> Carpets;
        public decimal TotalLength = 0;
        public decimal TotalCost;
        public decimal TotalCostHigh;

        protected async override Task OnInitializedAsync()
        {
            Carpets = await CarpetService.GetAllCarpetAsync();
            await Refresh();
        }

        public async Task Refresh()
        {
            TotalCost = 0;
            TotalCost = 0;

            Staircases = await StaircaseService.GetStaircaseByBuildingIdAsync(BuildingId);
            Rooms = await RoomService.GetAllRoomsByBuildingIdAsync(BuildingId);

            TotalLength += CalculateRoomsLength(Rooms);
            TotalCost += CalculateRoomsTotal(Rooms);
            TotalLength += CalculateStarcasesLength(Staircases);
            TotalCost += CalculateStaircasesTotal(Staircases);

            TotalCostHigh = TotalCost * 1.1m;
        }

        public async Task ShowAddRoomModal(Guid BuildingId)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddRoomModal.BuildingId), BuildingId);

            var CarpetModal = Modal.Show<AddRoomModal>("Add A New Room", parameters);
            var result = await CarpetModal.Result;

            if (!result.Cancelled) 
            {
                await Refresh();
            }
        }

        public async Task ShowAddStaircaseModal(Guid BuildingId)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddStaircaseModal.BuildingId), BuildingId);
            
            var StaircaseModal = Modal.Show<AddStaircaseModal>("Add A New Staircase", parameters);
            var result = await StaircaseModal.Result;

            if (!result.Cancelled)
            {
                await Refresh();
            }

        }

        public decimal CalculateRoomsTotal(List<RoomListResponse> Rooms)
        {

            foreach (var Room in Rooms)
            {
                var Carpet = Carpets.Where(c => c.Id == Room.CarpetId).FirstOrDefault();
                TotalCost += (((Room.Width * Room.Length) / 9) * Carpet.SquareYardPrice);
            }

            return TotalCost;
        }

        public decimal CalculateRoomsLength(List<RoomListResponse> Rooms)
        {
            foreach (var Room in Rooms)
            {
                var RoomArea = Room.Length * Room.Width;
                TotalLength += RoomArea / Room.CarpetWidth;
            }
            return TotalLength;
        }

        public decimal CalculateStaircasesTotal(List<StaircaseListResponse> Staircases)
        {

            foreach (var Staircase in Staircases)
            {
                TotalCost += Staircase.Total;
            }

            return TotalCost;
        }

        public decimal CalculateStarcasesLength(List<StaircaseListResponse> Staircases)
        {
            foreach (var Staircase in Staircases)
            {
                var StaircaseArea = (((Staircase.StairHeight / 12) * (Staircase.StairWidth / 12)) + ((Staircase.StairLength / 12) * (Staircase.StairWidth / 12))) * Staircase.StairCount;
                TotalLength = StaircaseArea / Staircase.CarpetWidth;
            }
            return TotalLength;
        }

        public async Task ShowDeleteRoomConfirmationModal(Guid id)
        {
            var ConfirmationModal = Modal.Show<Confirmation>("Are you sure you want to delete?");
            var result = await ConfirmationModal.Result;

            if (!result.Cancelled)
            {
                await RoomService.DeleteRoomAsync(id);
                await Refresh();
            }
        }

        public async Task ShowDeleteStaircaseConfirmationModal(Guid id)
        {
            var ConfirmationModal = Modal.Show<Confirmation>("Are you sure you want to delete?");
            var result = await ConfirmationModal.Result;

            if (!result.Cancelled)
            {
                await StaircaseService.DeleteStaircaseAsync(id);
                await Refresh();
            }
        }
    }
}
