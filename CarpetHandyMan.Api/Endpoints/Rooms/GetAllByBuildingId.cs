using Ardalis.ApiEndpoints;
using CarpetHandyMan.Shared.Rooms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Rooms
{
    public class GetAllByBuildingId : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<List<RoomListResponse>>
    {
        [HttpGet("/rooms/building/{id}")]
        public override async Task<ActionResult<List<RoomListResponse>>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = CarpetHandyManDB");

            var sql = @"SELECT 
                           r.[Id]
                          ,r.[BuildingId]
                          ,r.[CarpetId]
                          ,r.[RoomName]
                          ,r.[Width]
                          ,r.[Length]
                      FROM [dbo].[Rooms] r
                      WHERE r.[BuildingId] = @Id";
            var Carpet = await connection.ExecuteQueryAsync<List<RoomListResponse>>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(Carpet);
        }
    }
}
