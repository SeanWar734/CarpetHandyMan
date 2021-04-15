using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Carpet
{
    public class CarpetListBase : ComponentBase
    {
        [Inject] ICarpetService CarpetService { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        public List<CarpetListReponse> Carpets;

        protected async override Task OnInitializedAsync()
        {
            await Refresh();
        }

        public async Task Refresh()
        {
            Carpets = await CarpetService.GetAllCarpetAsync();
        }
    }
}
