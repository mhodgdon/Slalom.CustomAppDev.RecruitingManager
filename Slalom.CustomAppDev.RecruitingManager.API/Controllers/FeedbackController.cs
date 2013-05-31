using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class FeedbackController : ApiController
    {
        /// <summary>
        /// Returns all of the Recruiting Historical events that have occured
        /// for an interview Candidate specified by the Id parameter
        /// </summary>
        public IEnumerable<CandidateFeedbackDomainObject> Get(int id)
        {
            return new List<CandidateFeedbackDomainObject>()
            {
                new CandidateFeedbackDomainObject() {},
                new CandidateFeedbackDomainObject() {},
                new CandidateFeedbackDomainObject() {}
            };
        }

        /// <summary>
        /// Allows Interviewers to provide Feedback for Candidates
        /// </summary>
        public void Put([FromBody]CandidateDomainObject candidate)
        {

        }
    }
}
