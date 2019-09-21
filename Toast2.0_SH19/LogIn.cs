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

            listView1.Items.Clear();

            foreach (var item in tweets)
            {
                listView1.Items.Add(item.Text);
            }
        
            Analyze a = new Analyze();
            var z = a.AnalyzeList(tweets, us);
            joyLabel.Text = "Joy: " + z.joy;
            fearLabel.Text = "Fear: " + z.fear;
            disgustLabel.Text = "Disgust: " + z.disgust;
            surpriseLabel.Text = "Surprise: " + z.surprise;
            sadnessLabel.Text = "Sadness: " + z.sadness;
            angerLabel.Text = "Anger: " + z.anger;



            chart1.Series["Data1"].Points.Clear();



            chart1.Series["Data1"].Points.Add(0, z.joy);
            chart1.Series["Data1"].Points.Add(1, z.fear);
            chart1.Series["Data1"].Points.Add(2, z.disgust);
            chart1.Series["Data1"].Points.Add(3, z.surprise);
            chart1.Series["Data1"].Points.Add(4, z.sadness);
            chart1.Series["Data1"].Points.Add(5, z.anger);

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
            this.pictureBox2.BackgroundImage = temp;
        }
            Image temp = new Bitmap("Photos/-22.png");
            Image temp3 = new Bitmap("Photos/-.png");
            Image temp2 = new Bitmap("Photos/x22.png");
            Image temp1 = new Bitmap("Photos/x2.png");

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.BackgroundImage = temp3;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = temp2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = temp1;
        }

        private void sadnessLabel_Click(object sender, EventArgs e)
        {

        }

        private void surpriseLabel_Click(object sender, EventArgs e)
        {

        }

        private void angerLabel_Click(object sender, EventArgs e)
        {

        }

        private void joyLabel_Click(object sender, EventArgs e)
        {

        }

        private void fearLabel_Click(object sender, EventArgs e)
        {

        }

        private void disgustLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
