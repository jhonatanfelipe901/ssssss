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
    public class EvaluationRepository : IEvaluationRepository
    { 

        public ICollection<GoodBrowserGame> GetTop5GoodBrowserGameEvaluations()
        {
            using (var connection = new SqlConnection(Settings.AdsDatabase))
            {
                //Abre conexão com SQL
                connection.Open();

                //@ - Padrão para declaração de uma string de query
                string query = @"SELECT * FROM [dbo].[GoodBrowserGame]";

                //Conexão propriamente dita.
                return connection.Query<GoodBrowserGame>(query).ToList();
            }
        }
    }
}
