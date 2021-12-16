using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class MarkDef
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("_type")]
        public string Type { get; set; }
    }





}
