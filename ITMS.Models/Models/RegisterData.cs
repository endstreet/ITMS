using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMS.Models
{
    [JsonObject(Title = "RegisterData")]
    public partial class Register
    {
        public Patient Patient { get; set; }
        public List<object> Coding { get; set; }
        public List<object> Products { get; set; }
        public List<object> Perfusion { get; set; }
    }

    public partial class Patient
    {
        public long PatientNumber { get; set; }
        public string PatientSurname { get; set; }
        public string PatientInitials { get; set; }
        public string PatientGender { get; set; }
        public string IdPassportNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string WardCode { get; set; }
        public string WardName { get; set; }
        public string TheatreInvoiceNumber { get; set; }
        public DateTime TheatreInvoiceDate { get; set; }
        public string TheatreCode { get; set; }
        public string TheatreName { get; set; }
        public string TheatreComplexCode { get; set; }
        public DateTime TimeStampIn { get; set; }
        public DateTime TimeStampOut { get; set; }
        public long ScrubSisterNcno { get; set; }
        public string ScrubSisterName { get; set; }
        public long ScrubSister2Ncno { get; set; }
        public string ScrubSister2Name { get; set; }
        public long CirculatingNurseNcno { get; set; }
        public string CirculatingNurseName { get; set; }
        public long CirculatingNurse2Ncno { get; set; }
        public string CirculatingNurse2Name { get; set; }
        public long AnaestheticAssNurseNcno { get; set; }
        public string AnaestheticAssNurseName { get; set; }
        public long AnaestheticAssNurse2Ncno { get; set; }
        public string AnaestheticAssNurse2Name { get; set; }
        public string Surgeon1RegNo { get; set; }
        public string Surgeon1Name { get; set; }
        public string Surgeon2RegNo { get; set; }
        public string Surgeon2Name { get; set; }
        public string Assistant1RegNo { get; set; }
        public string Assistant1Name { get; set; }
        public string Assistant2RegNo { get; set; }
        public string Assistant2Name { get; set; }
        public string AnaethetistRegNo { get; set; }
        public string AnaethetistName { get; set; }
        public string TypeOfAnaesthetic { get; set; }
        public string TypeOfAnaesthetic2 { get; set; }
        public string PerftechRepName { get; set; }
        public string SpecimenNarration { get; set; }
        public string ColdCaseInd { get; set; }
        public string TouniquetInd { get; set; }
        public string SepticInd { get; set; }
        public string TheatreProcCatCode { get; set; }
        public string TheatreProcCatDesc { get; set; }
        public string TheatreProcCat2Code { get; set; }
        public string TheatreProcCat2Desc { get; set; }
        public string ProcessedInd { get; set; }
    }
}
