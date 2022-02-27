using Driving_School.DB.DrivingSchoolClasses;
using System.Collections.Generic;

namespace DrivingSchool.Logic
{
    public interface IInstructorReposetory
    {
        List<string> GetListOfStudent(DrivingInstructor drivingInstructor);
        public Student GetStudentDetails(DrivingInstructor drivingInstructor , string username);

    }
}