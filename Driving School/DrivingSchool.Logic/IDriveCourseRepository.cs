using Driving_School.DB.DrivingSchoolClasses;
using System.Collections.Generic;

namespace DrivingSchool.Logic
{
    public interface IDriveCourseRepository 
    {
        List<string> GetCoursesName();
        DriveCourse GetByName(string name);
        void DeleteCourse( Student student);
        
    }
}