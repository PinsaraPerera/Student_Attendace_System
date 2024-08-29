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
    public partial class AddFaculty : Form
    {
        public AddFaculty()
        {
            InitializeComponent();
        }


        private void fID_TextChanged(object sender, EventArgs e)
        {

        }

        private void fName_TextChanged(object sender, EventArgs e)
        {

        }

     

        private async void addfac_Click_1(object sender, EventArgs e)
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
            if (response == "SuccesFullyAdded")
            {
                var facultyadded = new FacultyAddedPopUp();
                facultyadded.ShowDialog();
                fID.Clear();
                fName.Clear();
            }
            else
            {
                MessageBox.Show("Error adding faculty");
            }
        }

        private void cancelAddFac_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }
        public void Clear()
        {
            fID.Text = "";
            fName.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
