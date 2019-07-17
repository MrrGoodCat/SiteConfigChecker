using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NiceApplications.SystemAdministrator.Common;

namespace SiteConfigChecker
{
    public partial class MainForm : Form
    {
        public string Token { get; set; }
        public MainForm(string token)
        {
            InitializeComponent();
            this.Size = new Size(734, 330);
            //ConfiguredComponents = new List<ResourceType>();
            //GenerateCheckBox("BSF Basic", 14, 35);
            //GenerateCheckBox("IIS Basic", 14, 54);
            dataGridView1.Rows.Add("http", "", "80", "", "");
            dataGridView1.Rows.Add("net.msmq", "", "", "", "localhost");
            dataGridView1.Rows.Add("msmq.formatname", "", "", "", "localhost");
            dataGridView1.Rows.Add("net.tcp", "", "", "", "808:*");
            dataGridView1.Rows.Add("net.pipe", "", "", "", "*");

            dataGridView2.Rows.Add("Anonymous Authentication", "Enabled", "");
            dataGridView2.Rows.Add("ASP.NET Impersonation", "Disabled", "");
            dataGridView2.Rows.Add("Basic Authentication", "Disabled", "HTTP 401 Challenge");
            dataGridView2.Rows.Add("Digest Authentication", "Disabled", "HTTP 401 Challenge");
            dataGridView2.Rows.Add("Forms Authentication", "Disabled", "HTTP 302 Login/Redirect");
            dataGridView2.Rows.Add("Windows Authentication", "Disabled", "HTTP 401 Challenge");
            Token = token;           
        }

        private CheckBox checkBox;
        List<ResourceType> ConfiguredComponents;

        public void GenerateCheckBox(string text, int locationX, int locationY)
        {
            checkBox = new CheckBox();
            this.checkBox.Text = text;
            this.checkBox.Location = new System.Drawing.Point(locationX, locationY);
            this.checkBox.Size = new System.Drawing.Size(200, 17);
            this.ComponentsPanel.Controls.Add(checkBox);
            this.checkBox.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(734, 900);
            this.tabControl1.Visible = true;
        }
    }
}
