using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SandRockDevAPILibrary
{
    public class WebApiProcessor<TEntity> where TEntity : class
    {
        public static async Task<List<TEntity>> Get(String method)
        {
			//add the url base 
            string url = "  " + method;
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<List<TEntity>>(content);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<TEntity> GetSingle(string method)
        {
			//add the url base 
            string url = " " + method;
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<TEntity>(content);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
