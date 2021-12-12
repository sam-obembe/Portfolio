using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class Post
    {
      

        [JsonPropertyName("_createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("_rev")]
        public string Rev { get; set; }

        [JsonPropertyName("_type")]
        public string Type { get; set; }

        [JsonPropertyName("_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("body")]
        public IEnumerable<PostBody> Body { get; set; }

        [JsonPropertyName("mainImage")]
        public MainImage MainImage { get; set; }

        [JsonPropertyName("slug")]
        public Slug Slug { get; set; }

        public string ImgUrl { get; set; }
    }

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

    public class MainImage
    {

        /*[JsonPropertyName("_type")]
        public string Type { get; set; }*/

        [JsonPropertyName("asset")]
        public Asset Asset { get; set; }
    }

    public class Asset
    {
        [JsonPropertyName("_ref")]
        public string Ref { get; set; }

        [JsonPropertyName("_type")]
        public string AssetType { get; set; }
    }


    public class Slug
    {
        [JsonPropertyName("_type")]
        public string Type { get; set; }

        [JsonPropertyName("current")]
        public string Current { get; set; }
    }


    public class MarkDef
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("_type")]
        public string Type { get; set; }
    }





}
