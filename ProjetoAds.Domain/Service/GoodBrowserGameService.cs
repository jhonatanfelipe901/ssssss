using ProjetoAds.Domain.Entities;
using ProjetoAds.Domain.Repository;
using ProjetoAds.Domain.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Domain.Service
{
    public class GoodBrowserGameService : IGoodBrowserGameService
    {
        private readonly IGoodBrowserGameRepository _goodBrowserGameRepository;

        public GoodBrowserGameService(IGoodBrowserGameRepository goodBrowserGameRepository)
        {
            _goodBrowserGameRepository = goodBrowserGameRepository;
        }

        public GoodBrowserGame Get(long id)
        {
            return _goodBrowserGameRepository.GetById(id);
        }

        public IEnumerable<GoodBrowserGame> GetAll()
        {
            return _goodBrowserGameRepository.GetAll();
        }

        public void Insert(GoodBrowserGame goodBrowserGame)
        {
            _goodBrowserGameRepository.Insert(goodBrowserGame);
        }

        public void Update(GoodBrowserGame goodBrowserGame)
        {
            _goodBrowserGameRepository.Update(goodBrowserGame);
        }

        public void Delete(long id)
        {
            _goodBrowserGameRepository.Delete(id);
        }
    }
}
