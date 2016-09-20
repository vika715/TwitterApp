using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace App.JsonModels
{
    public class Entities
    {
        [JsonProperty("urls")]
        public List<Urls> Urls { get; set; }
     /* [JsonProperty("hashtags")]
        public List<String> HashTags { get; set; }
        [JsonProperty("user_mentions")]
        public List<string> UserMentions { get; set; }*/
    }
}
