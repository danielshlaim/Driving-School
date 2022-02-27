using System;
using System.Collections.Generic;

#nullable disable

namespace Driving_School.DB.DrivingSchoolClasses
{
    public partial class History
    {
        public History()
        {
            DriveCourses = new HashSet<DriveCourse>();
        }

        public int HistoryId { get; set; }
        public int DrivingInstructorId { get; set; }
        public int StudentId { get; set; }
        public int CoursesId { get; set; }

        public virtual DriveCourse Courses { get; set; }
        public virtual ICollection<DriveCourse> DriveCourses { get; set; }
    }
}
