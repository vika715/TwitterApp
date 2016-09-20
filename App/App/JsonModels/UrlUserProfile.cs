using Newtonsoft.Json;
using System.Collections.Generic;


namespace App.JsonModels
{
    public class UrlUserProfile
    {
        [JsonProperty("expanded_url")]
        public string ExpandedUrl { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("indices")]
        public List<int> Indices { get; set; }
    }
}
