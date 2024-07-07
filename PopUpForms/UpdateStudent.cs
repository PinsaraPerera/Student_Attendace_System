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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            // Get the values from the input textboxes
            string studentNumber = this.StNum.Text;
            string studentName = stName.Text;
            string degreeId = dID.Text;
            string specializationID = specializationId.Text;
            string studentemail = emailAdd.Text;
            string studentfaculty = facultyName.Text;
            string departmentId = departmentName.Text;
            string studentimage = img.Text;
            string startingYear = startingYr.Text;

            // Log the input values for debugging
            Console.WriteLine("Posting Student Number: " + studentNumber);
            Console.WriteLine("Posting Student Name: " + studentName);
            Console.WriteLine("Posting Student Degree: " + degreeId);
            Console.WriteLine("Posting Student Specialization: " + specializationID);
            Console.WriteLine("Posting Student Email: " + studentemail);
            Console.WriteLine("Posting Student Faculty: " + studentfaculty);
            Console.WriteLine("Posting Student Department: " + departmentId);
            Console.WriteLine("Posting Student Image: " + studentimage);
            Console.WriteLine("Posting Student Starting Year: " + startingYear);


            // Post the values to the API
            var response = await APIHelper.UpdateItem(studentNumber, studentName, degreeId, specializationID, studentemail, studentfaculty, departmentId, studentimage, startingYear);

            if (!string.IsNullOrEmpty(response))
            {
                // Show the popup window
                StudentUpdatedPopUp popup = new StudentUpdatedPopUp();
                popup.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed to update student. Please try again.");
            }
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

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var updated = new StudentUpdatedPopUp();
            updated.Show();
        }
    }
}
