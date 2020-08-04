using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace testproj.Models
{
    public class Item
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public string ItemId { get; set; }
        public string StorageId { get; set; }
        public string RecipeId { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }

        public string Type { get; } = "item";
        public string Units { get; set; }
    }
}
