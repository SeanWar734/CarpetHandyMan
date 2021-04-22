using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Objects;
using CarpetHandyMan.Shared.Carpets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;

namespace CarpetHandyMan.Api.Endpoints.Carpets
{
    public class GetAll : BaseAsyncEndpoint.WithoutRequest.WithResponse<List<CarpetListReponse>>
    {
        [HttpGet("/carpet")]
        public override async Task<ActionResult<List<CarpetListReponse>>> HandleAsync(CancellationToken cancellationToken = default)
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
                          ,c.[Image]
                      FROM [dbo].[Carpet] c
                      ORDER BY c.[Brand];";
            var Carpet = await connection.ExecuteQueryAsync<CarpetListReponse>(sql, cancellationToken: cancellationToken);
            return Ok(Carpet);
        }
    }
}