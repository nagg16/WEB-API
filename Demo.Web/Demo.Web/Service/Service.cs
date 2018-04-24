using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Demo.Web.Service
{
    public class ServiceBAse
    {

        /// <summary>
        /// Method will be called when need to make GET request to API
        /// </summary>
        /// <typeparam name="T">Return datatype</typeparam>
        /// <param name="url">URL of API that needs to be called</param>
        /// <returns></returns>
        public T Get<T>(string url)
        {
            T searchResponse = default(T);
            try
            {
                using (var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(20) })
                {
                                    
                    HttpResponseMessage result = Task.Run(() => httpClient.GetAsync(url)).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        string responseString = Task.Run(() => result.Content.ReadAsStringAsync()).Result;
                        searchResponse = JsonConvert.DeserializeObject<T>(responseString);
                    }
                   
                    return searchResponse;
                }
            }
            catch (Exception ex)
            {
               
                return default(T);
            }
        }

    }
}