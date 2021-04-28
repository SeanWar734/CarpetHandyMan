using Blazored.Modal;
using Blazored.Modal.Services;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Blazor.Pages.Installer;
using CarpetHandyMan.Blazor.Pages.Modals;
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
        [Inject] IInstallerService InstallerService { get; set; }

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

        public async Task ShowInstallerListAsync(Guid RetailerId)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(InstallerListByRetailerModal.RetailerId), RetailerId);

            var InstallerListModal = Modal.Show<InstallerListByRetailerModal>("Installers", parameters);
            var result = await InstallerListModal.Result;

            if (!result.Cancelled)
            {
                await Refresh();
            }
        }

        public async Task ShowAddRetailerModalAsync()
        {
            var AddRetailerModal = Modal.Show<AddRetailerModal>("Add Retailer");
            var result = await AddRetailerModal.Result;

            if (!result.Cancelled)
            {
                await Refresh();
            }
        }

        public async Task ShowRemoveRetailerModalAsync(Guid RetailerId)
        {
            var DeleteRetailerModal = Modal.Show<Confirmation>("Are you sure you want to delete this Retailer?");
            var result = await DeleteRetailerModal.Result;

            if (!result.Cancelled)
            {
                var Installers = await InstallerService.GetAllInstallersByRetailerIdAsync(RetailerId);
                foreach (var installer in Installers)
                {
                    await InstallerService.DeleteInstallerAsync(installer.Id);
                }
                await RetailerService.DeleteRetailerAsync(RetailerId);
                await Refresh();
            }
        }
    }
}
