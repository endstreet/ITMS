using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static ITMS.Helper;

namespace ITMS.ESBModels
{
    [JsonObject(Title = "MyCar")]
    public class Case
    {
        [JsonProperty("HospitalLocation", Required = Required.Always)]
        public string HospitalLocation { get; set; }

        [JsonProperty("TheatreNumber", Required = Required.Always)]
        public string TheatreNumber { get; set; }

        [JsonProperty("DoctorRegistrationNumber", Required = Required.Always)]
        public string DoctorRegistrationNumber { get; set; }

        [JsonProperty("PatientNumber", Required = Required.Always)]
        public long PatientNumber { get; set; }

        [JsonProperty("PatientName", Required = Required.Always)]
        public string PatientName { get; set; }

        [JsonProperty("ProcedureText", Required = Required.Always)]
        public List<string> ProcedureText { get; set; }

        [JsonProperty("ClinicalCPTCodes", Required = Required.Always)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> ClinicalCptCodes { get; set; }

        [JsonProperty("ClinicalCPTDescriptions", Required = Required.Always)]
        public List<string> ClinicalCptDescriptions { get; set; }

        [JsonProperty("ProcedureStartDateTime", Required = Required.Always)]
        public DateTimeOffset ProcedureStartDateTime { get; set; }

        [JsonProperty("ProcedureEndDateTime", Required = Required.Always)]
        public DateTimeOffset ProcedureEndDateTime { get; set; }

        [JsonProperty("ProcedureDuration", Required = Required.Always)]
        public long ProcedureDuration { get; set; }
    }
}
