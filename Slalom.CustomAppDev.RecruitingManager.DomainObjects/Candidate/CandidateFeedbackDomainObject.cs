using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Common;

namespace Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate
{
    public class CandidateFeedbackDomainObject
    {
        public CompetencyArea Specialization { get; set; }

        public ConsultingRole SuggestedConsultingRole { get; set; }

        public ExperienceLevel SuggestedExperienceLevel { get; set; }

        public bool Hire { get; set; }
    }
}
