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
    public partial class UpdateLecture : Form
    {
        public UpdateLecture(int id)
        {
            InitializeComponent();
            lectureID.Text = id.ToString();
        }
        public void clearForm()
        {
            facName.Clear();
            degname.Clear();
            acadYear.Clear();
            subCode.Clear();
            lecID.Clear();
            lecHall.Clear();
            lecStart.Clear();
            lecEnd.Clear();
            
        }
        private async void lecCreate_Click(object sender, EventArgs e)
        {
            // Get the values from the input textboxes
            
            string lectID = this.lectureID.Text;
            string facultyName = facName.Text;
            string degreeProgram = degname.Text;
            string academicYear = acadYear.Text;
            string subjectCode = subCode.Text;
            string lecturersID = lecID.Text;
            string lectureHall = lecHall.Text;
            string lectureDay = lecDay.Text;
            string lectureStart = lecStart.Text;
            string lectureEnd = lecEnd.Text;

            // Log the input values for debugging
            Console.WriteLine("Posting Lecture Details:");
            Console.WriteLine("Faculty Name: " + lectID);
            Console.WriteLine("Faculty Name: " + facultyName);
            Console.WriteLine("Degree Program: " + degreeProgram);
            Console.WriteLine("Academic Year: " + academicYear);
            Console.WriteLine("Subject Code: " + subjectCode);
            Console.WriteLine("Lecturer's ID: " + lecturersID);
            Console.WriteLine("Lecture Hall: " + lectureHall);
            Console.WriteLine("Lecture Day: " + lectureDay);
            Console.WriteLine("Lecture Start: " + lectureStart);
            Console.WriteLine("Lecture End: " + lectureEnd);

            // Post the values to the API
            var response = await APIHelper.UpdateLecture(lectID, facultyName, degreeProgram, academicYear, subjectCode, lecturersID, lectureHall, lectureDay, lectureStart, lectureEnd);

            // Show the popup window
            if (response == "SuccesFullyAdded")
            {
                // Show the popup window
                LectureUpdatedPopUp popup = new LectureUpdatedPopUp();
                popup.ShowDialog();
                clearForm();
            }
            else
            {
                MessageBox.Show("Error adding faculty");
            }

           
        }

        private void close_button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void cancelLecCreate_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }



        private void cancelLecCreate_Click_1(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
