﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public CaseController(ILogger<CaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{hospitalcode}/{sectioncode}")]
        //SectionCode = ThetreCode 
        public IEnumerable<Case> GetCases(string HospitalCode, string SectionCode)
        {
            //todo: get the data from ESB and replace TestData.registers
            return JsonConvert.DeserializeObject<List<Case>>(JsonConvert.DeserializeObject<JObject>(TestData.cases).First.First.ToString());
        }
    }
}