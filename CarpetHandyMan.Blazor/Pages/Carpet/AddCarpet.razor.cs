using Blazored.Modal;
using Blazored.Modal.Services;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Carpet
{
    public class AddCarpetBase : ComponentBase
    {
        [Inject] ICarpetService CarpetService { get; set; }

        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        public CreateCarpetRequest Carpet;

        protected async override Task OnInitializedAsync()
        {
            Carpet = new CreateCarpetRequest();
        }

        public async Task AddNewCarpet(CreateCarpetRequest AddCarpet)
        {
            await CarpetService.AddNewCarpetAsync(AddCarpet);
            await ModalInstance.CloseAsync();
        }
    }
}
