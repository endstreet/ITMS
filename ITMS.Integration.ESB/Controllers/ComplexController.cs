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
    public class ComplexController : ControllerBase
    {

        private readonly ILogger<ComplexController> _logger;
        private readonly bool _usetestdata;
        private readonly ESBApi _api;
        public ComplexController(ILogger<ComplexController> logger, IConfiguration config, ESBApi api)
        {
            _logger = logger;
            _usetestdata = Boolean.Parse(config["ESBApi:UseTestdata"] ?? "false");
            _api = api;
        }

        [HttpGet("{facilitycode}")]
        public async Task<IEnumerable<Complex>> GetComplexes(string facilitycode)
        {
            if (_usetestdata)
            {
                return JsonConvert.DeserializeObject<List<Complex>>(JsonConvert.DeserializeObject<JObject>(TestData.complexes).First.First.ToString());
            }
            return await _api.GetComplex(facilitycode);
        }
    }
}