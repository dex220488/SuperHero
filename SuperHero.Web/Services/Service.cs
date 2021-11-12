using SuperHero.DataAccess.Entities.Output;
using System.Collections.Generic;
using System.Web;
using static SuperHero.DataAccess.Entities.Api.Enums;

namespace SuperHero.Web.Services
{
    internal class Service
    {
        private DataAccess.Services.Api.IService _serviceApi;

        public List<SearchOutput> GetSearchList(string name)
        {
            var response = new List<SearchOutput>();
            _serviceApi = new DataAccess.Services.Api.Service(ApiGetOptions.Search, name);
            var apiResponse = _serviceApi.Get();
            if (!apiResponse.HasError)
            {
                var castObject = new DataAccess.Services.Parse.Search();
                response = (List<SearchOutput>)castObject.Cast(apiResponse.Content.ToString());
            }
            else
            {
                if (apiResponse.ErrorMessage != "character with given name not found")
                {
                    throw new HttpException($"Api Exception: {apiResponse.ErrorMessage}");
                }
            }

            return response;
        }

        public SearchOutput GetSearchById(int id)
        {
            var response = new SearchOutput();
            _serviceApi = new DataAccess.Services.Api.Service(ApiGetOptions.Id, id.ToString());
            var apiResponse = _serviceApi.Get();
            if (!apiResponse.HasError)
            {
                var castObject = new DataAccess.Services.Parse.SearchId();
                response = (SearchOutput)castObject.Cast(apiResponse.Content.ToString());
            }
            else
            {
                if (apiResponse.ErrorMessage != "invalid id")
                {
                    throw new HttpException($"Api Exception: {apiResponse.ErrorMessage}");
                }
            }

            return response;
        }
    }
}