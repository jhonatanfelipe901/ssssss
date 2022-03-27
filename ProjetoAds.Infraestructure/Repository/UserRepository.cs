using Dapper;
using ProjetoAds.CrossCutting.Settings;
using ProjetoAds.Domain.Entities;
using ProjetoAds.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public User Get(string username, string password)
        {
            using (var connection = new SqlConnection(Settings.AdsDatabase))
            {
                //Abre conexão com SQL
                connection.Open();

                //@ - Padrão para declaração de uma string de query
                string query = @"SELECT * FROM [dbo].[User] WHERE [Username] = @Username AND [Senha] = @Password";

                //Conexão propriamente dita.
                return connection.Query<User>(query, new { Username = username, Password = password }).FirstOrDefault();
            }
        }

        public User Get(long id)
        {
            using (var connection = new SqlConnection(Settings.AdsDatabase))
            {
                //Abre conexão com SQL
                connection.Open();

                //@ - Padrão para declaração de uma string de query
                string query = @"SELECT * FROM [dbo].[User] WHERE [Id] = @Id";

                //Conexão propriamente dita.
                return connection.Query<User>(query, new { Id = id }).FirstOrDefault();
            }
        }

        public void Insert(User user)
        {
            using (var connection = new SqlConnection(Settings.AdsDatabase))
            {
                //Abre conexão com SQL
                connection.Open();

                //@ - Padrão para declaração de uma string de query
                string query = @"INSERT INTO [dbo].[User] VALUES (@NomeCompleto, @Username, @Senha, @DataNascimento, @Estado, @Pais, @Ativo, GETDATE(), GETDATE())";

                //Conexão propriamente dita.
                connection.Execute(query, 
                    new { NomeCompleto = user.NomeCompleto, Username = user.Username, 
                        Senha = user.Senha, DataNascimento = user.DataNascimento, 
                        Estado = user.Estado, Pais = user.Pais, Ativo = user.Ativo});
            }
        }
    }
}
