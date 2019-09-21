namespace Toast2._0_SH19
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.userName = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.requestPin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tweets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.followers = new System.Windows.Forms.Label();
            this.following = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.joyLabel = new System.Windows.Forms.Label();
            this.fearLabel = new System.Windows.Forms.Label();
            this.disgustLabel = new System.Windows.Forms.Label();
            this.sadnessLabel = new System.Windows.Forms.Label();
            this.surpriseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(46, 187);
            this.userName.Margin = new System.Windows.Forms.Padding(8);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(374, 38);
            this.userName.TabIndex = 2;
            this.userName.TextChanged += new System.EventHandler(this.pin_TextChanged);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(570, 599);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 32);
            this.error.TabIndex = 5;
            this.error.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // requestPin
            // 
            this.requestPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.requestPin.Location = new System.Drawing.Point(41, 234);
            this.requestPin.Margin = new System.Windows.Forms.Padding(12);
            this.requestPin.Name = "requestPin";
            this.requestPin.Size = new System.Drawing.Size(376, 72);
            this.requestPin.TabIndex = 6;
            this.requestPin.Text = "Search Person";
            this.requestPin.UseVisualStyleBackColor = false;
            this.requestPin.Click += new System.EventHandler(this.requestPin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "User";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(17, 461);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 399);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tweets});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(520, 461);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(900, 399);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Tweets
            // 
            this.Tweets.Text = "Tweets";
            this.Tweets.Width = 900;
            // 
            // followers
            // 
            this.followers.AutoSize = true;
            this.followers.Location = new System.Drawing.Point(40, 374);
            this.followers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.followers.Name = "followers";
            this.followers.Size = new System.Drawing.Size(152, 32);
            this.followers.TabIndex = 12;
            this.followers.Text = "Followers: ";
            this.followers.Click += new System.EventHandler(this.followers_Click);
            // 
            // following
            // 
            this.following.AutoSize = true;
            this.following.Location = new System.Drawing.Point(40, 421);
            this.following.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.following.Name = "following";
            this.following.Size = new System.Drawing.Size(152, 32);
            this.following.TabIndex = 13;
            this.following.Text = "Following: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1571, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 66);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1437, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 66);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // joyLabel
            // 
            this.joyLabel.AutoSize = true;
            this.joyLabel.Location = new System.Drawing.Point(1477, 597);
            this.joyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.joyLabel.Name = "joyLabel";
            this.joyLabel.Size = new System.Drawing.Size(74, 32);
            this.joyLabel.TabIndex = 17;
            this.joyLabel.Text = "Joy: ";
            // 
            // fearLabel
            // 
            this.fearLabel.AutoSize = true;
            this.fearLabel.Location = new System.Drawing.Point(1477, 548);
            this.fearLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fearLabel.Name = "fearLabel";
            this.fearLabel.Size = new System.Drawing.Size(88, 32);
            this.fearLabel.TabIndex = 18;
            this.fearLabel.Text = "Fear: ";
            // 
            // disgustLabel
            // 
            this.disgustLabel.AutoSize = true;
            this.disgustLabel.Location = new System.Drawing.Point(1477, 504);
            this.disgustLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.disgustLabel.Name = "disgustLabel";
            this.disgustLabel.Size = new System.Drawing.Size(125, 32);
            this.disgustLabel.TabIndex = 19;
            this.disgustLabel.Text = "Disgust: ";
            // 
            // sadnessLabel
            // 
            this.sadnessLabel.AutoSize = true;
            this.sadnessLabel.Location = new System.Drawing.Point(1477, 461);
            this.sadnessLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sadnessLabel.Name = "sadnessLabel";
            this.sadnessLabel.Size = new System.Drawing.Size(141, 32);
            this.sadnessLabel.TabIndex = 20;
            this.sadnessLabel.Text = "Sadness: ";
            this.sadnessLabel.Click += new System.EventHandler(this.sadnessLabel_Click);
            // 
            // surpriseLabel
            // 
            this.surpriseLabel.AutoSize = true;
            this.surpriseLabel.Location = new System.Drawing.Point(1477, 629);
            this.surpriseLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.surpriseLabel.Name = "surpriseLabel";
            this.surpriseLabel.Size = new System.Drawing.Size(136, 32);
            this.surpriseLabel.TabIndex = 21;
            this.surpriseLabel.Text = "Surprise: ";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1719, 940);
            this.Controls.Add(this.surpriseLabel);
            this.Controls.Add(this.sadnessLabel);
            this.Controls.Add(this.disgustLabel);
            this.Controls.Add(this.fearLabel);
            this.Controls.Add(this.joyLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.following);
            this.Controls.Add(this.followers);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestPin);
            this.Controls.Add(this.error);
            this.Controls.Add(this.userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LogIn";
            this.Text = "Emotion Tracker";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button requestPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tweets;
        private System.Windows.Forms.Label followers;
        private System.Windows.Forms.Label following;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label joyLabel;
        private System.Windows.Forms.Label fearLabel;
        private System.Windows.Forms.Label disgustLabel;
        private System.Windows.Forms.Label sadnessLabel;
        private System.Windows.Forms.Label surpriseLabel;
    }
}

