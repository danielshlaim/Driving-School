using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingSchool.Logic;

namespace Driving_School
{
    public partial class Form1 : Form
    {
        public static Form loginscreen;
        public Form1()
        {
            loginscreen = this;
            InitializeComponent();

            WelcomePanel welcomePanel = new WelcomePanel();
            welcomePanel.Parent = panel1;
            welcomePanel.MoveToLogIn += () =>
             {
                 panel1.Controls.Clear();
                 LogInUserControl logInUserControl = new LogInUserControl();
                 logInUserControl.Parent = panel1;
             };
        }

    }
}
