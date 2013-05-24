using System.Web;
using System.Web.Mvc;

namespace Slalom.CustomAppDev.RecruitingManager.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}