using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public interface ICompetencyFeedbackDataRepository
    {
        List<CompetencyFeedbackDomainObject> RetrieveCompetencyFeedbackList(int candidateId);

        void CreateCompetency(CompetencyFeedbackDomainObject createCompetencyFeedback);
    }
}
