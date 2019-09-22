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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.angerLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.polarGraphJoy = new System.Windows.Forms.Label();
            this.polarGraphFear = new System.Windows.Forms.Label();
            this.polarGraphDisgust = new System.Windows.Forms.Label();
            this.polarGraphSurprise = new System.Windows.Forms.Label();
            this.polarGraphSadness = new System.Windows.Forms.Label();
            this.Anger = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(6, 42);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(143, 20);
            this.userName.TabIndex = 2;
            this.userName.TextChanged += new System.EventHandler(this.pin_TextChanged);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(10, 18);
            this.error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 5;
            this.error.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // requestPin
            // 
            this.requestPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.requestPin.FlatAppearance.BorderSize = 0;
            this.requestPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestPin.Location = new System.Drawing.Point(6, 66);
            this.requestPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.requestPin.Name = "requestPin";
            this.requestPin.Size = new System.Drawing.Size(142, 30);
            this.requestPin.TabIndex = 6;
            this.requestPin.Text = "Search Person";
            this.requestPin.UseVisualStyleBackColor = false;
            this.requestPin.Click += new System.EventHandler(this.requestPin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "User";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(8, 163);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(142, 168);
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
            this.listView1.Location = new System.Drawing.Point(160, 164);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(340, 108);
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
            this.followers.Location = new System.Drawing.Point(5, 124);
            this.followers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.followers.Name = "followers";
            this.followers.Size = new System.Drawing.Size(57, 13);
            this.followers.TabIndex = 12;
            this.followers.Text = "Followers: ";
            this.followers.Click += new System.EventHandler(this.followers_Click);
            // 
            // following
            // 
            this.following.AutoSize = true;
            this.following.Location = new System.Drawing.Point(5, 145);
            this.following.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.following.Name = "following";
            this.following.Size = new System.Drawing.Size(57, 13);
            this.following.TabIndex = 13;
            this.following.Text = "Following: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(941, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 28);
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
            this.pictureBox2.Location = new System.Drawing.Point(890, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 28);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // joyLabel
            // 
            this.joyLabel.AutoSize = true;
            this.joyLabel.Location = new System.Drawing.Point(518, 268);
            this.joyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.joyLabel.Name = "joyLabel";
            this.joyLabel.Size = new System.Drawing.Size(29, 13);
            this.joyLabel.TabIndex = 17;
            this.joyLabel.Text = "Joy: ";
            this.joyLabel.Click += new System.EventHandler(this.joyLabel_Click);
            // 
            // fearLabel
            // 
            this.fearLabel.AutoSize = true;
            this.fearLabel.Location = new System.Drawing.Point(518, 237);
            this.fearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fearLabel.Name = "fearLabel";
            this.fearLabel.Size = new System.Drawing.Size(34, 13);
            this.fearLabel.TabIndex = 18;
            this.fearLabel.Text = "Fear: ";
            this.fearLabel.Click += new System.EventHandler(this.fearLabel_Click);
            // 
            // disgustLabel
            // 
            this.disgustLabel.AutoSize = true;
            this.disgustLabel.Location = new System.Drawing.Point(518, 207);
            this.disgustLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.disgustLabel.Name = "disgustLabel";
            this.disgustLabel.Size = new System.Drawing.Size(48, 13);
            this.disgustLabel.TabIndex = 19;
            this.disgustLabel.Text = "Disgust: ";
            this.disgustLabel.Click += new System.EventHandler(this.disgustLabel_Click);
            // 
            // sadnessLabel
            // 
            this.sadnessLabel.AutoSize = true;
            this.sadnessLabel.Location = new System.Drawing.Point(518, 179);
            this.sadnessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sadnessLabel.Name = "sadnessLabel";
            this.sadnessLabel.Size = new System.Drawing.Size(54, 13);
            this.sadnessLabel.TabIndex = 20;
            this.sadnessLabel.Text = "Sadness: ";
            this.sadnessLabel.Click += new System.EventHandler(this.sadnessLabel_Click);
            // 
            // surpriseLabel
            // 
            this.surpriseLabel.AutoSize = true;
            this.surpriseLabel.Location = new System.Drawing.Point(518, 299);
            this.surpriseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surpriseLabel.Name = "surpriseLabel";
            this.surpriseLabel.Size = new System.Drawing.Size(51, 13);
            this.surpriseLabel.TabIndex = 21;
            this.surpriseLabel.Text = "Surprise: ";
            this.surpriseLabel.Click += new System.EventHandler(this.surpriseLabel_Click);
            // 
            // angerLabel
            // 
            this.angerLabel.AutoSize = true;
            this.angerLabel.Location = new System.Drawing.Point(518, 330);
            this.angerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angerLabel.Name = "angerLabel";
            this.angerLabel.Size = new System.Drawing.Size(41, 13);
            this.angerLabel.TabIndex = 22;
            this.angerLabel.Text = "Anger: ";
            this.angerLabel.Click += new System.EventHandler(this.angerLabel_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.ZigZag;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(670, 35);
            this.chart1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 4;
            series1.Name = "Data1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(258, 239);
            this.chart1.TabIndex = 23;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // polarGraphJoy
            // 
            this.polarGraphJoy.AutoSize = true;
            this.polarGraphJoy.BackColor = System.Drawing.Color.Transparent;
            this.polarGraphJoy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.polarGraphJoy.Location = new System.Drawing.Point(785, 21);
            this.polarGraphJoy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraphJoy.Name = "polarGraphJoy";
            this.polarGraphJoy.Size = new System.Drawing.Size(26, 13);
            this.polarGraphJoy.TabIndex = 24;
            this.polarGraphJoy.Text = "Joy ";
            this.polarGraphJoy.Click += new System.EventHandler(this.label2_Click);
            // 
            // polarGraphFear
            // 
            this.polarGraphFear.AutoSize = true;
            this.polarGraphFear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.polarGraphFear.Location = new System.Drawing.Point(900, 83);
            this.polarGraphFear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraphFear.Name = "polarGraphFear";
            this.polarGraphFear.Size = new System.Drawing.Size(28, 13);
            this.polarGraphFear.TabIndex = 25;
            this.polarGraphFear.Text = "Fear";
            // 
            // polarGraphDisgust
            // 
            this.polarGraphDisgust.AutoSize = true;
            this.polarGraphDisgust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.polarGraphDisgust.Location = new System.Drawing.Point(902, 207);
            this.polarGraphDisgust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraphDisgust.Name = "polarGraphDisgust";
            this.polarGraphDisgust.Size = new System.Drawing.Size(42, 13);
            this.polarGraphDisgust.TabIndex = 26;
            this.polarGraphDisgust.Text = "Disgust";
            // 
            // polarGraphSurprise
            // 
            this.polarGraphSurprise.AutoSize = true;
            this.polarGraphSurprise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.polarGraphSurprise.Location = new System.Drawing.Point(775, 268);
            this.polarGraphSurprise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraphSurprise.Name = "polarGraphSurprise";
            this.polarGraphSurprise.Size = new System.Drawing.Size(45, 13);
            this.polarGraphSurprise.TabIndex = 27;
            this.polarGraphSurprise.Text = "Surprise";
            // 
            // polarGraphSadness
            // 
            this.polarGraphSadness.AutoSize = true;
            this.polarGraphSadness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.polarGraphSadness.Location = new System.Drawing.Point(654, 207);
            this.polarGraphSadness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraphSadness.Name = "polarGraphSadness";
            this.polarGraphSadness.Size = new System.Drawing.Size(48, 13);
            this.polarGraphSadness.TabIndex = 28;
            this.polarGraphSadness.Text = "Sadness";
            // 
            // Anger
            // 
            this.Anger.AutoSize = true;
            this.Anger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.Anger.Location = new System.Drawing.Point(667, 83);
            this.Anger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Anger.Name = "Anger";
            this.Anger.Size = new System.Drawing.Size(35, 13);
            this.Anger.TabIndex = 29;
            this.Anger.Text = "Anger";
            // 
            // listView2
            // 
            this.listView2.AutoArrange = false;
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(160, 299);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(156, 170);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Follower List";
            this.columnHeader1.Width = 900;
            // 
            // listView3
            // 
            this.listView3.AutoArrange = false;
            this.listView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(344, 299);
            this.listView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(156, 170);
            this.listView3.TabIndex = 31;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Following List";
            this.columnHeader2.Width = 900;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.chart2.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.chart2.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            chartArea2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.ZigZag;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(670, 309);
            this.chart2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerSize = 4;
            series2.Name = "Data2";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(258, 239);
            this.chart2.TabIndex = 32;
            this.chart2.TabStop = false;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1004, 583);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.Anger);
            this.Controls.Add(this.polarGraphSadness);
            this.Controls.Add(this.polarGraphSurprise);
            this.Controls.Add(this.polarGraphDisgust);
            this.Controls.Add(this.polarGraphFear);
            this.Controls.Add(this.polarGraphJoy);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.angerLabel);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LogIn";
            this.Text = "Emotion Tracker";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.Label angerLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label polarGraphJoy;
        private System.Windows.Forms.Label polarGraphFear;
        private System.Windows.Forms.Label polarGraphDisgust;
        private System.Windows.Forms.Label polarGraphSurprise;
        private System.Windows.Forms.Label polarGraphSadness;
        private System.Windows.Forms.Label Anger;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

