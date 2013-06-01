using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public interface IInterviewerDataRepository
    {
        DomainObjects.Interviewer.InterviewerDataContract Retrieve(int id);
    }
}
