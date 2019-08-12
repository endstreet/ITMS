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

        private List<Register> registers = new List<Register>();
        private List<Case> cases = new List<Case>();
        private List<Profile> profiles = new List<Profile>();
        private List<Complex> complexes = new List<Complex>();

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
                    cases = await response.Content.ReadAsAsync<List<Case>>();
                }
            }
            return cases;

        }
        public async Task<List<Register>> GetRegisters(string hospital)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,String.Format("api/register/{0}",hospital));
            using (var response = await client.SendAsync(request))
            {
                 if (response.IsSuccessStatusCode)
                {
                    registers = await response.Content.ReadAsAsync<List<Register>>();
                }
            }
            return registers;
          
        }



        public async Task<IEnumerable<Profile>> GetProfiles()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "api/profile");
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    profiles = await response.Content.ReadAsAsync<List<Profile>>();
                }
            }
            return profiles;

        }

        public async Task<List<Complex>> GetComplexes(string hospital)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("api/complex/{0}",hospital));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    complexes = await response.Content.ReadAsAsync<List<Complex>>();
                }
            }
            return complexes;
        }
    }
}
