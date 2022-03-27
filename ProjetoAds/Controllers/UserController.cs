using Microsoft.AspNetCore.Mvc;
using ProjetoAds.Application.Contracts;
using ProjetoAds.Application.DTO.Response.User;

namespace ProjetoAds.Controllers
{
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : BaseController
    {
        private readonly IUserApplication _userApplication;

        public UserController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<UserGetResponse> GetUserById(long id)
        {
            var usuarios = await _userApplication.Get(id);

            return usuarios;
        }
    }
}
