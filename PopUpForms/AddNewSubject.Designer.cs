﻿using System.Drawing;
using System.Windows.Forms;

namespace Student_Attendace_System.PopUpForms
{
    partial class AddNewSubject
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
            this.degreeName = new System.Windows.Forms.ComboBox();
            this.cancelAddNewSub = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.academicYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewSub = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.subCode = new System.Windows.Forms.TextBox();
            this.subName = new System.Windows.Forms.TextBox();
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
            this.header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(544, 35);
            this.header.TabIndex = 26;
            // 
            // close_button2
            // 
            this.close_button2.BackColor = System.Drawing.Color.Transparent;
            this.close_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_button2.FlatAppearance.BorderSize = 0;
            this.close_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button2.Location = new System.Drawing.Point(512, 8);
            this.close_button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close_button2.Name = "close_button2";
            this.close_button2.Size = new System.Drawing.Size(22, 19);
            this.close_button2.TabIndex = 0;
            this.close_button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.close_button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(126, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "ADD NEW SUBJECT";
            // 
            // degreeName
            // 
            this.degreeName.FormattingEnabled = true;
            this.degreeName.Items.AddRange(new object[] {
            "Bachelor of Engineering Technology (BET) ",
            "Bachelor of Information and Communication Technology (BICT)",
            "Bachelor of Science Honours in Computer Science"});
            this.degreeName.Location = new System.Drawing.Point(189, 197);
            this.degreeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.degreeName.Name = "degreeName";
            this.degreeName.Size = new System.Drawing.Size(330, 21);
            this.degreeName.TabIndex = 25;
            // 
            // cancelAddNewSub
            // 
            this.cancelAddNewSub.BackColor = System.Drawing.Color.Maroon;
            this.cancelAddNewSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelAddNewSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddNewSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddNewSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelAddNewSub.Location = new System.Drawing.Point(310, 278);
            this.cancelAddNewSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelAddNewSub.Name = "cancelAddNewSub";
            this.cancelAddNewSub.Size = new System.Drawing.Size(94, 29);
            this.cancelAddNewSub.TabIndex = 23;
            this.cancelAddNewSub.Text = "Cancel";
            this.cancelAddNewSub.UseVisualStyleBackColor = false;
            this.cancelAddNewSub.Click += new System.EventHandler(this.cancelAddNewSub_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Year";
            // 
            // academicYear
            // 
            this.academicYear.Location = new System.Drawing.Point(189, 234);
            this.academicYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.academicYear.Name = "academicYear";
            this.academicYear.Size = new System.Drawing.Size(120, 20);
            this.academicYear.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Degree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Subject Name";
            // 
            // addNewSub
            // 
            this.addNewSub.BackColor = System.Drawing.Color.Maroon;
            this.addNewSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNewSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewSub.Location = new System.Drawing.Point(423, 278);
            this.addNewSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addNewSub.Name = "addNewSub";
            this.addNewSub.Size = new System.Drawing.Size(94, 29);
            this.addNewSub.TabIndex = 15;
            this.addNewSub.Text = "Add";
            this.addNewSub.UseVisualStyleBackColor = false;
            this.addNewSub.Click += new System.EventHandler(this.addNewSub_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Subject Code";
            // 
            // subCode
            // 
            this.subCode.Location = new System.Drawing.Point(189, 120);
            this.subCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subCode.Name = "subCode";
            this.subCode.Size = new System.Drawing.Size(330, 20);
            this.subCode.TabIndex = 28;
            // 
            // subName
            // 
            this.subName.Location = new System.Drawing.Point(189, 156);
            this.subName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(330, 20);
            this.subName.TabIndex = 51;
            // 
            // AddNewSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 338);
            this.Controls.Add(this.subName);
            this.Controls.Add(this.subCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degreeName);
            this.Controls.Add(this.cancelAddNewSub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.academicYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNewSub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button close_button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox degreeName;
        private System.Windows.Forms.Button cancelAddNewSub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox academicYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewSub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subCode;
        private TextBox subName;
        
    }
}