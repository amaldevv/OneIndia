using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneIndiaInfo.DTO
{
    public class DistrictDTO
    {
        public int Id { get; set; }
        public int Timestamp { get; set; }
        public int St_Code { get; set; }
        public string State_Name { get; set; }
        public int Dt_Code { get; set; }
        public string District_Name { get; set; }
        public int Sdt_code { get; set; }
        public string Sub_District_Name { get; set; }
        public int Town_Code { get; set; }
        public string Area_Name { get; set; }

    }
}