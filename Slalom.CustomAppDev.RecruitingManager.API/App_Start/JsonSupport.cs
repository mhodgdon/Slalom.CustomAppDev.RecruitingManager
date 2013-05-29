using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http.Formatting;

namespace Slalom.CustomAppDev.RecruitingManager.API
{
    public static class JsonSupport
    {
        public static void SetupJsonSupport()
        {
            // Instructs Web API not to return XML formatted objects, just JSON
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
    

            // Web API uses json.net by default.  You can configure it further 
            // using HttpConfiguration object
            // i.e. jsonformatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            JsonMediaTypeFormatter jsonformatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            jsonformatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        }
    }
}