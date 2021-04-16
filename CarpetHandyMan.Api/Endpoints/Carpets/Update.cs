using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CarpetHandyMan.Core.Objects;

namespace CarpetHandyMan.Api.Endpoints.Carpets
{
    public class Update : BaseAsyncEndpoint.WithRequest<UpdateCarpetRequest>.WithoutResponse
    {
        private readonly ICarpetRepository _repo;

        public Update(ICarpetRepository repo)
        {
            _repo = repo;
        }

        [HttpPut("/carpet/{id}")]
        public override async Task<ActionResult> HandleAsync([FromBody] UpdateCarpetRequest request, CancellationToken cancellationToken = default)
        {

            var Carpet = new Carpet
            {
                Id = request.Id,
                Name = request.Name,
                Length = request.Length,
                Width = request.Width,
                SquareYardPrice = request.SquareYardPrice,
                Style = request.Style,
                Brand = request.Brand,
                Description = request.Description
            };

            _repo.UpdateCarpet(Carpet);
            await _repo.SaveAsync();
            return Ok(Carpet);
        }
    }
}
