using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Staircases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Services
{
    public class StaircaseService : IStaircaseService
    {
        private HttpClient HttpClient { get; set; }

        public StaircaseService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public Task AddNewStaircaseAsync(CreateStaircaseRequest staircaseRequest)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStaircaseAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<StaircaseListResponse> GetOneStaircaseAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStaircaseAsync(UpdateStaircaseRequest staircaseRequest)
        {
            throw new NotImplementedException();
        }
    }
}
