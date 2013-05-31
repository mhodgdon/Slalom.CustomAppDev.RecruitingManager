using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Common;

namespace Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency
{
    public class CompetencyDomainObject
    {
        public int Id { get; set; }

        public CompetencyArea Area { get; set; }

        public string ReviewCategory { get; set; }

        public string CompetencyDescription { get; set; }

        public ExperienceLevel Level { get; set; }

        public string Notes { get; set; }

        public string AppendToNotes { get; set; }

        public bool AnInterviewerProvidedFeedback { get; set; }
    }
}
