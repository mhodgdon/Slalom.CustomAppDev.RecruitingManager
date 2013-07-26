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
    public class CompetencyFeedbackDataRepository : ICompetencyFeedbackDataRepository
    {
        public List<CompetencyFeedbackDomainObject> RetrieveCompetencyFeedbackList(int candidateId)
        {
            using (RecruitingManagerEntities entities = new Data.RecruitingManagerEntities())
            {
                return entities.CompetencyFeedbacks
                    .Where(competencyFeedback => competencyFeedback.CandidateId == candidateId)
                    .Select(competencyFeedback => new CompetencyFeedbackDomainObject()
                    {
                        CandidateId = competencyFeedback.CandidateId,
                        CompetencyId = competencyFeedback.CompetencyId,
                        ExperienceLevel = (ExperienceLevel)competencyFeedback.CompetencyLevel.Value,
                        Id = competencyFeedback.Id,
                        InterviewerId = competencyFeedback.InterviewerId.Value,
                        Note = competencyFeedback.Note
                    }).ToList();
                        
            }
        }


        public void CreateCompetency(CompetencyFeedbackDomainObject createCompetencyFeedback)
        {
            using (RecruitingManagerEntities entities = new Data.RecruitingManagerEntities())
            {
                entities.CompetencyFeedbacks.AddObject(new CompetencyFeedback()
                {
                    CandidateId = createCompetencyFeedback.CandidateId,
                    CompetencyId = createCompetencyFeedback.CompetencyId,
                    InterviewerId = createCompetencyFeedback.InterviewerId,
                    Note = createCompetencyFeedback.Note,
                    CompetencyLevel = (int)createCompetencyFeedback.ExperienceLevel
                    
                });

                entities.SaveChanges();
            }
        }
    }
}
