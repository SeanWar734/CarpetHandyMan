using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Closets
{
    public class Delete : BaseAsyncEndpoint.WithRequest<Guid>.WithoutResponse
    {
        private readonly IClosetRepository _repo;

        public Delete(IClosetRepository repo)
        {
            _repo = repo;
        }

        [HttpDelete("/closet/{id}")]
        public override async Task<ActionResult> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _repo.DeleteClosetAsync(id);
            await _repo.SaveAsync();
            return Ok();
        }
    }
}
