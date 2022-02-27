using Driving_School.DB.DrivingSchoolClasses;

namespace DrivingSchool.Logic
{
    public interface IStudentRepositry
    {
        
        void AddCourse(Student student,string coursename);
        void RemoveCourse(Student student);
        
    }
}