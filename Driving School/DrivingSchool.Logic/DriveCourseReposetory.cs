using Driving_School.DB.DrivingSchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Logic
{
    public class DriveCourseRepository : IDriveCourseRepository
    {
        public void DeleteCourse(Student student)
        {
            using (var db = new DrivingSchoolContext())
            {
                student.CoursesId = 0;
                db.Students.Update(student);
                db.SaveChanges();

            }
        }

        public DriveCourse GetByName(string name)
        {
            using (var db  = new DrivingSchoolContext())
            {
                var course = db.DriveCourses.Where(c => c.Name.ToLower() == name.ToLower()).Select(c => c).FirstOrDefault();
                return course;
            }
        }

        public List<string> GetCoursesName()
        {
            using (var db = new DrivingSchoolContext())
            {
                var list = db.DriveCourses.Select(d => d.Name).ToList(); 
                return list;
            }
            
        }
    }
}
