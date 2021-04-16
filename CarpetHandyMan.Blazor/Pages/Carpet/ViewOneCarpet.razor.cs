using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Carpet
{
    public class ViewOneCarpetBase : ComponentBase
    {
        [Inject] ICarpetService CarpetService { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter] public Guid CarpetId { get; set; }

        public CarpetListReponse Carpet { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await Refresh();
        }

        public async Task Refresh()
        {
            Carpet = await CarpetService.GetOneCarpetAsync(CarpetId);
        }
    }
}
