using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace DashBord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void leture_btn_Click(object sender, EventArgs e)
        {
           addLecture1.Visible = true;
          addTeacher.Visible = false;
            sTudent1.Visible = false;
        }

        private void dashbord_btn_Click(object sender, EventArgs e)
        {
            addLecture1.Visible = false;
          //  addTeacher3.Visible = false;
            sTudent1.Visible = false;
        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to log out?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
               
                //Form1 f1 = new Form1();
                //f1.Show();
                this.Hide();
            }
        }

        private void add_teacher_btn_Click(object sender, EventArgs e)
        {
            addLecture1.Visible = false;
            addTeacher.Visible = true;
            sTudent1.Visible = false;
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
               
        }

        private void addLecture1_Load(object sender, EventArgs e)
        {

        }

        private void add_student_btn_Click_1(object sender, EventArgs e)
        {
            addLecture1.Visible = false;
           addTeacher.Visible = false;
            sTudent1.Visible = true;
            
        }

        private void report_btn_Click_1(object sender, EventArgs e)
        {
            addLecture1.Visible = false;
            addTeacher.Visible = false;
            sTudent1.Visible = false;
        }

        private void add_teacher_btn_Click_1(object sender, EventArgs e)
        {
            addLecture1.Visible = false;
           addTeacher.Visible = true;
            sTudent1.Visible = false;
        }

        private void setting_btn_Click_1(object sender, EventArgs e)
        {
            addLecture1.Visible = false;
           addTeacher.Visible = false;
            sTudent1.Visible = false;
        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sTudent1_Load(object sender, EventArgs e)
        {

        }

        private void addTeacher_Load(object sender, EventArgs e)
        {
        
           
        }
    }
}
