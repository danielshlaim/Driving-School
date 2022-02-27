using Driving_School.DB.DrivingSchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Logic
{
    public class HistoryReposetory : IHistoryReposetory
    {
        public History CreateHistoryInstance(int instractorId, int studentId, int courseId)
        {
            using ( var db = new DrivingSchoolContext())
            {
                History history = new History() {

                    DrivingInstructorId = instractorId,
                    StudentId = studentId,
                    CoursesId = courseId
                };
                db.Histories.Add(history);
                db.SaveChanges();
                return history;
            }
            
        }

        public List<History> GetStudentHistory(Student student)
        {
            using (var db = new DrivingSchoolContext())
            {
                var studentHistory = db.Histories.Where(h => h.StudentId == student.StudentId).Select(h => h).ToList();
                return studentHistory;


            }
        }
    }
}
