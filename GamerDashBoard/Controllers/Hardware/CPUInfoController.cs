﻿using RainbowDashBoard.Models;
using RainbowDashBoard.Models.Hardware.CPU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RainbowDashBoard.Controllers.Hardware
{
    public class CPUInfoController : ApiController
    {
        private ISystemInfoService service;

        public CPUInfoController(ISystemInfoService service)
        {
            this.service = service;
        }

        // GET: api/HardwareInfo
        public CPUInfo Get()
        {
            return service.getCPUInfo();
        }
    }
}
