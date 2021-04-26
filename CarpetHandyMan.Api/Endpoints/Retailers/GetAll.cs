using Ardalis.ApiEndpoints;
using CarpetHandyMan.Shared.Retailers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Retailers
{
    public class GetAll : BaseAsyncEndpoint.WithoutRequest.WithResponse<List<RetailerListResponse>>
    {
        [HttpGet("/retailer")]
        public override async Task<ActionResult<List<RetailerListResponse>>> HandleAsync( CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = CarpetHandyManDB");

            var sql = @"SELECT 
                           r.[Id]
                          ,r.[CompanyName]
                          ,r.[Address]
                          ,r.[City]
                          ,r.[State]
                          ,r.[PhoneNumber]
                          ,r.[Description]
                      FROM [dbo].[Retailers] r;";
            var Retailers = await connection.ExecuteQueryAsync<RetailerListResponse>(sql, cancellationToken: cancellationToken);
            return Ok(Retailers);
        }
    }
}
