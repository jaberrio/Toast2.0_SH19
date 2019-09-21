using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toast2._0_SH19
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void enter_Click(object sender, EventArgs e)
        {
            if (username.Text.Length == 0 || password.Text.Length == 0)
            {
                error.Text = "You must complete both fields";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
