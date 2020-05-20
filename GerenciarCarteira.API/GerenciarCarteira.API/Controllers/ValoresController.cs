using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCarteira.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValoresController : ControllerBase
    {
        // GET api/valores
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "valor1", "valor2" };
        }

        // GET api/valores/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "valor";
        }

        // POST api/valores
        [HttpPost]
        public void Post([FromBody] string valor)
        {
        }

        // PUT api/valores/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string valor)
        {
        }

        // DELETE api/valores/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
