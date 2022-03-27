using Microsoft.AspNetCore.Mvc;
using ProjetoAds.Application.Application;
using ProjetoAds.Application.Contracts;
using ProjetoAds.Domain.Entities;

namespace ProjetoAds.Controllers
{
    [Produces("application/json")]
    [Route("api/evaluation")]
    public class EvaluationController : BaseController
    {
        private readonly IEvaluationApplication _evaluationApplication;

        public EvaluationController(IEvaluationApplication evaluationApplication)
        {
            _evaluationApplication = evaluationApplication;
        }

        [HttpGet]
        [Route("top5")]
        public async Task<IEnumerable<GoodBrowserGame>> GetTop5GoodBrowserGameEvaluations()
        {
            var usuarios = await _evaluationApplication.GetTop5GoodBrowserGameEvaluations();

            return usuarios;
        }
    }
}
