using System;
using System.Collections.Generic;

#nullable disable

namespace Driving_School.DB.DrivingSchoolClasses
{
    public partial class DrivingInstructor
    {
        public int DrivingInstructorsId { get; set; }
        public int DrivingInstructorIdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int CoursesId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual DriveCourse Courses { get; set; }
    }
}
