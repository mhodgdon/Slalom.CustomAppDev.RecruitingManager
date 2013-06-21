using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slalom.CustomAppDev.RecruitingManager.DomainObjects.Interviewer
{
    public class InterviewerDataContract
    {
        public int Id { get; set; }
    
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
