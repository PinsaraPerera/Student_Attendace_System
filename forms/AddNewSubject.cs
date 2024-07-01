using StudentsManagementSystemForm.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagementSystemForm
{
    public partial class AddNewSubject : Form
    {
        public AddNewSubject()
        {
            InitializeComponent();
        }



        private async void addNewSub_Click(object sender, EventArgs e)
        {
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
            SubjectAddedPopUp popup = new SubjectAddedPopUp();
            popup.ShowDialog();
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
    }
}
