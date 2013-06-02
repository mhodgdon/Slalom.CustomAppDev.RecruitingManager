using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;

namespace Slalom.CustomAppDev.RecruitingManager.Web.Models
{
    public class HomeModel
    {
        public List<CompetencyArea> CompetencyAreas { get; set; }
    }
}