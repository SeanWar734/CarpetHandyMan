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

        public Guid BuildingId { get; set; } = Guid.NewGuid();
        public List<RoomListResponse> Rooms;
        public List<CarpetListReponse> Carpets;

        protected async override Task OnInitializedAsync()
        {
            Carpets = await CarpetService.GetAllCarpetAsync();
            await Refresh();
        }

        public async Task Refresh()
        {
            Rooms = await RoomService.GetAllRoomsByBuildingIdAsync(BuildingId);
        }

        public async Task ShowAddRoomModal(Guid BuildingId)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddRoomModal.BuildingId), BuildingId);

            var CarpetModal = Modal.Show<AddRoomModal>("Add A New Room", parameters);
            var result = await CarpetModal.Result;

            if (!result.Cancelled) 
            {
                Refresh();
            }
        }
    }
}
