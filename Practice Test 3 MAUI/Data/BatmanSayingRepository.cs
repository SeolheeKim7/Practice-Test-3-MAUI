using Practice_Test_3_MAUI.Models;
using Practice_Test_3_MAUI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test_3_MAUI.Data
{
    public class BatmanSayingRepository : IBatmanSayingRepository
    {
        HttpClient client = new HttpClient();

        public BatmanSayingRepository()
        {
            client.BaseAddress = Jeeves.DBUri;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<BatmanSaying> GetSaying()
        {
            var response = await client.GetAsync("batman");
            if (response.IsSuccessStatusCode)
            {
                BatmanSaying saying = await response.Content.ReadAsAsync<BatmanSaying>();
                return saying;
            }
            else
            {
                var ex = Jeeves.CreateApiException(response);
                throw ex;
            }
        }
    }
}
