using Blazored.Modal;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Staircases;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Estimate
{
    public class ViewStaircaseModalBase : ComponentBase
    {
        [Inject] public IStaircaseService StaircaseService { get; set; }
        [Inject] public IClosetService ClosetService { get; set; }
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public Guid StaircaseId { get; set; }

        public StaircaseListResponse Staircase;

        protected async override Task OnInitializedAsync()
        {
            Staircase = await StaircaseService.GetStaircaseById(StaircaseId);
        }

    }
}
