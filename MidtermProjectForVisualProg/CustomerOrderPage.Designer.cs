namespace MidtermProjectForVisualProg
{
    partial class CustomerOrderPage
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
            this.productlistBox = new System.Windows.Forms.ListBox();
            this.pricelistBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productlistBox
            // 
            this.productlistBox.FormattingEnabled = true;
            this.productlistBox.ItemHeight = 16;
            this.productlistBox.Location = new System.Drawing.Point(219, 72);
            this.productlistBox.Name = "productlistBox";
            this.productlistBox.Size = new System.Drawing.Size(210, 212);
            this.productlistBox.TabIndex = 0;
            this.productlistBox.SelectedIndexChanged += new System.EventHandler(this.productlistBox_SelectedIndexChanged);
            // 
            // pricelistBox
            // 
            this.pricelistBox.FormattingEnabled = true;
            this.pricelistBox.ItemHeight = 16;
            this.pricelistBox.Location = new System.Drawing.Point(429, 72);
            this.pricelistBox.Name = "pricelistBox";
            this.pricelistBox.Size = new System.Drawing.Size(143, 212);
            this.pricelistBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "Choose Your Product";
            // 
            // CustomerOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pricelistBox);
            this.Controls.Add(this.productlistBox);
            this.Name = "CustomerOrderPage";
            this.Text = "CustomerOrderPage";
            this.Load += new System.EventHandler(this.CustomerOrderPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productlistBox;
        private System.Windows.Forms.ListBox pricelistBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}