using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.DTO.Response.GoodBrowserGame
{
    public class GoodBrowserGameOperationResponse
    {
        [JsonProperty("Descricao")]
        public string Descricao { get; set; }

        public static IEnumerable<GoodBrowserGameOperationResponse> CreateList(IEnumerable<ProjetoAds.Domain.Entities.GoodBrowserGame> goodBrowserGameList)
        {
            if (goodBrowserGameList?.Count() == 0)
                return null;

            return goodBrowserGameList.Select(game => Create(game));
        }
        
        public static GoodBrowserGameOperationResponse Create(ProjetoAds.Domain.Entities.GoodBrowserGame goodBrowserGame)
        {
            if (goodBrowserGame is null)
                return null;

            return new GoodBrowserGameOperationResponse()
            {
                Descricao = goodBrowserGame.Descricao
            };
        }
    }
}
