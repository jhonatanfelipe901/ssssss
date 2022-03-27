using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.DTO.Request.GoodBrowserGame
{
    public class GoodBrowserGamePostRequest
    {
        [JsonIgnore]
        public long AdministradorId { get; set; }

        [Required(ErrorMessage = "O Id da categoria é obrigatório.")]
        [JsonProperty("CategoriaId")]
        public long CategoriaId { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [JsonProperty("Descricao")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A url do jogo é obrigatória.")]
        [JsonProperty("UrlJogo")]
        public string UrlJogo { get; set; }

        [Required(ErrorMessage = "A url do video de demonstração é obrigatória.")]
        [JsonProperty("UrlVideoDemonstracao")]
        public string UrlVideoDemonstracao { get; set; }

        [Required(ErrorMessage = "A url da imagem é obrigatória.")]
        [JsonProperty("UrlImagemIlustrativa")]
        public string UrlImagemIlustrativa { get; set; }

        [Required(ErrorMessage = "O campo ativo é obrigatório.")]
        [JsonProperty("Ativo")]
        public bool Ativo { get; set; }
    }
}
