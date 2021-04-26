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
    public class Update : BaseAsyncEndpoint.WithRequest<UpdateRetailerRequest>.WithoutResponse
    {
        private readonly IRetailerRepository _repo;
        public Update(IRetailerRepository repo)
        {
            _repo = repo;
        }

        [HttpPut("/retailer")]
        public override async Task<ActionResult> HandleAsync([FromBody] UpdateRetailerRequest request, CancellationToken cancellationToken = default)
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
            _repo.UpdateRetailer(Retailer);
            await _repo.SaveAsync();
            return Ok(Retailer);
        }
    }
}
