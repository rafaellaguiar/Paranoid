using Newtonsoft.Json;
using Paranoid.Enum;
using Paranoid.Helpers.Factory;
using Paranoid.Model;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Paranoid.Service
{
    public class SpeculationService : ISpeculationService
    {
        private HttpClient _httpClient;
        public SpeculationService()
        {
            _httpClient =  new HttpClient();
            _httpClient.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<DetalheDispositivo> GetDetalheDispositivo(string macAddress)
        {
            var url = EndPointFactory.GetEndpoint(EnumEndpoint.Detalhe);
            url += macAddress;

            var response = await _httpClient.GetAsync(url);

            if(!response.IsSuccessStatusCode)
                return new DetalheDispositivo("API error");

            var responseBody = await response.Content.ReadAsStringAsync();
            var detalheRetorno = JsonConvert.DeserializeObject<List<DetalheDispositivo>>(responseBody);

            if (response.StatusCode.Equals(204) || detalheRetorno == null)
                return new DetalheDispositivo("There's no information about the solicited device");

            return detalheRetorno.FirstOrDefault();
        }
    }
}
