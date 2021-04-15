using Ardalis.ApiEndpoints;
using CarpetHandyMan.Core.Objects;
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
    public class Get : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<CarpetSingleResponse>
    {
        [HttpGet("/carpet/{id}")]
        public override async Task<ActionResult<CarpetSingleResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = CarpetHandyManDB");

            var sql = @"SELECT 
                           c.[Id]
                          ,c.[Name]
                          ,c.[Length]
                          ,c.[Width]
                          ,c.[SquareYardPrice]
                          ,c.[Brand]
                          ,c.[Style]
                          ,c.[Description]
                      FROM [dbo].[Carpet] c
                      WHERE c.Id = @Id
                      ORDER BY c.[Name];";
            var Carpet = await connection.ExecuteQueryAsync<CarpetSingleResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(Carpet.FirstOrDefault());
        }
    }
}
