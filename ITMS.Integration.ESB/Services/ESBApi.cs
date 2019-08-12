using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ITMS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ITMS.Integration.ESB
{
    public class ESBApi
    {

        private readonly HttpClient client;
        private List<Register> registers = new List<Register>();
        private List<Case> cases = new List<Case>();
        private List<Profile> profiles = new List<Profile>();

        public ESBApi(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("ESBApi");
        }

        public async Task<List<Case>> GetCases(string facilitycode, string doctorcode, string theatrecode, string fromdate, string todate)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("GetBookedCases?FacilityCode={0}&DoctorCode={1}&Theatrecode={2}&FromDate={3}&ToDate{4}", facilitycode, doctorcode, theatrecode, fromdate, todate));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsoncases = await response.Content.ReadAsAsync<string>();
                    cases = JsonConvert.DeserializeObject<List<Case>>(JsonConvert.DeserializeObject<JObject>(jsoncases).First.First.ToString());
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

        public async Task<List<Profile>> GetProfiles()
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
    }
}
