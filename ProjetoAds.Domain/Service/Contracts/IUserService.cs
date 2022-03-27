using ProjetoAds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Domain.Service.Contracts
{
    public interface IUserService
    {
        User Get(string username, string password);
        User Get(long id);
        void Insert(User user);
    }
}
