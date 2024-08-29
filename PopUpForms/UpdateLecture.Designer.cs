﻿using System.Drawing;
using System.Windows.Forms;

namespace Student_Attendace_System.PopUpForms
{
    partial class UpdateLecture
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
            this.acadYear = new System.Windows.Forms.TextBox();
            this.degname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lecEnd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lecStart = new System.Windows.Forms.TextBox();
            this.lecDay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lecHall = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lecID = new System.Windows.Forms.TextBox();
            this.facName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.close_button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelLecCreate = new System.Windows.Forms.Button();
            this.lecCreate = new System.Windows.Forms.Button();
            this.lectureID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // acadYear
            // 
            this.acadYear.Location = new System.Drawing.Point(188, 203);
            this.acadYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acadYear.Name = "acadYear";
            this.acadYear.Size = new System.Drawing.Size(120, 20);
            this.acadYear.TabIndex = 75;
            // 
            // degname
            // 
            this.degname.Location = new System.Drawing.Point(188, 166);
            this.degname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.degname.Name = "degname";
            this.degname.Size = new System.Drawing.Size(330, 20);
            this.degname.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(340, 388);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 73;
            this.label12.Text = "End:";
            // 
            // lecEnd
            // 
            this.lecEnd.Location = new System.Drawing.Point(392, 388);
            this.lecEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecEnd.Name = "lecEnd";
            this.lecEnd.Size = new System.Drawing.Size(74, 20);
            this.lecEnd.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(189, 388);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 71;
            this.label11.Text = "Start:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(26, 388);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 70;
            this.label10.Text = "Lecturer Time";
            // 
            // lecStart
            // 
            this.lecStart.Location = new System.Drawing.Point(241, 388);
            this.lecStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecStart.Name = "lecStart";
            this.lecStart.Size = new System.Drawing.Size(74, 20);
            this.lecStart.TabIndex = 69;
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
            this.lecDay.Location = new System.Drawing.Point(188, 351);
            this.lecDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecDay.Name = "lecDay";
            this.lecDay.Size = new System.Drawing.Size(330, 21);
            this.lecDay.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 351);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 67;
            this.label9.Text = "Lecture Day";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 316);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Lecturer Hall";
            // 
            // lecHall
            // 
            this.lecHall.Location = new System.Drawing.Point(188, 316);
            this.lecHall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecHall.Name = "lecHall";
            this.lecHall.Size = new System.Drawing.Size(330, 20);
            this.lecHall.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Lecturer\'s ID";
            // 
            // lecID
            // 
            this.lecID.Location = new System.Drawing.Point(188, 280);
            this.lecID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecID.Name = "lecID";
            this.lecID.Size = new System.Drawing.Size(330, 20);
            this.lecID.TabIndex = 63;
            // 
            // facName
            // 
            this.facName.Location = new System.Drawing.Point(189, 128);
            this.facName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facName.Name = "facName";
            this.facName.Size = new System.Drawing.Size(330, 20);
            this.facName.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 61;
            this.label6.Text = "Faculty";
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
            this.header.Size = new System.Drawing.Size(550, 35);
            this.header.TabIndex = 60;
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
            this.label1.Location = new System.Drawing.Point(149, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 37);
            this.label1.TabIndex = 54;
            this.label1.Text = "UPDATE LECTURE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Add Subject Code";
            // 
            // subCode
            // 
            this.subCode.Location = new System.Drawing.Point(189, 242);
            this.subCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subCode.Name = "subCode";
            this.subCode.Size = new System.Drawing.Size(120, 20);
            this.subCode.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Academic Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Degree Program";
            // 
            // cancelLecCreate
            // 
            this.cancelLecCreate.BackColor = System.Drawing.Color.Maroon;
            this.cancelLecCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelLecCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelLecCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelLecCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelLecCreate.Location = new System.Drawing.Point(310, 437);
            this.cancelLecCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelLecCreate.Name = "cancelLecCreate";
            this.cancelLecCreate.Size = new System.Drawing.Size(94, 29);
            this.cancelLecCreate.TabIndex = 59;
            this.cancelLecCreate.Text = "Cancel";
            this.cancelLecCreate.UseVisualStyleBackColor = false;
            this.cancelLecCreate.Click += new System.EventHandler(this.cancelLecCreate_Click_1);
            // 
            // lecCreate
            // 
            this.lecCreate.BackColor = System.Drawing.Color.Maroon;
            this.lecCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lecCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lecCreate.Location = new System.Drawing.Point(422, 437);
            this.lecCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lecCreate.Name = "lecCreate";
            this.lecCreate.Size = new System.Drawing.Size(94, 29);
            this.lecCreate.TabIndex = 53;
            this.lecCreate.Text = "Update";
            this.lecCreate.UseVisualStyleBackColor = false;
            this.lecCreate.Click += new System.EventHandler(this.lecCreate_Click);
            // 
            // lectureID
            // 
            this.lectureID.Location = new System.Drawing.Point(189, 95);
            this.lectureID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lectureID.Name = "lectureID";
            this.lectureID.Size = new System.Drawing.Size(330, 20);
            this.lectureID.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Lecture ID";
            // 
            // UpdateLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 492);
            this.Controls.Add(this.lectureID);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelLecCreate);
            this.Controls.Add(this.lecCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateLecture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox acadYear;
        private TextBox degname;
        private Label label12;
        private TextBox lecEnd;
        private Label label11;
        private Label label10;
        private TextBox lecStart;
        private ComboBox lecDay;
        private Label label9;
        private Label label8;
        private TextBox lecHall;
        private Label label7;
        private TextBox lecID;
        private TextBox facName;
        private Label label6;
        private Panel header;
        private Button close_button2;
        private Label label1;
        private Label label4;
        private TextBox subCode;
        private Label label3;
        private Label label2;
        private Button cancelLecCreate;
        private Button lecCreate;
        private TextBox lectureID;
        private Label label5;

    }

}