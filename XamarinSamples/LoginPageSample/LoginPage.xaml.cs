using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace XamarinSamples
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void LoginButtonPushed(object sender, EventArgs e)
        {
            var result = await Login("test", "testpw");
        }

        private async Task<string> Login(string username, string password)
        {
            string tokenJson = "";
            try
            {
                var client = new HttpClient();
                var content = new StringContent(
                    JsonConvert.SerializeObject(new { username = "myusername", password = "mypass" }));
                var result = await client.PostAsync("http://localhost:8080", content).ConfigureAwait(false);
                if (result.IsSuccessStatusCode)
                {
                    tokenJson = await result.Content.ReadAsStringAsync();
                }

            }
            catch (System.Net.WebException)
            {
                System.Diagnostics.Debug.WriteLine("しっぱい!!");
            }
            return tokenJson;
        }
    }
}
