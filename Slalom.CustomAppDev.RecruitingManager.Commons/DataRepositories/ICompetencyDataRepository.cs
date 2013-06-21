using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public interface ICompetencyDataRepository
    {
        List<CompetencyDomainObject> RetrieveCompetencyList(DomainObjects.Competency.CompetencyArea area);

        List<CompetencyDomainObject> RetrieveCompetency(int id);
    }
}
