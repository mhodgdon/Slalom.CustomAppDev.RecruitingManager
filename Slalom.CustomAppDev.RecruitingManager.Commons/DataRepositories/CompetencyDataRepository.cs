using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;
using Slalom.CustomAppDev.RecruitingManager.Data;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Common;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public class CompetencyDataRepository : ICompetencyDataRepository
    {
        public List<CompetencyDomainObject> RetrieveCompetencyList(DomainObjects.Competency.CompetencyArea area)
        {
            switch (area)
            { 
                case CompetencyArea.JavaAndOpenSource :

                    return new List<CompetencyDomainObject>()
                    {
                        new CompetencyDomainObject()
                        {
                            Id = 1,
                            Area = area,
                            CompetencyDescription = "Inheritance, Interfaces, Exception handling, Futures",
                            ReviewCategory = "Java"
                        }
                    };
            }


            // Will hook this up to the database later ...

            using (RecruitingManager.Data.RecruitingManagerEntities entities = new Data.RecruitingManagerEntities())
            {
                return entities.Competencies
                    .Where(competency => competency.CompetencyArea == (int)area)
                     .Select(competency => new CompetencyDomainObject()
                     {
                         ReviewCategory = competency.ReviewCategory,
                         Area = (CompetencyArea)competency.CompetencyArea,
                         CompetencyDescription = competency.CompetencyDescription,
                         Id = competency.Id
                     }).ToList();
            }
        }

        public List<CompetencyDomainObject> RetrieveCompetency(int id)
        {
            using (RecruitingManagerEntities entities = new Data.RecruitingManagerEntities())
            {
                return entities.Competencies
                    .Where(competency => competency.Id == id)
                    .Select(competency => new CompetencyDomainObject()
                    {
                        ReviewCategory = competency.ReviewCategory,
                        Area = (CompetencyArea)competency.CompetencyArea,
                        CompetencyDescription = competency.CompetencyDescription,
                        Id = competency.Id
                    }).ToList();
                        
            }
        }
    }
}
