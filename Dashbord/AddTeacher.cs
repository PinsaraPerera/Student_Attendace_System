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
    public partial class AddTeacher : UserControl
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void create_lecture_btn_Click_1(object sender, EventArgs e)
        {
            var newTeacher = new PopUpForms.AddNewTeacher();
            newTeacher.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            var Dashbord = new Dashbord_window();
            Dashbord.ShowHomePanel();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
