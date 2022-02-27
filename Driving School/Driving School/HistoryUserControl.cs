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
    public partial class HistoryUserControl : UserControl
    {
        public HistoryUserControl()
        {
            InitializeComponent();
        }

        private void HistoryUserControl_Load(object sender, EventArgs e)
        {
            IHistoryReposetory historyReposetory = new HistoryReposetory();
            dataGridView1.DataSource = historyReposetory.GetStudentHistory(LogInUserControl.ThisStudent);
            
        }
    }
}
