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
    public class Get : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<RetailerListResponse>
    {
        [HttpGet("/retailer/{id}")]
        public override async Task<ActionResult<RetailerListResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
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
                      FROM [dbo].[Retailers] r
                      WHERE r.[Id] = @Id";
            var Retailer = await connection.ExecuteQueryAsync<RetailerListResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(Retailer.FirstOrDefault());
        }
    }
}