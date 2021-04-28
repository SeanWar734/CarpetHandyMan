using Blazored.Modal;
using Blazored.Modal.Services;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Blazor.Pages.Modals;
using CarpetHandyMan.Shared.Installers;
using CarpetHandyMan.Shared.Retailers;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Installer
{
    public class InstallerListByRetailerModalBase : ComponentBase
    {
        [Inject] IInstallerService InstallerService { get; set; }
        [Inject] IRetailerService RetailerService { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        [Parameter] public Guid RetailerId { get; set; }

        public RetailerListResponse Retailer;
        public List<InstallerListResponse> Installers;

        protected async override Task OnInitializedAsync()
        {
            await Refresh();
        }

        public async Task Refresh()
        {
            Retailer = await RetailerService.GetOneRetailerAsync(RetailerId);
            Installers = await InstallerService.GetAllInstallersByRetailerIdAsync(RetailerId);
        }

        public async Task ShowInstallerAsync(Guid InstallerId)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(OneInstallerModal.InstallerId), InstallerId);

            var InstallerListModal = Modal.Show<OneInstallerModal>("Installer", parameters);
            var result = await InstallerListModal.Result;

            if (!result.Cancelled)
            {
                await Refresh();
            }
        }

        public async Task ShowAddInstallerModalAsync(Guid RetailerId)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddInstallerModal.RetailerId), RetailerId);

            var InstallerListModal = Modal.Show<AddInstallerModal>("Add Installer", parameters);
            var result = await InstallerListModal.Result;

            if (!result.Cancelled)
            {
                await Refresh();
            }
        }
    }
}
