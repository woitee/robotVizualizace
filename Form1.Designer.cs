namespace robotVizualizace
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.maxLatLabel = new System.Windows.Forms.Label();
            this.minLatLabel = new System.Windows.Forms.Label();
            this.maxLonLabel = new System.Windows.Forms.Label();
            this.minLonLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rangeTextBox = new System.Windows.Forms.TextBox();
            this.angleTextBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.autoButton = new System.Windows.Forms.Button();
            this.autoLabel = new System.Windows.Forms.Label();
            this.autoTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(80, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(539, 414);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // maxLatLabel
            // 
            this.maxLatLabel.AutoSize = true;
            this.maxLatLabel.Location = new System.Drawing.Point(13, 30);
            this.maxLatLabel.Name = "maxLatLabel";
            this.maxLatLabel.Size = new System.Drawing.Size(35, 13);
            this.maxLatLabel.TabIndex = 1;
            this.maxLatLabel.Text = "label1";
            // 
            // minLatLabel
            // 
            this.minLatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minLatLabel.AutoSize = true;
            this.minLatLabel.Location = new System.Drawing.Point(12, 431);
            this.minLatLabel.Name = "minLatLabel";
            this.minLatLabel.Size = new System.Drawing.Size(35, 13);
            this.minLatLabel.TabIndex = 2;
            this.minLatLabel.Text = "label2";
            // 
            // maxLonLabel
            // 
            this.maxLonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maxLonLabel.AutoSize = true;
            this.maxLonLabel.Location = new System.Drawing.Point(562, 446);
            this.maxLonLabel.Name = "maxLonLabel";
            this.maxLonLabel.Size = new System.Drawing.Size(35, 13);
            this.maxLonLabel.TabIndex = 4;
            this.maxLonLabel.Text = "label4";
            // 
            // minLonLabel
            // 
            this.minLonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minLonLabel.AutoSize = true;
            this.minLonLabel.Location = new System.Drawing.Point(77, 446);
            this.minLonLabel.Name = "minLonLabel";
            this.minLonLabel.Size = new System.Drawing.Size(35, 13);
            this.minLonLabel.TabIndex = 5;
            this.minLonLabel.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "60";
            // 
            // rangeTextBox
            // 
            this.rangeTextBox.Location = new System.Drawing.Point(414, 4);
            this.rangeTextBox.Name = "rangeTextBox";
            this.rangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.rangeTextBox.TabIndex = 7;
            this.rangeTextBox.Text = "200";
            // 
            // angleTextBox
            // 
            this.angleTextBox.AutoSize = true;
            this.angleTextBox.Location = new System.Drawing.Point(80, 7);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(90, 13);
            this.angleTextBox.TabIndex = 8;
            this.angleTextBox.Text = "View Angle (deg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Max Range (mm):";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.nextButton.Location = new System.Drawing.Point(201, 460);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // autoButton
            // 
            this.autoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.autoButton.Location = new System.Drawing.Point(295, 460);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(75, 23);
            this.autoButton.TabIndex = 11;
            this.autoButton.Text = "Auto";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // autoLabel
            // 
            this.autoLabel.AutoSize = true;
            this.autoLabel.Location = new System.Drawing.Point(376, 465);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(13, 13);
            this.autoLabel.TabIndex = 12;
            this.autoLabel.Text = "0";
            // 
            // autoTimer
            // 
            this.autoTimer.Interval = 10;
            this.autoTimer.Tick += new System.EventHandler(this.autoTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(657, 495);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.rangeTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minLonLabel);
            this.Controls.Add(this.maxLonLabel);
            this.Controls.Add(this.minLatLabel);
            this.Controls.Add(this.maxLatLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label maxLatLabel;
        private System.Windows.Forms.Label minLatLabel;
        private System.Windows.Forms.Label maxLonLabel;
        private System.Windows.Forms.Label minLonLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox rangeTextBox;
        private System.Windows.Forms.Label angleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Label autoLabel;
        private System.Windows.Forms.Timer autoTimer;
    }
}

