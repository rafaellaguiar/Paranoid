using Newtonsoft.Json;

namespace Paranoid.Model
{
    public class LocationConfig
    {

        [JsonProperty("locationConfig")]
        public List<TranslationValues> LocationConfigList { get; set; }

        public class TranslationValues
        {
            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("value-pt")]
            public string ValuePt { get; set; }

            [JsonProperty("value-en")]
            public string ValueEn { get; set; }
        }
    }
}
