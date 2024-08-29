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
    public partial class AddNewSubject : Form
    {
        public AddNewSubject()
        {
            InitializeComponent();
        }

        public void clearForm()
        {
            subCode.Clear();
            subName.Clear();
            academicYear.Clear();
        }

        private async void addNewSub_Click_1(object sender, EventArgs e)
        {
            var studentAdded = new SubjectAddedPopUp();
            studentAdded.Show();

            // Get the values from the input textboxes
            string lectureCode = subCode.Text;
            string lectureName = subName.Text;
            string degree = degreeName.Text;
            string year = academicYear.Text;


            // Log the input values for debugging
            Console.WriteLine("Posting Student Number: " + lectureCode);
            Console.WriteLine("Posting Student Name: " + lectureName);
            Console.WriteLine("Posting Student Degree: " + degree);
            Console.WriteLine("Posting Student Specialization: " + year);


            // Post the values to the API
            var response = await APIHelper.Post(lectureCode, lectureName, degree, year);

            // Show the popup window
            if (response == "SuccesFullyAdded")
            {
                // Show the popup window
             
                SubjectAddedPopUp popup = new SubjectAddedPopUp();
                 popup.ShowDialog();
                clearForm();
            }
            else
            {
                MessageBox.Show("Failed to adding subject. Please try again.");
            }

            // Show the popup window

        }

        private void subCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelAddNewSub_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void close_button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }


        private void cancelAddNewSub_Click_1(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
