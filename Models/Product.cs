using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContosoCrafts.Models
{
    public class Product
    {
        [MaxLength(50)]
        public string Id { get; set; }
        [MaxLength(50)]
        public string Maker { get; set; }
        
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
