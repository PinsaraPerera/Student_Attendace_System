using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using ClassLibrary2;


namespace DashBord
{
    public partial class AddTeacher : UserControl
    {
        public AddTeacher()
        {
            InitializeComponent(); //Store result of API convertion in obj
        }
        Class1.Rootobject obj;
        private void button1_Click(object sender, EventArgs e)
        {
            string teacher_Id = textBox2.Text;

            Console.WriteLine("Teacher ID: " + teacher_Id);
        }

        private void getData()
        {
            //call the API
            //use RestSharp
            //Source :'https://fastapi-backend-2meuzsegna-uc.a.run.app/student/cs_2020_005' 
            // var apikey = "hfdg";

          
         
                var client = new RestClient("https://fastapi-backend-2meuzsegna-uc.a.run.app/student/");
                var request = new RestRequest("cs_2020_005", Method.Get);
                // request.AddHeader("Authorization", $"Bearer {apikey}");

                var response = client.ExecuteGet(request);
                Console.WriteLine(response.Content);
               // MessageBox.Show(response.Content);
                Console.WriteLine(response.StatusCode);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string rawResponse = response.Content;
                    //convert the raw DATA TO JSON
                    obj = JsonConvert.DeserializeObject<Class1.Rootobject>(rawResponse);
                    //display the data
                    if (obj != null)
                    {
                        var dataList = new List<Class1.Data> { obj.data };
                        //MessageBox.Show("Data Fetched Successfully");
                        // textBox1.Text = obj.data.employee_name;
                        /*if (!string.IsNullOrEmpty(obj.data.student_name))
                        {
                           
                        }
                        else
                        {

                        }*/
                        //textBox3.Text = obj.data.employee_age.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error in API call 2 ");
                    }
                }
                else
                {
                    MessageBox.Show("Error in API call:");
                }
            
            /*catch (Exception ex)
            {

                MessageBox.Show($"Exception occurred: {ex.Message}");
            }*/
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
