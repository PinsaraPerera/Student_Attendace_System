using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendace_System.Dashbord
{
    public partial class AddLecture : UserControl
    {
        public AddLecture()
        {
            InitializeComponent();
        }

        private void create_lecture_btn_Click(object sender, EventArgs e)
        {
            var createLecture = new PopUpForms.AddNewTeacher();
            createLecture.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
           var home = new Home_panel();
            home.Visible = true;
            this.Visible = false;
        }
    }
}
