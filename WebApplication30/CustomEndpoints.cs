using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication30
{
    public class CustomEndpoints : ControllerBase
    {
        [HttpGet]
        public Task<string> HiAsync()
        {
            return Task.FromResult("Hi!");
        }
    }
}
