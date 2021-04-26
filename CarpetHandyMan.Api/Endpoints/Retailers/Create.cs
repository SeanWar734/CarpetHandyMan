using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Shared.Retailers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CarpetHandyMan.Core.Objects;

namespace CarpetHandyMan.Api.Endpoints.Retailers
{
    public class Create : BaseAsyncEndpoint.WithRequest<CreateRetailerRequest>.WithoutResponse
    {
        private readonly IRetailerRepository _repo;
        public Create(IRetailerRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/retailer")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreateRetailerRequest request, CancellationToken cancellationToken = default)
        {
            var Retailer = new Retailer
            {
                Id = request.Id,
                Address = request.Address,
                City = request.City,
                CompanyName = request.CompanyName,
                Description = request.Description,
                State = request.State,
                PhoneNumber = request.PhoneNumber
            };
            await _repo.AddAsync(Retailer);
            await _repo.SaveAsync();
            return Ok(Retailer);
        }
    }
}