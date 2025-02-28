namespace Age_Calculator_Project
{
    partial class frmAgeCalculatorScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnStartAgeCalculation = new System.Windows.Forms.Button();
            this.lblAgeInYears = new System.Windows.Forms.Label();
            this.lblAgeInMonths = new System.Windows.Forms.Label();
            this.lblAgeInDays = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAgeAsNumberOfDays = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAgeAsNumberOfWeeks = new System.Windows.Forms.Label();
            this.lblAgeAsNumberOfHours = new System.Windows.Forms.Label();
            this.lblAgeAsNumberOfMinutes = new System.Windows.Forms.Label();
            this.lblAgeAsNumberOfSeconds = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAgeAsNumberOfMonths = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "ضع تاريخ ميلادك ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.CustomFormat = "yyyy\\mm\\dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnStartAgeCalculation
            // 
            this.btnStartAgeCalculation.BackColor = System.Drawing.Color.Blue;
            this.btnStartAgeCalculation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartAgeCalculation.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAgeCalculation.ForeColor = System.Drawing.Color.White;
            this.btnStartAgeCalculation.Location = new System.Drawing.Point(143, 227);
            this.btnStartAgeCalculation.Name = "btnStartAgeCalculation";
            this.btnStartAgeCalculation.Size = new System.Drawing.Size(151, 47);
            this.btnStartAgeCalculation.TabIndex = 5;
            this.btnStartAgeCalculation.Text = "أحسب";
            this.btnStartAgeCalculation.UseVisualStyleBackColor = false;
            this.btnStartAgeCalculation.Click += new System.EventHandler(this.btnStartAgeCalculation_Click);
            // 
            // lblAgeInYears
            // 
            this.lblAgeInYears.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeInYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAgeInYears.Location = new System.Drawing.Point(121, 295);
            this.lblAgeInYears.Name = "lblAgeInYears";
            this.lblAgeInYears.Size = new System.Drawing.Size(200, 31);
            this.lblAgeInYears.TabIndex = 6;
            this.lblAgeInYears.Text = "0";
            this.lblAgeInYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgeInMonths
            // 
            this.lblAgeInMonths.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeInMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAgeInMonths.Location = new System.Drawing.Point(121, 339);
            this.lblAgeInMonths.Name = "lblAgeInMonths";
            this.lblAgeInMonths.Size = new System.Drawing.Size(200, 31);
            this.lblAgeInMonths.TabIndex = 7;
            this.lblAgeInMonths.Text = "0";
            this.lblAgeInMonths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgeInDays
            // 
            this.lblAgeInDays.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeInDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAgeInDays.Location = new System.Drawing.Point(121, 383);
            this.lblAgeInDays.Name = "lblAgeInDays";
            this.lblAgeInDays.Size = new System.Drawing.Size(200, 31);
            this.lblAgeInDays.TabIndex = 8;
            this.lblAgeInDays.Text = "0";
            this.lblAgeInDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(298, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "عمرك بالأيام ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgeAsNumberOfDays
            // 
            this.lblAgeAsNumberOfDays.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAsNumberOfDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAgeAsNumberOfDays.Location = new System.Drawing.Point(105, 550);
            this.lblAgeAsNumberOfDays.Name = "lblAgeAsNumberOfDays";
            this.lblAgeAsNumberOfDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgeAsNumberOfDays.Size = new System.Drawing.Size(189, 31);
            this.lblAgeAsNumberOfDays.TabIndex = 10;
            this.lblAgeAsNumberOfDays.Text = "0";
            this.lblAgeAsNumberOfDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(298, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "عمرك بالساعات";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(298, 624);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "عمرك بالدقائق";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(298, 661);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 27);
            this.label9.TabIndex = 13;
            this.label9.Text = "عمرك بالثواني ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(298, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 27);
            this.label10.TabIndex = 14;
            this.label10.Text = "عمرك بالأسابيع ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgeAsNumberOfWeeks
            // 
            this.lblAgeAsNumberOfWeeks.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAsNumberOfWeeks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAgeAsNumberOfWeeks.Location = new System.Drawing.Point(105, 513);
            this.lblAgeAsNumberOfWeeks.Name = "lblAgeAsNumberOfWeeks";
            this.lblAgeAsNumberOfWeeks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgeAsNumberOfWeeks.Size = new System.Drawing.Size(189, 31);
            this.lblAgeAsNumberOfWeeks.TabIndex = 15;
            this.lblAgeAsNumberOfWeeks.Text = "0";
            this.lblAgeAsNumberOfWeeks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgeAsNumberOfHours
            // 
            this.lblAgeAsNumberOfHours.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAsNumberOfHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAgeAsNumberOfHours.Location = new System.Drawing.Point(105, 587);
            this.lblAgeAsNumberOfHours.Name = "lblAgeAsNumberOfHours";
            this.lblAgeAsNumberOfHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgeAsNumberOfHours.Size = new System.Drawing.Size(189, 31);
            this.lblAgeAsNumberOfHours.TabIndex = 16;
            this.lblAgeAsNumberOfHours.Text = "0";
            this.lblAgeAsNumberOfHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgeAsNumberOfMinutes
            // 
            this.lblAgeAsNumberOfMinutes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAsNumberOfMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAgeAsNumberOfMinutes.Location = new System.Drawing.Point(105, 624);
            this.lblAgeAsNumberOfMinutes.Name = "lblAgeAsNumberOfMinutes";
            this.lblAgeAsNumberOfMinutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgeAsNumberOfMinutes.Size = new System.Drawing.Size(189, 31);
            this.lblAgeAsNumberOfMinutes.TabIndex = 17;
            this.lblAgeAsNumberOfMinutes.Text = "0";
            this.lblAgeAsNumberOfMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgeAsNumberOfSeconds
            // 
            this.lblAgeAsNumberOfSeconds.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAsNumberOfSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAgeAsNumberOfSeconds.Location = new System.Drawing.Point(105, 661);
            this.lblAgeAsNumberOfSeconds.Name = "lblAgeAsNumberOfSeconds";
            this.lblAgeAsNumberOfSeconds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgeAsNumberOfSeconds.Size = new System.Drawing.Size(189, 31);
            this.lblAgeAsNumberOfSeconds.TabIndex = 18;
            this.lblAgeAsNumberOfSeconds.Text = "0";
            this.lblAgeAsNumberOfSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Age_Calculator_Project.Properties.Resources.confetti;
            this.pictureBox2.Location = new System.Drawing.Point(2, 597);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Age_Calculator_Project.Properties.Resources.balloons;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAgeAsNumberOfMonths
            // 
            this.lblAgeAsNumberOfMonths.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAsNumberOfMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAgeAsNumberOfMonths.Location = new System.Drawing.Point(105, 476);
            this.lblAgeAsNumberOfMonths.Name = "lblAgeAsNumberOfMonths";
            this.lblAgeAsNumberOfMonths.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgeAsNumberOfMonths.Size = new System.Drawing.Size(189, 31);
            this.lblAgeAsNumberOfMonths.TabIndex = 21;
            this.lblAgeAsNumberOfMonths.Text = "0";
            this.lblAgeAsNumberOfMonths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(298, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "عمرك بالشهور";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAgeCalculatorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(447, 706);
            this.Controls.Add(this.lblAgeAsNumberOfMonths);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAgeAsNumberOfSeconds);
            this.Controls.Add(this.lblAgeAsNumberOfMinutes);
            this.Controls.Add(this.lblAgeAsNumberOfHours);
            this.Controls.Add(this.lblAgeAsNumberOfWeeks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAgeAsNumberOfDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAgeInDays);
            this.Controls.Add(this.lblAgeInMonths);
            this.Controls.Add(this.lblAgeInYears);
            this.Controls.Add(this.btnStartAgeCalculation);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgeCalculatorScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.frmAgeCalculatorScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnStartAgeCalculation;
        private System.Windows.Forms.Label lblAgeInYears;
        private System.Windows.Forms.Label lblAgeInMonths;
        private System.Windows.Forms.Label lblAgeInDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAgeAsNumberOfDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAgeAsNumberOfWeeks;
        private System.Windows.Forms.Label lblAgeAsNumberOfHours;
        private System.Windows.Forms.Label lblAgeAsNumberOfMinutes;
        private System.Windows.Forms.Label lblAgeAsNumberOfSeconds;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAgeAsNumberOfMonths;
        private System.Windows.Forms.Label label3;
    }
}