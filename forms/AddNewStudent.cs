using StudentsManagementSystemForm;
using StudentsManagementSystemForm.shared;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace forms
{
    public partial class AddNewStudent : Form
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Get the values from the input textboxes
            string studentNumber = StNum.Text;
            string studentName = stName.Text;
            string degreeId = dID.Text;
            string specializationID = specializationId.Text;
            string email = emailAdd.Text;
            string faculty = facultyName.Text;
            string departmentId = departmentName.Text;
            string image = img.Text;
            string startingYear = startingYr.Text;

            // Log the input values for debugging
            Console.WriteLine("Posting Student Number: " + studentNumber);
            Console.WriteLine("Posting Student Name: " + studentName);
            Console.WriteLine("Posting Student Degree: " + degreeId);
            Console.WriteLine("Posting Student Specialization: " + specializationID);
            Console.WriteLine("Posting Student Email: " + email);
            Console.WriteLine("Posting Student Faculty: " + faculty);
            Console.WriteLine("Posting Student Department: " + departmentId);
            Console.WriteLine("Posting Student Image: " + image);
            Console.WriteLine("Posting Student Starting Year: " + startingYear);

            // Post the values to the API
            var response = await APIHelper.Post(studentNumber, studentName, degreeId, specializationID, email, faculty, departmentId, image, startingYear);

            // Show the popup window
            StudentAddedPopUp popup = new StudentAddedPopUp();
            popup.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // You can leave this event handler empty or remove it if not needed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void close_button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void textstudent_no_TextChanged(object sender, EventArgs e)
        {
            // You can leave this event handler empty or remove it if not needed
        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {
            // You can leave this event handler empty or remove it if not needed
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
