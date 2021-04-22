using CarpetHandyMan.Shared.Closets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarpetHandyMan.Core.Objects;
using CarpetHandyMan.Core.Interfaces;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace CarpetHandyMan.Api.Endpoints.Closets
{
    public class Create : BaseAsyncEndpoint.WithRequest<CreateClosetRequest>.WithoutResponse
    {
        private readonly IClosetRepository _repo;
        public Create(IClosetRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/closet")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreateClosetRequest request, CancellationToken cancellationToken = default)
        {
            var Closet = new Closet
            {
                Id = request.Id,
                RoomId = request.RoomId,
                BuildingId = request.BuildingId,
                CarpetId = request.CarpetId,
                CarpetPrice = request.CarpetPrice,
                Length = request.Length,
                Width = request.Width
            };
            await _repo.AddAsync(Closet);
            await _repo.SaveAsync();
            return Ok(Closet);
        }
    }
}
