using Driving_School.DB.DrivingSchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Logic
{
    public class InstructorReposetory : IInstructorReposetory
    {
        public List<string> GetListOfStudent(DrivingInstructor drivingInstructor)
        {
            using (var db = new DrivingSchoolContext())
            {
                
                var studentlist = db.Students.Where( s => s.CoursesId == drivingInstructor.CoursesId).Select(s => s.FirstName + " " + s.LastName).ToList();
                return studentlist;
            }
        }

        public Student GetStudentDetails(DrivingInstructor drivingInstructor ,string username)
        {
                     using (var db = new DrivingSchoolContext())
            {
                var studentlist = db.Students.Where(s => s.CoursesId == drivingInstructor.CoursesId).Select(s => s).ToList();
                foreach (var student in studentlist)
                {
                    if (student.FirstName + " " + student.LastName == username)
                    {
                        return student;
                    }
                    
                }
               
                return null;
            }
        }
    }
}

