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
using static DashBord.STudent;

namespace DashBord
{
    public partial class AddLecture : UserControl
    {
        private List<LectureData>lecture  = new List<LectureData>();

        public AddLecture()
        {
            InitializeComponent();
            Load += new EventHandler(Lecture_Load);

        }
        public static readonly string baseurl = "https://fastapi-backend-2meuzsegna-uc.a.run.app/subject/getAll";

        public static async Task<List<LectureData>> Get()
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
                                var lecture = JsonConvert.DeserializeObject<List<LectureData>>(data);
                                return lecture;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return new List<LectureData>();
        }
        private async void Lecture_Load(object sender, EventArgs e)
        {
             lecture = await Get();
            dataGridView2.DataSource = lecture;
        }


        public class LectureData
        {
            public string subject_code { get; set; }
            public string subject_name { get; set; }
            public string degree { get; set; }
            public int year { get; set; }
        }

        private void search_txtBox_Enter(object sender, EventArgs e)
        {
            if (search_txtBox.Text == "")
            {
                search_txtBox.Text = "CSCI22042";
                search_txtBox.ForeColor = Color.Black;
                search_txtBox.Font = new Font(search_txtBox.Font, FontStyle.Regular);

            }
        }

        private void search_txtBox_Leave(object sender, EventArgs e)
        {
            if (search_txtBox.Text == "")
            {
                search_txtBox.Text = "CSCI22042";
                search_txtBox.ForeColor = Color.Silver;
                search_txtBox.Font = new Font(search_txtBox.Font, FontStyle.Italic);
            }
        }
        private void showAll_btn_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = lecture;
            search_txtBox.Text = string.Empty;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string sub_code = search_txtBox.Text;
            var filteredStudents = lecture.Where(s => s.subject_code.Equals(sub_code, StringComparison.OrdinalIgnoreCase)).ToList();
            dataGridView2.DataSource = filteredStudents;

        }
    }
}
