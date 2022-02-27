using DrivingSchool.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_School
{
    public partial class InstrutorSideManage : UserControl
    {
        public event Action BackToHomePage;
        public InstrutorSideManage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            StudentDetailGB.Visible = true;

            IInstructorReposetory instructorReposetory = new InstructorReposetory();
            listBox1.DataSource = instructorReposetory.GetListOfStudent(LogInUserControl.drivingInstructor);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteStudentBtn.Visible = true;
            IInstructorReposetory instructorReposetory = new InstructorReposetory();
            var studentDt = instructorReposetory.GetStudentDetails(LogInUserControl.drivingInstructor, listBox1.SelectedValue.ToString());
            label7.Text = studentDt.StudentIdentityNumber.ToString();
            label8.Text = studentDt.Email.ToString();
            label9.Text = studentDt.FirstName.ToString();
            label10.Text = studentDt.LastName.ToString();
            label1.Text = studentDt.PhoneNumber.ToString();
        }

        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            IDriveCourseRepository courseRepo = new DriveCourseRepository();
            IInstructorReposetory instructorReposetory = new InstructorReposetory();
            var studentDt = instructorReposetory.GetStudentDetails(LogInUserControl.drivingInstructor, listBox1.SelectedValue.ToString());
            courseRepo.DeleteCourse(studentDt);
            MessageBox.Show("Student Deleted Successfully");
            listBox1.DataSource = instructorReposetory.GetListOfStudent(LogInUserControl.drivingInstructor);
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label1.Text = "";

        }
        
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            BackToHomePage();

        }
    }
}
