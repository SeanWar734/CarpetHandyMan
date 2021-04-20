using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Shared.Staircases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarpetHandyMan.Core.Objects;
using System.Threading;

namespace CarpetHandyMan.Api.Endpoints.Staircases
{
    public class Create : BaseAsyncEndpoint.WithRequest<CreateStaircaseRequest>.WithoutResponse
    {
        private readonly IStaircaseRepository _repo;
        public Create(IStaircaseRepository repo)
        {
            _repo = repo;
        }

        public Staircase Staircase;

        [HttpPost("/staircase")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreateStaircaseRequest request, CancellationToken cancellationToken = default)
        {
            if (request.Id != Guid.Empty)
            {
                var Staircase = new Staircase
                {
                    Id = request.Id,
                    BuildingId = request.BuildingId,
                    CarpetId = request.CarpetId,
                    IsCurved = request.IsCurved,
                    StairCount = request.StairCount,
                    Total = (((request.StairWidth * request.StairLength) + (request.StairWidth * request.StairHeight) * request.CarpetPrice) * request.StairCount)
                };
            } 
            else
            {
                var Staircase = new Staircase
                {
                    Id = Guid.NewGuid(),
                    BuildingId = request.BuildingId,
                    CarpetId = request.CarpetId,
                    IsCurved = request.IsCurved,
                    StairCount = request.StairCount,
                    Total = ((((request.StairWidth * request.StairLength) + (request.StairWidth * request.StairHeight) / 9) * request.CarpetPrice) * request.StairCount)
                };
            }

            for (int i = 0; i < request.StairCount; i++)
            {
                Staircase.Stairs.Add(new Stair
                {
                    StaircaseId = Staircase.Id,
                    CarpetId = request.CarpetId,
                    Height = request.StairHeight,
                    Width = request.StairWidth,
                    Length = request.StairLength,

                    Price = (((request.StairLength * request.StairWidth) + (request.StairHeight * request.StairWidth)) * request.CarpetPrice)
                });
            }

            await _repo.AddAsync(Staircase);
            await _repo.SaveAsync();
            return Ok(Staircase);
        }
    }
}