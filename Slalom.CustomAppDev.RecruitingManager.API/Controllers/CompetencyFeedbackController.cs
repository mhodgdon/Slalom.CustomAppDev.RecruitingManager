using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;
using Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class CompetencyFeedbackController : ApiController
    {
        #region Fields

        ICompetencyFeedbackDataRepository competencyFeedbackRepository;

        #endregion

        #region Ctors

        public CompetencyFeedbackController() 
        {
            competencyFeedbackRepository = new CompetencyFeedbackDataRepository();
        }

        public CompetencyFeedbackController(ICompetencyFeedbackDataRepository competencyRepository)
        {
            this.competencyFeedbackRepository = competencyRepository;
        }

        #endregion

        #region Api Methods

        /// <summary>
        /// Returns all of the Competencies with the data on filed
        /// for a candidate specified by the Id
        /// Optionally you can filter by 'Area'
        /// </summary>
        public IEnumerable<CompetencyFeedbackDomainObject> Get(int filter)
        {
            int candidateId = filter;

            return competencyFeedbackRepository.RetrieveCompetencyFeedbackList(candidateId);
        }

        /// <summary>
        /// Records Feedback for a Candidate provided by an 
        /// Interviwer specified by the Id parameter
        /// </summary>
        public void Post([FromBody]CompetencyFeedbackDomainObject createCompetencyFeedback)
        {
            competencyFeedbackRepository.CreateCompetency(createCompetencyFeedback);
        }

        #endregion
    }
}
