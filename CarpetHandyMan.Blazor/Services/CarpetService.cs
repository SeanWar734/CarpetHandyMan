using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Carpets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        public async Task AddNewCarpetAsync(CreateCarpetRequest carpetRequest)
        {
            var CarpetRequestJson = new StringContent(JsonSerializer.Serialize(carpetRequest), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"carpet", CarpetRequestJson);
        }

        public async Task DeleteCarpetAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"carpet/{id}");
        }

        public async Task<List<CarpetListReponse>> GetAllCarpetAsync()
        {
            var result = await HttpClient.GetStreamAsync($"carpet");
            return await JsonSerializer.DeserializeAsync<List<CarpetListReponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<CarpetListReponse> GetOneCarpetAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"carpet/{id}");
            return await JsonSerializer.DeserializeAsync<CarpetListReponse>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateCarpetAsync(UpdateCarpetRequest carpetRequest)
        {
            var CarpetJson = new StringContent(JsonSerializer.Serialize(carpetRequest), Encoding.UTF8, "application/json");
            await HttpClient.PutAsync($"purchaseitems/{carpetRequest.Id}", CarpetJson);
        }
    }
}
