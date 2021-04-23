using Ardalis.ApiEndpoints;
using CarpetHandyMan.Shared.Closets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Closets
{
    public class GetAllByRoomId : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<List<ClosetListResponse>>
    {
        [HttpGet("/closet/room/{id}")]
        public override async Task<ActionResult<List<ClosetListResponse>>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = CarpetHandyManDB");

            var sql = @"SELECT 
                           cl.[Id]
                          ,cl.[RoomId]
                          ,cl.[CarpetId]
                          ,cl.[BuildingId]
                          ,cl.[CarpetPrice]
                          ,c.[Width] as CarpetWidth
                          ,cl.[Width]
                          ,cl.[Length]
                      FROM [dbo].[Closets] cl
                      JOIN [dbo].[Carpet] c
                      ON cl.[CarpetId] = c.[Id]
                      WHERE cl.[RoomId] = @Id;";
            var Carpet = await connection.ExecuteQueryAsync<ClosetListResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(Carpet);
        }
    }
}
