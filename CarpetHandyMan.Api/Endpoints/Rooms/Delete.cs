using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Rooms
{
    public class Delete : BaseAsyncEndpoint.WithRequest<Guid>.WithoutResponse
    {
        private readonly IRoomRepository _repo;

        public Delete(IRoomRepository repo)
        {
            _repo = repo;
        }

        [HttpDelete("/room/{id}")]
        public override async Task<ActionResult> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _repo.DeleteRoomAsync(id);
            await _repo.SaveAsync();
            return Ok();
        }
    }
}
