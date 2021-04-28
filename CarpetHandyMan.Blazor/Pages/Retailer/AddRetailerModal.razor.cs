using Blazored.Modal;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Retailers;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Retailer
{
    public class AddRetailerModalBase : ComponentBase
    {
        [Inject] IRetailerService RetailerService { get; set; }

        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        public CreateRetailerRequest Retailer;

        protected override void OnInitialized()
        {
            Retailer = new CreateRetailerRequest();
        }

        public async Task AddNewRetailerAsync(CreateRetailerRequest RetailerRequest)
        {
            await RetailerService.AddNewRetailerAsync(RetailerRequest);
            await ModalInstance.CloseAsync();
        }
    }
}
