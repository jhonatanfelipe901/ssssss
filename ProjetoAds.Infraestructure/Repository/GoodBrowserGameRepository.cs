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
    public class GoodBrowserGameRepository : IGoodBrowserGameRepository
    {
        public IEnumerable<GoodBrowserGame> GetAll()
        {
            using (var connection = new SqlConnection(Settings.AdsDatabase))
            {
                connection.Open();

                string query = @"SELECT * FROM [dbo].[GoodBrowserGame]";

                return connection.Query<GoodBrowserGame>(query).ToList();
            }
        }

        public GoodBrowserGame GetById(long id)
        {
            using (var connection = new SqlConnection(Settings.AdsDatabase))
            {
                connection.Open();

                string query = @"SELECT * FROM [dbo].[GoodBrowserGame] WHERE [Id] = @Id";

                return connection.Query<GoodBrowserGame>(query, new { Id = id }).FirstOrDefault();
            }
        }

        public void Insert(GoodBrowserGame goodBrowserGame)
        {
            using (var connection = new SqlConnection(Settings.AdsDatabase))
            {
                connection.Open();

                var query = $"INSERT INTO [dbo].[GoodBrowserGame] (UserIdAdministrador, IdCategoria, Nome, Descricao, UrlJogo," +
                            "UrlVideoDemonstracao, UrlImagemIlustrativa, Ativo, DataCriacao, DataAtualizacao)" +
                            "VALUES" +
                            "(@UserIdAdministrador, @IdCategoria, @Nome, @Descricao, @UrlJogo, @UrlVideoDemonstracao, @UrlImagemIlustrativa, @Ativo," +
                            "GETDATE(), GETDATE())";

                connection.Execute(query, new
                {
                    UserIdAdministrador = goodBrowserGame.UserIdAdministrador,
                    IdCategoria = goodBrowserGame.IdCategoria,
                    Nome = goodBrowserGame.Nome,
                    Descricao = goodBrowserGame.Descricao,
                    UrlJogo = goodBrowserGame.UrlJogo,
                    UrlVideoDemonstracao = goodBrowserGame.UrlVideoDemonstracao,
                    UrlImagemIlustrativa = goodBrowserGame.UrlImagemIlustrativa,
                    Ativo = goodBrowserGame.Ativo ? 1 : 0,
                });
            }
        }

        public void Update(GoodBrowserGame goodBrowserGame)
        {
            using (var connection = new SqlConnection(Settings.AdsDatabase))
            {
                connection.Open();

                var query = $"UPDATE [dbo].[GoodBrowserGame] SET " +
                            "IdCategoria = @IdCategoria, " +
                            "Nome = @Nome, " +
                            "Descricao = @Descricao, " +
                            "UrlJogo = @UrlJogo, " +
                            "UrlVideoDemonstracao = @UrlVideoDemonstracao, " +
                            "UrlImagemIlustrativa = @UrlImagemIlustrativa, " +
                            "Ativo = @Ativo, " +
                            "DataAtualizacao = GETDATE() WHERE [Id] = @Id";

                connection.Execute(query, new
                {
                    Id = goodBrowserGame.Id,
                    UserIdAdministrador = goodBrowserGame.UserIdAdministrador,
                    IdCategoria = goodBrowserGame.IdCategoria,
                    Nome = goodBrowserGame.Nome,
                    Descricao = goodBrowserGame.Descricao,
                    UrlJogo = goodBrowserGame.UrlJogo,
                    UrlVideoDemonstracao = goodBrowserGame.UrlVideoDemonstracao,
                    UrlImagemIlustrativa = goodBrowserGame.UrlImagemIlustrativa,
                    Ativo = goodBrowserGame.Ativo
                });
            }
        }

        public void Delete(long id)
        {
            using (var connection = new SqlConnection(Settings.AdsDatabase))
            {
                connection.Open();

                var query = $"DELETE [dbo].[GoodBrowserGame] WHERE [Id] = @Id";

                connection.Execute(query, new
                {
                    Id = id
                });
            }
        }
    }
}

