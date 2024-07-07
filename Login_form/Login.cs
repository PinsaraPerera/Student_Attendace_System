using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace Student_Attendace_System.Login_form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void ClosePIcBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void signUpBtn_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            Debug.WriteLine("hi my name is spider man");
            Debug.WriteLine(username + ":" + password);

            string data = await Api.Login(username, password);
            if (data != "")
            {
                MessageBox.Show(data);

                if (data == "successfully logged in!")
                {
                    var dashbord = new Dashbord.Dashbord_window();
                    dashbord.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("something went wrong. Try again later");
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
