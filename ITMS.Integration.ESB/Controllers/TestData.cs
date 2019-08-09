using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMS.Integration.ESB.Controllers
{
    public static class TestData
    {
        public const string profiles = "[]";
        public const string cases = "[]";
        public const string complexes = "[]";
        public const string slates = "[]";
        public const string theatres = "[]";
        public const string registers = "[" +
   "{" +
   "\"Patient\": {" +
   "\"PatientNumber\": 94626," +
   "\"PatientSurname\": \"JKHJHDKHKJHDU\"," +
   "\"PatientInitials\": \"J\"," +
   "\"PatientGender\": \"M\"," +
   "\"ID_PassportNumber\": \"6204091234087\"," +
   "\"DateOfBirth\": \"1962-04-09\"," +
   "\"AdmissionDate\": \"2008-10-09\"," +
   "\"DischargeDate\": \"2008-10-10\"," +
   "\"WardCode\": \"U\"," +
   "\"WardName\": \"Ward U General Cardio\"," +
   "\"TheatreInvoiceNumber\": \"T60430\"," +
   "\"TheatreInvoiceDate\": \"2008-10-09\"," +
   "\"TheatreCode\": \"M1\"," +
   "\"TheatreName\": \"CATHLAB\"," +
   "\"TheatreComplexCode\": \"T\"," +
   "\"TimeStampIn\": \"2008-10-09T14:15:00+02:00\"," +
   "\"TimeStampOut\": \"2008-10-09T14:40:00+02:00\"," +
   "\"ScrubSisterNCNO\": 52," +
   "\"ScrubSisterName\": \"BAILIE Z\"," +
   "\"ScrubSister2NCNO\": 0," +
   "\"ScrubSister2Name\": \"\"," +
   "\"CirculatingNurseNCNO\": 13286588," +
   "\"CirculatingNurseName\": \"DREYER Y\"," +
   "\"CirculatingNurse2NCNO\": 0," +
   "\"CirculatingNurse2Name\": \"\"," +
   "\"AnaestheticAssNurseNCNO\": 0," +
   "\"AnaestheticAssNurseName\": \"\"," +
   "\"AnaestheticAssNurse2NCNO\": 0," +
   "\"AnaestheticAssNurse2Name\": \"\"," +
   "\"Surgeon1RegNo\": \"MP0162539\"," +
   "\"Surgeon1Name\": \"DU TOIT W, DR\"," +
   "\"Surgeon2RegNo\": \"\"," +
   "\"Surgeon2Name\": \"\"," +
   "\"Assistant1RegNo\": \"\"," +
   "\"Assistant1Name\": \"\"," +
   "\"Assistant2RegNo\": \"\"," +
   "\"Assistant2Name\": \"\"," +
   "\"AnaethetistRegNo\": \"\"," +
   "\"AnaethetistName\": \"\"," +
   "\"TypeOfAnaesthetic\": \"L\"," +
   "\"TypeOfAnaesthetic2\": \"\"," +
   "\"PerftechRepName\": \"N\"," +
   "\"SpecimenNarration\": \"N\"," +
   "\"ColdCaseIND\": \"N\"," +
   "\"TouniquetIND\": \"N\"," +
   "\"SepticIND\": \"N\"," +
   "\"TheatreProcCatCode\": \"030\"," +
   "\"TheatreProcCatDesc\": \"CARDIOLOGY\"," +
   "\"TheatreProcCat2Code\": \"\"," +
   "\"TheatreProcCat2Desc\": \"\"," +
   "\"ProcessedIND\": \"A\"" +
"}," +
"\"Coding\": []," +
"\"Products\": []," +
"\"Perfusion\": []" +
"}," +
"{" +
"\"Patient\": {" +
   "\"PatientNumber\": 69043," +
   "\"PatientSurname\": \"WUEYRDBQ\"," +
   "\"PatientInitials\": \"AAL\"," +
   "\"PatientGender\": \"M\"," +
   "\"ID_PassportNumber\": \"510812\"," +
   "\"DateOfBirth\": \"1951-08-12\"," +
   "\"AdmissionDate\": \"2015-01-24\"," +
   "\"DischargeDate\": \"0001-01-01\"," +
   "\"WardCode\": \"R\"," +
   "\"WardName\": \"\"," +
   "\"TheatreInvoiceNumber\": \"T64033\"," +
   "\"TheatreInvoiceDate\": \"2015-01-25\"," +
   "\"TheatreCode\": \"51\"," +
   "\"TheatreName\": \"CATHLAB A\"," +
   "\"TheatreComplexCode\": \"T\"," +
   "\"TimeStampIn\": \"2015-01-25T10:15:00+02:00\"," +
   "\"TimeStampOut\": \"2015-01-25T10:38:00+02:00\"," +
   "\"ScrubSisterNCNO\": 32," +
   "\"ScrubSisterName\": \"LIT T\"," +
   "\"ScrubSister2NCNO\": 0," +
   "\"ScrubSister2Name\": \"\"," +
   "\"CirculatingNurseNCNO\": 18705," +
   "\"CirculatingNurseName\": \"MOSTERT SS\"," +
   "\"CirculatingNurse2NCNO\": 0," +
   "\"CirculatingNurse2Name\": \"\"," +
   "\"AnaestheticAssNurseNCNO\": 0," +
   "\"AnaestheticAssNurseName\": \"\"," +
   "\"AnaestheticAssNurse2NCNO\": 0," +
   "\"AnaestheticAssNurse2Name\": \"\"," +
   "\"Surgeon1RegNo\": \"MP0212231\"," +
   "\"Surgeon1Name\": \"VELDMAN AN, DR\"," +
   "\"Surgeon2RegNo\": \"\"," +
   "\"Surgeon2Name\": \"\"," +
   "\"Assistant1RegNo\": \"\"," +
   "\"Assistant1Name\": \"\"," +
   "\"Assistant2RegNo\": \"\"," +
   "\"Assistant2Name\": \"\"," +
   "\"AnaethetistRegNo\": \"\"," +
   "\"AnaethetistName\": \"\"," +
   "\"TypeOfAnaesthetic\": \"L\"," +
   "\"TypeOfAnaesthetic2\": \"\"," +
   "\"PerftechRepName\": \"P\"," +
   "\"SpecimenNarration\": \"N\"," +
   "\"ColdCaseIND\": \"N\"," +
   "\"TouniquetIND\": \"N\"," +
   "\"SepticIND\": \"N\"," +
   "\"TheatreProcCatCode\": \"030\"," +
   "\"TheatreProcCatDesc\": \"CARDIOLOGY\"," +
   "\"TheatreProcCat2Code\": \"\"," +
   "\"TheatreProcCat2Desc\": \"\"," +
   "\"ProcessedIND\": \"A\"" +
"}," +
"\"Coding\": []," +
"\"Products\": []," +
"\"Perfusion\": []" +
"}" +
"]";
        public const string oldregisters = "{\"RegisterData\": [" +
    "{" +
    "\"Patient\": {" +
    "\"PatientNumber\": 94626," +
    "\"PatientSurname\": \"JKHJHDKHKJHDU\"," +
    "\"PatientInitials\": \"J\"," +
    "\"PatientGender\": \"M\"," +
    "\"ID_PassportNumber\": \"6204091234087\"," +
    "\"DateOfBirth\": \"1962-04-09\"," +
    "\"AdmissionDate\": \"2008-10-09\"," +
    "\"DischargeDate\": \"2008-10-10\"," +
    "\"WardCode\": \"U\"," +
    "\"WardName\": \"Ward U General Cardio\"," +
    "\"TheatreInvoiceNumber\": \"T60430\"," +
    "\"TheatreInvoiceDate\": \"2008-10-09\"," +
    "\"TheatreCode\": \"M1\"," +
    "\"TheatreName\": \"CATHLAB\"," +
    "\"TheatreComplexCode\": \"T\"," +
    "\"TimeStampIn\": \"2008-10-09T14:15:00+02:00\"," +
    "\"TimeStampOut\": \"2008-10-09T14:40:00+02:00\"," +
    "\"ScrubSisterNCNO\": 52," +
    "\"ScrubSisterName\": \"BAILIE Z\"," +
    "\"ScrubSister2NCNO\": 0," +
    "\"ScrubSister2Name\": \"\"," +
    "\"CirculatingNurseNCNO\": 13286588," +
    "\"CirculatingNurseName\": \"DREYER Y\"," +
    "\"CirculatingNurse2NCNO\": 0," +
    "\"CirculatingNurse2Name\": \"\"," +
    "\"AnaestheticAssNurseNCNO\": 0," +
    "\"AnaestheticAssNurseName\": \"\"," +
    "\"AnaestheticAssNurse2NCNO\": 0," +
    "\"AnaestheticAssNurse2Name\": \"\"," +
    "\"Surgeon1RegNo\": \"MP0162539\"," +
    "\"Surgeon1Name\": \"DU TOIT W, DR\"," +
    "\"Surgeon2RegNo\": \"\"," +
    "\"Surgeon2Name\": \"\"," +
    "\"Assistant1RegNo\": \"\"," +
    "\"Assistant1Name\": \"\"," +
    "\"Assistant2RegNo\": \"\"," +
    "\"Assistant2Name\": \"\"," +
    "\"AnaethetistRegNo\": \"\"," +
    "\"AnaethetistName\": \"\"," +
    "\"TypeOfAnaesthetic\": \"L\"," +
    "\"TypeOfAnaesthetic2\": \"\"," +
    "\"PerftechRepName\": \"N\"," +
    "\"SpecimenNarration\": \"N\"," +
    "\"ColdCaseIND\": \"N\"," +
    "\"TouniquetIND\": \"N\"," +
    "\"SepticIND\": \"N\"," +
    "\"TheatreProcCatCode\": \"030\"," +
    "\"TheatreProcCatDesc\": \"CARDIOLOGY\"," +
    "\"TheatreProcCat2Code\": \"\"," +
    "\"TheatreProcCat2Desc\": \"\"," +
    "\"ProcessedIND\": \"A\"" +
"}," +
"\"Coding\": []," +
"\"Products\": []," +
"\"Perfusion\": []" +
"}," +
"{" +
"\"Patient\": {" +
    "\"PatientNumber\": 69043," +
    "\"PatientSurname\": \"WUEYRDBQ\"," +
    "\"PatientInitials\": \"AAL\"," +
    "\"PatientGender\": \"M\"," +
    "\"ID_PassportNumber\": \"510812\"," +
    "\"DateOfBirth\": \"1951-08-12\"," +
    "\"AdmissionDate\": \"2015-01-24\"," +
    "\"DischargeDate\": \"0001-01-01\"," +
    "\"WardCode\": \"R\"," +
    "\"WardName\": \"\"," +
    "\"TheatreInvoiceNumber\": \"T64033\"," +
    "\"TheatreInvoiceDate\": \"2015-01-25\"," +
    "\"TheatreCode\": \"51\"," +
    "\"TheatreName\": \"CATHLAB A\"," +
    "\"TheatreComplexCode\": \"T\"," +
    "\"TimeStampIn\": \"2015-01-25T10:15:00+02:00\"," +
    "\"TimeStampOut\": \"2015-01-25T10:38:00+02:00\"," +
    "\"ScrubSisterNCNO\": 32," +
    "\"ScrubSisterName\": \"LIT T\"," +
    "\"ScrubSister2NCNO\": 0," +
    "\"ScrubSister2Name\": \"\"," +
    "\"CirculatingNurseNCNO\": 18705," +
    "\"CirculatingNurseName\": \"MOSTERT SS\"," +
    "\"CirculatingNurse2NCNO\": 0," +
    "\"CirculatingNurse2Name\": \"\"," +
    "\"AnaestheticAssNurseNCNO\": 0," +
    "\"AnaestheticAssNurseName\": \"\"," +
    "\"AnaestheticAssNurse2NCNO\": 0," +
    "\"AnaestheticAssNurse2Name\": \"\"," +
    "\"Surgeon1RegNo\": \"MP0212231\"," +
    "\"Surgeon1Name\": \"VELDMAN AN, DR\"," +
    "\"Surgeon2RegNo\": \"\"," +
    "\"Surgeon2Name\": \"\"," +
    "\"Assistant1RegNo\": \"\"," +
    "\"Assistant1Name\": \"\"," +
    "\"Assistant2RegNo\": \"\"," +
    "\"Assistant2Name\": \"\"," +
    "\"AnaethetistRegNo\": \"\"," +
    "\"AnaethetistName\": \"\"," +
    "\"TypeOfAnaesthetic\": \"L\"," +
    "\"TypeOfAnaesthetic2\": \"\"," +
    "\"PerftechRepName\": \"P\"," +
    "\"SpecimenNarration\": \"N\"," +
    "\"ColdCaseIND\": \"N\"," +
    "\"TouniquetIND\": \"N\"," +
    "\"SepticIND\": \"N\"," +
    "\"TheatreProcCatCode\": \"030\"," +
    "\"TheatreProcCatDesc\": \"CARDIOLOGY\"," +
    "\"TheatreProcCat2Code\": \"\"," +
    "\"TheatreProcCat2Desc\": \"\"," +
    "\"ProcessedIND\": \"A\"" +
"}," +
"\"Coding\": []," +
"\"Products\": []," +
"\"Perfusion\": []" +
"}" +
"]" +
"}";
    }
}
