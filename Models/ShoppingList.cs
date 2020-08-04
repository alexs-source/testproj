using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace testproj.Models
{
    public class ShoppingList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ShoppingListId { get; set; }
        public string Type { get; } = "shoppinglist";

        public string Notes { get; set; }
    }
}
