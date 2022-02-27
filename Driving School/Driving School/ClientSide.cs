using Driving_School.DB;
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
    public partial class ClientSide : Form
    {
        public RepositoryManagament UnitOfWork { get; set; }
        public ClientSide()
        {
           
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void ClientSide_Load(object sender, EventArgs e)
        {
            StudentHomePage studentHomePage = new StudentHomePage();
            studentHomePage.Parent = panel2;
            panel2.Controls.Add(studentHomePage);
            studentHomePage.BringToFront();
            studentHomePage.Show();
            studentHomePage.Dock = DockStyle.Fill;

        }

        private void coursesNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           AddOrDeleteCourseUserControl addOrDeleteCourseUserControl = new AddOrDeleteCourseUserControl();
            addOrDeleteCourseUserControl.Parent = panel2;

            panel2.Controls.Add(addOrDeleteCourseUserControl);
            addOrDeleteCourseUserControl.BringToFront();
            addOrDeleteCourseUserControl.Show();
            addOrDeleteCourseUserControl.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HistoryUserControl historyUserControl = new HistoryUserControl();
            historyUserControl.Parent = panel2;
            panel2.Controls.Add(historyUserControl);
            historyUserControl.BringToFront();
            historyUserControl.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            StudentHomePage studentHomePage = new StudentHomePage();
            studentHomePage.Parent = panel2;
            panel2.Controls.Add(studentHomePage);
            studentHomePage.BringToFront();
            studentHomePage.Show();
            studentHomePage.Dock = DockStyle.Fill;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
