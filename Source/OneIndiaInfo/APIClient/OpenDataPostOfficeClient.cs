using OneIndiaInfo.Common;
using OneIndiaInfo.Interfaces.APIClient;
using OneIndiaInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneIndiaInfo.APIClient
{
    public class OpenDataPostOfficeClient : APIWrapperBase, IOpenDataPostOfficeClient
    {
         public OpenDataPostOfficeClient() : base(Utilities.OpenDataPincodeUrl) { }

         public OpenDataPostOfficeClient(String APIUrl)
             : base(APIUrl)
        {
            
        }

        public List<PostOfficeLookup> GetPostOffices(string DistrictName)
        {

            return ExecuteAndReturnList<PostOfficeLookup>("&api-key=" + Utilities.ApiKey +  "&sort[officename]=asc&filters[districtname]=" + DistrictName  + "&fields=id,officename");
        }

        public PostOfficeDetail GetPostOfficeDetail(int Id)
        {
            return Execute<PostOfficeDetail>("&api-key=" + Utilities.ApiKey + "&filters[id]=" + Id.ToString() );
        }
        
        public PostOfficeDetail GetPostOfficeDetilByPincode(string Pincode)
        {
            return Execute<PostOfficeDetail>("&api-key=" + Utilities.ApiKey + "&filters[Pincode]=" + Pincode);
        }
    }
}