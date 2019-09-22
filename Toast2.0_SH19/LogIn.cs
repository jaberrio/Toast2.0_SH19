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
        
        ITwitterCredentials appCreds = Auth.SetApplicationOnlyCredentials("eGr9HEC4100Ru5ysWQC4JtODI", "xsYHSKZ54y9cgl1zwq4L21FXgrAj5bzkMWjBk0BdLhLRyiiIiT", true);

        private void requestPin_Click(object sender, EventArgs e)
        {
            var us = User.GetUserFromScreenName(userName.Text);
            try
            {
                label1.Text = us.Name;
                error.Text = "";
            }
            catch (Exception r)
            {
                error.Text = "The user you have entered is incorrect, please try again";
                return;
            }


            followers.Text = "Followers: " + us.FollowersCount.ToString();
            following.Text = "Following: " + us.FriendsCount.ToString();

            var utp = new UserTimelineParameters
            {
                MaximumNumberOfTweetsToRetrieve = 1500
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
            var z = a.getPersonaities(tweets, us);
            double _tval = 0;


     
            chart2.Series["Data2"].Points.Clear();
            z.TryGetValue("Neurotic", out _tval);
            chart2.Series["Data2"].Points.AddXY(0, _tval);
            z.TryGetValue("Agreeable", out _tval);
            chart2.Series["Data2"].Points.AddXY(1, _tval);
            z.TryGetValue("Open", out _tval);
            chart2.Series["Data2"].Points.AddXY(2, _tval);
            z.TryGetValue("Extrovert", out _tval);
            chart2.Series["Data2"].Points.AddXY(3, _tval);
            z.TryGetValue("Conscientious", out _tval);
            chart2.Series["Data2"].Points.AddXY(4, _tval);

            var followersHave = User.GetFollowers(us,250);
            z.TryGetValue("Joy", out _tval);
            joyLabel.Text = "Joy: " + _tval;
            
            z.TryGetValue("Fear", out _tval);
            fearLabel.Text = "Fear: " + _tval;
            
            z.TryGetValue("Disgust", out _tval);
            disgustLabel.Text = "Disgust: " + _tval;
            
            z.TryGetValue("Surprise", out _tval);
            surpriseLabel.Text = "Surprise: " + _tval;

            z.TryGetValue("Sadness", out _tval);
            sadnessLabel.Text = "Sadness: " + _tval;

            z.TryGetValue("Anger", out _tval);
            angerLabel.Text = "Anger: " + _tval;



            chart1.Series["Data1"].Points.Clear();

            z.TryGetValue("Joy", out _tval);
            chart1.Series["Data1"].Points.AddXY(0, _tval);
            z.TryGetValue("Fear", out _tval);
            chart1.Series["Data1"].Points.AddXY(1, _tval);
            z.TryGetValue("Disgust", out _tval);
            chart1.Series["Data1"].Points.AddXY(2, _tval);
            z.TryGetValue("Surprise", out _tval);
            chart1.Series["Data1"].Points.AddXY(3, _tval);
            z.TryGetValue("Sadness", out _tval);
            chart1.Series["Data1"].Points.AddXY(4, _tval);
            z.TryGetValue("Anger", out _tval);
            chart1.Series["Data1"].Points.AddXY(5, _tval);


            listView2.Items.Clear();

            foreach (var item in followersHave)
            {
                listView2.Items.Add(item.ScreenName);
            }
            var followingHave = User.GetFriends(us, 1000);

            listView3.Items.Clear();
            foreach (var item in followingHave)
            {
                listView3.Items.Add(item.ScreenName);
            }
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
            if (isMove)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
