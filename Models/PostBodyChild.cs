using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class PostBodyChild
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("_type")]
        public string Type { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("marks")]
        public string[] Marks { get; set; }

        [JsonPropertyName("asset")]
        public Asset Asset { get; set; }
    }





}
