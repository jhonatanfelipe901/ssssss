using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Domain.Entities
{
    public class GoodBrowserGame : BaseEntity
    {
        public long UserIdAdministrador { get; set; }
        public long IdCategoria { get; set; }
        public string Descricao { get; set; }
        public string UrlJogo { get; set; }
        public string UrlVideoDemonstracao { get; set; }
        public string UrlImagemIlustrativa { get; set; }

        public GoodBrowserGame()
        {

        }
        private GoodBrowserGame(
            long id, long userIdAdministrador, long idCategoria,
            string descricao, string urlJogo,
            string urlVideoDemonstracao, string urlImagemIlustrativa, bool ativo)
        {
            Id = id;
            UserIdAdministrador = userIdAdministrador;
            IdCategoria = idCategoria;
            Descricao = descricao;
            UrlJogo = urlJogo;
            UrlVideoDemonstracao = urlVideoDemonstracao;
            UrlImagemIlustrativa = urlImagemIlustrativa;
            Ativo = ativo;
        }

        private GoodBrowserGame(
            long userIdAdministrador, long idCategoria, 
            string descricao, string urlJogo, 
            string urlVideoDemonstracao, string urlImagemIlustrativa, bool ativo)
        {
            UserIdAdministrador = userIdAdministrador;
            IdCategoria = idCategoria;
            Descricao = descricao;
            UrlJogo = urlJogo;
            UrlVideoDemonstracao = urlVideoDemonstracao;
            UrlImagemIlustrativa = urlImagemIlustrativa;
            Ativo = ativo;
        }

        public static GoodBrowserGame CreateInstance(
            long userIdAdministrador, long idCategoria, 
            string descricao, string urlJogo, 
            string urlVideoDemonstracao, string urlImagemIlustrativa, bool ativo)
        {
            return new GoodBrowserGame(userIdAdministrador, idCategoria, descricao, urlJogo, urlVideoDemonstracao, urlImagemIlustrativa, ativo);
        }

        public static GoodBrowserGame CreateInstanceUpdate(
            long id, long userIdAdministrador, long idCategoria,
            string descricao, string urlJogo,
            string urlVideoDemonstracao, string urlImagemIlustrativa, bool ativo)
        {
            return new GoodBrowserGame(id, userIdAdministrador, idCategoria, descricao, urlJogo, urlVideoDemonstracao, urlImagemIlustrativa, ativo);
        }
    }
}
