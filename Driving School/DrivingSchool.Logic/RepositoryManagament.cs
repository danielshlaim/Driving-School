using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Logic
{
    public class RepositoryManagament : StudentRepository
    {
        public DriveInsturctorRepository TeacherRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public RepositoryManagament()
        {
            TeacherRepository = new DriveInsturctorRepository();
            StudentRepository = new StudentRepository();    

        }
    }
}
