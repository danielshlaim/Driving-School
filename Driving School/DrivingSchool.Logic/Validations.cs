using Driving_School.DB;
using Driving_School.DB.DrivingSchoolClasses;
using System.Linq;

namespace DrivingSchool.Logic
{
    public class Validations
    {
        private Validations _Instance { get; set; }

        private Validations()
        {

        }


        public string LoginCheck(string username, string password)
        {
            using (var db = new DrivingSchoolContext())
            {
                var StudentLoginValidation = db.Students.Where(s => s.UserName == username && s.Password == password).Any();
                var DrivingInstructorsLoginValidation = db.DrivingInstructors.Where(d => d.UserName == username && d.Password == password).Any();
                if (StudentLoginValidation == true)
                {
                    return "Student";
                }
                else if (DrivingInstructorsLoginValidation == true)
                {
                    return "Instructors";
                }
                return "not exist";

            }

        }
        public Student LoginCheckStudent(string username, string password)
        {
            using (var db = new DrivingSchoolContext())
            {
                var StudentLoginValidation = db.Students.Where(s => s.UserName == username && s.Password == password).Select(c => c).FirstOrDefault();
                if (StudentLoginValidation != null)
                {
                    return StudentLoginValidation;
                }
                else
                {
                    return null;
                }

            }

        }


        public DrivingInstructor LoginCheckDrivingInstructort(string username, string password)
        {
         
            using (var db = new DrivingSchoolContext())
            {
                var DrivingInstructorsLoginValidation = db.DrivingInstructors.Where(s => s.UserName == username && s.Password == password).Select(c => c).FirstOrDefault();
                if (DrivingInstructorsLoginValidation != null)
                {
                    return DrivingInstructorsLoginValidation;
                }
                else
                {
                    return null;
                }

            }

        }







        public static Validations GetInstance()
        {
            Validations validations = new Validations();
            if (validations._Instance != null)
            {
                return validations;
            }
            else
            {
                return validations._Instance = new Validations();

            }
        }




    }
}
