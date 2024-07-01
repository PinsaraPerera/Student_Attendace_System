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
    public partial class AddFaculty : Form
    {
        public AddFaculty()
        {
            InitializeComponent();
        }


        private void close_button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }


        private void fID_TextChanged(object sender, EventArgs e)
        {

        }

        private void fName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelAddFac_Click_1(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private async void addfac_Click(object sender, EventArgs e)
        {
            // Get the values from the input textboxes
            string facultyID = fID.Text;
            string facultyName = fName.Text;
            

            // Log the input values for debugging
            Console.WriteLine("Posting Student Number: " + facultyID);
            Console.WriteLine("Posting Student Name: " + facultyName);
           

            // Post the values to the API
            var response = await APIHelper.PostFaculty(facultyID, facultyName);

            // Show the popup window
            FacultyAddedPopUp popup = new FacultyAddedPopUp();
            popup.ShowDialog();
        }
    }
}
