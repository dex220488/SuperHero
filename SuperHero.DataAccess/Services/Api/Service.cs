using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuperHero.DataAccess.Entities.Api;
using System;
using System.Configuration;
using System.Net.Http;
using static SuperHero.DataAccess.Entities.Api.Enums;

namespace SuperHero.DataAccess.Services.Api
{
    public class Service : IService
    {
        private HttpClient client;
        private string path = "";

        public Service(ApiGetOptions apiGetOptions, string filter)
        {
            path = $"{ConfigurationManager.AppSettings.Get("SuperHero.Api.Url")}/{ConfigurationManager.AppSettings.Get("SuperHero.Api.Token")}";

            if (apiGetOptions != ApiGetOptions.Search)
            {
                if (apiGetOptions == ApiGetOptions.Id)
                {
                    path = $"{path}/{filter}";
                }
                else
                {
                    path = $"{path}/{filter}/{apiGetOptions.ToString().ToLower()}";
                }
            }
            else
            {
                path = $"{path}/{apiGetOptions.ToString().ToLower()}/{filter}";
            }

            client = new HttpClient();
        }

        public Response Get()
        {
            var response = new Response();
            try
            {
                HttpResponseMessage apiResponse = client.GetAsync(path).Result;
                if (apiResponse.IsSuccessStatusCode)
                {
                    var jsonData = apiResponse.Content.ReadAsStringAsync().Result;

                    var data = (JObject)JsonConvert.DeserializeObject(jsonData);
                    string responseStatus = data["response"].Value<string>();

                    if (responseStatus == "success")
                    {
                        if (data["results"] != null)
                            response.Content = data["results"].ToString();
                        else
                            response.Content = data.ToString();
                    }
                    else
                    {
                        response.HasError = true;
                        response.ErrorMessage = data["error"].Value<string>();
                    }
                }
                else
                {
                    response.HasError = true;
                    response.ErrorMessage = $"{(int)apiResponse.StatusCode} {apiResponse.ReasonPhrase})";
                }
                client.Dispose();
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }
    }
}