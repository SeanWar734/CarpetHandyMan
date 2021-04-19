using Blazored.Modal;
using Blazored.Modal.Services;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using CarpetHandyMan.Shared.Rooms;
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
        [Inject] NavigationManager NavManager { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        public Guid BuildingId = Guid.Parse("bac8fdb0-1232-4232-a586-596b6cc05415");
        public List<RoomListResponse> Rooms;
        public List<CarpetListReponse> Carpets;
        public decimal TotalLength;
        public decimal TotalCost;

        protected async override Task OnInitializedAsync()
        {
            Carpets = await CarpetService.GetAllCarpetAsync();
            await Refresh();
        }

        public async Task Refresh()
        {
            TotalLength = 0;
            TotalCost = 0;
            Rooms = await RoomService.GetAllRoomsByBuildingIdAsync(BuildingId);
            foreach (var Room in Rooms)
            {
                TotalLength += Room.Length;
                var Carpet = Carpets.Where(c => c.Id == Room.CarpetId).FirstOrDefault();
                TotalCost += (((Room.Width * Room.Length) / 9) * Carpet.SquareYardPrice);
            }
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
    }
}
