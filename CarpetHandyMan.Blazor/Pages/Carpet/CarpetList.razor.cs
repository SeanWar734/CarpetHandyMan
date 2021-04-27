using Blazored.Modal;
using Blazored.Modal.Services;
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

        [CascadingParameter] public IModalService Modal { get; set; }

        public List<CarpetListReponse> Carpets;

        protected async override Task OnInitializedAsync()
        {
            await Refresh();
        }

        public async Task Refresh()
        {
            Carpets = await CarpetService.GetAllCarpetAsync();
            Carpets = Carpets.OrderBy(c => c.Brand).ThenBy(c => c.Name).ToList();
        }

        public void ShowCarpetModal(Guid CarpetId)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(ViewOneCarpet.CarpetId), CarpetId);

            var CarpetModal = Modal.Show<ViewOneCarpet>("", parameters);
        }

        public async Task ShowAddCarpetModal()
        {
            var AddCarpetModal = Modal.Show<AddCarpet>("Add Carpet");

            var result = await AddCarpetModal.Result;
            if (!result.Cancelled)
            {
                await Refresh();
            }
        }
    }
}
