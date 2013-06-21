using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate;

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
            using (RecruitingManager.Data.RecruitingManagerEntities entities = new Data.RecruitingManagerEntities())
            {
                return entities.Candidates
                    .Where(candidate => candidate.Id == id)
                    .Select(candidate =>
                    new CandidateDomainObject()
                    {
                        EmailAddress = candidate.EmailAddress,
                        FirstName = candidate.FirstName,
                        HireCandidate = candidate.HireCandidate,
                        Id = candidate.Id,
                        InterviewComplete = candidate.InterviewComplete,
                        LastName = candidate.LastName,
                        ResumeAddress = new Uri(candidate.ResumeAddress)
                    }
                ).FirstOrDefault();
            }
            
        }

        public void CreateCandidate(DomainObjects.Candidate.CandidateDomainObject candidate)
        {
            throw new NotImplementedException();
        }
    }
}
