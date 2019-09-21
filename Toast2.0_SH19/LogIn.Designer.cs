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
            this.enter = new System.Windows.Forms.Button();
            this.pin = new System.Windows.Forms.TextBox();
            this.pinLabel = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.requestPin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(661, 490);
            this.enter.Margin = new System.Windows.Forms.Padding(6);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(186, 72);
            this.enter.TabIndex = 0;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // pin
            // 
            this.pin.Location = new System.Drawing.Point(576, 391);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(374, 38);
            this.pin.TabIndex = 2;
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(570, 335);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(57, 32);
            this.pinLabel.TabIndex = 4;
            this.pinLabel.Text = "Pin";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(570, 598);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 32);
            this.error.TabIndex = 5;
            this.error.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // requestPin
            // 
            this.requestPin.Location = new System.Drawing.Point(661, 147);
            this.requestPin.Margin = new System.Windows.Forms.Padding(6);
            this.requestPin.Name = "requestPin";
            this.requestPin.Size = new System.Drawing.Size(186, 72);
            this.requestPin.TabIndex = 6;
            this.requestPin.Text = "Request Pin";
            this.requestPin.UseVisualStyleBackColor = true;
            this.requestPin.Click += new System.EventHandler(this.requestPin_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.requestPin);
            this.Controls.Add(this.error);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.enter);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button requestPin;
    }
}

