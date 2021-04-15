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
    public class Create : BaseAsyncEndpoint.WithRequest<CreateCarpetRequest>.WithoutResponse
    {
        private readonly ICarpetRepository _repo;
        public Create(ICarpetRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/carpet")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreateCarpetRequest request, CancellationToken cancellationToken = default)
        {
            var Carpet = new Carpet
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Length = request.Length,
                Width = request.Width,
                Brand = request.Brand,
                Style = request.Style,
                SquareYardPrice = request.SquareYardPrice
            };
            await _repo.AddAsync(Carpet);
            await _repo.SaveAsync();
            return Ok(Carpet);
        }
    }
}
