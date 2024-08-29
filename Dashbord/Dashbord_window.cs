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
    public partial class Dashbord_window : Form
    {
        private Home_panel home_panel1;

        public Dashbord_window()
        {
            InitializeComponent();
            home_panel1 = new Home_panel();
            home_panel1.Visible = false;
            home_panel1.Dock = DockStyle.Fill; // Make the panel fill the form
            this.Controls.Add(home_panel1); // Add it to the form's controls
        }

        public void ShowHomePanel()
        {
            addTeacher2.Visible = false;
            addStudent1.Visible = false;
            addLecture2.Visible = false;
            home_panel2.Visible = true;

        }


        private void leture_btn_Click(object sender, EventArgs e)
        {
           addTeacher2.Visible = false;
            addStudent1.Visible = false;
            addLecture2.Visible = true;
            home_panel2.Visible = false;

        }

        private void dashbord_btn_Click(object sender, EventArgs e)
        {
            ShowHomePanel();

        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

                //Form1 f1 = new Form1();
                //f1.Show();
                this.Hide();
                var login = new Login_form.Login();
                login.Show();

            }
        }

        private void add_teacher_btn_Click(object sender, EventArgs e)
        {
            addTeacher2.Visible = true;
            addStudent1.Visible = false;
            addLecture2.Visible = false;
            home_panel2.Visible = false;
           
            
        }
        private void add_student_btn_Click_1(object sender, EventArgs e)
        {
            addTeacher2.Visible = false;
            addStudent1.Visible = true;
            addLecture2.Visible = false;
            home_panel2.Visible = false;


        }

        private void report_btn_Click_1(object sender, EventArgs e)
        {
            addLecture2.Visible = false;
            addStudent1.Visible = false;
            addTeacher2.Visible = false;
            home_panel2.Visible = true;


        }

        private void add_teacher_btn_Click_1(object sender, EventArgs e)
        {
            addTeacher2.Visible = true;
            addStudent1.Visible = false;
            addLecture2.Visible = false;
            home_panel2.Visible = false;

        }

        private void setting_btn_Click_1(object sender, EventArgs e)
        {
            addTeacher2.Visible = false;
            addStudent1.Visible = false;
            addLecture2.Visible = false;
            home_panel2.Visible = false;

        }

        private void Add_Faculty_btn_Click(object sender, EventArgs e)
        {
            addTeacher2.Visible = false;
            addStudent1.Visible = false;
            addLecture2.Visible = false;
            home_panel2.Visible = false;


            var addFaculty = new PopUpForms.AddFaculty();
            addFaculty.ShowDialog();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            addLecture2.Visible = false;
            addStudent1.Visible = false;
            addTeacher2.Visible = false;
            home_panel2.Visible = true;

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_panel2_Load(object sender, EventArgs e)
        {

        }

        private void subject_btn_Click(object sender, EventArgs e)
        {
            addTeacher2.Visible = false;
            addStudent1.Visible = false;
            addLecture2.Visible = false;
            home_panel2.Visible = false;

            var addSubject = new PopUpForms.AddNewSubject();
            addSubject.ShowDialog();
        }
    }
}
