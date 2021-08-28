using System;
using System.Collections.Generic;
using System.Text;

namespace App3.View
{
   public class Data
    {

        public int StudentID { get; set; }
        public string Name { get; set; }
        public int CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int NoUnits { get; set; }
        public int DateofAttendance { get; set; }
        public string PersonInfo()
        { return $"StudentID:{StudentID} {Name} CourseCode:{CourseCode} {CourseTitle} NoUnits:{NoUnits} DateofAttendance:{DateofAttendance}"; }

    }
}
