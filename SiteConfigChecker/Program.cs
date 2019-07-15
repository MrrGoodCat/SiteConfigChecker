using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteConfigChecker
{
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
            //Client client;
            DialogResult result;
            string token;
            using (var loginForm = new Login())
            {
                result = loginForm.ShowDialog();
                token = loginForm.Token;
            }
            if (result == DialogResult.OK)
            {
                // login was successful
                Application.Run(new MainForm(token));
            }
            
        }
    }
}
