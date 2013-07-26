using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Common;

namespace Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency
{
    public class CompetencyFeedbackDomainObject
    {
        public int Id { get; set; }

        public int CandidateId { get; set; }

        public int InterviewerId { get; set; }

        public int CompetencyId { get; set; }

        public ExperienceLevel ExperienceLevel { get; set; }

        public string Note { get; set; }
    }
}
