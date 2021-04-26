using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Retailers
{
    public class Delete : BaseAsyncEndpoint.WithRequest<Guid>.WithoutResponse
    {
        private readonly IRetailerRepository _repo;

        public Delete(IRetailerRepository repo)
        {
            _repo = repo;
        }

        [HttpDelete("/retailer/{id}")]
        public override async Task<ActionResult> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _repo.DeleteRetailerAsync(id);
            await _repo.SaveAsync();
            return Ok();
        }
    }
}
