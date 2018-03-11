using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exoft.NetCore.Learn.WebAPI.Controllers.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET api/test/request-headers
        [HttpGet("request-headers")]
        public string Get()
        {
            string data = "";
            foreach (var o in Request.Headers)
            {
                string val = "";
                foreach (string s in o.Value)
                {
                    val += s + ";";
                }
                data += o.Key + " : " + val + Environment.NewLine;
            }
            return data;
        }

        // GET api/test/200
        [HttpGet("200")]
        public void Get204()
        {
            // this method returns nothing but StatusCode 200
        }
    }
}
