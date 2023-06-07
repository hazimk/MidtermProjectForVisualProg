namespace MidtermProjectForVisualProg
{
    partial class EmployeePage
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
            this.ToWarehouse = new System.Windows.Forms.Button();
            this.ToManufactory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToWarehouse
            // 
            this.ToWarehouse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToWarehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToWarehouse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ToWarehouse.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.ToWarehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToWarehouse.Location = new System.Drawing.Point(437, 0);
            this.ToWarehouse.Name = "ToWarehouse";
            this.ToWarehouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToWarehouse.Size = new System.Drawing.Size(115, 450);
            this.ToWarehouse.TabIndex = 1;
            this.ToWarehouse.Text = "Warehouse";
            this.ToWarehouse.UseVisualStyleBackColor = false;
            this.ToWarehouse.Click += new System.EventHandler(this.ToWarehouse_Click);
            // 
            // ToManufactory
            // 
            this.ToManufactory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToManufactory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToManufactory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ToManufactory.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToManufactory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToManufactory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ToManufactory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToManufactory.ImageKey = "(none)";
            this.ToManufactory.Location = new System.Drawing.Point(0, 0);
            this.ToManufactory.Name = "ToManufactory";
            this.ToManufactory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToManufactory.Size = new System.Drawing.Size(120, 450);
            this.ToManufactory.TabIndex = 2;
            this.ToManufactory.Text = "Manufactory";
            this.ToManufactory.UseVisualStyleBackColor = false;
            this.ToManufactory.Click += new System.EventHandler(this.ToManufactory_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.ToManufactory);
            this.Controls.Add(this.ToWarehouse);
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToWarehouse;
        private System.Windows.Forms.Button ToManufactory;
    }
}