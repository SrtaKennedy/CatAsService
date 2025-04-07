using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAsService.Modules
{
     public class GatoRaca
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("origin")]
        public string Origem { get; set; }

        [JsonProperty("description")]
        public string Descricao { get; set; }

        [JsonProperty("temperament")]
        public string Temperamento { get; set; }
    }
}
