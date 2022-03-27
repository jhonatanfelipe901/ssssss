using Microsoft.AspNetCore.Identity;
using ProjetoAds.Application.Contracts;
using ProjetoAds.Application.DTO.Request.Auth;
using ProjetoAds.Application.DTO.Request.User;
using ProjetoAds.Application.DTO.Response.Auth;
using ProjetoAds.CrossCutting.Helpers.Auth.Services;
using ProjetoAds.CrossCutting.Helpers.JWT;
using ProjetoAds.Domain.Entities;
using ProjetoAds.Domain.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.Application
{
    public class AuthApplication : IAuthApplication
    {
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;

        public AuthApplication(ITokenService tokenService, IUserService userService)
        {
            _tokenService = tokenService;
            _userService = userService;
        }

        public async Task<AuthResponse> LoginAsync(AuthLogInRequest request)
        {
            var user = _userService.Get(request.Username, request.Password);

            if (user == null)
            {
                return new AuthResponse()
                {
                    Errors = new List<string>() { "Invalid username or password" }
                };
            }

            return new AuthResponse()
            {
                Succeeded = true,
                Token = _tokenService.GenerateToken(Convert.ToString(user.Id))
            };  
        }

        public async Task<AuthResponse> RegisterAsync(UserPostRequest request)
        {
            var user = User.CreateInstance(request.NomeCompleto, request.Username, request.Senha, request.DataNascimento, request.Estado, request.Pais);

            _userService.Insert(user);

            return new AuthResponse()
            {
                Succeeded = true,
                Token = _tokenService.GenerateToken(user.Username)
            };
        }
    }
}
