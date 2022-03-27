using Newtonsoft.Json;
using ProjetoAds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.DTO.Response
{
    public class GoodBrowserGameGetResponse
    {
        [JsonProperty("UserIdAdministrador")]
        public long UserIdAdministrador { get; set; }

        [JsonProperty("IdCategoria")]
        public long IdCategoria { get; set; }

        [JsonProperty("Descricao")]
        public string Descricao { get; set; }

        [JsonProperty("UrlJogo")]
        public string UrlJogo { get; set; }

        [JsonProperty("UrlVideoDemonstracao")]
        public string UrlVideoDemonstracao { get; set; }

        [JsonProperty("UrlImagemIlustrativa")]
        public string UrlImagemIlustrativa { get; set; }

        public static IEnumerable<GoodBrowserGameGetResponse> CreateList(IEnumerable<ProjetoAds.Domain.Entities.GoodBrowserGame> goodBrowserGameList)
        {
            if (goodBrowserGameList?.Count() == 0)
                return null;

            return goodBrowserGameList.Select(game => Create(game));
        }

        public static GoodBrowserGameGetResponse Create(ProjetoAds.Domain.Entities.GoodBrowserGame goodBrowserGame)
        {
            if (goodBrowserGame is null)
                return null;

            return new GoodBrowserGameGetResponse()
            {
                UserIdAdministrador = goodBrowserGame.UserIdAdministrador,
                IdCategoria = goodBrowserGame.IdCategoria,
                Descricao = goodBrowserGame.Descricao,
                UrlJogo = goodBrowserGame.UrlJogo,
                UrlVideoDemonstracao = goodBrowserGame.UrlVideoDemonstracao,
                UrlImagemIlustrativa = goodBrowserGame.UrlImagemIlustrativa
            };
        }
    }
}
