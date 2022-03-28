using ProjetoAds.Application.DTO.Request.GoodBrowserGame;
using ProjetoAds.Application.DTO.Response;
using ProjetoAds.Application.DTO.Response.GoodBrowserGame;
using ProjetoAds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.Contracts
{
    public interface IGoodBrowserGameApplication
    {
        Task<BaseResponse<IEnumerable<GoodBrowserGameGetResponse>>> GetAll();
        Task<BaseResponse<GoodBrowserGameGetResponse>> Get(long id);
        Task<BaseResponse<GoodBrowserGameOperationResponse>> Insert(GoodBrowserGamePostRequest request);
        Task<BaseResponse<GoodBrowserGameOperationResponse>> Update(long id, GoodBrowserGamePutRequest request);
        Task<BaseResponse<GoodBrowserGameOperationResponse>> Delete(long id);
    }
}
