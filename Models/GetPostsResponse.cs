using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class GetPostsResponse
    {
        [JsonPropertyName("ms")]
        public int MS { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("result")]
        public Post[] Result { get; set; }
    }
}
