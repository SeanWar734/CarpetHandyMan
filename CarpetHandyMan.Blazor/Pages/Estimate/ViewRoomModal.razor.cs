using Blazored.Modal;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Closets;
using CarpetHandyMan.Shared.Rooms;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Estimate
{
    public class ViewRoomModalBase : ComponentBase
    {
        [Inject] public IRoomService RoomService { get; set; }
        [Inject] public IClosetService ClosetService { get; set; }
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public Guid RoomId { get; set; }

        public RoomSingleResponse Room;
        public List<ClosetListResponse> Closets;

        protected async override Task OnInitializedAsync()
        {
            Room = await RoomService.GetOneRoomAsync(RoomId);
            Closets = await ClosetService.GetAllClosetByRoomIdAsync(RoomId);
        }
    }
}
