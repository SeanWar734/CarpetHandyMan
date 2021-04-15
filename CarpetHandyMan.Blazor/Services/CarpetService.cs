using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Services
{
    public class CarpetService : ICarpetService
    {
        private HttpClient HttpClient { get; set; }

        public CarpetService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public Task AddNewCarpetAsync(CreateCarpetRequest carpetRequest)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCarpetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarpetListReponse>> GetAllCarpetAsync()
        {
            var result = await HttpClient.GetStreamAsync($"/carpet");
            return await JsonSerializer.DeserializeAsync<List<CarpetListReponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<CarpetListReponse> GetOneCarpetAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"/carpet/{id}");
            return await JsonSerializer.DeserializeAsync<CarpetListReponse>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public Task UpdateCarpetAsync(UpdateCarpetRequest carpetRequest)
        {
            throw new NotImplementedException();
        }
    }
}
