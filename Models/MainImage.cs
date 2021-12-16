using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class MainImage
    {

        /*[JsonPropertyName("_type")]
        public string Type { get; set; }*/

        [JsonPropertyName("asset")]
        public Asset Asset { get; set; }
    }





}
