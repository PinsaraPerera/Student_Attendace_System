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
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Password;

            Debug.WriteLine("hi my name is spider man");
            Debug.WriteLine(username + ":" + password);

            string data = await Api.Login(username, password);
            if(data != "") 
            {
                MessageBox.Show(data);
            }
            else
            {
                MessageBox.Show("something went wrong. Try again later");
            }
        }

        
    }
    
}