using System;
using System.Collections.Generic;
using System.Text;

namespace ITMS.Models
{
    public partial class Slate
    {
        public string HospitalLocation { get; set; }
        public string TheatreNumber { get; set; }
        public string DoctorRegistrationNumber { get; set; }
        public long DayOfWeek { get; set; }
        public DateTime TheatreStartTime { get; set; } //DatetimeOffSet
        public DateTime TheatreEndTime { get; set; }
    }
}
