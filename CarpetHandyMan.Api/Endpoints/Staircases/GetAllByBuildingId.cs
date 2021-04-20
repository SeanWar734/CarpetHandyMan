using Ardalis.ApiEndpoints;
using CarpetHandyMan.Shared.Staircases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Staircases
{
    public class GetAllByBuildingId : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<List<StaircaseListResponse>>
    {
        [HttpGet("/staircases/building/{id}")]
        public override async Task<ActionResult<List<StaircaseListResponse>>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
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
                      WHERE sc.[BuildingId] = @Id;";
            var Carpet = await connection.ExecuteQueryAsync<StaircaseListResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(Carpet);
        }
    }
}
