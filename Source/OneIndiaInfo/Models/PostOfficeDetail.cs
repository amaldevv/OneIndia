using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneIndiaInfo.Models
{
    public class PostOfficeDetail
    {
        public int Id { get; set; }
        public string OfficeName { get; set; }
        public int Pincode { get; set; }
        public string OfficeType { get; set; }
        public string DeliveryStatus { get; set; }
        public string RegionName { get; set; }
        public string CircleName { get; set; }
        public string Taluk { get; set; }
        public string DistrictName { get; set; }
        public string StateName { get; set; }
        public int Timestamp { get; set; }
    }
}