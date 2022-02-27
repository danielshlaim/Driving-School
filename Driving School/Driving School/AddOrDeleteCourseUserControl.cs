using Driving_School.DB.DrivingSchoolClasses;
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
    public partial class AddOrDeleteCourseUserControl : UserControl
    {
        public AddOrDeleteCourseUserControl()
        {
            InitializeComponent();
        }

        private void Course_RankLbl_Click(object sender, EventArgs e)
        {

        }

        private void JoinBtn_Click(object sender, EventArgs e)
        {

            IStudentRepositry studentRepositry = new StudentRepository(); 
            IDriveCourseRepository courseRepo = new DriveCourseRepository();
            IHistoryReposetory historyReposetory = new HistoryReposetory();
            using (var db = new DrivingSchoolContext())
            {
              
                
                var student = LogInUserControl.ThisStudent;

                var course = courseRepo.GetByName(courseNameComboBox.Text);

                var history = historyReposetory.CreateHistoryInstance(course.DrivingInstructorId, student.StudentId, course.CoursesId);
                
                student.CoursesId = course.CoursesId;
                db.Update(student);
                db.SaveChanges();

                MessageBox.Show("You Have Been joined Successfully");
            }




        }

        private void AddOrDeleteCourseUserControl_Load(object sender, EventArgs e)
        {
            IDriveCourseRepository driveCourseRepository = new DriveCourseRepository();
            var list = driveCourseRepository.GetCoursesName();
            courseNameComboBox.DataSource = list;

            B_RadioBtn.Checked = false;
            A_RankRadioBtn.Checked = false;
            Taxi_RadioBtn.Checked = false;

            A_RankRadioBtn.Enabled = false;
            B_RadioBtn.Enabled = false;
            Taxi_RadioBtn.Enabled = false;

        }

        private void courseNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedname = courseNameComboBox.SelectedValue;
            A_RankRadioBtn.Enabled = false;
            B_RadioBtn.Enabled = false;
            Taxi_RadioBtn.Enabled = false;
            switch (selectedname.ToString().ToLower())
            {
                case "motorcycle":
                    A_RankRadioBtn.Enabled= true;
                    A_RankRadioBtn.Checked=true;
                    break;
                case "car":
                    B_RadioBtn.Enabled= true;
                    B_RadioBtn.Checked = true;
                    break;
                default:
                    Taxi_RadioBtn.Enabled =true;
                    Taxi_RadioBtn.Checked = true;
                    break;
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            IStudentRepositry studentRepositry = new StudentRepository();
            IDriveCourseRepository courseRepo = new DriveCourseRepository();
            IHistoryReposetory historyReposetory = new HistoryReposetory();

            courseRepo.DeleteCourse(LogInUserControl.ThisStudent);
            MessageBox.Show("Deleted Successfully");
        }
    }
}
