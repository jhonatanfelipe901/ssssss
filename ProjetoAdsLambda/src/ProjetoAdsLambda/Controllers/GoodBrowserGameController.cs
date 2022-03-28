using Microsoft.AspNetCore.Mvc;
using ProjetoAds.Application.Contracts;
using ProjetoAds.Application.DTO.Request.GoodBrowserGame;
using ProjetoAds.Application.DTO.Response;
using ProjetoAds.Application.DTO.Response.GoodBrowserGame;

namespace ProjetoAdsLambda.Controllers
{
    [Produces("application/json")]
    [Route("api/goodbrowsergame")]
    public class GoodBrowserGameController :  BaseController
    {
        private readonly IGoodBrowserGameApplication _goodBrowserGameApplication;

        public GoodBrowserGameController(IGoodBrowserGameApplication goodBrowserGameApplication)
        {
            _goodBrowserGameApplication = goodBrowserGameApplication;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var goodBrowserGameList = await _goodBrowserGameApplication.GetAll();

            return BaseResponse<IEnumerable<GoodBrowserGameGetResponse>>(goodBrowserGameList);
        }


        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> Get(long id)
        {
            var goodBrowserGame = await _goodBrowserGameApplication.Get(id);

            return BaseResponse<GoodBrowserGameGetResponse>(goodBrowserGame);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GoodBrowserGamePostRequest request)
        {
            return BaseResponse<GoodBrowserGameOperationResponse>(await _goodBrowserGameApplication.Insert(request));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] GoodBrowserGamePutRequest request)
        {
            return BaseResponse<GoodBrowserGameOperationResponse>(await _goodBrowserGameApplication.Update(request));
        }

        [HttpDelete]
        public async Task<BaseResponse<GoodBrowserGameOperationResponse>> Delete(long id)
        {
            return await _goodBrowserGameApplication.Delete(id);
        }
    }
}
