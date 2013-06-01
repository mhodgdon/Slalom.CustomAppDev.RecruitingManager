using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public class CandidateDataRepository : ICandidateDataRepository
    {
        public IEnumerable<DomainObjects.Candidate.CandidateDomainObject> RetrieveAllCandidates()
        {
            throw new NotImplementedException();
        }

        public DomainObjects.Candidate.CandidateDomainObject RetrieveCandidate(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateCandidate(DomainObjects.Candidate.CandidateDomainObject candidate)
        {
            throw new NotImplementedException();
        }
    }
}
