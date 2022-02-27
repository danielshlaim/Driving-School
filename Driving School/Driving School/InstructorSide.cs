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
    public partial class InstructorSide : Form
    {
       public static  Form instrutorsidescreen;

        public InstructorSide()
        {
            InitializeComponent();
            instrutorsidescreen = this;

        }
       
      



        private void InstructorSide_Load(object sender, EventArgs e)
        {
            WelcomeInstructor welcomeInstructor = new WelcomeInstructor();
            welcomeInstructor.Parent = panel1;
            panel1.Controls.Add(welcomeInstructor);
            welcomeInstructor.BringToFront();
            welcomeInstructor.Show();
            welcomeInstructor.Dock = DockStyle.Fill;
            welcomeInstructor.MoveNext += () =>
            {

                BackHome();
         


            };
           
        }
        public void BackHome()
        {
           
                panel1.Controls.Clear();
                InstrutorSideManage instrutorSideManage = new InstrutorSideManage();
                instrutorSideManage.Parent = panel1;
                panel1.Controls.Add(instrutorSideManage);
                instrutorSideManage.BringToFront();
                instrutorSideManage.Show();
                instrutorSideManage.Dock = DockStyle.Fill;

                instrutorSideManage.BackToHomePage += () =>
                {
                    panel1.Controls.Clear();

                    WelcomeInstructor welcomeInstructor = new WelcomeInstructor();
                    welcomeInstructor.Parent = panel1;
                    panel1.Controls.Add(welcomeInstructor);
                    welcomeInstructor.BringToFront();
                    welcomeInstructor.Show();
                    welcomeInstructor.Dock = DockStyle.Fill;
                    welcomeInstructor.MoveNext += () =>
                    {
                        BackHome();
                    };

                };
              
           
           
            

        }


    }
}
