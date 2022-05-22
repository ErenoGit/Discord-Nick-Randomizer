using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Discord_Nick_Randomizer
{
    public class DiscordServer
    {
        public string id { get; set; }
        public string name { get; set; }
        public ulong permissions { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }



        public static List<DiscordServer> GetAllServers()
        {
            var discordServersList = new List<DiscordServer>();

            try
            {
                using (var wc = new WebClient())
                {
                    wc.Headers.Set("Authorization", Form1._apiToken);
                    var response = wc.DownloadString("https://discordapp.com/api/users/@me/guilds");
                    discordServersList = JsonConvert.DeserializeObject<List<DiscordServer>>(response);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while trying to get the server list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            discordServersList = discordServersList.Where(x => Convert.ToBoolean(x.permissions & 67108864) == true).ToList();

            return discordServersList;
        }


        public static async void SetNick(string guildId, string nick)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", Form1._apiToken);
                    client.BaseAddress = new Uri("https://discord.com");

                    var listItemPayload = new Dictionary<string, object>
                    {
                        {"nick", nick}
                    };

                    var requestContent = new StringContent(JsonConvert.SerializeObject(listItemPayload));

                    requestContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    var response = await client.PatchAsync(new Uri($"https://discord.com/api/guilds/{guildId}/members/@me"), requestContent);
                    var data = response.Content.ReadAsStringAsync().Result.ToString();

                    Debug.WriteLine("zwrotka: "+data);

                    if (response.IsSuccessStatusCode == false)
                    {
                        throw (new Exception("An error occurred while trying to set name: " + data));
                    }
                }
            }
            catch (Exception ex)
            {
                throw (new Exception("An error occurred while trying to set name: " + ex.Message));
            }
        }
    }


    public static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri, HttpContent iContent)
        {
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = iContent
            };

            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                response = await client.SendAsync(request);
            }
            catch (TaskCanceledException e)
            {
                throw (new Exception("An error occurred while trying to set name: " + e.Message));
            }

            return response;
        }
    }

}