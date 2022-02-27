using Driving_School.DB.DrivingSchoolClasses;
using System.Collections.Generic;

namespace DrivingSchool.Logic
{
    public interface IHistoryReposetory
    {
        History CreateHistoryInstance(int instractorId , int studentId,int courseId);
        List<History> GetStudentHistory(Student student);

    }
}