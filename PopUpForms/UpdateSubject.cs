using Microsoft.VisualBasic;
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
    public partial class UpdateSubject : Form
    {
        public UpdateSubject()
        {
            InitializeComponent();
        }
        public void clearForm()
        {
            subName.Clear();
            academicYear.Clear();
        }

        private void cancelAddNewSub_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }


        private async void addNewSub_Click(object sender, EventArgs e)
        {
            // Get the values from the input textboxes
            string lectureCode = this.subCode.Text;
            string lectureName = subName.Text;
            string degree = degreeName.Text;
            string year = academicYear.Text;


            // Log the input values for debugging
            Console.WriteLine("Posting Student Number: " + lectureCode);
            Console.WriteLine("Posting Student Name: " + lectureName);
            Console.WriteLine("Posting Student Degree: " + degree);
            Console.WriteLine("Posting Student Specialization: " + year);


            // Post the values to the API
            var response = await APIHelper.UpdateSubject(lectureCode, lectureName, degree, year);

         
            // Show the popup window
            if (response == "SuccesFullyAdded")
            {
                    // Show the popup window
                    SubjectUpdatedPopUp popup = new SubjectUpdatedPopUp();
                    popup.ShowDialog();
                    clearForm();
            }
            else
            {
                MessageBox.Show("Failed to update subject.Please try again.");
            }

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
