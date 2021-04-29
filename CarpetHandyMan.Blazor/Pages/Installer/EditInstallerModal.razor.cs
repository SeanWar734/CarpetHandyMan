using Blazored.Modal;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Installers;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Installer
{
    public class EditInstallerModalBase : ComponentBase
    {
        [Inject] IInstallerService InstallerService { get; set; }

        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public InstallerListResponse EditInstaller { get; set; }

        public UpdateInstallerRequest Installer;

        protected override void OnInitialized()
        {
            Installer = new UpdateInstallerRequest
            {
                Id = EditInstaller.Id,
                FirstName = EditInstaller.FirstName,
                LastName = EditInstaller.LastName,
                Area = EditInstaller.Area,
                PhoneNumber = EditInstaller.PhoneNumber,
                RetailerId = EditInstaller.RetailerId,
                SquareYardPrice = EditInstaller.SquareYardPrice
            };
        }

        public void Confirm(UpdateInstallerRequest installerRequest)
        {
            InstallerService.UpdateInstallerAsync(installerRequest);
            ModalInstance.CloseAsync();
        }
    }
}
