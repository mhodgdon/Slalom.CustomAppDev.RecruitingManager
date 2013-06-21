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
    public class CandidateController : ApiController
    {
        #region Fields

        ICandidateDataRepository candidateRepository;
        ICompetencyDataRepository competencyRepository;

        #endregion

        #region Ctors

        public CandidateController() 
        {
            candidateRepository = new CandidateDataRepository();
            competencyRepository = new CompetencyDataRepository();
        }

        public CandidateController(ICandidateDataRepository candidateRepository, ICompetencyDataRepository competencyRepository)
        {
            this.candidateRepository = candidateRepository;
            this.competencyRepository = competencyRepository;
        }

        #endregion

        #region Api Methods

        /// <summary>
        /// Returns a 'light' version of each User.  This call will return
        /// all users in the system (Completed and Not Completed).
        /// </summary>
        public IEnumerable<CandidateDomainObject> Get()
        {
            return candidateRepository.RetrieveAllCandidates();
        }
        
        /// <summary>
        /// Returns a single user, filtered by the specified Id.
        /// The object will return all of the information on record for the user
        /// </summary>
        public CandidateDomainObject Get(int id)
        {
            return null;
            
            CandidateDomainObject candidate = candidateRepository.RetrieveCandidate(id);

            candidate.CompetencyFeedback = competencyRepository.RetrieveCompetency(id);

            return candidateRepository.RetrieveCandidate(id);
        }

        /// <summary>
        /// Adds a new Candidate into the system, and preps for the sytem
        /// </summary>
        public void Put([FromBody]CandidateDomainObject candidate)
        {
            candidateRepository.CreateCandidate(candidate);
        }

        #endregion
    }
}
