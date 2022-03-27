using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Domain.Entities
{
    public class User : BaseEntity
    {
        public string NomeCompleto { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public User()
        {

        }

        private User(string nomeCompleto, string username, string senha, DateTime dataNascimento, string estado, string pais)
        {
            NomeCompleto = nomeCompleto;
            Username = username;
            Senha = senha;
            DataNascimento = dataNascimento;
            Estado = estado;
            Pais = pais;
        }

        public static User CreateInstance(string nomeCompleto, string username, string senha, DateTime dataNascimento, string estado, string pais)
        {
            return new User(nomeCompleto, username, senha, dataNascimento, estado, pais);
        }
    }
}
