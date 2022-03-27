using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.DTO.Request.Auth
{
    public class RegisterUserRequest
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [JsonProperty("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O username é obrigatório.")]
        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [JsonProperty("Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O estado é obrigatório.")]
        [JsonProperty("Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O pais é obrigatório.")]
        [JsonProperty("Pais")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "O campo ativo é obrigatório.")]
        [JsonProperty("Ativo")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [JsonProperty("DataNascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
