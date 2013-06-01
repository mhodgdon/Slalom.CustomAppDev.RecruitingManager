using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.RecruitingHistory;
using Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class RecruitingHistoryController : ApiController
    {
         #region Fields

        IRecruitingHistoryDataRepository recruitingHistoryRepository;

        #endregion

        #region Ctors

        public RecruitingHistoryController() 
        {
            recruitingHistoryRepository = new RecruitingHistoryDataRepository();
        }

        public RecruitingHistoryController(IRecruitingHistoryDataRepository RecruitingHistoryRepository)
        {
            this.recruitingHistoryRepository = RecruitingHistoryRepository;
        }

        #endregion

        #region Api Methods

        /// <summary>
        /// Returns all of the Recruiting Historical events that have occured
        /// for an interview Candidate specified by the Id parameter
        /// </summary>
        public IEnumerable<RecruitingHistoryDomainObject> Get(int id)
        {
            return recruitingHistoryRepository.Retrieve(id);
        }

        #endregion

    }
}
