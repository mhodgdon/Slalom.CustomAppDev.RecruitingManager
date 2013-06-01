using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public class FeedbackDataRepository : IFeedbackDataRepository
    {
        public IEnumerable<DomainObjects.Candidate.CandidateFeedbackDomainObject> RetrieveFeedback(int id)
        {
            throw new NotImplementedException();
        }

        public void AddFeedback(DomainObjects.Candidate.CandidateDomainObject candidate)
        {
            throw new NotImplementedException();
        }
    }
}
