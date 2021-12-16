using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class AboutMe
    {
        [JsonPropertyName("intro")]
        public string Intro { get; set; }

        [JsonPropertyName("body")]
        public IEnumerable<PostBody> Body { get; set; } 
    }
}
