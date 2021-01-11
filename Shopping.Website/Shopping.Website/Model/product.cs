using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shopping.Website.Model
{
    public class product
    {
        [JsonPropertyName("Id")]
        public String Id { get; set; }
        
        [JsonPropertyName("Maker")]
        public String Maker { get; set; }
        
        [JsonPropertyName("img")]
        public String Image { get; set; }
        
        [JsonPropertyName("Url")]
        public  String URL { get; set; }
        
        [JsonPropertyName("Title")]
        public String Title { get; set; }
        
        [JsonPropertyName("Description")]
        public String Description { get; set; }
        
        [JsonPropertyName("Ratings")]
        public int[] Rating { get; set; }
    }
}
