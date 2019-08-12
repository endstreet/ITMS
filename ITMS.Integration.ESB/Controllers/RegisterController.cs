using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ITMS.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;

namespace ITMS.Integration.ESB.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ILogger<ComplexController> _logger;
        private readonly bool _usetestdata;
        private readonly ESBApi _api;
        public RegisterController(ILogger<ComplexController> logger, IConfiguration config, ESBApi api)
        {
            _logger = logger;
            _usetestdata = Boolean.Parse(config["ESBApi:UseTestdata"] ?? "false");
            _api = api;
        }

        [HttpGet("{facilitycode}/{fromdate}/{todate}")]
        public async Task<IEnumerable<Register>> GetRegisters(string facilitycode, string fromdate, string todate)
        {
            if (_usetestdata)
            {
                return JsonConvert.DeserializeObject<List<Register>>(JsonConvert.DeserializeObject<JObject>(TestData.complexes).First.First.ToString());
            }
            return await _api.GetTheatreRegister(facilitycode, fromdate,todate);
        }
    }
}