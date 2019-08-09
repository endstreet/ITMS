using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMS.Models
{
    public class Complex
    {
        [JsonProperty("HospitalLocation")]
        public string HospitalLocation { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Manager")]
        public string Manager { get; set; }
    }
}
