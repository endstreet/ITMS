using System;
using System.Collections.Generic;
using System.Text;

namespace ITMS.Models
{
    public  class Theatre
    {
        public string HospitalLocation { get; set; }
        public string ActiveFlag { get; set; }
        public string SectionCode { get; set; }
        public string SectionName { get; set; }
        public string CostCentrum { get; set; }
        public int ActivityCentre { get; set; }
        public string BarcodeBilling { get; set; }
        //ComplexCode (Code)   
        public string TheatreComplex { get; set; }
    }
}
