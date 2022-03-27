using ProjetoAds.Application.Contracts;
using ProjetoAds.Application.DTO.Response;
using ProjetoAds.Application.DTO.Response.User;
using ProjetoAds.Domain.Entities;
using ProjetoAds.Domain.Repository;
using ProjetoAds.Domain.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.Application
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserService _userService;

        public UserApplication(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UserGetResponse> Get(long id)
        {
            return await Task.Run(() =>
            {
                var user = _userService.Get(id);

                return UserGetResponse.Create(user);
            });
        }
    }
}
