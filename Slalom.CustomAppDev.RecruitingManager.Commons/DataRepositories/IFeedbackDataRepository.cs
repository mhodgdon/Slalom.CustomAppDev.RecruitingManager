using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public interface IFeedbackDataRepository
    {
        IEnumerable<DomainObjects.Candidate.CandidateFeedbackDomainObject> RetrieveFeedback(int id);

        void AddFeedback(DomainObjects.Candidate.CandidateDomainObject candidate);
    }
}
