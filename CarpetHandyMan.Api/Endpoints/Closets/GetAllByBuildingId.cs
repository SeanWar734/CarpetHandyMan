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
    public class GetAllByBuildingId : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<List<ClosetListResponse>>
    {
        [HttpGet("/closet/building/{id}")]
        public override async Task<ActionResult<List<ClosetListResponse>>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = CarpetHandyManDB");

            var sql = @"SELECT 
                           c.[Id]
                          ,c.[RoomId]
                          ,c.[BuildingId]
                          ,c.[CarpetId]
                          ,c.[CarpetPrice]
                          ,c.[Width]
                          ,c.[Length]
                      FROM [dbo].[Closets] c
                      WHERE c.[BuildingId] = @Id;";
            var Carpet = await connection.ExecuteQueryAsync<ClosetListResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(Carpet);
        }
    }
}
