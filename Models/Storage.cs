using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace testproj.Models
{
    public class Storage
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public string StorageId { get; set; }
        public string UserId { get; set; }
        public string Type { get; } = "storage";
        public string Name { get; set; }
    }
}
