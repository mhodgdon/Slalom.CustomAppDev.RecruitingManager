using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate
{
    public class CandidateDomainObject
    {
        public int Id { get; set; }

        public Nullable<bool> InterviewComplete { get; set; }

        public Nullable<bool> HireCandidate { get; set; }
    }
}
