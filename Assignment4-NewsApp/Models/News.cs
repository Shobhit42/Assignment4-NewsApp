using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NewsApp.Models
{
    public class News
    {
        [JsonProperty("Articles")]
        public Article[]? Articles { get; set; }
    }

    public class Article
    {
        [JsonProperty("Author")]
        public string? Author { get; set; }

        [JsonProperty("Title")]
        public string? Title { get; set; }

        [JsonProperty("Description")]
        public string? Description { get; set; }

        [JsonProperty("publishedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime PublishedAt { get; set; }

        [JsonProperty("source")]
        public Source? Source { get; set; }
    }

    public class Source
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
