namespace Windows_Control_Project
{
    partial class frmMain
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
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textContactNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1Male = new System.Windows.Forms.RadioButton();
            this.radioButton2Female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.CivilStatus = new System.Windows.Forms.Label();
            this.listBox1stCS = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1Basketball = new System.Windows.Forms.CheckBox();
            this.checkBox2WatchingTv = new System.Windows.Forms.CheckBox();
            this.checkBox3Swimming = new System.Windows.Forms.CheckBox();
            this.button1ShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(142, 47);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 0;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(142, 76);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 1;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(142, 105);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 20);
            this.textAge.TabIndex = 2;
            // 
            // textContactNo
            // 
            this.textContactNo.Location = new System.Drawing.Point(142, 207);
            this.textContactNo.Name = "textContactNo";
            this.textContactNo.Size = new System.Drawing.Size(100, 20);
            this.textContactNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FirtsName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LastName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ContactNo. :";
            // 
            // radioButton1Male
            // 
            this.radioButton1Male.AutoSize = true;
            this.radioButton1Male.Location = new System.Drawing.Point(142, 132);
            this.radioButton1Male.Name = "radioButton1Male";
            this.radioButton1Male.Size = new System.Drawing.Size(48, 17);
            this.radioButton1Male.TabIndex = 9;
            this.radioButton1Male.TabStop = true;
            this.radioButton1Male.Text = "Male";
            this.radioButton1Male.UseVisualStyleBackColor = true;
            // 
            // radioButton2Female
            // 
            this.radioButton2Female.AutoSize = true;
            this.radioButton2Female.Location = new System.Drawing.Point(142, 155);
            this.radioButton2Female.Name = "radioButton2Female";
            this.radioButton2Female.Size = new System.Drawing.Size(59, 17);
            this.radioButton2Female.TabIndex = 10;
            this.radioButton2Female.TabStop = true;
            this.radioButton2Female.Text = "Female";
            this.radioButton2Female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "City:";
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "Caloocan",
            "Makati",
            "Mandaluyong",
            "Manila",
            "Marikina",
            "Muntinlupa ",
            "Navotas",
            "Pasay",
            "Pasig"});
            this.cboCity.Location = new System.Drawing.Point(452, 45);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(121, 21);
            this.cboCity.TabIndex = 13;
            // 
            // CivilStatus
            // 
            this.CivilStatus.AutoSize = true;
            this.CivilStatus.Location = new System.Drawing.Point(372, 83);
            this.CivilStatus.Name = "CivilStatus";
            this.CivilStatus.Size = new System.Drawing.Size(62, 13);
            this.CivilStatus.TabIndex = 14;
            this.CivilStatus.Text = "Civil Status:";
            // 
            // listBox1stCS
            // 
            this.listBox1stCS.FormattingEnabled = true;
            this.listBox1stCS.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Divorce"});
            this.listBox1stCS.Location = new System.Drawing.Point(452, 83);
            this.listBox1stCS.Name = "listBox1stCS";
            this.listBox1stCS.Size = new System.Drawing.Size(120, 56);
            this.listBox1stCS.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hobbies:";
            // 
            // checkBox1Basketball
            // 
            this.checkBox1Basketball.AutoSize = true;
            this.checkBox1Basketball.Location = new System.Drawing.Point(452, 159);
            this.checkBox1Basketball.Name = "checkBox1Basketball";
            this.checkBox1Basketball.Size = new System.Drawing.Size(75, 17);
            this.checkBox1Basketball.TabIndex = 17;
            this.checkBox1Basketball.Text = "Basketball";
            this.checkBox1Basketball.UseVisualStyleBackColor = true;
            // 
            // checkBox2WatchingTv
            // 
            this.checkBox2WatchingTv.AutoSize = true;
            this.checkBox2WatchingTv.Location = new System.Drawing.Point(452, 182);
            this.checkBox2WatchingTv.Name = "checkBox2WatchingTv";
            this.checkBox2WatchingTv.Size = new System.Drawing.Size(85, 17);
            this.checkBox2WatchingTv.TabIndex = 18;
            this.checkBox2WatchingTv.Text = "WatchingTv";
            this.checkBox2WatchingTv.UseVisualStyleBackColor = true;
            // 
            // checkBox3Swimming
            // 
            this.checkBox3Swimming.AutoSize = true;
            this.checkBox3Swimming.Location = new System.Drawing.Point(454, 210);
            this.checkBox3Swimming.Name = "checkBox3Swimming";
            this.checkBox3Swimming.Size = new System.Drawing.Size(73, 17);
            this.checkBox3Swimming.TabIndex = 19;
            this.checkBox3Swimming.Text = "Swimming";
            this.checkBox3Swimming.UseVisualStyleBackColor = true;
            // 
            // button1ShowResult
            // 
            this.button1ShowResult.Location = new System.Drawing.Point(228, 255);
            this.button1ShowResult.Name = "button1ShowResult";
            this.button1ShowResult.Size = new System.Drawing.Size(221, 37);
            this.button1ShowResult.TabIndex = 20;
            this.button1ShowResult.Text = "Show";
            this.button1ShowResult.UseVisualStyleBackColor = true;
            this.button1ShowResult.Click += new System.EventHandler(this.button1ShowResult_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 361);
            this.Controls.Add(this.button1ShowResult);
            this.Controls.Add(this.checkBox3Swimming);
            this.Controls.Add(this.checkBox2WatchingTv);
            this.Controls.Add(this.checkBox1Basketball);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1stCS);
            this.Controls.Add(this.CivilStatus);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2Female);
            this.Controls.Add(this.radioButton1Male);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textContactNo);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Name = "frmMain";
            this.Text = "My personal Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textContactNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1Male;
        private System.Windows.Forms.RadioButton radioButton2Female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label CivilStatus;
        private System.Windows.Forms.ListBox listBox1stCS;
        private System.Windows.Forms.CheckBox checkBox1Basketball;
        private System.Windows.Forms.CheckBox checkBox2WatchingTv;
        private System.Windows.Forms.CheckBox checkBox3Swimming;
        private System.Windows.Forms.Button button1ShowResult;
        protected internal System.Windows.Forms.Label label9;
    }
}

