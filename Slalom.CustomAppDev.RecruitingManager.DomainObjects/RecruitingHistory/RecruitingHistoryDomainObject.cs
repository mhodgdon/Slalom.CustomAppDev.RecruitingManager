using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate;

namespace Slalom.CustomAppDev.RecruitingManager.DomainObjects.RecruitingHistory
{
    public class RecruitingHistoryDomainObject
    {
        public int InterviewerId { get; set; }

        public int InterviewerDisplayName { get; set; }

        public DateTime InterviewDate { get; set; }

        public CandidateFeedbackDomainObject Results { get; set; }
    }
}
