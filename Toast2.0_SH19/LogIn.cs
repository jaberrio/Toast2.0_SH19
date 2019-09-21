using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;
using System.Net;
using System.IO;
using Tweetinvi.Parameters;

namespace Toast2._0_SH19
{
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void enter_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void requestPin_Click(object sender, EventArgs e)
        {
            var appCreds = Auth.SetApplicationOnlyCredentials("eGr9HEC4100Ru5ysWQC4JtODI", "xsYHSKZ54y9cgl1zwq4L21FXgrAj5bzkMWjBk0BdLhLRyiiIiT", true);


            var us = User.GetUserFromScreenName(userName.Text);

            label1.Text = us.Name;

            var utp = new UserTimelineParameters
            {
                MaximumNumberOfTweetsToRetrieve = 100
            };

            var tweets = Timeline.GetUserTimeline(us, utp);
            
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(us.ProfileImageUrlFullSize);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            pictureBox.Image = img;
            pictureBox.Update();
        }

        private void pin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
