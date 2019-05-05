using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MD5_Tool
{
    public partial class Main : Form
    {
        private bool stm = true;

        public string baseaddress = "https://md5.gromweb.com/?";
        public string md5query = "md5=";
        public string stringquery = "string=";
        public string proxy1 = "http://46.101.37.48:3128";
        public string proxy2 = "http://134.209.21.48:3128";
        public string proxy3 = "http://188.166.145.121:3128";

        public async Task StringToMD5()
        {
            startButton.Enabled = false;
            md5Box.ReadOnly = true;
            stringBox.ReadOnly = true;
            md5Box.Text = "";
            string[] newArray = stringBox.Text.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            int i = 0;
            int j = 0;
            foreach (var str in newArray)
            {
                string url = baseaddress + stringquery + newArray[i];
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = @"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.0.4) Gecko/20060508 Firefox/1.5.0.4";
                if (j >= 9)
                {
                    WebProxy newProxy = new WebProxy();
                    Uri newuri = new Uri(proxy1);
                    newProxy.Address = newuri;
                    request.Proxy = newProxy;
                }
                if (j >= 18)
                {
                    WebProxy newProxy = new WebProxy();
                    Uri newuri = new Uri(proxy2);
                    newProxy.Address = newuri;
                    request.Proxy = newProxy;
                }
                if (j >= 27)
                {
                    WebProxy newProxy = new WebProxy();
                    Uri newuri = new Uri(proxy3);
                    newProxy.Address = newuri;
                    request.Proxy = newProxy;
                }
                if (j == 36)
                { 
                    request.Proxy = null;
                    j = 0;
                }
                HttpWebResponse response = null;
                await Task.Delay(1000);
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (System.Net.WebException ex)
                {
                    response = null;
                    md5Box.Text = md5Box.Text + ex.Message;
                    startButton.Enabled = true;
                    md5Box.ReadOnly = false;
                    stringBox.ReadOnly = false;
                    return;
                }
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    string data = readStream.ReadToEnd();
                    Regex rx = new Regex(@"""long-content hash"">(\S+)</em><");
                    MatchCollection matches = rx.Matches(data);
                    string Out = Convert.ToString(matches[0].Groups[1]);
                    md5Box.Text = md5Box.Text + Out + Environment.NewLine;
                    response.Close();
                    readStream.Close();
                    i++;
                    j++;
                    startButton.Enabled = true;
                    md5Box.ReadOnly = false;
                    stringBox.ReadOnly = false;
                }
            }
            return;
        }
        public async Task MD5ToString()
        {
            startButton.Enabled = false;
            md5Box.ReadOnly = true;
            stringBox.ReadOnly = true;
            stringBox.Text = "";
            string[] newArray = md5Box.Text.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            int i = 0;
            int j = 0;
            foreach (var str in newArray)
            {
                string url = baseaddress + md5query + newArray[i];
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = @"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.0.4) Gecko/20060508 Firefox/1.5.0.4";
                if (j >= 9)
                {
                    WebProxy newProxy = new WebProxy();
                    Uri newuri = new Uri(proxy1);
                    newProxy.Address = newuri;
                    request.Proxy = newProxy;
                }
                if (j >= 18)
                {
                    WebProxy newProxy = new WebProxy();
                    Uri newuri = new Uri(proxy2);
                    newProxy.Address = newuri;
                    request.Proxy = newProxy;
                }
                if (j >= 27)
                {
                    WebProxy newProxy = new WebProxy();
                    Uri newuri = new Uri(proxy3);
                    newProxy.Address = newuri;
                    request.Proxy = newProxy;
                }
                if (j == 36)
                {
                    request.Proxy = null;
                    j = 0;
                }
                HttpWebResponse response = null;
                await Task.Delay(1000);
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (System.Net.WebException ex)
                {
                    response = null;
                    md5Box.Text = md5Box.Text + ex.Message;
                    startButton.Enabled = true;
                    md5Box.ReadOnly = false;
                    stringBox.ReadOnly = false;
                    return;
                }

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    string data = readStream.ReadToEnd();
                    Regex rx = new Regex(@"""long-content string"">(\S+)</em><");
                    MatchCollection matches = rx.Matches(data);
                    string Out = Convert.ToString(matches[0].Groups[1]);
                    stringBox.Text = stringBox.Text + Out + Environment.NewLine;
                    response.Close();
                    readStream.Close();
                    i++;
                    j++;
                    startButton.Enabled = true;
                    md5Box.ReadOnly = false;
                    stringBox.ReadOnly = false;
                }

            }
            return;
        }
        public void ProxyPrompt()
        {
            Form prompt = new Form()
            {
                Width = 334,
                Height = 253,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                ControlBox = false,
                Text = "Proxy List",
                StartPosition = FormStartPosition.CenterParent,
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.Color.Lime
            };
            TextBox proxy1box = new TextBox()
            {
                Text = proxy1,
                Enabled = false,
                Left = 25,
                Top = 26,
                Width = 163,
                Height = 20,
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.Color.Lime
            };
            TextBox proxy2box = new TextBox()
            {
                Text = proxy2,
                Enabled = false,
                Left = 25,
                Top = 82,
                Width = 163,
                Height = 20,
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.Color.Lime
            };
            TextBox proxy3box = new TextBox()
            {
                Text = proxy3,
                Enabled = false,
                Left = 25,
                Top = 136,
                Width = 163,
                Height = 20,
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.Color.Lime
            };
            CheckBox custom1 = new CheckBox()
            {
                Left = 194,
                Top = 29,
                Width = 99,
                Height = 17,
                Text = "Custom Proxy 1",
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.Color.Lime
            };
            CheckBox custom2 = new CheckBox()
            {
                Left = 194,
                Top = 85,
                Width = 99,
                Height = 17,
                Text = "Custom Proxy 2",
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.Color.Lime
            };
            CheckBox custom3 = new CheckBox()
            {
                Left = 194,
                Top = 139,
                Width = 99,
                Height = 17,
                Text = "Custom Proxy 3",
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.Color.Lime
            };
            Button revert = new Button()
            {
                Left = 80,
                Width = 75,
                Top = 179,
                Height = 23,
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.Color.Lime,
                DialogResult = DialogResult.Yes,
                Text = "Revert"
            };
            Button done = new Button()
            {
                Left = 161,
                Width = 75,
                Top = 179,
                Height = 23,
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.Color.Lime,
                DialogResult = DialogResult.No,
                Text = "Done"
            };
            revert.Click += (sender, e) => {
                proxy1 = "http://46.101.37.48:3128";
                proxy2 = "http://134.209.21.48:3128";
                proxy3 = "http://188.166.145.121:3128";
            };
            done.Click += (sender, e) => {
                if (custom1.Checked)
                {
                    proxy1 = proxy1box.Text;
                }
                if (custom2.Checked)
                {
                    proxy2 = proxy2box.Text;
                }
                if (custom3.Checked)
                {
                    proxy3 = proxy3box.Text;
                }
            };
            custom1.CheckStateChanged += (sender, e) => {
                if (custom1.Checked) { proxy1box.Enabled = true; }
                else { proxy1box.Enabled = false; } };
            custom2.CheckStateChanged += (sender, e) => {
                if (custom2.Checked) { proxy2box.Enabled = true; }
                else { proxy2box.Enabled = false; } };
            custom3.CheckStateChanged += (sender, e) => {
                if (custom3.Checked) { proxy3box.Enabled = true; }
                else { proxy3box.Enabled = false; } };
            prompt.Controls.Add(proxy1box);
            prompt.Controls.Add(proxy2box);
            prompt.Controls.Add(proxy3box);
            prompt.Controls.Add(custom1);
            prompt.Controls.Add(custom2);
            prompt.Controls.Add(custom3);
            prompt.Controls.Add(revert);
            prompt.Controls.Add(done);
            var result = prompt.ShowDialog();
            if (result == DialogResult.Yes)
            {
                prompt.Close();
                return;
            }
            else if (result == DialogResult.No)
            {
                prompt.Close();
                return;
            }
            return;
        }
        //Init
        public Main()
        {
            InitializeComponent();
        }
        //Open Files
        private void stringFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = "c:\\";
            openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openDialog.FilterIndex = 1;
            openDialog.RestoreDirectory = true;
            var ret = openDialog.ShowDialog();
            if (ret == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openDialog.OpenFile()) != null)
                    {
                        stringBox.Text = File.ReadAllText(openDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!: " + ex.Message);
                }
            }
        }
        private void mD5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = "c:\\";
            openDialog.Filter = "hsh files (*.hsh)|*.hsh|All files (*.*)|*.*";
            openDialog.FilterIndex = 1;
            openDialog.RestoreDirectory = true;
            var ret = openDialog.ShowDialog();
            if (ret == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openDialog.OpenFile()) != null)
                    {
                        md5Box.Text = File.ReadAllText(openDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!: " + ex.Message);
                }
            }
        }
        //Save Files
        private void stringBox_TextChanged(object sender, EventArgs e)
        {
            if (stringBox.Text.Length != 0)
            {
                startButton.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                stringOutputtxtToolStripMenuItem.Enabled = true;
            }
            else
            {
                stringOutputtxtToolStripMenuItem.Enabled = false;
            }
            if (stringBox.Text.Length == 0 && md5Box.Text.Length == 0)
            {
                saveToolStripMenuItem.Enabled = false;
                startButton.Enabled = false;
            }
        }
        private void md5Box_TextChanged(object sender, EventArgs e)
        {
            if (md5Box.Text.Length != 0)
            {
                startButton.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                mD5OutputhshToolStripMenuItem.Enabled = true;
            }
            else
            {
                mD5OutputhshToolStripMenuItem.Enabled = false;
            }
            if (stringBox.Text.Length == 0 && md5Box.Text.Length == 0)
            {
                saveToolStripMenuItem.Enabled = false;
                startButton.Enabled = false;
            }
        }
        private void stringOutputtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = "c:\\";
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;
            var ret = saveDialog.ShowDialog();
            if (ret == DialogResult.OK)
            {
                try
                {
                    if (saveDialog.FileName != "")
                    {
                        using (StreamWriter sw = new StreamWriter(saveDialog.OpenFile()))
                        {
                            sw.Write(stringBox.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!: " + ex.Message);
                }
            }
        }
        private void mD5OutputhshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = "c:\\";
            saveDialog.Filter = "hsh files (*.hsh)|*.hsh|All files (*.*)|*.*";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;
            var ret = saveDialog.ShowDialog();
            if (ret == DialogResult.OK)
            {
                try
                {
                    if (saveDialog.FileName != "")
                    {
                        using (StreamWriter sw = new StreamWriter(saveDialog.OpenFile()))
                        {
                            sw.Write(md5Box.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!: " + ex.Message);
                }
            }
        }
        //Close Button
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Operation Buttons
        private void stringToMd5Button_Click(object sender, EventArgs e)
        {
            stringToMd5Button.BackColor = Color.Lime;
            stringToMd5Button.ForeColor = Color.Black;
            md5ToStringButton.BackColor = Color.Black;
            md5ToStringButton.ForeColor = Color.Lime;
            stm = true;
        }
        private void md5ToStringButton_Click(object sender, EventArgs e)
        {
            stringToMd5Button.BackColor = Color.Black;
            stringToMd5Button.ForeColor = Color.Lime;
            md5ToStringButton.BackColor = Color.Lime;
            md5ToStringButton.ForeColor = Color.Black;
            stm = false;
        }
        //Start Buttons
        private void startButton_Click(object sender, EventArgs e)
        {
            if (stm == false)
            {
                MD5ToString();
            }
            else
            {
                StringToMD5();
            }
        }
        private void startButton_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.ForeColor = btn.Enabled ? Color.Lime : Color.Gray;
        }
        private void startButton_Paint(object sender, PaintEventArgs e)
        {
            var btn = (Button)sender;
            var drawBrush = new SolidBrush(btn.ForeColor);
            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            startButton.Text = string.Empty;
            e.Graphics.DrawString("Start", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }
        //Proxy List
        private void proxyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProxyPrompt();
        }
    }
}
