using CarpetHandyMan.Shared.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarpetHandyMan.Core.Objects;
using CarpetHandyMan.Core.Interfaces;
using System.Threading;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace CarpetHandyMan.Api.Endpoints.Installers
{
    public class Create : BaseAsyncEndpoint.WithRequest<CreateInstallerRequest>.WithoutResponse
    {
        private readonly IInstallerRepository _repo;
        public Create(IInstallerRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/installers")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreateInstallerRequest request, CancellationToken cancellationToken = default)
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
            await _repo.AddAsync(Installer);
            await _repo.SaveAsync();
            return Ok(Installer);
        }
    }
}