using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ITMS.Integration.ESB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        private readonly ILogger<CaseController> _logger;
        private readonly bool _usetestdata;
        private readonly ESBApi _api;
        public CaseController(ILogger<CaseController> logger,IConfiguration config,ESBApi api)
        {
            _logger = logger;
            _usetestdata = Boolean.Parse(config["ESBApi:UseTestdata"] ?? "false");
            _api = api;
        }

        [HttpGet("{facilitycode}/{doctorcode}/{theatrecode}/{fromdate}/{todate}")]
        //SectionCode = ThetreCode 
        public async Task<List<Case>> GetCases(string facilitycode, string doctorcode, string theatrecode, string fromdate, string todate)
        {
            if (_usetestdata)
            {
                return JsonConvert.DeserializeObject<List<Case>>(JsonConvert.DeserializeObject<JObject>(TestData.cases).First.First.ToString());
            }
            return await _api.GetCases(facilitycode, doctorcode, theatrecode, fromdate, todate);
        }
    }
}