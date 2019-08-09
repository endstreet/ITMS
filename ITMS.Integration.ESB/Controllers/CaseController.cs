using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ITMS.Integration.ESB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        private readonly ILogger<ESBController> _logger;
        public CaseController(ILogger<ESBController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{hospitalcode}/{sectioncode}")]
        //SectionCode = ThetreCode 
        public IEnumerable<Case> GetCases(string HospitalCode, string SectionCode)
        {
            return new List<Case>();
        }
    }
}