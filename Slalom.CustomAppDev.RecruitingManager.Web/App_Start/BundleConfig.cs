using System.Web;
using System.Web.Optimization;
using Slalom.CustomAppDev.RecruitingManager.Commons.DataHelpers;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;
using System.Collections.Generic;

namespace Slalom.CustomAppDev.RecruitingManager.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            competencyAreaSetup(bundles);
            jQuerySetup(bundles);
            shimsAndModernizationSetup(bundles);
            CSSSetup(bundles); 
            bootstrapSetup(bundles);
            jQueryStylesSetup(bundles);
        }

        private static void competencyAreaSetup(BundleCollection bundles)
        {
            List<string> scripts = new List<string>();

            CompetencyAreaHelper.GetAreas().ForEach(item => {
                switch(item)
                {
                    case CompetencyArea.ConsultingSkills :
                        scripts.Add("~/Scripts/CompetencyAreas/ConsultingSkillsController.js");
                        break;
                    case CompetencyArea.DotNet:
                        scripts.Add("~/Scripts/CompetencyAreas/DotNetController.js");
                        break;
                    case CompetencyArea.GeneralEngineering:
                        scripts.Add("~/Scripts/CompetencyAreas/GeneralEngineeringController.js");
                        break;
                    case CompetencyArea.JavaAndOpenSource:
                        scripts.Add("~/Scripts/CompetencyAreas/JavaAndOpenSourceController.js");
                        break;
                    case CompetencyArea.OtherPlatforms:
                        scripts.Add("~/Scripts/CompetencyAreas/OtherPlatformsController.js");
                        break;
                    case CompetencyArea.ProjectManagement:
                        scripts.Add("~/Scripts/CompetencyAreas/ProjectManagementController.js");
                        break;
                }
            });

            bundles.Add(new ScriptBundle("~/bundles/competencyareas").Include(scripts.ToArray()));
        }

        private static void jQuerySetup(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));
        }

        private static void CSSSetup(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

        }

        private static void shimsAndModernizationSetup(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
        }

        private static void bootstrapSetup(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrapResponsive").Include("~/Content/bootstrap-responsive.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
        }

        private static void jQueryStylesSetup(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}