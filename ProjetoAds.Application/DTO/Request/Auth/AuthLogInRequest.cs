using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.DTO.Request.Auth
{
    public class AuthLogInRequest
    {
        [Required(ErrorMessage = "O Username é obrigatório.")]
        [JsonProperty("Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [JsonProperty("Senha")]
        public string Password { get; set; }
    }
}
