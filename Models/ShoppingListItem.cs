using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace testproj.Models
{
    public class ShoppingListItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public string ShoppingListItemId { get; set; }
        public string ShoppingListId { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }

        public string Type { get; } = "shoppinglistitem";
        public string Units { get; set; }
    }
}
