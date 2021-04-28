using Blazored.Modal;
using Blazored.Modal.Services;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Blazor.Pages.Modals;
using CarpetHandyMan.Shared.Installers;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Installer
{
    public class OneInstallerModalBase : ComponentBase
    {
        [Inject] IInstallerService InstallerService { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public Guid InstallerId { get; set; }

        public InstallerListResponse Installer;

        protected async override Task OnInitializedAsync()
        {
            await Refresh();
        }

        public async Task Refresh()
        {
            Installer = await InstallerService.GetOneInstallerAsync(InstallerId);
        }

        public async Task ShowRemoveInstallerConfirmationModal()
        {
            var RemoveInstallerConfirmationModal = Modal.Show<Confirmation>("Are you sure you want to remove this Installer");
            var result = await RemoveInstallerConfirmationModal.Result;

            if (!result.Cancelled)
            {
                await InstallerService.DeleteInstallerAsync(InstallerId);
                await ModalInstance.CloseAsync();
            }
        }
    }
}
