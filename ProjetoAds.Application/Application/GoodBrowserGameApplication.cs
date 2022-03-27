using ProjetoAds.Application.Contracts;
using ProjetoAds.Application.DTO.Request.GoodBrowserGame;
using ProjetoAds.Application.DTO.Response;
using ProjetoAds.Application.DTO.Response.GoodBrowserGame;
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
    public class GoodBrowserGameApplication : ApplicationBase<GoodBrowserGame>, IGoodBrowserGameApplication
    {
        private readonly IGoodBrowserGameService _goodBrowserGameService;

        public GoodBrowserGameApplication(IGoodBrowserGameService goodBrowserGameService)
        {
            _goodBrowserGameService = goodBrowserGameService;
        }

        public async Task<BaseResponse<IEnumerable<GoodBrowserGameGetResponse>>> GetAll()
        {
            var goodBrowserGameList = _goodBrowserGameService.GetAll();

            return await Task.Run(() =>
            {
                return GetBaseResponse<IEnumerable<GoodBrowserGameGetResponse>>(GoodBrowserGameGetResponse.CreateList(goodBrowserGameList));
            });
        }

        public async Task<BaseResponse<GoodBrowserGameGetResponse>> Get(long id)
        {
            var goodBrowserGameList = _goodBrowserGameService.Get(id);

            return await Task.Run(() =>
            {
                return GetBaseResponse<GoodBrowserGameGetResponse>(GoodBrowserGameGetResponse.Create(goodBrowserGameList));
            });
        }

        public async Task<BaseResponse<GoodBrowserGameOperationResponse>> Insert(GoodBrowserGamePostRequest request)
        {
            return await Task.Run(() =>
            {
                var goodBrowserGame = GoodBrowserGame.CreateInstance(request.AdministradorId, request.CategoriaId, request.Descricao, request.UrlJogo, request.UrlVideoDemonstracao, request.UrlImagemIlustrativa, request.Ativo);

                _goodBrowserGameService.Insert(goodBrowserGame);

                return GetBaseResponse<GoodBrowserGameOperationResponse>(GoodBrowserGameOperationResponse.Create(goodBrowserGame));
            });
        }

        public async Task<BaseResponse<GoodBrowserGameOperationResponse>> Update(GoodBrowserGamePutRequest request)
        {
            return await Task.Run(() =>
            {
                var goodBrowserGame = GoodBrowserGame.CreateInstanceUpdate(request.Id, request.AdministradorId, request.CategoriaId, request.Descricao, request.UrlJogo, request.UrlVideoDemonstracao, request.UrlImagemIlustrativa, request.Ativo);

                _goodBrowserGameService.Update(goodBrowserGame);

                return GetBaseResponse<GoodBrowserGameOperationResponse>(GoodBrowserGameOperationResponse.Create(goodBrowserGame));
            });
        }

        public async Task<BaseResponse<GoodBrowserGameOperationResponse>> Delete(long id)
        {
            return await Task.Run(() =>
            {
                var goodBrowserGame = _goodBrowserGameService.Get(id);

                _goodBrowserGameService.Delete(goodBrowserGame.Id);

                return GetBaseResponse<GoodBrowserGameOperationResponse>(GoodBrowserGameOperationResponse.Create(goodBrowserGame));
            });
        }
    }
}
