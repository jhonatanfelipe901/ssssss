using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.DTO.Response.User
{
    public class UserGetResponse
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("NomeCompleto")]
        public string NomeCompleto { get; set; }

        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [JsonProperty("Estado")]
        public string Estado { get; set; }

        [JsonProperty("Pais")]
        public string Pais { get; set; }

        public static IEnumerable<UserGetResponse> CreateList(IEnumerable<ProjetoAds.Domain.Entities.User> userList)
        {
            if (userList?.Count() == 0)
                return null;

            return userList.Select(game => Create(game));
        }

        public static UserGetResponse Create(ProjetoAds.Domain.Entities.User user)
        {
            if (user is null)
                return null;

            return new UserGetResponse()
            {
                Id = user.Id,
                NomeCompleto = user.NomeCompleto,
                Username = user.Username,
                DataNascimento = user.DataNascimento,
                Estado = user.Estado,
                Pais = user.Pais
            };
        }
    }
}
