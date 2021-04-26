using Blazored.Modal.Services;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Retailers;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Retailer
{
    public class RetailerListBase : ComponentBase
    {
        [Inject] IRetailerService RetailerService { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        public List<RetailerListResponse> Retailers;

        protected async override Task OnInitializedAsync()
        {
            await Refresh();
        }

        public async Task Refresh()
        {
            Retailers = await RetailerService.GetAllRetailersAsync();
        }
    }
}
