using ProjetoAds.Application.DTO.Request.Auth;
using ProjetoAds.Application.DTO.Request.User;
using ProjetoAds.Application.DTO.Response.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.Contracts
{
    public interface IAuthApplication
    {
        Task<AuthResponse> LoginAsync(AuthLogInRequest request);
        Task<AuthResponse> RegisterAsync(UserPostRequest request);
    }
}
