namespace WindowsFormsApplication1
{
    partial class frmPrivateAccess
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
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.btnPublicAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(170, 53);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(212, 23);
            this.btnShowMessage.TabIndex = 0;
            this.btnShowMessage.Text = "Show";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // btnPublicAccess
            // 
            this.btnPublicAccess.Location = new System.Drawing.Point(170, 101);
            this.btnPublicAccess.Name = "btnPublicAccess";
            this.btnPublicAccess.Size = new System.Drawing.Size(212, 23);
            this.btnPublicAccess.TabIndex = 1;
            this.btnPublicAccess.Text = "Go To Public Acces";
            this.btnPublicAccess.UseVisualStyleBackColor = true;
            this.btnPublicAccess.Click += new System.EventHandler(this.btnPublicAccess_Click);
            // 
            // frmPrivateAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 262);
            this.Controls.Add(this.btnPublicAccess);
            this.Controls.Add(this.btnShowMessage);
            this.Name = "frmPrivateAccess";
            this.Text = "Private Access";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMessage;
        private System.Windows.Forms.Button btnPublicAccess;
    }
}