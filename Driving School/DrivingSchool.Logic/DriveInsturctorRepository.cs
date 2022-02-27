using Driving_School.DB.DrivingSchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Logic
{
    public  class DriveInsturctorRepository : IRepository<DrivingInstructor,List<DriveCourse>>
    {
        public  List<DriveCourse> GetCourses(DrivingInstructor obj)
        {
            using (var db = new DrivingSchoolContext())
            {
                var list = db.DriveCourses.Where(c => c.DrivingInstructorId == obj.DrivingInstructorsId).Select(c => c).ToList();
                return list;
            }
        }
    }
}
