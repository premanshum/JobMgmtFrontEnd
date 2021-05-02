using System;
using System.Net.Http;
using System.Text;
using JobManagementWeb.Infrastructure.Entities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace JobManagementWeb.Repository
{
	public class ServiceCaller
	{
		private readonly ILogger _logger;

		public ServiceCaller()
		{
        }
        public ServiceCaller(ILogger logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <typeparam name="O"></typeparam>
        /// <param name="inputParams"></param>
        /// <param name="logErrorsSwitchedOff"></param>
        /// <returns></returns>
        public Response<O> MakeRequestPost<I, O>(Request<I> inputParams)
            where I : class
            where O : class
        {
            Response<O> response = new Response<O>();
            try
            {

                response = MakeLoginRequestPost<I, Response<O>>(inputParams);
                //var stringContent = new StringContent(
                //    JsonConvert.SerializeObject(inputParams.RequestObject),
                //    Encoding.UTF8,
                //    "application/json");

                //using (HttpClient client = new ServiceHttpClient(inputParams.Url, inputParams.Token))
                //using (HttpResponseMessage httpResponse = client.PostAsync(inputParams.Url, stringContent).Result)
                //using (HttpContent content = httpResponse.Content)
                //{
                //    var jsonAsString = content.ReadAsStringAsync().Result;
                //    response = JsonConvert.DeserializeObject<Response<O>>(jsonAsString);
                //}
            }
            catch (Exception ex)
            {
                throw;
            }

            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <typeparam name="O"></typeparam>
        /// <param name="inputParams"></param>
        /// <param name="logErrorsSwitchedOff"></param>
        /// <returns></returns>
        public O MakeLoginRequestPost<I, O>(Request<I> inputParams)
            where I : class
            where O : class
        {
            O response;
            try
            {
                var stringContent = new StringContent(
                    JsonConvert.SerializeObject(inputParams.RequestObject),
                    Encoding.UTF8,
                    "application/json");

                using (HttpClient client = new ServiceHttpClient(inputParams.Url, inputParams.Token))
                using (HttpResponseMessage httpResponse = client.PostAsync(inputParams.Url, stringContent).Result)
                using (HttpContent content = httpResponse.Content)
                {
                    var jsonAsString = content.ReadAsStringAsync().Result;
                    response = JsonConvert.DeserializeObject<O>(jsonAsString);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return response;
        }
    }
}
