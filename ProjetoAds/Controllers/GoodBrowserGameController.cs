using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoAds.Application.Contracts;
using ProjetoAds.Application.DTO.Request.GoodBrowserGame;
using ProjetoAds.Application.DTO.Response;
using ProjetoAds.Application.DTO.Response.GoodBrowserGame;

namespace ProjetoAds.Controllers
{
    [Produces("application/json")]
    [Route("api/goodbrowsergame")]
    public class GoodBrowserGameController : BaseController
    {
        private readonly IGoodBrowserGameApplication _goodBrowserGameApplication;

        public GoodBrowserGameController(IGoodBrowserGameApplication goodBrowserGameApplication)
        {
            _goodBrowserGameApplication = goodBrowserGameApplication;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var goodBrowserGameList = await _goodBrowserGameApplication.GetAll();

            return BaseResponse<IEnumerable<GoodBrowserGameGetResponse>>(goodBrowserGameList);
        }

        [Authorize]
        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> Get(long id)
        {
            var goodBrowserGame = await _goodBrowserGameApplication.Get(id);

            return BaseResponse<GoodBrowserGameGetResponse>(goodBrowserGame);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GoodBrowserGamePostRequest request)
        {
            request.AdministradorId = Convert.ToInt64(GetUserLoggedInId());

            return BaseResponse<GoodBrowserGameOperationResponse>(await _goodBrowserGameApplication.Insert(request));
        }

        [Authorize]
        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> Put(long id, [FromBody] GoodBrowserGamePutRequest request)
        {
            request.AdministradorId = Convert.ToInt64(GetUserLoggedInId());

            return BaseResponse<GoodBrowserGameOperationResponse>(await _goodBrowserGameApplication.Update(id, request));
        }

        [Authorize]
        [HttpDelete]
        [Route("{id:long}")]
        public async Task<BaseResponse<GoodBrowserGameOperationResponse>> Delete(long id)
        {
            return await _goodBrowserGameApplication.Delete(id);
        }
    }
}
