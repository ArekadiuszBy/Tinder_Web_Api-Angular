using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Tinder1.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
            [HttpGet]
            public ActionResult<IEnumerable<string>> Get(){
                return new string[] {"value1", "value2"};
            }

            [HttpGet("{id}")]
            public ActionResult<string> Get(int id)
            {
                return "Value";
            }

            [HttpPost]
            public void Post([FromBody] string value){

            }

            [HttpPut("{id}")]
            public void put(int id){
                
            } 

            [HttpDelete("{id}")]
            public void delete(int id){

            }
    }
}
