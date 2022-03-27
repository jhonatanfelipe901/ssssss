using ProjetoAds.Application.DTO.Response;
using ProjetoAds.Application.DTO.Response.Paging;
using ProjetoAds.CrossCutting.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.Application
{
    public abstract class BaseApplication
    {
        protected BaseResponse<T> GetBaseResponse<T>(T data)
        {
            var baseResponse = new BaseResponse<T>();
            baseResponse.Data = data;

            return baseResponse;
        }

        protected BaseResponse<T> GetBaseResponseWithErrors<T>(IEnumerable<string> errors, T data = default(T))
        {
            var errorsResponse = new List<ErrorResponse>();

            errors.ToList().ForEach(e => errorsResponse.Add(new ErrorResponse { ErrorMessage = e }));

            return new BaseResponse<T>
            {
                Data = data,
                Errors = errorsResponse,
                ValidationsErrors = errorsResponse
            };
        }

        protected BaseResponse<T> GetBaseResponseWithError<T>(string error, T data = default(T))
        {
            var errorsResponse = new List<ErrorResponse>();

            errorsResponse.Add(new ErrorResponse { ErrorMessage = error });

            return new BaseResponse<T>
            {
                Data = data,
                Errors = errorsResponse,
                ValidationsErrors = errorsResponse
            };
        }

        protected PagedResult<T> GetPagedResult<T>(IEnumerable<T> list, int page, int pageSize)
        {
            var result = new PagedResult<T>();

            if (list != null)
            {
                result.CurrentPage = page;
                result.PageSize = pageSize;
                result.RowCount = list.Count();

                var pageCount = (double)result.RowCount / pageSize;
                result.PageCount = (int)Math.Ceiling(pageCount);

                result.Results = list.GetPaged(page, pageSize).ToList();
            }

            return result;
        }

        protected string GetErrorMessage(string errorMessage, Exception exception)
        {
            return $"{errorMessage} {exception.Message}";
        }
    }
}
