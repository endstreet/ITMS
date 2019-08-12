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

        public ESBApi(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("ESBApi");
        }

        public async Task<IEnumerable<Case>> GetCases(string facilitycode, string doctorcode, string theatrecode, string fromdate, string todate)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("GetBookedCases?FacilityCode={0}&DoctorCode={1}&Theatrecode={2}&FromDate={3}&ToDate{4}", facilitycode, doctorcode, theatrecode, fromdate, todate));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonresult = await response.Content.ReadAsAsync<string>();
                    return JsonConvert.DeserializeObject<List<Case>>(JsonConvert.DeserializeObject<JObject>(jsonresult).First.First.ToString());
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<IEnumerable<Complex>> GetComplex(string facilitycode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("GetComplex?FacilityCode={0}", facilitycode));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonresult = await response.Content.ReadAsAsync<string>();
                    return JsonConvert.DeserializeObject<List<Complex>>(JsonConvert.DeserializeObject<JObject>(jsonresult).First.First.ToString());
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<IEnumerable<Theatre>> GetTheatres(string facilitycode,string complex)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("GetComplexTheatres?FacilityCode={0}&Complex={1}", facilitycode, complex));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonresult = await response.Content.ReadAsAsync<string>();
                    return JsonConvert.DeserializeObject<List<Theatre>>(JsonConvert.DeserializeObject<JObject>(jsonresult).First.First.ToString());
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<IEnumerable<Profile>> GetProfiles(string facilitycode, string doctorcode)
        {
             var request = new HttpRequestMessage(HttpMethod.Get, String.Format("GetDoctorProfiles?FacilityCode={0}&DoctorCode={1}", facilitycode, doctorcode));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonresult = await response.Content.ReadAsAsync<string>();
                    return JsonConvert.DeserializeObject<List<Profile>>(JsonConvert.DeserializeObject<JObject>(jsonresult).First.First.ToString());
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<IEnumerable<Slate>> GetDoctorSlate(string facilitycode, string doctorcode,string theatrecode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("GetDoctorProfiles?FacilityCode={0}&DoctorCode={1}&TheatreCode={2}", facilitycode, doctorcode,theatrecode));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonresult = await response.Content.ReadAsAsync<string>();
                    return JsonConvert.DeserializeObject<List<Slate>>(JsonConvert.DeserializeObject<JObject>(jsonresult).First.First.ToString());
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<IEnumerable<Register>> GetTheatreRegister(string facilitycode, string fromdate, string todate)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("GetDoctorProfiles?FacilityCode={0}&FromDate={1}&ToDate={2}", facilitycode, fromdate, todate));
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonresult = await response.Content.ReadAsAsync<string>();
                    return JsonConvert.DeserializeObject<List<Register>>(JsonConvert.DeserializeObject<JObject>(jsonresult).First.First.ToString());
                }
                else
                {
                    return null;
                }
            }
        }


    }
}
