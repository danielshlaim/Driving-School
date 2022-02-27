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
    public partial class WelcomePanel : UserControl
    {
        public event Action MoveToLogIn;
        public WelcomePanel()
        {
            InitializeComponent();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            

          MoveToLogIn();

        }

        private void WelcomePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
