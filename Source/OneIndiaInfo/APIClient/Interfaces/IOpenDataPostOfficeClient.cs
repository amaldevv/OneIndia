
using OneIndiaInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneIndiaInfo.Interfaces.APIClient
{
    public interface IOpenDataPostOfficeClient
    {
        List<PostOfficeLookup> GetPostOffices(string DistrictName);
       PostOfficeDetail GetPostOfficeDetail(int Id);

       PostOfficeDetail GetPostOfficeDetilByPincode(string Pincode);
    }
}
