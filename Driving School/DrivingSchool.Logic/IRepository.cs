using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Driving_School.DB;
using Driving_School.DB.DrivingSchoolClasses;

namespace DrivingSchool.Logic
{
    public interface IRepository<T,K> where T : class
    {
         K GetCourses(T obj);

    }
}
