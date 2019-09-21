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
            followers.Text = "Followers: " + us.FollowersCount.ToString();
            following.Text = "Following: " + us.FriendsCount.ToString();

            var utp = new UserTimelineParameters
            {
                MaximumNumberOfTweetsToRetrieve = 1000
            };

            var tweets = Timeline.GetUserTimeline(us, utp);
            
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(us.ProfileImageUrlFullSize);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            pictureBox.Image = img;
            pictureBox.Update();
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BorderStyle = BorderStyle.None;

            foreach (var item in tweets)
            {
                listView1.Items.Add(item.Text);
            }
            


            Analyze a = new Analyze();
            a.AnalyzeList(tweets, us);
            

        }

        private void pin_TextChanged(object sender, EventArgs e)
        {

        }

        private void followers_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        Point mouseDownPoint = Point.Empty;
        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }
        bool isMove = false;
        private void LogIn_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (mouseDownPoint.IsEmpty)
            {
                isMove = false;
                return;
            }
            else if (e.Y < 30)
            {
                isMove = true;
            }
            if(isMove)
            {
                Form f = sender as Form;
                f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
            }
         }

        private void LogIn_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Image temp = new Bitmap("Photos/-22.png");
            this.pictureBox2.BackgroundImage = temp;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Image temp = new Bitmap("Photos/-.png");
            this.pictureBox2.BackgroundImage = temp;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Image temp = new Bitmap("Photos/x22.png");
            this.pictureBox1.BackgroundImage = temp;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Image temp = new Bitmap("Photos/x2.png");
            this.pictureBox1.BackgroundImage = temp;
        }

        private void sadnessLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
