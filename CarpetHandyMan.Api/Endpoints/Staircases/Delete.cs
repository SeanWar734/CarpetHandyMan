using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Staircases
{
    public class Delete : BaseAsyncEndpoint.WithRequest<Guid>.WithoutResponse
    {
        private readonly IStaircaseRepository _repo;

        public Delete(IStaircaseRepository repo)
        {
            _repo = repo;
        }

        [HttpDelete("/staircase/{id}")]
        public override async Task<ActionResult> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _repo.DeleteStaircaseAsync(id);
            await _repo.SaveAsync();
            return Ok();
        }
    }
}
