﻿using System.Drawing;
using System.Windows.Forms;

namespace Student_Attendace_System.PopUpForms
{
    partial class UpdateFaculty
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
            this.header = new System.Windows.Forms.Panel();
            this.close_button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelAddFac = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.facultyID = new System.Windows.Forms.Label();
            this.fID = new System.Windows.Forms.TextBox();
            this.addfac = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.header.CausesValidation = false;
            this.header.Controls.Add(this.close_button2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Enabled = false;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(733, 43);
            this.header.TabIndex = 38;
            // 
            // close_button2
            // 
            this.close_button2.BackColor = System.Drawing.Color.Transparent;
            this.close_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_button2.FlatAppearance.BorderSize = 0;
            this.close_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button2.Location = new System.Drawing.Point(687, 10);
            this.close_button2.Name = "close_button2";
            this.close_button2.Size = new System.Drawing.Size(29, 23);
            this.close_button2.TabIndex = 0;
            this.close_button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.close_button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(199, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 46);
            this.label1.TabIndex = 32;
            this.label1.Text = "UPDATE FACULTY";
            // 
            // cancelAddFac
            // 
            this.cancelAddFac.BackColor = System.Drawing.Color.Maroon;
            this.cancelAddFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelAddFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddFac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelAddFac.Location = new System.Drawing.Point(414, 259);
            this.cancelAddFac.Name = "cancelAddFac";
            this.cancelAddFac.Size = new System.Drawing.Size(126, 36);
            this.cancelAddFac.TabIndex = 37;
            this.cancelAddFac.Text = "Cancel";
            this.cancelAddFac.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Name";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(256, 206);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(438, 22);
            this.fName.TabIndex = 35;
            // 
            // facultyID
            // 
            this.facultyID.AutoSize = true;
            this.facultyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyID.ForeColor = System.Drawing.Color.Black;
            this.facultyID.Location = new System.Drawing.Point(40, 161);
            this.facultyID.Name = "facultyID";
            this.facultyID.Size = new System.Drawing.Size(100, 22);
            this.facultyID.TabIndex = 34;
            this.facultyID.Text = "Faculty ID";
            // 
            // fID
            // 
            this.fID.Location = new System.Drawing.Point(256, 161);
            this.fID.Name = "fID";
            this.fID.Size = new System.Drawing.Size(438, 22);
            this.fID.TabIndex = 33;
            // 
            // addfac
            // 
            this.addfac.BackColor = System.Drawing.Color.Maroon;
            this.addfac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addfac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addfac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addfac.Location = new System.Drawing.Point(564, 259);
            this.addfac.Name = "addfac";
            this.addfac.Size = new System.Drawing.Size(126, 36);
            this.addfac.TabIndex = 31;
            this.addfac.Text = "Update";
            this.addfac.UseVisualStyleBackColor = false;
            this.addfac.Click += new System.EventHandler(this.addfac_Click_1);
            // 
            // UpdateFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 331);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelAddFac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.facultyID);
            this.Controls.Add(this.fID);
            this.Controls.Add(this.addfac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel header;
        private Button close_button2;
        private Label label1;
        private Button cancelAddFac;
        private Label label5;
        private TextBox fName;
        private Label facultyID;
        private TextBox fID;
        private Button addfac;
    }
}