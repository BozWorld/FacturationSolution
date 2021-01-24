using FacturationSolution.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturationSolution.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturesController : ControllerBase
    {

        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;
        public FacturesController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<FactureClient> Get()
        {
           return _data.Factures;
        }
        [HttpGet("{client}")]
        public ActionResult<FactureClient> Get(String client)
        {
            var facture = _data.Factures.Where(inv => inv.Client == client).FirstOrDefault();
            if(facture != null)
            {
                return facture;
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public ActionResult<FactureClient> Post([FromBody] FactureClient newFacture)
        {
            if (ModelState.IsValid)
            {
                _data.AddFacture(newFacture);
                return Created($"/Factures/{newFacture.Numero}", newFacture);
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }
    }
}



