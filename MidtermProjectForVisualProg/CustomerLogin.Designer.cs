namespace MidtermProjectForVisualProg
{
    partial class CustomerLogin
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
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernametextbox
            // 
            this.usernametextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernametextbox.Location = new System.Drawing.Point(119, 107);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(191, 22);
            this.usernametextbox.TabIndex = 0;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(119, 219);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(191, 22);
            this.passwordtextbox.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Location = new System.Drawing.Point(166, 292);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(104, 34);
            this.Login.TabIndex = 2;
            this.Login.Text = "Log in";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(119, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username :-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(119, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "password :-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MidtermProjectForVisualProg.Properties.Resources.a88a5fc39c1e979cbf3b501069f568aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(407, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernametextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerLogin";
            this.Text = "CustomerLogin";
            this.Load += new System.EventHandler(this.CustomerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}