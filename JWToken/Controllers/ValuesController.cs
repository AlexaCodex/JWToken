using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWToken.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace JWToken.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public ValuesController(AuthenticationSite authenticationSite, IOptions<AuthenticationSite> options)
        {

        }

        [Authorize]
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [Route("example")]
        [HttpGet]
        public string Get(string token)
        {
            TokenHelper tokenHelper = new TokenHelper();
            tokenHelper.ValidateToken(token);
            
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
