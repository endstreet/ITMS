using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMS.Integration.ESB.Controllers
{
    public static class TestData
    {
        public const string profiles = "{" + 
        "\"Profile\": [" + 
        "{" + 
        "\"DoctorCode\": \"001\"," + 
        "\"Name\": \"GOUWS W\"," + 
        "\"Title\": \"PR\"," + 
        "\"Pediatrition\": \"Y\"," + 
        "\"Speciality\": {" + 
        "\"Code\": 30," + 
        "\"Description\": \"CARDIOLOGY\"" + 
        "}," + 
        "\"RegistrationNumber\": \"MP0161259\"," + 
        "\"MemberOfIPA\": \"Y\"," + 
        "\"Filler\": \"JAN      2016/11/21 09h52\"," + 
        "\"Locum\": \"N\"," + 
        "\"PracticeCode\": \"0180001809660\"," + 
        "\"GroupPractice\": \"\"," + 
        "\"ContactNumbers\": {" + 
        "\"Tel_Rooms\": \"021 9790440\"," + 
        "\"Tel_Home\": \"082 8844402\"," + 
        "\"Tel_Emergency\": \"082 8445402\"" + 
        "}," + 
        "\"Address\": {" + 
        "\"AddressLine1\": \"PRIVATE BAG 132\"," + 
        "\"AddressLine2\": \"TYGER VALLEY\"," + 
        "\"AddressLine3\": \"\"," + 
        "\"PostalCode\": \"7536\"" + 
        "}" + 
        "}," + 
        "{" + 
        "\"DoctorCode\": \"002\"," + 
        "\"Name\": \"OSLOO R\"," + 
        "\"Title\": \"DR\"," + 
        "\"Pediatrition\": \"Y\"," + 
        "\"Speciality\": {" + 
        "\"Code\": 140," + 
        "\"Description\": \"ORTHOPAEDIC SURGERY\"" + 
        "}," + 
        "\"RegistrationNumber\": \"MP0253310\"," + 
        "\"MemberOfIPA\": \"N\"," + 
        "\"Filler\": \"JANE   2013/09/26 15h04\"," + 
        "\"Locum\": \"N\"," + 
        "\"PracticeCode\": \"0280002801233\"," + 
        "\"GroupPractice\": \"\"," + 
        "\"ContactNumbers\": {" + 
        "\"Tel_Rooms\": \"021 9313040\"," + 
        "\"Tel_Home\": \"021 967135\"," + 
        "\"Tel_Emergency\": \"021 4219900\"" + 
        "}," + 
        "\"Address\": {" + 
        "\"AddressLine1\": \"ROOM G30 MEDICLINIC PANORAMA\"," + 
        "\"AddressLine2\": \"ROTHSCHILD BOULEVARD\"," + 
        "\"AddressLine3\": \"PANORAMA\"," + 
        "\"PostalCode\": \"7500\"" + 
        "}" + 
        "}," + 
        "{" + 
        "\"DoctorCode\": \"004\"," + 
        "\"Name\": \"CLOETE JA\"," + 
        "\"Title\": \"DR\"," + 
        "\"Pediatrition\": \"Y\"," + 
        "\"Speciality\": {" + 
        "\"Code\": 30," + 
        "\"Description\": \"CARDIOLOGY\"" + 
        "}," + 
        "\"RegistrationNumber\": \"MP0244473\"," + 
        "\"MemberOfIPA\": \"N\"," + 
        "\"Filler\": \"MARLENE   2013/09/26 15h04\"," + 
        "\"Locum\": \"N\"," + 
        "\"PracticeCode\": \"0210076764386\"," + 
        "\"GroupPractice\": \"\"," + 
        "\"ContactNumbers\": {" + 
        "\"Tel_Rooms\": \"021 9322211\"," + 
        "\"Tel_Home\": \"021 9309877\"," + 
        "\"Tel_Emergency\": \"021 4218750\"" + 
        "}," + 
        "\"Address\": {" + 
        "\"AddressLine1\": \"ROOM G10 MEDICLINIC PANORAMA\"," + 
        "\"AddressLine2\": \"ROTHSCHILD BOULEVARD\"," + 
        "\"AddressLine3\": \"PANORAMA\"," + 
        "\"PostalCode\": \"7500\"" + 
        "}" + 
        "}," + 
        "{" + 
        "\"DoctorCode\": \"998\"," + 
        "\"Name\": \"NO ANAETHETIST\"," + 
        "\"Title\": \".\"," + 
        "\"Pediatrition\": \"Y\"," + 
        "\"Speciality\": {" + 
        "\"Code\": 998," + 
        "\"Description\": \"NO ANAESTHETIST\"" + 
        "}," + 
        "\"RegistrationNumber\": \"998\"," + 
        "\"MemberOfIPA\": \"N\"," + 
        "\"Filler\": \"LEA   2012/11/06 15h19\"," + 
        "\"Locum\": \"N\"," + 
        "\"PracticeCode\": \"998\"," + 
        "\"GroupPractice\": \"\"," + 
        "\"ContactNumbers\": {" + 
        "\"Tel_Rooms\": \".\"," + 
        "\"Tel_Home\": \".\"," + 
        "\"Tel_Emergency\": \".\"" + 
        "}," + 
        "\"Address\": {" + 
        "\"AddressLine1\": \".\"," + 
        "\"AddressLine2\": \".\"," + 
        "\"AddressLine3\": \"\"," + 
        "\"PostalCode\": \"9999\"" + 
        "}" + 
        "}," + 
        "{" + 
        "\"DoctorCode\": \"999\"," + 
        "\"Name\": \"NEW/UNKNOWN DOCTOR\"," + 
        "\"Title\": \"DR\"," + 
        "\"Pediatrition\": \"Y\"," + 
        "\"Speciality\": {" + 
        "\"Code\": 999," + 
        "\"Description\": \"OTHER SPECIALITIES\"" + 
        "}," + 
        "\"RegistrationNumber\": \"DOC1\"," + 
        "\"MemberOfIPA\": \"N\"," + 
        "\"Filler\": \"\"," + 
        "\"Locum\": \"\"," + 
        "\"PracticeCode\": \"999\"," + 
        "\"GroupPractice\": \"\"," + 
        "\"ContactNumbers\": {" + 
        "\"Tel_Rooms\": \".\"," + 
        "\"Tel_Home\": \".\"," + 
        "\"Tel_Emergency\": \".\"" + 
        "}," + 
        "\"Address\": {" + 
        "\"AddressLine1\": \".\"," + 
        "\"AddressLine2\": \".\"," + 
        "\"AddressLine3\": \"\"," + 
        "\"PostalCode\": \"9999\"" + 
        "}" + 
        "}" + 
        "]" + 
        "}";
        public const string cases = "{" + 
        "\"Cases\": [" +  
        "{" +  
        "\"HospitalLocation\": \"ZZ\"," +  
        "\"TheatreNumber\": \"01\"," +  
        "\"DoctorRegistrationNumber\": \"MP0111219\"," + 
        "\"PatientNumber\": 28385," + 
        "\"PatientName\": \"ROSSOUW MRS .C\"," +  
        "\"ProcedureText\": [" +  
        "\"KDJHFIFH\"" +  
        "]," +  
        "\"ClinicalCPTCodes\": [" +  
        "\"23031\"" +  
        "]," +  
        "\"ClinicalCPTDescriptions\": [" +  
        "\"DRAINAGE INFECTED BURSA SHOULDER AREA\"" +  
        "]," +  
        "\"ProcedureStartDateTime\": \"2017-02-02T08:00:00+02:00\"," +  
        "\"ProcedureEndDateTime\": \"2017-02-02T09:30:00+02:00\"," +  
        "\"ProcedureDuration\": 90" +  
        "}," +  
        "{" +  
        "\"HospitalLocation\": \"ZZ\"," +  
        "\"TheatreNumber\": \"01\"," +  
        "\"DoctorRegistrationNumber\": \"MP0431356\"," +  
        "\"PatientNumber\": 39297," +  
        "\"PatientName\": \"MARAIS MNR .A\"," +  
        "\"ProcedureText\": [" +  
        "\"OSIGH;SGVN\"" +  
        "]," +  
        "\"ClinicalCPTCodes\": [" +  
        "\"11311\"" +  
        "]," +  
        "\"ClinicalCPTDescriptions\": [" +  
        "\"SHAVE SKIN LESION FACE/EAR/EYELID/NOSE/LIP 0.6-1CM\"" +  
        "]," +  
        "\"ProcedureStartDateTime\": \"2017-02-03T07:00:00+02:00\"," +  
        "\"ProcedureEndDateTime\": \"2017-02-03T07:30:00+02:00\"," +  
        "\"ProcedureDuration\": 30" +  
        "}," +  
        "{" +  
        "\"HospitalLocation\": \"ZZ\"," +  
        "\"TheatreNumber\": \"01\"," +  
        "\"DoctorRegistrationNumber\": \"MP0414489\"," +  
        "\"PatientNumber\": 39300," +  
        "\"PatientName\": \"NEL MRS .CB\"," +  
        "\"ProcedureText\": [" +  
        "\"KJG\"" +  
        "]," +  
        "\"ClinicalCPTCodes\": [" +  
        "\"93000\"" +  
        "]," +  
        "\"ClinicalCPTDescriptions\": [" +  
        "\"ECG 12 LEAD/INTERPRETATION/REPORT\"" +  
        "]," +  
        "\"ProcedureStartDateTime\": \"2017-02-08T07:00:00+02:00\"," +  
        "\"ProcedureEndDateTime\": \"2017-02-08T08:30:00+02:00\"," +  
        "\"ProcedureDuration\": 90" +  
        "}" +  
        "]" +  
        "}";
        public const string complexes = "{" + 
        "\"Complex\": [" + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"Code\": \"A\"," + 
        "\"Name\": \"MAIN COMPLEX\"," + 
        "\"Manager\": \"REINETTE ALBERTS\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"Code\": \"CR\"," + 
        "\"Name\": \"CARDIAC THEATRES\"," + 
        "\"Manager\": \"HILDA DU TOIT\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"Code\": \"K\"," + 
        "\"Name\": \"DAY\"," + 
        "\"Manager\": \"MAGDA PRINSLOO\"" + 
        "}" + 
        "]" + 
        "}";
        public const string slates = "{" + 
        "\"SlateData\": [" + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"TheatreNumber\": \"K\"," + 
        "\"DoctorRegistrationNumber\": \"MP0174411\"," + 
        "\"DayOfWeek\": 1," + 
        "\"TheatreStartTime\": \"08:00:00+02:00\"," + 
        "\"TheatreEndTime\": \"09:00:00+02:00\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"TheatreNumber\": \"M1\"," + 
        "\"DoctorRegistrationNumber\": \"MP0353329\"," + 
        "\"DayOfWeek\": 1," + 
        "\"TheatreStartTime\": \"07:46:00+02:00\"," + 
        "\"TheatreEndTime\": \"18:00:00+02:00\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"TheatreNumber\": \"M1\"," + 
        "\"DoctorRegistrationNumber\": \"MP0444510\"," + 
        "\"DayOfWeek\": 1," + 
        "\"TheatreStartTime\": \"07:46:00+02:00\"," + 
        "\"TheatreEndTime\": \"18:00:00+02:00\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"TheatreNumber\": \"M2\"," + 
        "\"DoctorRegistrationNumber\": \"MP0322207\"," + 
        "\"DayOfWeek\": 1," + 
        "\"TheatreStartTime\": \"08:31:00+02:00\"," + 
        "\"TheatreEndTime\": \"13:00:00+02:00\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"TheatreNumber\": \"M2\"," + 
        "\"DoctorRegistrationNumber\": \"MP0123659\"," + 
        "\"DayOfWeek\": 1," + 
        "\"TheatreStartTime\": \"13:01:00+02:00\"," + 
        "\"TheatreEndTime\": \"18:00:00+02:00\"" + 
        "}" + 
        "]" + 
        "}";
        public const string theatres = "{" + 
        "\"TheatreDetail\": [" + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"*\"," + 
        "\"SectionCode\": \"L1\"," + 
        "\"SectionName\": \"THEATRE 1\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 0," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"01\"," + 
        "\"SectionName\": \"THEATRE 01\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"02\"," + 
        "\"SectionName\": \"THEATRE 02\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"03\"," + 
        "\"SectionName\": \"THEATRE 03\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"04\"," + 
        "\"SectionName\": \"THEATRE 04\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"05\"," + 
        "\"SectionName\": \"THEATRE 05\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"06\"," + 
        "\"SectionName\": \"THEATRE 06\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"07\"," + 
        "\"SectionName\": \"THEATRE 07\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"08\"," + 
        "\"SectionName\": \"THEATRE 08\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"09\"," + 
        "\"SectionName\": \"THEATRE 09\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"10\"," + 
        "\"SectionName\": \"THEATRE 10\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"11\"," + 
        "\"SectionName\": \"THEATRE 11\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}," + 
        "{" + 
        "\"HospitalLocation\": \"ZZ\"," + 
        "\"ActiveFlag\": \"\"," + 
        "\"SectionCode\": \"12\"," + 
        "\"SectionName\": \"THEATRE 12\"," + 
        "\"CostCentrum\": \"T\"," + 
        "\"ActivityCentre\": 51," + 
        "\"BarcodeBilling\": \"N\"," + 
        "\"TheatreComplex\": \"A\"" + 
        "}" + 
        "]" + 
        "}";
        public const string registers = "{\"RegisterData\": [" +
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
