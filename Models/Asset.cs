using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class Asset
    {
        [JsonPropertyName("_ref")]
        public string Ref { get; set; }

        [JsonPropertyName("_type")]
        public string AssetType { get; set; }
    }





}
