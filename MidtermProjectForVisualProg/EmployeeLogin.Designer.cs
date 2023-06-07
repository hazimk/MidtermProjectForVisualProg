namespace MidtermProjectForVisualProg
{
    partial class EmployeeLogin
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
            this.loginConfirm = new System.Windows.Forms.Button();
            this.usernameemployee = new System.Windows.Forms.TextBox();
            this.passwordemployee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginConfirm
            // 
            this.loginConfirm.Location = new System.Drawing.Point(165, 295);
            this.loginConfirm.Name = "loginConfirm";
            this.loginConfirm.Size = new System.Drawing.Size(115, 40);
            this.loginConfirm.TabIndex = 0;
            this.loginConfirm.Text = "login";
            this.loginConfirm.UseVisualStyleBackColor = true;
            this.loginConfirm.Click += new System.EventHandler(this.loginConfirm_Click);
            // 
            // usernameemployee
            // 
            this.usernameemployee.Location = new System.Drawing.Point(139, 103);
            this.usernameemployee.Name = "usernameemployee";
            this.usernameemployee.Size = new System.Drawing.Size(168, 22);
            this.usernameemployee.TabIndex = 1;
            // 
            // passwordemployee
            // 
            this.passwordemployee.Location = new System.Drawing.Point(139, 206);
            this.passwordemployee.Name = "passwordemployee";
            this.passwordemployee.Size = new System.Drawing.Size(168, 22);
            this.passwordemployee.TabIndex = 2;
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 438);
            this.Controls.Add(this.passwordemployee);
            this.Controls.Add(this.usernameemployee);
            this.Controls.Add(this.loginConfirm);
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginConfirm;
        private System.Windows.Forms.TextBox usernameemployee;
        private System.Windows.Forms.TextBox passwordemployee;
    }
}