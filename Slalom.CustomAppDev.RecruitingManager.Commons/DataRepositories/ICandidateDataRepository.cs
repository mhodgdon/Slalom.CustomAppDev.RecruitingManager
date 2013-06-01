using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public interface ICandidateDataRepository
    {
        IEnumerable<CandidateDomainObject> RetrieveAllCandidates();

        CandidateDomainObject RetrieveCandidate(int id);

        void CreateCandidate(CandidateDomainObject candidate);
    }
}
