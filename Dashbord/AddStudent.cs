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
using Newtonsoft.Json;


namespace Student_Attendace_System.Dashbord
{
    public partial class AddStudent : UserControl
    {
        private List<StudentData> students = new List<StudentData>();
        public AddStudent()
        {
            InitializeComponent();
            Load += new EventHandler(STudent_Load);
        }
        public static readonly string baseurl = "https://fastapi-backend-2meuzsegna-uc.a.run.app/student/getAll";

        public static async Task<List<StudentData>> Get()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseurl))
                    {
                        using (HttpContent resContent = res.Content)
                        {
                            string data = await resContent.ReadAsStringAsync();
                            if (!string.IsNullOrEmpty(data))
                            {
                                var students = JsonConvert.DeserializeObject<List<StudentData>>(data);
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
            return new List<StudentData>();
        }
        private async void STudent_Load(object sender, EventArgs e)
        {
            students = await Get();
            dataGridView1.DataSource = students;
        }

        /*private  async void search_btn_Click(object sender, EventArgs e)
        {
            string student_Id = search_txtBox.Text;

            Console.WriteLine("Student ID: " + student_Id);

            var filteredStudents = students.Where(s => s.student_no.Equals(student_Id, StringComparison.OrdinalIgnoreCase)).ToList();
            dataGridView1.DataSource = filteredStudents;

            //     var respone = await Post(student_Id);
        }*/
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
            dataGridView1.DataSource = students;
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
    }
}
