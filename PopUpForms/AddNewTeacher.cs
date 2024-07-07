using StudentsManagementSystemForm.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendace_System.PopUpForms
{
    public partial class AddNewTeacher : Form
    {
        public AddNewTeacher()
        {
            InitializeComponent();
        }

        private void close_button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void addTeacher_Click(object sender, EventArgs e)
        {
            // Get the values from the input textboxes
            string teacherDepartment = TDepartment.Text;
            string teachername = TName.Text;
            string teacherEmail = TEmail.Text;


            // Log the input values for debugging
            Console.WriteLine("Posting Student Number: " + teacherDepartment);
            Console.WriteLine("Posting Student Name: " + teachername);
            Console.WriteLine("Posting Student Degree: " + teacherEmail);


            // Post the values to the API
            var response = await APIHelper.PostTeacher(teacherDepartment, teachername, teacherEmail);

            // Show the popup window
            TeacherAddedPopUp popup = new TeacherAddedPopUp();
            popup.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTeacher_Click_1(object sender, EventArgs e)
        {
            var added = new TeacherAddedPopUp();
            added.Show();
        }
    }
}
