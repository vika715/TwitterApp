using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace App.JsonModels
{
    public class Description
    {
        [JsonProperty("urls")]
        public List<String> Urls { get; set; }
    }
}
