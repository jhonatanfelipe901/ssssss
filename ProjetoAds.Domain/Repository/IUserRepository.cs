using ProjetoAds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Domain.Repository
{
    public interface IUserRepository
    {
        User Get(string username, string password);
        User Get(long id);
        void Insert(User usuario);
    }
}
