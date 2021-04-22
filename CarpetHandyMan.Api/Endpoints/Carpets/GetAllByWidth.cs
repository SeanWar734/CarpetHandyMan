using Ardalis.ApiEndpoints;
using CarpetHandyMan.Shared.Carpets;
using Microsoft.AspNetCore.Mvc;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Carpets
{
    public class GetAllByWidth : BaseAsyncEndpoint.WithRequest<decimal>.WithResponse<List<CarpetListReponse>>
    {
        [HttpGet("/carpet/width/{Width}")]
        public override async Task<ActionResult<List<CarpetListReponse>>> HandleAsync(decimal Width, CancellationToken cancellationToken = default)
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
                      WHERE c.[Width] = @Width
                      ORDER BY c.[Name];";
            var Carpet = await connection.ExecuteQueryAsync<CarpetListReponse>(sql, new { Width = Width }, cancellationToken: cancellationToken);
            return Ok(Carpet);
        }
    }
}
