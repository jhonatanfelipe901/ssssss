using ProjetoAds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Domain.Service.Contracts
{
    public interface IGoodBrowserGameService
    {
        IEnumerable<GoodBrowserGame> GetAll();

        GoodBrowserGame Get(long id);

        void Insert(GoodBrowserGame goodBrowserGame);

        void Update(GoodBrowserGame goodBrowserGame);

        void Delete(long id);
    }
}
