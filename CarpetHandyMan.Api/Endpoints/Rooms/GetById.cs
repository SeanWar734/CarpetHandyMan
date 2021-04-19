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
    public class GetById : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<RoomSingleResponse>
    {
        [HttpGet("/room/{id}")]
        public override async Task<ActionResult<RoomSingleResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = CarpetHandyManDB");

            var sql = @"SELECT 
                           r.[Id]
                          ,r.[BuildingId]
                          ,r.[CarpetId]
                          ,c.[Name] AS CarpetName
                          ,r.[RoomName]
                          ,r.[Width]
                          ,r.[Length]
                      FROM [dbo].[Rooms] r
                      JOIN [dbo].[Carpet] c
                      ON r.[CarpetId] = c.[Id]
                      WHERE r.[Id] = @Id";
            var Carpet = await connection.ExecuteQueryAsync<RoomSingleResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(Carpet.FirstOrDefault());
        }
    }
}