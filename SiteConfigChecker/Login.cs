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

            appServerLocation = sysAdminLocationTextBox.Text;
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            Client client;
            try
            {
                client = new Client(appServerLocation, username, password);
                Token = client.tokenWithID;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Login Failed \n {0}\n {1}",ex.Message, ex.ToString()));
            }

            //if (User.Login(username, password))
            //{
            //    Globals._Login = true;

            //    // Close login form
            //    this.Dispose(false);

            //}
            //else
            //{
            //    MessageBox.Show("Login Failed");
            //}

        }
    }
}
