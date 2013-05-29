using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class CompetencyController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException("This verb is not yet supported for this controller");
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException("This verb is not yet supported for this controller");
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            throw new NotImplementedException("This verb is not yet supported for this controller");
        }   
    }
}
