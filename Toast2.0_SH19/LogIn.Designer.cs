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
            this.polarGraph2neurotic = new System.Windows.Forms.Label();
            this.polarGraph2Agreeable = new System.Windows.Forms.Label();
            this.polarGraph2Conscientious = new System.Windows.Forms.Label();
            this.polarGraph2Open = new System.Windows.Forms.Label();
            this.polarGraph2Extrovert = new System.Windows.Forms.Label();
            this.Conscientious = new System.Windows.Forms.Label();
            this.neuroticLabel = new System.Windows.Forms.Label();
            this.agreeableLabel = new System.Windows.Forms.Label();
            this.openLabel = new System.Windows.Forms.Label();
            this.extrovertLabel = new System.Windows.Forms.Label();
            this.posotiveBar = new System.Windows.Forms.ProgressBar();
            this.negativeBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tweetNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
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
            this.pictureBox.Location = new System.Drawing.Point(8, 180);
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
            this.joyLabel.Location = new System.Drawing.Point(518, 256);
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
            this.fearLabel.Location = new System.Drawing.Point(518, 225);
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
            this.disgustLabel.Location = new System.Drawing.Point(518, 195);
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
            this.sadnessLabel.Location = new System.Drawing.Point(518, 167);
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
            this.surpriseLabel.Location = new System.Drawing.Point(518, 287);
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
            this.angerLabel.Location = new System.Drawing.Point(518, 318);
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
            this.polarGraphSurprise.Location = new System.Drawing.Point(776, 261);
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
            this.listView2.Size = new System.Drawing.Size(156, 224);
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
            this.listView3.Size = new System.Drawing.Size(156, 224);
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
            this.chart2.Location = new System.Drawing.Point(670, 299);
            this.chart2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
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
            // polarGraph2neurotic
            // 
            this.polarGraph2neurotic.AutoSize = true;
            this.polarGraph2neurotic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.polarGraph2neurotic.Location = new System.Drawing.Point(776, 285);
            this.polarGraph2neurotic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraph2neurotic.Name = "polarGraph2neurotic";
            this.polarGraph2neurotic.Size = new System.Drawing.Size(47, 13);
            this.polarGraph2neurotic.TabIndex = 33;
            this.polarGraph2neurotic.Text = "Neurotic";
            // 
            // polarGraph2Agreeable
            // 
            this.polarGraph2Agreeable.AutoSize = true;
            this.polarGraph2Agreeable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.polarGraph2Agreeable.Location = new System.Drawing.Point(902, 369);
            this.polarGraph2Agreeable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraph2Agreeable.Name = "polarGraph2Agreeable";
            this.polarGraph2Agreeable.Size = new System.Drawing.Size(55, 13);
            this.polarGraph2Agreeable.TabIndex = 35;
            this.polarGraph2Agreeable.Text = "Agreeable";
            // 
            // polarGraph2Conscientious
            // 
            this.polarGraph2Conscientious.AutoSize = true;
            this.polarGraph2Conscientious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.polarGraph2Conscientious.Location = new System.Drawing.Point(618, 369);
            this.polarGraph2Conscientious.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraph2Conscientious.Name = "polarGraph2Conscientious";
            this.polarGraph2Conscientious.Size = new System.Drawing.Size(73, 13);
            this.polarGraph2Conscientious.TabIndex = 36;
            this.polarGraph2Conscientious.Text = "Conscientious";
            // 
            // polarGraph2Open
            // 
            this.polarGraph2Open.AutoSize = true;
            this.polarGraph2Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.polarGraph2Open.Location = new System.Drawing.Point(869, 510);
            this.polarGraph2Open.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraph2Open.Name = "polarGraph2Open";
            this.polarGraph2Open.Size = new System.Drawing.Size(33, 13);
            this.polarGraph2Open.TabIndex = 37;
            this.polarGraph2Open.Text = "Open";
            // 
            // polarGraph2Extrovert
            // 
            this.polarGraph2Extrovert.AutoSize = true;
            this.polarGraph2Extrovert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.polarGraph2Extrovert.Location = new System.Drawing.Point(688, 510);
            this.polarGraph2Extrovert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polarGraph2Extrovert.Name = "polarGraph2Extrovert";
            this.polarGraph2Extrovert.Size = new System.Drawing.Size(49, 13);
            this.polarGraph2Extrovert.TabIndex = 38;
            this.polarGraph2Extrovert.Text = "Extrovert";
            // 
            // Conscientious
            // 
            this.Conscientious.AutoSize = true;
            this.Conscientious.Location = new System.Drawing.Point(518, 504);
            this.Conscientious.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Conscientious.Name = "Conscientious";
            this.Conscientious.Size = new System.Drawing.Size(51, 13);
            this.Conscientious.TabIndex = 43;
            this.Conscientious.Text = "Surprise: ";
            // 
            // neuroticLabel
            // 
            this.neuroticLabel.AutoSize = true;
            this.neuroticLabel.Location = new System.Drawing.Point(518, 384);
            this.neuroticLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.neuroticLabel.Name = "neuroticLabel";
            this.neuroticLabel.Size = new System.Drawing.Size(54, 13);
            this.neuroticLabel.TabIndex = 42;
            this.neuroticLabel.Text = "Sadness: ";
            // 
            // agreeableLabel
            // 
            this.agreeableLabel.AutoSize = true;
            this.agreeableLabel.Location = new System.Drawing.Point(518, 412);
            this.agreeableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.agreeableLabel.Name = "agreeableLabel";
            this.agreeableLabel.Size = new System.Drawing.Size(48, 13);
            this.agreeableLabel.TabIndex = 41;
            this.agreeableLabel.Text = "Disgust: ";
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(518, 442);
            this.openLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(34, 13);
            this.openLabel.TabIndex = 40;
            this.openLabel.Text = "Fear: ";
            // 
            // extrovertLabel
            // 
            this.extrovertLabel.AutoSize = true;
            this.extrovertLabel.Location = new System.Drawing.Point(518, 473);
            this.extrovertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.extrovertLabel.Name = "extrovertLabel";
            this.extrovertLabel.Size = new System.Drawing.Size(29, 13);
            this.extrovertLabel.TabIndex = 39;
            this.extrovertLabel.Text = "Joy: ";
            // 
            // posotiveBar
            // 
            this.posotiveBar.Location = new System.Drawing.Point(328, 83);
            this.posotiveBar.Name = "posotiveBar";
            this.posotiveBar.Size = new System.Drawing.Size(172, 33);
            this.posotiveBar.TabIndex = 45;
            // 
            // negativeBar
            // 
            this.negativeBar.Location = new System.Drawing.Point(155, 83);
            this.negativeBar.Name = "negativeBar";
            this.negativeBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.negativeBar.RightToLeftLayout = true;
            this.negativeBar.Size = new System.Drawing.Size(172, 33);
            this.negativeBar.TabIndex = 46;
            this.negativeBar.Click += new System.EventHandler(this.negativeBar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "-100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "+100";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "0";
            // 
            // tweetNum
            // 
            this.tweetNum.AutoSize = true;
            this.tweetNum.Location = new System.Drawing.Point(5, 164);
            this.tweetNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tweetNum.Name = "tweetNum";
            this.tweetNum.Size = new System.Drawing.Size(118, 13);
            this.tweetNum.TabIndex = 50;
            this.tweetNum.Text = "# of tweets calculated: ";
            this.tweetNum.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Subjectivity Bar";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DimGray;
            this.title.Location = new System.Drawing.Point(395, 35);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(254, 34);
            this.title.TabIndex = 52;
            this.title.Text = "Twitter Tweet Tracker";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1004, 550);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tweetNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.negativeBar);
            this.Controls.Add(this.posotiveBar);
            this.Controls.Add(this.Conscientious);
            this.Controls.Add(this.neuroticLabel);
            this.Controls.Add(this.agreeableLabel);
            this.Controls.Add(this.openLabel);
            this.Controls.Add(this.extrovertLabel);
            this.Controls.Add(this.polarGraph2Extrovert);
            this.Controls.Add(this.polarGraph2Open);
            this.Controls.Add(this.polarGraph2Conscientious);
            this.Controls.Add(this.polarGraph2Agreeable);
            this.Controls.Add(this.polarGraph2neurotic);
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
        private System.Windows.Forms.Label polarGraph2neurotic;
        private System.Windows.Forms.Label polarGraph2Agreeable;
        private System.Windows.Forms.Label polarGraph2Conscientious;
        private System.Windows.Forms.Label polarGraph2Open;
        private System.Windows.Forms.Label polarGraph2Extrovert;
        private System.Windows.Forms.Label Conscientious;
        private System.Windows.Forms.Label neuroticLabel;
        private System.Windows.Forms.Label agreeableLabel;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.Label extrovertLabel;
        private System.Windows.Forms.ProgressBar posotiveBar;
        private System.Windows.Forms.ProgressBar negativeBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tweetNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

