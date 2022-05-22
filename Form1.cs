using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Discord_Nick_Randomizer
{
    public partial class Form1 : Form
    {
        public static string _apiToken;

        public static bool _enabled = false;
        public static int countNicks = 0;
        public static int secondsDelayCount = 0;

        public static string _guildId;
        public static int _secondsDelay;
        public static string[] _nicks;
        public static bool _sequence;

        private static Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while(true)
                {
                    if(_enabled)
                    {
                        secondsDelayCount--;
                        if(secondsDelayCount <= 0)
                        {
                            if(_sequence)
                            {
                                if (countNicks == _nicks.Count())
                                    countNicks = 0;

                                Program.SetNick(_guildId, _nicks[countNicks]);
                                countNicks++;
                            }
                            else
                            {
                                var random = _rand.Next(0, _nicks.Count());
                                Program.SetNick(_guildId, _nicks[random]);
                            }
                            secondsDelayCount = _secondsDelay;
                        }
                    }

                    Thread.Sleep(1000);
                }
            }).Start();
        }

        private void btnApplyToken_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textToken.Text))
            {
                MessageBox.Show("API token field cannot be empty!");
                return;
            }

            _apiToken = textToken.Text;

            var discordServersList = Program.GetAllServers();

            dataGridServers.Rows.Clear();
            foreach (var discordServer in discordServersList.ToList())
            {
                dataGridServers.Rows.Add(discordServer.id, discordServer.name);
                dataGridServers.Refresh();
            }

            if (dataGridServers.Rows.Count > 0)
                btnStartStop.Enabled = true;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_enabled)
            {
                _enabled = false;
                btnStartStop.Text = "Start!";
                status.Text = "Status: Stopped";
                ToggleUi(true);
            }
            else
            {
                if (dataGridServers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("You have to select row from server list!");
                    return;
                }

                DataGridViewRow selectedRow = dataGridServers.SelectedRows[0];

                _secondsDelay = (int)Math.Floor(numericSecondsChange.Value);
                
                if (_secondsDelay <= 0)
                {
                    MessageBox.Show("Number of seconds must be greater than 0!");
                    return;
                }

                secondsDelayCount = _secondsDelay;
                _guildId = selectedRow.Cells[0].Value.ToString();
                _nicks = textListOfNicks.Lines.Where(x => !String.IsNullOrEmpty(x) && x.Length < 32).ToArray();
                _sequence = checkBoxSequence.Checked;
                _enabled = true;
                btnStartStop.Text = "Stop!";
                status.Text = "Status: Started";
                countNicks = 0;
                ToggleUi(false);
            }
        }

        private void ToggleUi(bool toggle)
        {
            textToken.Enabled = toggle;
            btnApplyToken.Enabled = toggle;
            dataGridServers.Enabled = toggle;
            textListOfNicks.Enabled = toggle;
            checkBoxSequence.Enabled = toggle;
            numericSecondsChange.Enabled = toggle;
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}
