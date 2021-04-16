using Ardalis.ApiEndpoints;
using CarpetHandyMan.Shared.Carpets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Carpets
{
    public class GetAllByStyle : BaseAsyncEndpoint.WithRequest<String>.WithResponse<List<CarpetListReponse>>
    {
        [HttpGet("/carpet/style/{Style}")]
        public override async Task<ActionResult<List<CarpetListReponse>>> HandleAsync(String Style, CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = CarpetHandyManDB");

            var sql = @"SELECT 
                           c.[Id]
                          ,c.[Name]
                          ,c.[Width]
                          ,c.[SquareYardPrice]
                          ,c.[Brand]
                          ,c.[Style]
                          ,c.[Description]
                      FROM [dbo].[Carpet] c
                      WHERE c.[Style] = @Style
                      ORDER BY c.[Name];";
            var Carpet = await connection.ExecuteQueryAsync<CarpetListReponse>(sql, new { Style = Style }, cancellationToken: cancellationToken);
            return Ok(Carpet);
        }
    }
}
