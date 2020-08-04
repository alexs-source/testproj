using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace testproj.Models
{
    public class Recipe
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public string RecipeId { get; set; }
        public string UserId { get; set; }
        public string Type { get; } = "recipe";

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
    }
}
