namespace MidtermProjectForVisualProg
{
    partial class CustomerPage
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
            this.CatgoryType = new System.Windows.Forms.ComboBox();
            this.Confirmthecatgory = new System.Windows.Forms.Button();
            this.FactoryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CatgoryType
            // 
            this.CatgoryType.FormattingEnabled = true;
            this.CatgoryType.Items.AddRange(new object[] {
            "Electronics",
            "Clothing",
            "Home & Garden"});
            this.CatgoryType.Location = new System.Drawing.Point(183, 241);
            this.CatgoryType.Name = "CatgoryType";
            this.CatgoryType.Size = new System.Drawing.Size(389, 24);
            this.CatgoryType.TabIndex = 0;
            this.CatgoryType.Text = "Choose Your Category :";
            // 
            // Confirmthecatgory
            // 
            this.Confirmthecatgory.Location = new System.Drawing.Point(294, 313);
            this.Confirmthecatgory.Name = "Confirmthecatgory";
            this.Confirmthecatgory.Size = new System.Drawing.Size(172, 46);
            this.Confirmthecatgory.TabIndex = 1;
            this.Confirmthecatgory.Text = "Confirm";
            this.Confirmthecatgory.UseVisualStyleBackColor = true;
            this.Confirmthecatgory.Click += new System.EventHandler(this.Confirmthecatgory_Click);
            // 
            // FactoryName
            // 
            this.FactoryName.AutoSize = true;
            this.FactoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactoryName.Location = new System.Drawing.Point(331, 141);
            this.FactoryName.Name = "FactoryName";
            this.FactoryName.Size = new System.Drawing.Size(85, 29);
            this.FactoryName.TabIndex = 2;
            this.FactoryName.Text = "label1";
            this.FactoryName.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 538);
            this.Controls.Add(this.FactoryName);
            this.Controls.Add(this.Confirmthecatgory);
            this.Controls.Add(this.CatgoryType);
            this.Name = "CustomerPage";
            this.Text = "CustomerPage";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CatgoryType;
        private System.Windows.Forms.Button Confirmthecatgory;
        private System.Windows.Forms.Label FactoryName;
    }
}