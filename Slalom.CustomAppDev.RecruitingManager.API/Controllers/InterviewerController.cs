using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Interviewer;
using Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class InterviewerController : ApiController
    {
        #region Fields

        IInterviewerDataRepository interviewerRepository;

        #endregion

        #region Ctors

        public InterviewerController() 
        {
            interviewerRepository = new InterviewerDataRepository();
        }

        public InterviewerController(IInterviewerDataRepository InterviewerRepository)
        {
            this.interviewerRepository = InterviewerRepository;
        }

        #endregion

        #region Api Methods

        /// <summary>
        /// Returns the details for an Interviwer
        /// </summary>
        public InterviewerDataContract Get(int id)
        {
            return interviewerRepository.Retrieve(id);
        }

        #endregion

    }
}
