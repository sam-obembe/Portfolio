using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class AboutMeResponse
    {
        [JsonPropertyName("result")]
        public IEnumerable<AboutMe> Result { get; set; }
    }
}
