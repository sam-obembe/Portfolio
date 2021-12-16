using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class Slug
    {
        [JsonPropertyName("_type")]
        public string Type { get; set; }

        [JsonPropertyName("current")]
        public string Current { get; set; }
    }





}
