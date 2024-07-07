using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;
using System.Net.Http;
using System.Net;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Student_Attendace_System.Login_form
{    
    public class Api
    {
        private static readonly string loginURL = "https://fastapi-backend-2meuzsegna-uc.a.run.app/login";

        public async static Task<string> Login(string userName, string pass)
        {
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", userName),
                new KeyValuePair<string, string>("password", pass)
            });

            using (var client = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage res = await client.PostAsync(loginURL, formContent))
                    {
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Status Code: " + res.StatusCode);
                        Console.WriteLine("Response: " + data);

                        if (res.IsSuccessStatusCode)
                        {
                            //return data;  // Return the actual response data
                            return "successfully logged in!";
                        }
                        else
                        {
                            Console.WriteLine("Failed to login. Status Code: " + res.StatusCode);
                            //return string.Empty;
                            return "logging failed!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    //return string.Empty;
                    return "logging failed!";
                }
            }
        }
    }
}


