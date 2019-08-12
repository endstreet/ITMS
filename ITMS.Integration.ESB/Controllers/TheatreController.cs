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
    public class TheatreController : ControllerBase
    {

        private readonly ILogger<ComplexController> _logger;
        private readonly bool _usetestdata;
        private readonly ESBApi _api;
        public TheatreController(ILogger<ComplexController> logger, IConfiguration config, ESBApi api)
        {
            _logger = logger;
            _usetestdata = Boolean.Parse(config["ESBApi:UseTestdata"] ?? "false");
            _api = api;
        }

        [HttpGet("{facilitycode}/{complex}")]
        public async Task<IEnumerable<Theatre>> GetRegisters(string facilitycode, string complex)
        {
            if (_usetestdata)
            {
                return JsonConvert.DeserializeObject<List<Theatre>>(JsonConvert.DeserializeObject<JObject>(TestData.theatres).First.First.ToString());
            }
            return await _api.GetTheatres(facilitycode, complex);
        }
    }
}