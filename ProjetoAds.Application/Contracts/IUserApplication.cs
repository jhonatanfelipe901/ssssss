using ProjetoAds.Application.DTO.Response.User;
using ProjetoAds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.Contracts
{
    public interface IUserApplication
    {
        Task<UserGetResponse> Get(long id);
    }
}
