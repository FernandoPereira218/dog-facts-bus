using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace dog_facts_bus.Model
{
    public static class UtilsAPI
    {
        private const string API_ENDPOINT = "https://www.dogfactsapi.ducnguyen.dev/api/v1/facts/?number=";

        public static async Task<string> MakeRequestAsync(string value)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = new TimeSpan(1, 1, 1);
                HttpResponseMessage response = await httpClient.GetAsync(API_ENDPOINT + value);

                string strContent = await response.Content.ReadAsStringAsync();
                return strContent;
            }
            catch
            {
                throw;
            }
        }
    }
}
