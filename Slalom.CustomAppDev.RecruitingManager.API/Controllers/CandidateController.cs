using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class CandidateController : ApiController
    {
        /// <summary>
        /// Returns a 'light' version of each User.  This call will return
        /// all users in the system (Completed and Not Completed).
        /// </summary>
        public IEnumerable<CandidateDomainObject> Get()
        {
            return new List<CandidateDomainObject>()
            {
                new CandidateDomainObject() {},
                new CandidateDomainObject() {},
                new CandidateDomainObject() {}
            };
        }
        
        /// <summary>
        /// Returns a single user, filtered by the specified Id.
        /// The object will return all of the information on record for the user
        /// </summary>
        public CandidateDomainObject Get(int id)
        {
            return new CandidateDomainObject() { Id = id};
        }

        /// <summary>
        /// Adds a new Candidate into the system, and preps for the sytem
        /// </summary>
        public void Put([FromBody]CandidateDomainObject candidate)
        {
            
        }

    }
}
