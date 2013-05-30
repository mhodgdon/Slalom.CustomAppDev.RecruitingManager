using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class CompetencyController : ApiController
    {

        [HttpGet, ActionName("Action")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet, ActionName("Action")]
        public string Get(int identifier)
        {
            return "value";
        }

        [HttpGet, ActionName("GetByCategory")]
        public string Get(string identifier)
        {
            return "value";
        }

        [HttpPost, ActionName("Action")]
        public void Post([FromBody]string value)
        {
            return; //noop
        }

        [HttpPut, ActionName("Action")]
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException("This verb is not yet supported for this controller");
        }

        [HttpDelete, ActionName("Action")]
        public void Delete(int id)
        {
            throw new NotImplementedException("This verb is not yet supported for this controller");
        }   
    }
}
