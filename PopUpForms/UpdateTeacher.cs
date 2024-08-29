﻿using StudentsManagementSystemForm.shared;
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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher(int id)
        {
            InitializeComponent();
            teacherID.Text = id.ToString();
        }
        public void clearForm()
        {
            TDepartment.Clear();
            TEmail.Clear();
            TName.Clear();
        }

        private void close_button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelAddTeacher_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void close_button2_Click_1(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private async void addTeacher_Click(object sender, EventArgs e)
        {
            // Get the values from the input textboxes
            string teacherid = this.teacherID.Text;
            string teacherDepartment = TDepartment.Text;
            string teachername = TName.Text;
            string teacherEmail = TEmail.Text;


            // Log the input values for debugging
            Console.WriteLine("Posting Student Number: " + teacherid);
            Console.WriteLine("Posting Student Number: " + teacherDepartment);
            Console.WriteLine("Posting Student Name: " + teachername);
            Console.WriteLine("Posting Student Degree: " + teacherEmail);

            if(teacherid == " " || teacherDepartment == " " || teachername == " " || teacherEmail == " ")
            {
                MessageBox.Show("Failed to update teacher.");
            }

            // Post the values to the API
            var response = await APIHelper.UpdateTeacher(teacherid, teacherDepartment, teachername, teacherEmail);



            // Show the popup window
            if (response == "SuccesFullyAdded")
            {
                // Show the popup window
                // Show the popup window
                TeacherUpdatePopUp popup = new TeacherUpdatePopUp();
                popup.ShowDialog();

                 clearForm();
            }
            else
            {
                MessageBox.Show("Failed to update teacher. Please try again.");
            }
        }


        private void cancelAddTeacher_Click_1(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
