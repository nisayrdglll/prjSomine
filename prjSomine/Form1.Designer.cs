﻿namespace prjSomine
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
            this.components = new System.ComponentModel.Container();
            this.lblAlev = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblAlev
            // 
            this.lblAlev.BackColor = System.Drawing.Color.Transparent;
            this.lblAlev.Image = global::prjSomine.Properties.Resources._1;
            this.lblAlev.Location = new System.Drawing.Point(134, 400);
            this.lblAlev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlev.Name = "lblAlev";
            this.lblAlev.Size = new System.Drawing.Size(103, 124);
            this.lblAlev.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjSomine.Properties.Resources.somine;
            this.ClientSize = new System.Drawing.Size(504, 724);
            this.Controls.Add(this.lblAlev);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAlev;
        private System.Windows.Forms.Timer timer1;
    }
}

