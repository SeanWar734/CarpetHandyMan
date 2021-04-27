using Blazored.Modal;
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
    public class AddRoomModalBase : ComponentBase
    {
        [Inject] public ICarpetService CarpetService { get; set; }
        [Inject] public IRoomService RoomService { get; set; }
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public Guid BuildingId { get; set; }

        public CreateRoomRequest NewRoom;
        public List<CarpetListReponse> Carpet;

        protected async override Task OnInitializedAsync()
        {
            NewRoom = new CreateRoomRequest();
            Carpet = await CarpetService.GetAllCarpetAsync();
            Carpet = Carpet.OrderBy(c => c.Brand).ThenBy(c => c.Name).ToList();
        }

        public async Task AddNewRoom(CreateRoomRequest RoomRequest)
        {
            NewRoom = new CreateRoomRequest
            {
                Id = RoomRequest.Id,
                Length = RoomRequest.Length,
                Width = RoomRequest.Width,
                RoomName = RoomRequest.RoomName,
                BuildingId = BuildingId,
                CarpetId = RoomRequest.CarpetId
            };

            await RoomService.AddNewRoomAsync(NewRoom);
            await ModalInstance.CloseAsync();
        }
    }
}
