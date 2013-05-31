using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.RecruitingHistory;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class RecruitingHistoryController : ApiController
    {
        /// <summary>
        /// Returns all of the Recruiting Historical events that have occured
        /// for an interview Candidate specified by the Id parameter
        /// </summary>
        public IEnumerable<RecruitingHistoryDomainObject> Get(int id)
        {
            return new List<RecruitingHistoryDomainObject>()
            {
                new RecruitingHistoryDomainObject() {},
                new RecruitingHistoryDomainObject() {},
                new RecruitingHistoryDomainObject() {}
            };
        }
    }
}
