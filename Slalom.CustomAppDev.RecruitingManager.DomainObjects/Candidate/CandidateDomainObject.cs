using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate
{
    public class CandidateDomainObject
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public Uri ResumeAddress { get; set; }

        public string DisplayName
        {
            get { return string.Format("{0} {1}", FirstName, LastName);  }
        }

        public List<Competency.CompetencyDomainObject> CompetencyFeedback
        {
            get;
            set;
        }

        public Nullable<bool> InterviewComplete { get; set; }

        public Nullable<bool> HireCandidate { get; set; }
    }
}
