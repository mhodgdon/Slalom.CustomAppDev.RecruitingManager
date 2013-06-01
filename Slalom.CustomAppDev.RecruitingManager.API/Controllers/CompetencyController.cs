using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;
using Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class CompetencyController : ApiController
    {
        #region Fields

        ICompetencyDataRepository competencyRepository;

        #endregion

        #region Ctors

        public CompetencyController() 
        {
            competencyRepository = new CompetencyDataRepository();
        }

        public CompetencyController(ICompetencyDataRepository competencyRepository)
        {
            this.competencyRepository = competencyRepository;
        }

        #endregion

        #region Api Methods

        /// <summary>
        /// Returns all of the Competencies with the data on filed
        /// for a candidate specified by the Id
        /// Optionally you can filter by 'Area'
        /// </summary>
        public IEnumerable<CompetencyDomainObject> Get(int id, int filter)
        {
            CompetencyArea area = (CompetencyArea)filter;

            competencyRepository.RetrieveCompetency(id, area);

            var competencyDOquery = new List<CompetencyDomainObject>()
            {
                new CompetencyDomainObject() { Id = id},
                new CompetencyDomainObject() {}
            }.AsQueryable();

            if (area == CompetencyArea.UnSelected)
            {
                return competencyDOquery.ToList();
            }

            return competencyDOquery.Select(item => item).Where(item => item.Area == area);
        }

        /// <summary>
        /// Records Feedback for a Candidate provided by an 
        /// Interviwer specified by the Id parameter
        /// </summary>
        public void Post([FromBody]CompetencyDomainObject UpdateCompetency, int id)
        {
            competencyRepository.UpdateCompetency(id, UpdateCompetency);
        }

        #endregion
    }
}
