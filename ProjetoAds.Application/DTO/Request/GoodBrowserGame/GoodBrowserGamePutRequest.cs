using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.DTO.Request.GoodBrowserGame
{
    public class GoodBrowserGamePutRequest : GoodBrowserGamePostRequest
    {
        [JsonIgnore]
        [JsonProperty("AdministradorId")]
        public long AdministradorId { get; set; }
    }
}
