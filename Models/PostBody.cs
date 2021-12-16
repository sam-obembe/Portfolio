using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class PostBody
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("_type")]
        public string Type { get; set; }

        [JsonPropertyName("children")]
        public IEnumerable<PostBodyChild> Children { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }


        [JsonPropertyName("listItem")]
        public string ListItem { get; set; }

        [JsonPropertyName("markDefs")]
        public IEnumerable<MarkDef> MarkDefs { get; set; }

        

    }





}
