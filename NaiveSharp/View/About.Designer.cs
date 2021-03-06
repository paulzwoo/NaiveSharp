﻿namespace NaiveSharp.View
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.picNavBackground = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContext = new System.Windows.Forms.Label();
            this.lstCredit = new System.Windows.Forms.ListBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.llbLicense = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picNavBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picNavBackground
            // 
            this.picNavBackground.BackColor = System.Drawing.SystemColors.Window;
            this.picNavBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.picNavBackground.Location = new System.Drawing.Point(0, 0);
            this.picNavBackground.Name = "picNavBackground";
            this.picNavBackground.Size = new System.Drawing.Size(347, 54);
            this.picNavBackground.TabIndex = 0;
            this.picNavBackground.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Window;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naive #";
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContext.Location = new System.Drawing.Point(14, 66);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(111, 60);
            this.lblContext.TabIndex = 2;
            this.lblContext.Text = "NaiveSharp\r\nVersion 0.6.4-prev\r\n© 2020 KevinZonda\r\nGNU GPL  v3.0";
            // 
            // lstCredit
            // 
            this.lstCredit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCredit.FormattingEnabled = true;
            this.lstCredit.ItemHeight = 15;
            this.lstCredit.Items.AddRange(new object[] {
            "klzgrad/naiveproxy - BSD 3-Clause",
            "trojan-gfw/igniter - GPLv3",
            "Dreamacro/clash - GPLv3",
            "privoxy.org/privoxy - GPLv2"});
            this.lstCredit.Location = new System.Drawing.Point(17, 153);
            this.lstCredit.Name = "lstCredit";
            this.lstCredit.Size = new System.Drawing.Size(313, 94);
            this.lstCredit.TabIndex = 3;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(14, 135);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(39, 15);
            this.lblCredit.TabIndex = 4;
            this.lblCredit.Text = "Credit";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(255, 253);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // llbLicense
            // 
            this.llbLicense.AccessibleDescription = "License of NaiveSharp";
            this.llbLicense.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbLicense.AutoSize = true;
            this.llbLicense.BackColor = System.Drawing.SystemColors.Window;
            this.llbLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLicense.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbLicense.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llbLicense.Location = new System.Drawing.Point(265, 18);
            this.llbLicense.Name = "llbLicense";
            this.llbLicense.Size = new System.Drawing.Size(51, 15);
            this.llbLicense.TabIndex = 6;
            this.llbLicense.TabStop = true;
            this.llbLicense.Text = "LICENSE";
            this.llbLicense.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLicense_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 283);
            this.Controls.Add(this.llbLicense);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lstCredit);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picNavBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About Naive #";
            ((System.ComponentModel.ISupportInitialize)(this.picNavBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNavBackground;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.ListBox lstCredit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.LinkLabel llbLicense;
    }
}