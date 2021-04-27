using CarpetHandyMan.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarpetHandyMan.Core.Objects;
using Ardalis.ApiEndpoints;
using CarpetHandyMan.Shared.Installers;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace CarpetHandyMan.Api.Endpoints.Installers
{
    public class Update : BaseAsyncEndpoint.WithRequest<UpdateInstallerRequest>.WithoutResponse
    {
        private readonly IInstallerRepository _repo;

        public Update(IInstallerRepository repo)
        {
            _repo = repo;
        }

        [HttpPut("/installers/{id}")]
        public override async Task<ActionResult> HandleAsync([FromBody] UpdateInstallerRequest request, CancellationToken cancellationToken = default)
        {

            var Installer = new Installer
            {
                Id = request.Id,
                RetailerId = request.RetailerId,
                Area = request.Area,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                SquareYardPrice = request.SquareYardPrice
            };

            _repo.UpdateInstaller(Installer);
            await _repo.SaveAsync();
            return Ok(Installer);
        }
    }
}
