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

        public IEnumerable<Register> Registers { get; private set; }

        public ESBService(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("ESB");
        }

        public async Task<List<Register>> GetRegisters(string hospital)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,String.Format("api/register/{0}",hospital));
            var response = await client.SendAsync(request);
            List<Register> registers = new List<Register>();

            if (response.IsSuccessStatusCode)
            {
                registers = await response.Content.ReadAsAsync<List<Register>>();
            }
            //else
            //{
            //    GetPullRequestsError = true;
            //    PullRequests = Array.Empty<GitHubPullRequest>();
            //}
            return registers;
          
        }

        public async Task<List<Register>> GetCases(string hospital,string section)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, String.Format("api/case/{0}/{1}", hospital, section));
            var response = await client.SendAsync(request);
            List<Register> registers = new List<Register>();

            if (response.IsSuccessStatusCode)
            {
                registers = await response.Content.ReadAsAsync<List<Register>>();
            }
            //else
            //{
            //    GetPullRequestsError = true;
            //    PullRequests = Array.Empty<GitHubPullRequest>();
            //}
            return registers;

        }
    }
}
