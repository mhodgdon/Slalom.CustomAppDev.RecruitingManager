using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;

namespace Slalom.CustomAppDev.RecruitingManager.Web.ViewsHelpers
{
    public static class CardViewHelpers
    {
        public static string GetAngularController(CompetencyArea area)
        {
            switch (area)
            { 
                case CompetencyArea.ConsultingSkills:
                    return "ConsultingSkillsController";
                case CompetencyArea.DotNet :
                    return "DotNetController";
                case CompetencyArea.GeneralEngineering:
                    return "GeneralEngineeringController";
                case CompetencyArea.JavaAndOpenSource:
                    return "JavaAndOpenSourceController";
                case CompetencyArea.OtherPlatforms :
                    return "OtherPlatformsController";
                case CompetencyArea.ProjectManagement :
                    return "ProjectManagementController";
                default :
                    throw new ArgumentException("Unknwon Competency Area");
            }
        }
    }
}