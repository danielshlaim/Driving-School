using Driving_School.DB.DrivingSchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Logic
{
    public class StudentRepository : IRepository<Student,DriveCourse> ,IStudentRepositry
    {
       

        public void AddCourse(Student student, string coursename)
        {
            
          
            
           
            
            
            using (var db = new DrivingSchoolContext())
            {
                var course = db.DriveCourses.Where(s => s.Name.ToLower() == coursename.ToLower()).Select(s => s).FirstOrDefault();
                student.CoursesId = course.CoursesId;
                db.Students.Update(student);
                db.SaveChanges();
            }
        }

        public DriveCourse GetCourses(Student obj)
        {
            using (var db = new DrivingSchoolContext())
            {
                var list = db.DriveCourses.Where(c => c.CoursesId == obj.CoursesId).Select(c => c).FirstOrDefault();
                return list;
            }
        }

        public void RemoveCourse(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
