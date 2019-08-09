using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ITMS.Models;
using Newtonsoft.Json;

namespace ITMS.Integration.ESB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ESBController : ControllerBase
    {
        private readonly ILogger<ESBController> _logger;

        public ESBController(ILogger<ESBController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetStatus()
        {
            //todo: query esb status and send error or:
            return "Happy API running here..";
        }
        [HttpGet("{hospitalcode}")]
        public IEnumerable<Complex> GetComplexes(string HospitalCode)
        {
            return new List<Complex>();
        }

        //[HttpGet]
        //public IEnumerable<Theatre> GetComplexTheatres(string HospitalCode)
        //{
        //    return new List<Theatre>();
        //}

        //[HttpGet]
        //public IEnumerable<Slate> GetDoctorSlates(string HospitalCode)
        //{
        //    return new List<Slate>();
        //}


    }
}
