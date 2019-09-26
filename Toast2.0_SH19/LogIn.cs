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
                MaximumNumberOfTweetsToRetrieve = 300
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
            int tweetCount = 0;
            if (tweets.Count<ITweet>() == 0) return;
            foreach (var item in tweets)
            {
                tweetCount++;
                listView1.Items.Add(item.Text);
            }
            tweetNum.Text = "# of tweets calculated: " + tweetCount;
            Analyze a = new Analyze();
            var z = a.getPersonalities(tweets, us);
            double _tval = 0;

            foreach (var item in a.getListViewStringTop())
            {
                listView5.Items.Add(item);
            }
            var emoS = new string[] { "Joy", "Fear", "Disgust", "Surprise", "Sadness", "Anger" };
            var bigS = new string[] { "Neurotic", "Agreeable", "Open", "Extroverted", "Conscientious" };


            chart2.Series["Data2"].Points.Clear();
            for (int i = 0; i < bigS.Length; i++)
            {
            z.TryGetValue(bigS[i], out _tval);
            chart2.Series["Data2"].Points.AddXY(i, _tval);
            }

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
                                    


            z.TryGetValue("Neurotic", out _tval);
            neuroticLabel.Text = "Neurotic: " + _tval;

            z.TryGetValue("Agreeable", out _tval);
            agreeableLabel.Text = "Agreeable: " + _tval;

            z.TryGetValue("Open", out _tval);
            openLabel.Text = "Open: " + _tval;

            z.TryGetValue("Extrovert", out _tval);
            extrovertLabel.Text = "Extrovert: " + _tval;

            z.TryGetValue("Conscientious", out _tval);
            Conscientious.Text = "Conscientious: " + _tval;
                        

            chart1.Series["Data1"].Points.Clear();
            for (int i = 0; i < emoS.Length; i++)
            {
                z.TryGetValue(emoS[i], out _tval);
                chart1.Series["Data1"].Points.AddXY(i, _tval);
            }
            
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
            z.TryGetValue("Positivity", out _tval);
            if (_tval < 0)
            {
                posotiveBar.Value = 0;
                negativeBar.Value = (int)(-1 * _tval);
            }
            else
            {
                negativeBar.Value = 0;
                posotiveBar.Value = (int)_tval;
            }

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
        bool isMove = false;

        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }
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
                                 
        Image temp = new Bitmap("Photos/-22.png");
        Image temp3 = new Bitmap("Photos/-.png");
        Image temp2 = new Bitmap("Photos/x22.png");
        Image temp1 = new Bitmap("Photos/x2.png");

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = temp2;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = temp1;
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.BackgroundImage = temp;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.BackgroundImage = temp3;
        }
          
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void pin_TextChanged(object sender, EventArgs e)
        {

        }
        private void joyLabel_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
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
        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void enter_Click(object sender, EventArgs e)
        {

        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }
        private void chart3_Click(object sender, EventArgs e)
        {

        }
        private void followers_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void negativeBar_Click(object sender, EventArgs e)
        {

        }
        private void title_Click(object sender, EventArgs e)
        {

        }
                      
    }
}
