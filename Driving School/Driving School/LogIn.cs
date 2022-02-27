using DrivingSchool.Logic;
using Driving_School.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Driving_School.DB.DrivingSchoolClasses;

namespace Driving_School
{
    public partial class LogInUserControl : UserControl
    {
       public static Student ThisStudent { get; set; }
        public static DrivingInstructor drivingInstructor { get; set; }
        public static bool IsStudent { get; set; }
        Validations validations =  Validations.GetInstance();
        
        public LogInUserControl()
        {
            
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {

            var vali = validations.LoginCheck(UserNameTxt.Text, PasswordTxt.Text);

            if (vali == "Student")
            {
                var student = validations.LoginCheckStudent(UserNameTxt.Text, PasswordTxt.Text);
                if (student != null)
                {
                    IsStudent = true;
                    ThisStudent = student;
                } 
                var StudentScreen = new ClientSide();
                StudentScreen.Show();
                Form1.loginscreen.Visible = false;

            }
            else if (vali == "Instructors")
            {
                var instructor = validations.LoginCheckDrivingInstructort(UserNameTxt.Text, PasswordTxt.Text);
                IsStudent =false;
                var InstructorScreen = new InstructorSide();
                drivingInstructor = instructor;
                InstructorScreen.Show();
                Form1.loginscreen.Visible = false;
               
            }
        }
    
    }
}
