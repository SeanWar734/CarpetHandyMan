using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Carpets
{
    public class Delete : BaseAsyncEndpoint.WithRequest<Guid>.WithoutResponse
    {
        private readonly ICarpetRepository _repo;

        public Delete(ICarpetRepository repo)
        {
            _repo = repo;
        }

        [HttpDelete("/carpet/{id}")]
        public override async Task<ActionResult> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _repo.DeleteCarpetAsync(id);
            await _repo.SaveAsync();
            return Ok();
        }
    }
}
