using OneIndiaInfo.Common;
using OneIndiaInfo.Interfaces.APIClient;
using OneIndiaInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneIndiaInfo.APIClient
{
    public class OpenDataDistrictClient : APIWrapperBase, IOpenDataDistrictClient
    {
         public OpenDataDistrictClient() : base(Utilities.OpenDataDistrictUrl) { }

         public OpenDataDistrictClient(String APIUrl)
             : base(APIUrl)
        {
            
        }

        public List<District> GetDistricts(string StateCode)
        {
            var items = ExecuteAndReturnListFromFile<District>( Utilities.RootPhysicalPath  + @"/App_Data/districts.json");
            var retItems = String.IsNullOrWhiteSpace(StateCode)?items:items.Where(x=>x.StateName.Equals(StateCode)).ToList();
            return retItems;
        }
    }
}