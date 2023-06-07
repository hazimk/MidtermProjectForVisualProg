namespace MidtermProjectForVisualProg
{
    partial class MainPage
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
            this.CustomerToLogin = new System.Windows.Forms.Button();
            this.EmployeeToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerToLogin
            // 
            this.CustomerToLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomerToLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerToLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.CustomerToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustomerToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.CustomerToLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomerToLogin.Location = new System.Drawing.Point(540, 0);
            this.CustomerToLogin.Name = "CustomerToLogin";
            this.CustomerToLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerToLogin.Size = new System.Drawing.Size(115, 479);
            this.CustomerToLogin.TabIndex = 0;
            this.CustomerToLogin.Text = "Customer";
            this.CustomerToLogin.UseVisualStyleBackColor = false;
            this.CustomerToLogin.Click += new System.EventHandler(this.CustomerToLogin_Click);
            // 
            // EmployeeToLogin
            // 
            this.EmployeeToLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EmployeeToLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeeToLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmployeeToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.EmployeeToLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmployeeToLogin.ImageKey = "(none)";
            this.EmployeeToLogin.Location = new System.Drawing.Point(0, 0);
            this.EmployeeToLogin.Name = "EmployeeToLogin";
            this.EmployeeToLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeToLogin.Size = new System.Drawing.Size(120, 479);
            this.EmployeeToLogin.TabIndex = 1;
            this.EmployeeToLogin.Text = "Employee";
            this.EmployeeToLogin.UseVisualStyleBackColor = false;
            this.EmployeeToLogin.Click += new System.EventHandler(this.EmployeeToLogin_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MidtermProjectForVisualProg.Properties.Resources._3cb9779bdf6e90a878370e8d0a936db0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 479);
            this.Controls.Add(this.EmployeeToLogin);
            this.Controls.Add(this.CustomerToLogin);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerToLogin;
        private System.Windows.Forms.Button EmployeeToLogin;
    }
}

