﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class CompetencyAreaController : ApiController
    {
        /// <summary>
        /// Returns a list of all of the available Competency Areas
        /// </summary>
        /// <returns></returns>
        public List<CompetencyArea> Get()
        {
            return new List<CompetencyArea>()
            {
                CompetencyArea.ConsultingSkills,
                CompetencyArea.DotNet,
                CompetencyArea.GeneralEngineering,
                CompetencyArea.JavaAndOpenSource,
                CompetencyArea.OtherPlatforms,
                CompetencyArea.ProjectManagement
            };
        }
    }
}
