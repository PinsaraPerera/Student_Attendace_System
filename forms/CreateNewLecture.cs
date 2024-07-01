using StudentsManagementSystemForm.shared;
using System;
using System.Windows.Forms;

namespace StudentsManagementSystemForm
{
    public partial class CreateNewLecture : Form
    {
        public CreateNewLecture()
        {
            InitializeComponent();
        }

        private async void lecCreate_Click(object sender, EventArgs e)
        {
            // Get the values from the input textboxes
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
            var response = await APIHelper.PostLecture(facultyName, degreeProgram, academicYear, subjectCode, lecturersID, lectureHall, lectureDay, lectureStart, lectureEnd);

            // Show the popup window
            LectureCreatedPopUp popup = new LectureCreatedPopUp();
            popup.ShowDialog();
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
    }
}
