using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Shared.Closets;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CarpetHandyMan.Core.Objects;

namespace CarpetHandyMan.Api.Endpoints.Closets
{
    public class Update : BaseAsyncEndpoint.WithRequest<UpdateClosetRequest>.WithoutResponse
    {
        private readonly IClosetRepository _repo;

        public Update(IClosetRepository repo)
        {
            _repo = repo;
        }

        [HttpPut("/closet/{id}")]
        public override async Task<ActionResult> HandleAsync([FromBody] UpdateClosetRequest request, CancellationToken cancellationToken = default)
        {

            var Closet = new Closet
            {
                Id = request.Id,
                RoomId = request.RoomId,
                CarpetId = request.CarpetId,
                BuildingId = request.BuildingId,
                CarpetPrice = request.CarpetPrice,
                Length = request.Length,
                Width = request.Width
            };

            _repo.UpdateCloset(Closet);
            await _repo.SaveAsync();
            return Ok(Closet);
        }
    }
}
