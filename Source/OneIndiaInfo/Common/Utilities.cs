using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace OneIndiaInfo.Common
{
    public static class Utilities
    {
        public static string ApiKey { get { return GetConfigValue("OpenDataGovAPIKey"); } }
        public static string OpenDataDistrictUrl { get { return GetConfigValue("DistrictURl"); } }
        public static string OpenDataPincodeUrl { get { return GetConfigValue("PincodeURL"); } }
        public static string RootPhysicalPath
        {
            get
            {
                var virPath = HttpRuntime.AppDomainAppVirtualPath;
                return System.Web.Hosting.HostingEnvironment.MapPath(virPath);
            }
        }


        public static string GetConfigValue(string Key)
        {
            if (String.IsNullOrWhiteSpace(Key))
                return "";
            return WebConfigurationManager.AppSettings[Key];


        }
    }
}