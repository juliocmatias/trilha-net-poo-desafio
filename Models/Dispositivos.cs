using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesafioPOO.Models
{
    public class Dispositivos
    {
        [JsonProperty("nokia_apps")]
        public List<App> NokiaApps { get; set; }
        [JsonProperty("iphone_apps")]
        public List<App> IphoneApps { get; set; }
    }
}