
using OneIndiaInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneIndiaInfo.Interfaces.APIClient
{
    public interface IOpenDataDistrictClient
    {
        List<District> GetDistricts(string StateId);
    }
}
