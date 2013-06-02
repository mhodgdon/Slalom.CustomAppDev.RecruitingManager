using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataHelpers
{
    public static class CompetencyAreaHelper
    {
        public static List<CompetencyArea> GetAreas()
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
