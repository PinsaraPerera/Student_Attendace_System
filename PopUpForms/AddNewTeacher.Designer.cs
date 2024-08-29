﻿using System.Drawing;
using System.Windows.Forms;

namespace Student_Attendace_System.PopUpForms
{
    partial class AddNewTeacher
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
            this.cancelAddTeacher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addTeacher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TDepartment = new System.Windows.Forms.TextBox();
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
            this.header.Size = new System.Drawing.Size(547, 35);
            this.header.TabIndex = 22;
            // 
            // close_button2
            // 
            this.close_button2.BackColor = System.Drawing.Color.Transparent;
            this.close_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_button2.FlatAppearance.BorderSize = 0;
            this.close_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button2.Location = new System.Drawing.Point(518, 8);
            this.close_button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close_button2.Name = "close_button2";
            this.close_button2.Size = new System.Drawing.Size(22, 19);
            this.close_button2.TabIndex = 0;
            this.close_button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.close_button2.UseVisualStyleBackColor = false;
            // 
            // cancelAddTeacher
            // 
            this.cancelAddTeacher.BackColor = System.Drawing.Color.Maroon;
            this.cancelAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelAddTeacher.Location = new System.Drawing.Point(308, 228);
            this.cancelAddTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelAddTeacher.Name = "cancelAddTeacher";
            this.cancelAddTeacher.Size = new System.Drawing.Size(94, 29);
            this.cancelAddTeacher.TabIndex = 21;
            this.cancelAddTeacher.Text = "Cancel";
            this.cancelAddTeacher.UseVisualStyleBackColor = false;
            this.cancelAddTeacher.Click += new System.EventHandler(this.cancelAddTeacher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(188, 184);
            this.TEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(330, 20);
            this.TEmail.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(188, 148);
            this.TName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(330, 20);
            this.TName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(126, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "ADD NEW TEACHER";
            // 
            // addTeacher
            // 
            this.addTeacher.BackColor = System.Drawing.Color.Maroon;
            this.addTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTeacher.Location = new System.Drawing.Point(420, 228);
            this.addTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(94, 29);
            this.addTeacher.TabIndex = 15;
            this.addTeacher.Text = "Add Teacher";
            this.addTeacher.UseVisualStyleBackColor = false;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Department";
            // 
            // TDepartment
            // 
            this.TDepartment.Location = new System.Drawing.Point(189, 110);
            this.TDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TDepartment.Name = "TDepartment";
            this.TDepartment.Size = new System.Drawing.Size(330, 20);
            this.TDepartment.TabIndex = 23;
            // 
            // AddNewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TDepartment);
            this.Controls.Add(this.header);
            this.Controls.Add(this.cancelAddTeacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button close_button2;
        private System.Windows.Forms.Button cancelAddTeacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTeacher;
        private Label label2;
        private TextBox TDepartment;
    }
}