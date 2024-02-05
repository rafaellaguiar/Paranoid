using Newtonsoft.Json;
using Paranoid.Model;
using Paranoid.Service.Interfaces;
using static Paranoid.Model.LocationConfig;

namespace Paranoid.Service
{
    public class RoundService : IRoundService
    {
        public LocationConfig GetLocationConfig()
        {
            string path = "LocationConfig/location.json";

            var jsonFile = GetJson(path);

            var retorno = JsonConvert.DeserializeObject<LocationConfig>(jsonFile);

            return retorno;
        }

        private static string GetJson(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
