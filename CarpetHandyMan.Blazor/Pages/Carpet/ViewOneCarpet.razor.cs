using Blazored.Modal;
using Blazored.Modal.Services;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Blazor.Pages.Modals;
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

        [CascadingParameter] public IModalService Modal { get; set; }

        public CarpetListReponse Carpet { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await Refresh();
        }

        public async Task Refresh()
        {
            Carpet = await CarpetService.GetOneCarpetAsync(CarpetId);
        }

        public async Task ShowDeleteCarpetConfirmationModal(Guid CarpetId)
        {
            var RemoveCarpetModal = Modal.Show<Confirmation>("Are you sure you would like to delete this carpet?");
            var result = await RemoveCarpetModal.Result;

            if (!result.Cancelled)
            {
                await CarpetService.DeleteCarpetAsync(CarpetId);
                await Refresh();
            }
        }

        public async Task ShowEditCarpetModal()
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(EditCarpetModal.EditCarpet), Carpet);

            var ShowEditCarpetModal = Modal.Show<EditCarpetModal>("Edit", parameters);
            var result = await ShowEditCarpetModal.Result;

            if (!result.Cancelled)
            {
                await Refresh();
            } else
            {
                await Refresh();
            }
        }
    }
}
