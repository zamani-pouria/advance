﻿namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xx1 = new System.Windows.Forms.TextBox();
            this.xx2 = new System.Windows.Forms.TextBox();
            this.yy1 = new System.Windows.Forms.TextBox();
            this.yy2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "y2";
            // 
            // xx1
            // 
            this.xx1.Location = new System.Drawing.Point(78, 23);
            this.xx1.Name = "xx1";
            this.xx1.Size = new System.Drawing.Size(100, 22);
            this.xx1.TabIndex = 4;
            // 
            // xx2
            // 
            this.xx2.Location = new System.Drawing.Point(271, 29);
            this.xx2.Name = "xx2";
            this.xx2.Size = new System.Drawing.Size(100, 22);
            this.xx2.TabIndex = 5;
            // 
            // yy1
            // 
            this.yy1.Location = new System.Drawing.Point(76, 107);
            this.yy1.Name = "yy1";
            this.yy1.Size = new System.Drawing.Size(100, 22);
            this.yy1.TabIndex = 6;
            // 
            // yy2
            // 
            this.yy2.Location = new System.Drawing.Point(271, 110);
            this.yy2.Name = "yy2";
            this.yy2.Size = new System.Drawing.Size(100, 22);
            this.yy2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "حساب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yy2);
            this.Controls.Add(this.yy1);
            this.Controls.Add(this.xx2);
            this.Controls.Add(this.xx1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xx1;
        private System.Windows.Forms.TextBox xx2;
        private System.Windows.Forms.TextBox yy1;
        private System.Windows.Forms.TextBox yy2;
        private System.Windows.Forms.Button button1;
    }
}

