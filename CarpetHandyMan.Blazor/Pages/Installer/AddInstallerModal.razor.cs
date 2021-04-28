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
    public class AddInstallerModalBase : ComponentBase
    {
        [Inject] IInstallerService InstallerService { get; set; }

        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public Guid RetailerId { get; set; }

        public CreateInstallerRequest Installer;

        protected override void OnInitialized()
        {
            Installer = new CreateInstallerRequest();
        }


        public async Task AddNewInstallerAsync(CreateInstallerRequest InstallerRequest)
        {
            CreateInstallerRequest newInstaller = new CreateInstallerRequest
            {
                FirstName = InstallerRequest.FirstName,
                LastName = InstallerRequest.LastName,
                Area = 0,
                PhoneNumber = InstallerRequest.PhoneNumber,
                RetailerId = RetailerId,
                SquareYardPrice = InstallerRequest.SquareYardPrice
            };

            await InstallerService.AddNewInstallerAsync(newInstaller);
            await ModalInstance.CloseAsync();
        }
    }
}
