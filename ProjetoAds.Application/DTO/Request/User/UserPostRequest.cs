using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.DTO.Request.User
{
    public class UserPostRequest
    {
        [Required(ErrorMessage = "O Id da categoria é obrigatório.")]
        [JsonProperty("NomeCompleto")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O Id da categoria é obrigatório.")]
        [JsonProperty("Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "O Id da categoria é obrigatório.")]
        [JsonProperty("Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O Id da categoria é obrigatório.")]
        [JsonProperty("DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O Id da categoria é obrigatório.")]
        [JsonProperty("Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O Id da categoria é obrigatório.")]
        [JsonProperty("Pais")]
        public string Pais { get; set; }
    }
}
