using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;
using Slalom.CustomAppDev.RecruitingManager.Commons.DataHelpers;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class CompetencyAreaController : ApiController
    {

        #region Api Methods

        /// <summary>
        /// Returns a list of all of the available Competency Areas
        /// </summary>
        /// <returns></returns>
        public List<CompetencyArea> Get()
        {
            return CompetencyAreaHelper.GetAreas();
        } 
        
        #endregion

    }
}
