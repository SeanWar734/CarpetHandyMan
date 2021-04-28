using Blazored.Modal;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Carpet
{
    public class EditCarpetModalBase : ComponentBase
    {
        [Inject] ICarpetService CarpetService { get; set; }

        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public CarpetListReponse EditCarpet { get; set; }

        public UpdateCarpetRequest Carpet;

        protected override void OnInitialized()
        {
            Carpet = new UpdateCarpetRequest
            {
                Id = EditCarpet.Id,
                Brand = EditCarpet.Brand,
                Description = EditCarpet.Description,
                Length = EditCarpet.Length,
                Width = EditCarpet.Width,
                Name = EditCarpet.Name,
                SquareYardPrice = EditCarpet.SquareYardPrice,
                Style = EditCarpet.Style,
                Image = EditCarpet.Image
            };
        }

        public void Confirm(UpdateCarpetRequest carpetRequest)
        {
            CarpetService.UpdateCarpetAsync(carpetRequest);
            ModalInstance.CloseAsync();
        }
    }
}
