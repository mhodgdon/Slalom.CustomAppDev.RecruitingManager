using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Interviewer;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class InterviewerController : ApiController
    {
        /// <summary>
        /// Returns the details for an Interviwer
        /// </summary>
        public InterviewerDataContract Get(int id)
        {
            return new InterviewerDataContract() { Id = 2, Email = "user@slalom.com"};
        }   
    }
}
