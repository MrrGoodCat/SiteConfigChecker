using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteConfigChecker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string Token;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string appServerLocation;
            string username;
            string password;
            string domain;

            appServerLocation = sysAdminLocationTextBox.Text;
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            domain = domainTextBox.Text;
            Client client;
            try
            {
                if (adAuthCheckBox.Checked)
                {
                    client = new Client(appServerLocation, username, password, domain);
                }
                else
                {
                    client = new Client(appServerLocation, username, password);
                }
                
                Token = client.tokenWithID;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Login Failed \n {0}\n {1}",ex.Message, ex.ToString()));
            }

        }

        private void adAuthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (adAuthCheckBox.Checked)
            {
                domainTextBox.Enabled = true;
            }
            else
            {
                domainTextBox.Enabled = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
