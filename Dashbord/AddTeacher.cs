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
using static Student_Attendace_System.Dashbord.AddLecture;
using static Student_Attendace_System.Dashbord.AddStudent;

namespace Student_Attendace_System.Dashbord
{
    public partial class AddTeacher : UserControl
    {
        public AddTeacher()
        {
            InitializeComponent();
            Load += new EventHandler(Teacher_load);
        }
        private List<TeacherData> data = new List<TeacherData>();
        public static readonly string baseurl = "https://university-backend-es4ftzjzmq-uc.a.run.app";

        public static async Task<List<TeacherData>> Get(string url)
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
                                var teacher = JsonConvert.DeserializeObject<List<TeacherData>>(data);
                                return teacher;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return new List<TeacherData>();
        }
        private async void Teacher_load(object sender, EventArgs e)
        {
           data = await Get($"{baseurl}/teacher/getAll");
          /* teacherId.DataPropertyName = "id";
           TeacherName.DataPropertyName = "name";
           department.DataPropertyName = "department";
            email.DataPropertyName = "email";*/
           // dataView.DataSource = data;

            teacherId.DataPropertyName = nameof(ViewModel.teacherId);
            TeacherName.DataPropertyName = nameof(ViewModel.teacherName);
            email.DataPropertyName = nameof(ViewModel.email);
            department.DataPropertyName = nameof(ViewModel.department);

            var lectureViewModels = data.Select(dt => new ViewModel
            {
                
                teacherId = dt.id,
                teacherName = dt.name,
                email = dt.email,
                department = dt.department
            }).ToList();

            dataView.DataSource = lectureViewModels;

        }

        public class TeacherData
        {
            public string name { get; set; }
            public string email { get; set; }
            public string department { get; set; }
            public int id { get; set; }
        }

        public class ViewModel
        {
            public int teacherId { get; set; }
            public string teacherName { get; set; }
            public string email { get; set; }
            public string department { get; set; }
        }

        private void create_lecture_btn_Click_1(object sender, EventArgs e)
        {
            var newTeacher = new PopUpForms.AddNewTeacher();
            newTeacher.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            var Dashbord = new Dashbord_window();
            Dashbord.ShowHomePanel();
            this.Visible = false;
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            Teacher_load(sender, e);
            textBox2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void UpdateRow(int rowIndex)
        {
            DataGridViewRow row = dataView.Rows[rowIndex];
            int id = (int)row.Cells["teacherId"].Value;


            var updateLecture = new PopUpForms.UpdateTeacher(id);
            updateLecture.ShowDialog();

        }
        private async void DeleteRow(int rowIndex)
        {
            DataGridViewRow row = dataView.Rows[rowIndex];
            int id = (int)row.Cells["teacherId"].Value;
            data = await Get($"{baseurl}/teacher/remove/{id}");

        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dataView.Columns[e.ColumnIndex].Name == "updateBtn")
                {
                    UpdateRow(e.RowIndex);
                }
                else if (dataView.Columns[e.ColumnIndex].Name == "deleteBtn")
                {
                    if (MessageBox.Show("Are you sure to delete this Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeleteRow(e.RowIndex);
                    }
                }
            }

        }
    }
}
