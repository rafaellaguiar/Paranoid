using Newtonsoft.Json;

namespace Paranoid.Model
{
    public class DetalheDispositivo
    {

        public DetalheDispositivo(string mensagemRetorno)
        {
            MensagemRetorno = mensagemRetorno;
        }


        [JsonProperty("startHex")]
        public string? StartHex { get; set; }

        [JsonProperty("endHex")]
        public string? EndHex { get; set; }

        [JsonProperty("startDec")]
        public string? StartDec { get; set; }

        [JsonProperty("endDec")]
        public string? EndDec { get; set; }

        [JsonProperty("company")]
        public string? Company { get; set; }

        [JsonProperty("addressL1")]
        public string? AddressL1 { get; set; }

        [JsonProperty("addressL2")]
        public string? AddressL2 { get; set; }

        [JsonProperty("addressL3")]
        public string? AddressL3 { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        public string? MensagemRetorno { get; set; }
    }
}
