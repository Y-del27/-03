﻿namespace Осннова_7
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.Glavnaya = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавление корабля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Glavnaya
            // 
            this.Glavnaya.Location = new System.Drawing.Point(484, 107);
            this.Glavnaya.Name = "Glavnaya";
            this.Glavnaya.Size = new System.Drawing.Size(267, 55);
            this.Glavnaya.TabIndex = 1;
            this.Glavnaya.Text = "Добавление порта";
            this.Glavnaya.UseVisualStyleBackColor = true;
            this.Glavnaya.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Посещения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Glavnaya);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Glavnaya;
        private System.Windows.Forms.Button button2;
    }
}