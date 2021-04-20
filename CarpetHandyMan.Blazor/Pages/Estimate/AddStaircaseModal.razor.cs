using Blazored.Modal;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using CarpetHandyMan.Shared.Staircases;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Pages.Estimate
{
    public class AddStaircaseModalBase : ComponentBase
    {
        [Inject] public IStaircaseService StaircaseService { get; set; }
        [Inject] public ICarpetService CarpetService { get; set; }
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public Guid BuildingId { get; set; }

        public CreateStaircaseRequest NewStaircase;
        public List<CarpetListReponse> Carpet;

        protected async override Task OnInitializedAsync()
        {
            NewStaircase = new CreateStaircaseRequest();
            Carpet = await CarpetService.GetAllCarpetAsync();
        }

        public decimal CalculateTotal(CreateStaircaseRequest Staircase)
        {
            var Area = ((Staircase.StairWidth / 12) * (Staircase.StairLength / 12)) + ((Staircase.StairWidth / 12) * (Staircase.StairHeight / 12));
            var TotalPerStep = (Area / 9) * Staircase.CarpetPrice;
            var Total = TotalPerStep * Staircase.StairCount;
            return Total;
        }

        public async Task AddNewStaircase(CreateStaircaseRequest NewStaircase)
        {
            NewStaircase.BuildingId = BuildingId;

            NewStaircase.CarpetPrice = Carpet.Where(c => c.Id == NewStaircase.CarpetId).FirstOrDefault().SquareYardPrice;
            NewStaircase.Total = CalculateTotal(NewStaircase);

            await StaircaseService.AddNewStaircaseAsync(NewStaircase);
            await ModalInstance.CloseAsync();
        }
    }
}
