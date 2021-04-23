using Ardalis.ApiEndpoints;
using CarpetHandyMan.Shared.Rooms;
using CarpetHandyMan.Shared.Staircases;
using Microsoft.AspNetCore.Mvc;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Staircases
{
    public class Get : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<StaircaseListResponse>
    {
        [HttpGet("/staircase/{id}")]
        public override async Task<ActionResult<StaircaseListResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = CarpetHandyManDB");

            var sql = @"SELECT DISTINCT
                            sc.[Id]
                          , sc.[BuildingId]
                          , sc.[CarpetId]
                          , sc.[Total]
                          , sc.[StairCount]
                          , sc.[IsCurved]
                          , s.[Width] as StairWidth
                          , s.[Length] as StairLength
                          , s.[Height] as StairHeight
                          , c.[SquareYardPrice] as CarpetPrice
                          , c.[Width] as CarpetWidth
	                      , c.[Name] as CarpetName
                      FROM [dbo].[Staircases] sc
                      JOIN[dbo].[Carpet] c
                      ON sc.[CarpetId] = c.[Id]                      
                      JOIN [dbo].[Stairs] s
                      ON sc.[Id] = s.[StaircaseId]
                      WHERE sc.[Id] = @Id;";
            var Staircase = await connection.ExecuteQueryAsync<StaircaseListResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(Staircase.FirstOrDefault());
        }
    }
}
