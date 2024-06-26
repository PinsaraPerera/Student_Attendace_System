﻿using StudentsManagementSystemForm.shared;
using StudentsManagementSystemForm;
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

namespace forms
{
    public partial class UpdateSubject : Form
    {
        public UpdateSubject()
        {
            InitializeComponent();
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

            if (!string.IsNullOrEmpty(response))
            {
                // Show the popup window
                SubjectUpdatedPopUp popup = new SubjectUpdatedPopUp();
                popup.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed to update student. Please try again.");
            }
        }

        private void close_button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
