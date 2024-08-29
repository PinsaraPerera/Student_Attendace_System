using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Student_Attendace_System.Dashbord.AddLecture.Data;
using static Student_Attendace_System.Dashbord.AddStudent;

namespace Student_Attendace_System.Dashbord
{
    public partial class AddLecture : UserControl
    {
        private List<Rootobject> data = new List<Rootobject>();
        private List<Teacher> teachers = new List<Teacher>();
        private Dictionary<int, string> teacherMapping = new Dictionary<int, string>();
        private Dictionary<int, string> degreeMapping = new Dictionary<int, string>()
{
    { 1, "Computer Science" },
    { 2, "BICT" },
    { 3, "ET" },
    { 4, "Software Engineering" }
};
        private Dictionary<int, int> yearMapping = new Dictionary<int, int>()
{
     {0,2019 },
    { 1,  2019},
    { 2, 2020 },
    { 3, 2021 },
    { 4, 2022 }
};
        public AddLecture()
        {
            InitializeComponent();
            Load += new EventHandler(load);
        }

        public static readonly string baseurl = "https://university-backend-es4ftzjzmq-uc.a.run.app";

        public static async Task<List<T>> Get<T>(string url)
        {
            using (HttpClient client = new HttpClient())  
            {
                try
                {
                    using (HttpResponseMessage res = await client.GetAsync(url))
                    {
                        using (HttpContent resContent = res.Content)
                        {
                            string data = await resContent.ReadAsStringAsync();
                            if (!string.IsNullOrEmpty(data))
                            {
                                var lectures = JsonConvert.DeserializeObject<List<T>>(data);
                                return lectures;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return new List<T>();
        }

        private async void load(object sender, EventArgs e)
        {
            lecId.DataPropertyName = nameof(LectureViewModel.Id);
            faculty.DataPropertyName = nameof(LectureViewModel.Faculty);
            degree.DataPropertyName = nameof(LectureViewModel.Degree);
            academic_year.DataPropertyName = nameof(LectureViewModel.AcademicYear);
            subject_code.DataPropertyName = nameof(LectureViewModel.SubjectCode);
            teacher_id.DataPropertyName = nameof(LectureViewModel.Teacher);
            day.DataPropertyName = nameof(LectureViewModel.Day);
            start_time.DataPropertyName = nameof(LectureViewModel.StartTime);
            end_time.DataPropertyName = nameof(LectureViewModel.EndTime);
            lecture_hall.DataPropertyName = nameof(LectureViewModel.LectureHall);

            data = await Get<Rootobject>($"{baseurl}/lecture/getAll");
            teachers = await Get<Teacher>($"{baseurl}/teacher/getAll");
           
            // Create mappings
            teacherMapping = teachers.ToDictionary(t => t.id, t => t.name);
            
            var lectureViewModels = data.Select(ro => new LectureViewModel
            {

                Id = ro.id,
                Faculty = ro.faculty,
                Degree = degreeMapping.ContainsKey(ro.degree) ? degreeMapping[ro.degree] : "Unknown",
                AcademicYear = yearMapping.ContainsKey(ro.academic_year) ? yearMapping[ro.academic_year] : 0,
                SubjectCode = ro.subject_code,
                Teacher = teacherMapping.ContainsKey(ro.teacher_id) ? teacherMapping[ro.teacher_id] : "Unknown",
                Day = ro.day,
                StartTime = ro.time_slot?.start_time,
                EndTime = ro.time_slot?.end_time,
                LectureHall = ro.lecture_hall
            }).ToList();
            
            dataView.DataSource = lectureViewModels;
            
        }


        public class Rootobject
        {
            public int id { get; set; }
            public string faculty { get; set; }
            public int degree { get; set; }
            public int academic_year { get; set; }
            public string subject_code { get; set; }
            public int teacher_id { get; set; }
            public string day { get; set; }
            public Time_Slot time_slot { get; set; }
            public string lecture_hall { get; set; }
            // public Subject subject { get; set; }
        }

        public class Time_Slot
        {
            public string start_time { get; set; }
            public string end_time { get; set; }
        }

        public class Subject
        {
            public string subject_code { get; set; }
            public string subject_name { get; set; }
            public string degree { get; set; }
            public int year { get; set; }
        }

        public class Teacher
        {
            public int id { get; set; }
            public string name { get; set; }
        }



        public class LectureViewModel
        {
            public int Id { get; set; }
            public string Faculty { get; set; }
            public string Degree { get; set; }
            public int AcademicYear { get; set; }
            public string SubjectCode { get; set; }
            public string Teacher { get; set; }
            public string Day { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }
            public string LectureHall { get; set; }
        }




        private void create_lecture_btn_Click(object sender, EventArgs e)
        {
            var createLecture = new PopUpForms.CreateNewLecture();
            createLecture.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            var home = new Home_panel();
            home.Visible = true;
            this.Visible = false;
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            load(sender, e);
        }

        private void AddLecture_Load(object sender, EventArgs e)
        {

        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataView.Columns[e.ColumnIndex].Name == "updateBtn")
                {
                    UpdateRow(e.RowIndex);
                }
                else if (dataView.Columns[e.ColumnIndex].Name == "deletBtn")
                {
                    if(MessageBox.Show("Are you sure to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    DeleteRow(e.RowIndex);
                    }
                }
            }
        }
        private void UpdateRow(int rowIndex)
        {
            DataGridViewRow row = dataView.Rows[rowIndex];
            int lectureId = (int)row.Cells["lecId"].Value;


            var updateLecture = new PopUpForms.UpdateLecture(lectureId);
           updateLecture.ShowDialog();
            
        }  
        private async void DeleteRow(int rowIndex)
        {
            DataGridViewRow row = dataView.Rows[rowIndex];
            int id =(int)row.Cells["lecId"].Value;
            data = await Get<Rootobject>($"{baseurl}/lecture/delete/{id}");


        }
    }
}
