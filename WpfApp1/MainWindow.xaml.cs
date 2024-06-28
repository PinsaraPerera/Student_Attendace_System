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
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private string service = "http://server:81/SearchSvc/CVWebService.svc/";
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text;
            string passwordbox = txtPassword.Password;


            string token = await Api.Post(username, passwordbox,service);
            if(string.IsNullOrEmpty(token) ) 
            {
                Debug.WriteLine("Login Failed");
                MessageBox.Show("Login failed!");
            }
            else
            {
                Debug.WriteLine("Login Successful");
                MessageBox.Show("Login successful!");
            }




        }

        
    }
    
}