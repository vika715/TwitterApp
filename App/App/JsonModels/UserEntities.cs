using Newtonsoft.Json;

namespace App.JsonModels
{
    public class UserEntities
    {
        [JsonProperty("url")]
        public UrlUserProfile Url { get; set; }
        //[JsonProperty("description")]
        //public Description description { get; set; }
    }
}
