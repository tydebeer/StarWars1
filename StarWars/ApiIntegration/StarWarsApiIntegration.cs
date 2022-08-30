using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWars.ApiIntegration
{
    public class StarWarsApiIntegration
    {
        public async Task<HttpResponseMessage> GetRequest()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var requestResult = await client.GetAsync("https://swapi.dev/api/people");

                    return requestResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
