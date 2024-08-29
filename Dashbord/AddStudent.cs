using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static Student_Attendace_System.Dashbord.AddLecture;


namespace Student_Attendace_System.Dashbord
{
    public partial class AddStudent : UserControl
    {
        private List<StudentData> students = new List<StudentData>();
        private List<FacultyData> faculty = new List<FacultyData>();
        private Dictionary<int, string> facultyMapping = new Dictionary<int, string>();
        private Dictionary<int, string> departmentMapping = new Dictionary<int, string>()
        {
            { 1, "Software Engineering" },
            { 2, "Applied Computing" },
            { 3, "Computer System Engineering" }
        };
        private Dictionary<int, string> specializationMapping = new Dictionary<int, string>()
        {
            { 1, "Cyber Security" },
            { 2, "Data Science" },
            { 3, "Artificial Intelligence" },
            { 4, "Scientific Computing" }
        };
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
        public AddStudent()
        {
            InitializeComponent();
            Load += new EventHandler(STudent_Load);
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
                                var students = JsonConvert.DeserializeObject<List<T>>(data);
                                return students;
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
        private async void STudent_Load(object sender, EventArgs e)
        {
            students = await Get<StudentData>($"{baseurl}/student/getAll");
            faculty = await Get<FacultyData>($"{baseurl}/faculty/getAll");
            facultyMapping = faculty.ToDictionary(f => f.id, f => f.name);


            stdId.DataPropertyName = nameof(ViewModel.studentNo);
            StdName.DataPropertyName = nameof(ViewModel.studentName);
            degreeId.DataPropertyName = nameof(ViewModel.degreeId);
            special_Id.DataPropertyName = nameof(ViewModel.specializationId);
            email.DataPropertyName = nameof(ViewModel.email);
            Faculty_Id.DataPropertyName = nameof(ViewModel.faculty);
            department_id.DataPropertyName = nameof(ViewModel.departmentId);
            image.DataPropertyName = nameof(ViewModel.image);
            starting_yr.DataPropertyName = nameof(ViewModel.startingYr);

            var lectureViewModels = students.Select(st => new ViewModel
            {
                studentNo = st.student_no,
                studentName = st.student_name,
                degreeId = degreeMapping.ContainsKey(st.degree_id) ? degreeMapping[st.degree_id] : "Unknown",
                specializationId = specializationMapping.ContainsKey(st.specialization_id) ? specializationMapping[st.specialization_id] : "Unknown",
                email = st.email,
                faculty = facultyMapping.ContainsKey(st.faculty) ? facultyMapping[st.faculty] : "Unknown",
                departmentId = departmentMapping.ContainsKey(st.department_id) ? departmentMapping[st.department_id] : "Unknown",
                image = st.image,
                startingYr = yearMapping.ContainsKey(st.starting_yr) ? yearMapping[st.starting_yr] : 0
            }).ToList();

            dataView.DataSource = lectureViewModels;

           
        }
        private async Task STudent_serch()
        {
            students = await Get<StudentData>($"{baseurl}/student/getAll");
            faculty = await Get<FacultyData>($"{baseurl}/faculty/getAll");
            facultyMapping = faculty.ToDictionary(f => f.id, f => f.name);


            stdId.DataPropertyName = nameof(ViewModel.studentNo);
            StdName.DataPropertyName = nameof(ViewModel.studentName);
            degreeId.DataPropertyName = nameof(ViewModel.degreeId);
            special_Id.DataPropertyName = nameof(ViewModel.specializationId);
            email.DataPropertyName = nameof(ViewModel.email);
            Faculty_Id.DataPropertyName = nameof(ViewModel.faculty);
            department_id.DataPropertyName = nameof(ViewModel.departmentId);
            image.DataPropertyName = nameof(ViewModel.image);
            starting_yr.DataPropertyName = nameof(ViewModel.startingYr);

            string searchValue = search_txtBox.Text.Trim().ToLower();
            var filteredData = students.Where(row => row.student_no.ToLower().Contains(searchValue)).ToList();
            var lectureViewModels = filteredData.Select(st => new ViewModel
            {
                studentNo = st.student_no,
                studentName = st.student_name,
                degreeId = degreeMapping.ContainsKey(st.degree_id) ? degreeMapping[st.degree_id] : "Unknown",
                specializationId = specializationMapping.ContainsKey(st.specialization_id) ? specializationMapping[st.specialization_id] : "Unknown",
                email = st.email,
                faculty = facultyMapping.ContainsKey(st.faculty) ? facultyMapping[st.faculty] : "Unknown",
                departmentId = departmentMapping.ContainsKey(st.department_id) ? departmentMapping[st.department_id] : "Unknown",
                image = st.image,
                startingYr = yearMapping.ContainsKey(st.starting_yr) ? yearMapping[st.starting_yr] : 0
            }).ToList();

            dataView.DataSource = lectureViewModels;


        }
        public class StudentData
        {
            public string student_no { get; set; }
            public string student_name { get; set; }
            public int degree_id { get; set; }
            public int specialization_id { get; set; }
            public string email { get; set; }
            public int faculty { get; set; }
            public int department_id { get; set; }
            public string image { get; set; }
            public int starting_yr { get; set; }
        }

        public class ViewModel
        {
            public string studentNo { get; set; }
            public string studentName { get; set; }
            public string degreeId { get; set; }
            public string specializationId { get; set; }
            public string email { get; set; }
            public string faculty { get; set; }
            public string departmentId { get; set; }
            public string image { get; set; }
            public int startingYr { get; set; }
        }

        public class FacultyData
        {
            public int id { get; set; }
            public string name { get; set; }
        }


        private void search_txtBox_Enter(object sender, EventArgs e)
        {
            if (search_txtBox.Text == "cs_2020_005")
            {
                search_txtBox.Text = "";
                search_txtBox.ForeColor = Color.Black;
                search_txtBox.Font = new Font(search_txtBox.Font, FontStyle.Regular);

            }
        }

        private void search_txtBox_Leave(object sender, EventArgs e)
        {
            if (search_txtBox.Text == "")
            {
                search_txtBox.Text = "CS_2020_005";
                search_txtBox.ForeColor = Color.Silver;
                search_txtBox.Font = new Font(search_txtBox.Font, FontStyle.Italic);
            }
        }

        private void search_txtBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            STudent_Load(sender, e);
            search_txtBox.Text = string.Empty;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_std_btn_Click(object sender, EventArgs e)
        {
            var newStudent = new PopUpForms.AddNewStudent();
            newStudent.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }

        private async void serch_btn_Click(object sender, EventArgs e)
        {
            await STudent_serch();
            search_txtBox.Text = string.Empty;
            // var filteredData = students.Where(row => row.student_no.ToLower().Contains(searchValue)).ToList();
            // dataView.DataSource = filteredData;

        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataView.Columns[e.ColumnIndex].Name == "btnUpdate")
                {
                    UpdateRow(e.RowIndex);
                }
                else if (dataView.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    if (MessageBox.Show("Are you sure to delete this Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeleteRow(e.RowIndex);
                    }
                }
            }
        }
        private void UpdateRow(int rowIndex)
        {
            DataGridViewRow row = dataView.Rows[rowIndex];
            string Id = (string)row.Cells["stdId"].Value;


            var update = new PopUpForms.UpdateStudent(Id);
            update.ShowDialog();

        }
        private async void DeleteRow(int rowIndex)
        {
            DataGridViewRow row = dataView.Rows[rowIndex];
            string id = (string)row.Cells["stdId"].Value;
            students = await Get<StudentData>($"{baseurl}/student/remove/{id}");


        
        }
    }
}


