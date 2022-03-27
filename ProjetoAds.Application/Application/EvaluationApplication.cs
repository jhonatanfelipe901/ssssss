using ProjetoAds.Application.Contracts;
using ProjetoAds.Data.Repository;
using ProjetoAds.Domain.Entities;
using ProjetoAds.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.Application
{
    public class EvaluationApplication : IEvaluationApplication
    {
        private readonly IEvaluationRepository _evaluationRepository;

        public EvaluationApplication(IEvaluationRepository evaluationApplication)
        {
            _evaluationRepository = evaluationApplication;
        }

        public async Task<IEnumerable<GoodBrowserGame>> GetTop5GoodBrowserGameEvaluations()
        {
            var usuarios =  _evaluationRepository.GetTop5GoodBrowserGameEvaluations();

            return usuarios;
        }
    }
}
