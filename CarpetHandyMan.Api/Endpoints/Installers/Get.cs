using Ardalis.ApiEndpoints;
using CarpetHandyMan.Shared.Installers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarpetHandyMan.Api.Endpoints.Installers
{
    public class Get : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<InstallerListResponse>
    {
        [HttpGet("/installers/{id}")]
        public override async Task<ActionResult<InstallerListResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = CarpetHandyManDB");

            var sql = @"SELECT 
                           i.[Id]
                          ,i.[RetailerId]
                          ,i.[FirstName]
                          ,i.[LastName]
                          ,i.[PhoneNumber]
                          ,i.[SquareYardPrice]
                          ,i.[Area]
                      FROM [dbo].[Installers] i
                      WHERE i.[Id] = @Id;";
            var Installer = await connection.ExecuteQueryAsync<InstallerListResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(Installer.FirstOrDefault());
        }
    }
}
