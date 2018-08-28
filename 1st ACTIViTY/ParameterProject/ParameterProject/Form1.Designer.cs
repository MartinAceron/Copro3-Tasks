namespace ParameterProject
{
    partial class frmParameter
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
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.txtSecondValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnValueParameter = new System.Windows.Forms.RadioButton();
            this.rbnRefParameter = new System.Windows.Forms.RadioButton();
            this.rbnOutParameter = new System.Windows.Forms.RadioButton();
            this.btnSwapNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Location = new System.Drawing.Point(114, 23);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(100, 20);
            this.txtFirstValue.TabIndex = 0;
            // 
            // txtSecondValue
            // 
            this.txtSecondValue.Location = new System.Drawing.Point(114, 66);
            this.txtSecondValue.Name = "txtSecondValue";
            this.txtSecondValue.Size = new System.Drawing.Size(100, 20);
            this.txtSecondValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Types of Parameter:";
            // 
            // rbnValueParameter
            // 
            this.rbnValueParameter.AutoSize = true;
            this.rbnValueParameter.Location = new System.Drawing.Point(114, 141);
            this.rbnValueParameter.Name = "rbnValueParameter";
            this.rbnValueParameter.Size = new System.Drawing.Size(103, 17);
            this.rbnValueParameter.TabIndex = 5;
            this.rbnValueParameter.TabStop = true;
            this.rbnValueParameter.Text = "Value Parameter";
            this.rbnValueParameter.UseVisualStyleBackColor = true;
            // 
            // rbnRefParameter
            // 
            this.rbnRefParameter.AutoSize = true;
            this.rbnRefParameter.Location = new System.Drawing.Point(114, 164);
            this.rbnRefParameter.Name = "rbnRefParameter";
            this.rbnRefParameter.Size = new System.Drawing.Size(126, 17);
            this.rbnRefParameter.TabIndex = 6;
            this.rbnRefParameter.TabStop = true;
            this.rbnRefParameter.Text = "Reference Parameter";
            this.rbnRefParameter.UseVisualStyleBackColor = true;
            // 
            // rbnOutParameter
            // 
            this.rbnOutParameter.AutoSize = true;
            this.rbnOutParameter.Location = new System.Drawing.Point(114, 187);
            this.rbnOutParameter.Name = "rbnOutParameter";
            this.rbnOutParameter.Size = new System.Drawing.Size(93, 17);
            this.rbnOutParameter.TabIndex = 7;
            this.rbnOutParameter.TabStop = true;
            this.rbnOutParameter.Text = "Out Parameter";
            this.rbnOutParameter.UseVisualStyleBackColor = true;
            // 
            // btnSwapNow
            // 
            this.btnSwapNow.Location = new System.Drawing.Point(114, 227);
            this.btnSwapNow.Name = "btnSwapNow";
            this.btnSwapNow.Size = new System.Drawing.Size(83, 23);
            this.btnSwapNow.TabIndex = 8;
            this.btnSwapNow.Text = "Swap Now";
            this.btnSwapNow.UseVisualStyleBackColor = true;
            this.btnSwapNow.Click += new System.EventHandler(this.btnSwapNow_Click);
            // 
            // frmParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 262);
            this.Controls.Add(this.btnSwapNow);
            this.Controls.Add(this.rbnOutParameter);
            this.Controls.Add(this.rbnRefParameter);
            this.Controls.Add(this.rbnValueParameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecondValue);
            this.Controls.Add(this.txtFirstValue);
            this.Name = "frmParameter";
            this.Text = "Parameter Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.TextBox txtSecondValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbnValueParameter;
        private System.Windows.Forms.RadioButton rbnRefParameter;
        private System.Windows.Forms.RadioButton rbnOutParameter;
        private System.Windows.Forms.Button btnSwapNow;
    }
}

