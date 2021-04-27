using Blazored.Modal;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using CarpetHandyMan.Shared.Closets;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Estimate
{
    public class AddClosetModalBase : ComponentBase
    {
        [Inject] public ICarpetService CarpetService { get; set; }
        [Inject] public IClosetService ClosetService { get; set; }
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public Guid BuildingId { get; set; }
        [Parameter] public Guid RoomId { get; set; }

        public CreateClosetRequest Closet { get; set; }
        public List<CarpetListReponse> Carpet;

        protected async override Task OnInitializedAsync()
        {
            Closet = new CreateClosetRequest();
            Carpet = await CarpetService.GetAllCarpetAsync();
            Carpet = Carpet.OrderBy(c => c.Brand).ThenBy(c => c.Name).ToList();
        }
        public async Task AddNewCloset(CreateClosetRequest ClosetRequest)
        {
            ClosetRequest.RoomId = RoomId;
            ClosetRequest.BuildingId = BuildingId;
            ClosetRequest.CarpetPrice = Carpet.Where(c => c.Id == ClosetRequest.CarpetId).FirstOrDefault().SquareYardPrice;

            await ClosetService.AddNewClosetAsync(ClosetRequest);
            await ModalInstance.CloseAsync();
        }
    }
}
