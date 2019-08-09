﻿using System;
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
    public class ProfileController : ControllerBase
    {
        private readonly ILogger<ESBController> _logger;
        public ProfileController(ILogger<ESBController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Profile> GetDoctorProfiles()
        {
            return new List<Profile>();
        }
    }
}