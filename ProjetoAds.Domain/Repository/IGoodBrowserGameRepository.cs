using ProjetoAds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Domain.Repository
{
    public interface IGoodBrowserGameRepository
    {
        GoodBrowserGame GetById(long id);

        IEnumerable<GoodBrowserGame> GetAll();

        void Insert(GoodBrowserGame goodBrowserGame);

        void Update(GoodBrowserGame goodBrowserGame);

        void Delete(long id);
    }
}
