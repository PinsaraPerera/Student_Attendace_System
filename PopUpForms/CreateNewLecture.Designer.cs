﻿using System.Drawing;
using System.Windows.Forms;

namespace Student_Attendace_System.PopUpForms
{
    partial class CreateNewLecture
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
            this.cancelLecCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.subCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lecCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.facName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lecID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lecHall = new System.Windows.Forms.TextBox();
            this.lecDay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lecStart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lecEnd = new System.Windows.Forms.TextBox();
            this.degname = new System.Windows.Forms.TextBox();
            this.acadYear = new System.Windows.Forms.TextBox();
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
            this.close_button2.Location = new System.Drawing.Point(514, 8);
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
            this.label1.Location = new System.Drawing.Point(86, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "CREATE A NEW LECTURE";
            // 
            // cancelLecCreate
            // 
            this.cancelLecCreate.BackColor = System.Drawing.Color.Maroon;
            this.cancelLecCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelLecCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelLecCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelLecCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelLecCreate.Location = new System.Drawing.Point(310, 429);
            this.cancelLecCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelLecCreate.Name = "cancelLecCreate";
            this.cancelLecCreate.Size = new System.Drawing.Size(94, 29);
            this.cancelLecCreate.TabIndex = 23;
            this.cancelLecCreate.Text = "Cancel";
            this.cancelLecCreate.UseVisualStyleBackColor = false;
            this.cancelLecCreate.Click += new System.EventHandler(this.cancelLecCreate_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Add Subject Code";
            // 
            // subCode
            // 
            this.subCode.Location = new System.Drawing.Point(189, 234);
            this.subCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subCode.Name = "subCode";
            this.subCode.Size = new System.Drawing.Size(120, 20);
            this.subCode.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Academic Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Degree Program";
            // 
            // lecCreate
            // 
            this.lecCreate.BackColor = System.Drawing.Color.Maroon;
            this.lecCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lecCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lecCreate.Location = new System.Drawing.Point(422, 429);
            this.lecCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecCreate.Name = "lecCreate";
            this.lecCreate.Size = new System.Drawing.Size(94, 29);
            this.lecCreate.TabIndex = 15;
            this.lecCreate.Text = "Create";
            this.lecCreate.UseVisualStyleBackColor = false;
            this.lecCreate.Click += new System.EventHandler(this.lecCreate_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Faculty";
            // 
            // facName
            // 
            this.facName.Location = new System.Drawing.Point(189, 120);
            this.facName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facName.Name = "facName";
            this.facName.Size = new System.Drawing.Size(330, 20);
            this.facName.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Lecturer\'s ID";
            // 
            // lecID
            // 
            this.lecID.Location = new System.Drawing.Point(188, 271);
            this.lecID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecID.Name = "lecID";
            this.lecID.Size = new System.Drawing.Size(330, 20);
            this.lecID.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 307);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Lecturer Hall";
            // 
            // lecHall
            // 
            this.lecHall.Location = new System.Drawing.Point(188, 307);
            this.lecHall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecHall.Name = "lecHall";
            this.lecHall.Size = new System.Drawing.Size(330, 20);
            this.lecHall.TabIndex = 31;
            // 
            // lecDay
            // 
            this.lecDay.FormattingEnabled = true;
            this.lecDay.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
            this.lecDay.Location = new System.Drawing.Point(188, 343);
            this.lecDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecDay.Name = "lecDay";
            this.lecDay.Size = new System.Drawing.Size(330, 21);
            this.lecDay.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 343);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "Lecture Day";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(26, 379);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "Lecturer Time";
            // 
            // lecStart
            // 
            this.lecStart.Location = new System.Drawing.Point(241, 379);
            this.lecStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecStart.Name = "lecStart";
            this.lecStart.Size = new System.Drawing.Size(74, 20);
            this.lecStart.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(189, 379);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 37;
            this.label11.Text = "Start:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(340, 379);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 39;
            this.label12.Text = "End:";
            // 
            // lecEnd
            // 
            this.lecEnd.Location = new System.Drawing.Point(392, 379);
            this.lecEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecEnd.Name = "lecEnd";
            this.lecEnd.Size = new System.Drawing.Size(74, 20);
            this.lecEnd.TabIndex = 38;
            // 
            // degname
            // 
            this.degname.Location = new System.Drawing.Point(188, 158);
            this.degname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.degname.Name = "degname";
            this.degname.Size = new System.Drawing.Size(330, 20);
            this.degname.TabIndex = 51;
            // 
            // acadYear
            // 
            this.acadYear.Location = new System.Drawing.Point(188, 195);
            this.acadYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acadYear.Name = "acadYear";
            this.acadYear.Size = new System.Drawing.Size(120, 20);
            this.acadYear.TabIndex = 52;
            // 
            // CreateNewLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 479);
            this.Controls.Add(this.acadYear);
            this.Controls.Add(this.degname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lecEnd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lecStart);
            this.Controls.Add(this.lecDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lecHall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lecID);
            this.Controls.Add(this.facName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelLecCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lecCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateNewLecture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button close_button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelLecCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lecCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox facName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lecID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lecHall;
        private System.Windows.Forms.ComboBox lecDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lecStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lecEnd;
        private TextBox degname;
        private TextBox acadYear;
    }
}