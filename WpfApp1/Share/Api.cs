using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;
using System.Net.Http;
using System.Net;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Xml;

namespace WpfApp1
{
    public static class Api
    {
        public static async Task<string> Post(string username, string password, string service)
        {
            string token = string.Empty;
            string loginService = service + "Login";
            byte[] pwd = Encoding.UTF8.GetBytes(password);
            string encodedPassword = Convert.ToBase64String(pwd, 0, pwd.Length, Base64FormattingOptions.None);
            string loginReq = string.Format("<DM2ContentIndexing_CheckCredentialReq username=\"{0}\" password=\"{1}\" />", username, encodedPassword);

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(loginReq, Encoding.UTF8, "application/xml");
                HttpResponseMessage response = await client.PostAsync(loginService, content);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(responseContent);
                    XmlNode tokenNode = xmlDoc.SelectSingleNode("/DM2ContentIndexing_CheckCredentialResp/@token");
                    if (tokenNode != null)
                    {
                        token = tokenNode.Value;
                    }
                }
                else
                {
                    Debug.WriteLine(string.Format("Login Failed. Status Code: {0}, Status Description: {1}", response.StatusCode, response.ReasonPhrase));
                }
            }

            return token;
        }
    }
}


