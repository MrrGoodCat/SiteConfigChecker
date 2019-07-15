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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            DialogResult = DialogResult.OK;

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
