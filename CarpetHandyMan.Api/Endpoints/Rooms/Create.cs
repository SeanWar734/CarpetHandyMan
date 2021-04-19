using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Shared.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarpetHandyMan.Core.Objects;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace CarpetHandyMan.Api.Endpoints.Rooms
{
    public class Create : BaseAsyncEndpoint.WithRequest<CreateRoomRequest>.WithoutResponse
    {
        private readonly IRoomRepository _repo;
        public Create(IRoomRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/room")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreateRoomRequest request, CancellationToken cancellationToken = default)
        {
            var Room = new Room
            {
                Id = request.Id,
                BuildingId = request.BuildingId,
                CarpetId = request.CarpetId,
                Length = request.Length,
                Width = request.Width,
                RoomName = request.RoomName
            };
            await _repo.AddAsync(Room);
            await _repo.SaveAsync();
            return Ok(Room);
        }
    }
}