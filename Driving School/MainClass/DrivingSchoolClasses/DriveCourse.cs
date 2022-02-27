using System;
using System.Collections.Generic;

#nullable disable

namespace Driving_School.DB.DrivingSchoolClasses
{
    public partial class DriveCourse
    {
        public DriveCourse()
        {
            DrivingInstructors = new HashSet<DrivingInstructor>();
            Histories = new HashSet<History>();
        }

        public int CoursesId { get; set; }
        public string Name { get; set; }
        public int NumberOfLessones { get; set; }
        public string Rank { get; set; }
        public int DrivingInstructorId { get; set; }
        public int? HistoryId { get; set; }

        public virtual History History { get; set; }
        public virtual ICollection<DrivingInstructor> DrivingInstructors { get; set; }
        public virtual ICollection<History> Histories { get; set; }
    }
}
