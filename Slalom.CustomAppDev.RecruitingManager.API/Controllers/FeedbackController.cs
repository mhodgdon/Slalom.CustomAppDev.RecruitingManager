using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate;
using Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class FeedbackController : ApiController
    {
        #region Fields

        IFeedbackDataRepository feedbackRepository;

        #endregion

        #region Ctors

        public FeedbackController() 
        {
            feedbackRepository = new FeedbackDataRepository();
        }

        public FeedbackController(IFeedbackDataRepository feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }

        #endregion

        #region Api Methods

        /// <summary>
        /// Returns all of the Recruiting Historical events that have occured
        /// for an interview Candidate specified by the Id parameter
        /// </summary>
        public IEnumerable<CandidateFeedbackDomainObject> Get(int id)
        {
            return feedbackRepository.RetrieveFeedback(id);
        }

        /// <summary>
        /// Allows Interviewers to provide Feedback for Candidates
        /// </summary>
        public void Put([FromBody]CandidateDomainObject candidate)
        {
            feedbackRepository.AddFeedback(candidate);
        }

        #endregion

    }
}
