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
    public partial class MainForm : Form
    {
        public string Token { get; set; }
        public MainForm(string token)
        {
            InitializeComponent();
            Token = token;
        }
    }
}
