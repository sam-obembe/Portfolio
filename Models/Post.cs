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





}
