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
    public partial class StudentHomePage : UserControl
    {
        public StudentHomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void StudentHomePage_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome {LogInUserControl.ThisStudent.FirstName}";
        }
    }
}
