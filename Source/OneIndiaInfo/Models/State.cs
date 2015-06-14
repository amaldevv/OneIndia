using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneIndiaInfo.Models
{
    public class State
    {
        public int State_Id { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
    }
}