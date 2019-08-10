using System;
using System.Collections.Generic;
using System.Text;

namespace ITMS.ESBModels
{ 
    //DoctorProfile
    public class Profile
    {
        public string DoctorCode { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Pediatrition { get; set; }
        public Speciality Speciality { get; set; }
        public string RegistrationNumber { get; set; }
        public string MemberOfIpa { get; set; }
        public string Filler { get; set; }
        public string Locum { get; set; }
        public string PracticeCode { get; set; }
        public string GroupPractice { get; set; }
        public ContactNumbers ContactNumbers { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public int PostalCode { get; set; }
    }

    public class ContactNumbers
    {
        public string TelRooms { get; set; }
        public string TelHome { get; set; }
        public string TelEmergency { get; set; }
    }

    public class Speciality
    {
        public int Code { get; set; }
        public string Description { get; set; }
    }
}
