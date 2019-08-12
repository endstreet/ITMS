using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ITMS.Models;

namespace ITMS.App.Data
{
    public class ESBService
    {

        private readonly HttpClient client;

        public ESBService(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("ESBService");
        }

        public async Task<List<Case>> GetCases(string facilitycode, string doctorcode, string theatrecode,string fromdate,string todate)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("api/case/{0}/{1}/{2}/{3}/{4}", facilitycode, doctorcode, theatrecode, fromdate, todate));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Case>>();
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<List<Register>> GetRegisters(string facilitycode, string fromdate,string todate)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,String.Format("api/register/{0}/{1}/{2}", facilitycode,fromdate,todate));
            using (var response = await client.SendAsync(request))
            {
                 if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Register>>();
                }
                else
                {
                    return null;
                }
            }

        }



        public async Task<IEnumerable<Profile>> GetProfiles(string facilitycode, string doctorcode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("api/profile/{0}/{1}",facilitycode,doctorcode));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Profile>>();
                }
                else
                {
                    return null;
                }
            }
       }

        public async Task<List<Complex>> GetComplexes(string facilitycode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("api/complex/{0}",facilitycode));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Complex>>();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
