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
using static Student_Attendace_System.Dashbord.AddTeacher;

namespace Student_Attendace_System.Dashbord
{
    public partial class Home_panel : UserControl
    {
        public Home_panel()
        {
            InitializeComponent();
            LoadTeacherCount();
        }

        public static readonly string baseurl = "https://university-backend-es4ftzjzmq-uc.a.run.app";

        public static async Task<int> GetTeachersCount()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"{baseurl}/teacher/getAll";
                    using (HttpResponseMessage res = await client.GetAsync(url))
                    {
                            res.EnsureSuccessStatusCode();
                            string data = await res.Content.ReadAsStringAsync();
                            if (!string.IsNullOrEmpty(data))
                            {
                                var teacher = JsonConvert.DeserializeObject<List<TeacherData>>(data);
                                return teacher?.Count ?? 0;
                            }
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                    return 0 ;
            }
        }

        public class TeacherData
        {
            public string department { get; set; }
            public string email { get; set; }
            public int id { get; set; }
            public string name { get; set; }
        }

        private async void LoadTeacherCount()
        {
            int count = await GetTeachersCount();
            teacherCount.Text = count.ToString(); 
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Home_panel_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }


        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void atendance_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lecture_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teacherCount_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
