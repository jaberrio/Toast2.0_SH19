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

                                  
         
        private void requestPin_Click(object sender, EventArgs e)
        {
            var ls = new LogicStepper(userName.Text);
                      
            
            if(ls.us.Name == null)
            {           
                error.Text = "The user you have entered is incorrect, please try again";
                return;
            }

            userNamelabel.Text = ls.us.Name;
            
            followers.Text = "Followers: " + ls.us.FollowersCount.ToString();
            following.Text = "Following: " + ls.us.FriendsCount.ToString();

            var tweets = ls.getTweets();

            pictureBox.Image = ls.getPicture();
            pictureBox.Update();
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BorderStyle = BorderStyle.None;

            listView1.Items.Clear();

            int tweetCount = 0;

            tweets = ls.getTweets();        

            foreach (var item in tweets)
            {
                tweetCount++;
                listView1.Items.Add(item.Text);
            }
            
            tweetNum.Text = "# of tweets calculated: " + tweetCount;
            Analyze a = new Analyze();
            var z = a.getPersonalities(tweets);
            double _tval = 0;

            foreach (var item in a.getListViewStringTop())
            {
                listView5.Items.Add(item);
            }
            

            listView2.Items.Clear();
            listView3.Items.Clear();

            var followersHave = ls.us.GetFollowers(10);
            var followingHave = ls.us.GetFriends(10);

            foreach (var item in followersHave)
                listView2.Items.Add(item.ScreenName);

            foreach (var item in followingHave)
                listView3.Items.Add(item.ScreenName);
            
            
            var emoLabel = new Label[] { joyLabel, fearLabel, disgustLabel, surpriseLabel, sadnessLabel, angerLabel };
            var bigLabel = new Label[] { neuroticLabel, agreeableLabel, openLabel, extrovertLabel, conscientiousLabel };

            
            

            chart1.Series["Data1"].Points.Clear();
            chart2.Series["Data2"].Points.Clear();

            for (int i = 0; i < Const.bigS.Length; i++)
            {
                z.TryGetValue(Const.bigS[i], out _tval);
                chart2.Series["Data2"].Points.AddXY(i, _tval);
                bigLabel[i].Text = Const.bigS[i] + ": " + _tval;
            }


            for (int i = 0; i < Const.emoS.Length; i++)
            {
                z.TryGetValue(Const.emoS[i], out _tval);
                chart1.Series["Data1"].Points.AddXY(i, _tval);
                emoLabel[i].Text = Const.emoS[i] + ": " + _tval;
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
