﻿namespace MidtermProjectForVisualProg
{
    partial class WarehousePage
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CONFIRMBB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(589, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // CONFIRMBB
            // 
            this.CONFIRMBB.Location = new System.Drawing.Point(311, 267);
            this.CONFIRMBB.Name = "CONFIRMBB";
            this.CONFIRMBB.Size = new System.Drawing.Size(189, 53);
            this.CONFIRMBB.TabIndex = 2;
            this.CONFIRMBB.Text = "CONFIRM";
            this.CONFIRMBB.UseVisualStyleBackColor = true;
            this.CONFIRMBB.Click += new System.EventHandler(this.CONFIRMBB_Click);
            // 
            // WarehousePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CONFIRMBB);
            this.Controls.Add(this.comboBox1);
            this.Name = "WarehousePage";
            this.Text = "WarehousePage";
            this.Load += new System.EventHandler(this.WarehousePage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CONFIRMBB;
    }
}