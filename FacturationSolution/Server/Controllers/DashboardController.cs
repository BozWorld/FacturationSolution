using FacturationSolution.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationSolution.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly ILogger<DashboardController> _logger;
        private readonly IBusinessData _data;
        public DashboardController(ILogger<DashboardController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }
        [HttpGet]
        public String Get()
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            JsonWriter jw = new JsonTextWriter(sw);
            jw.Formatting = Formatting.Indented;
            jw.WriteStartObject();
            jw.WritePropertyName("CADu");
            jw.WriteValue(_data.CAdu);
            jw.WritePropertyName("CAreel");
            jw.WriteValue(_data.CAsupposé);
            jw.WriteEnd();
            return sb.ToString();
        }
    }
}
