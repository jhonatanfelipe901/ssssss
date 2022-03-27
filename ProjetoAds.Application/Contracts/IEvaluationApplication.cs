using ProjetoAds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.Contracts
{
    public interface IEvaluationApplication
    {
        Task<IEnumerable<GoodBrowserGame>> GetTop5GoodBrowserGameEvaluations();
    }
}
