using Newtonsoft.Json;

namespace final27.Models
{
    public class Nemodel
    {
        [JsonProperty("copyright")]
        public string? Url { get; set; }//copyright
        [JsonProperty("explanation")]
        public string? Explanation { get; set; }//explanation
    }
}
