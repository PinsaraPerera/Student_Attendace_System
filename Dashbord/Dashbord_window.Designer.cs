using System.Windows.Forms;
using System;

namespace Student_Attendace_System.Dashbord
{
    partial class Dashbord_window : Form
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoLb2 = new System.Windows.Forms.Label();
            this.logoLb1 = new System.Windows.Forms.Label();
            this.uniLogoPicBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.facultyLb = new System.Windows.Forms.Label();
            this.uniLb = new System.Windows.Forms.Label();
            this.Add_Faculty_btn = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.leture_btn = new System.Windows.Forms.Button();
            this.add_teacher_btn = new System.Windows.Forms.Button();
            this.add_student_btn = new System.Windows.Forms.Button();
            this.dashbord_btn = new System.Windows.Forms.Button();
            this.log_out_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addTeacher2 = new Student_Attendace_System.Dashbord.AddTeacher();
            this.addStudent1 = new Student_Attendace_System.Dashbord.AddStudent();
            this.addLecture2 = new Student_Attendace_System.Dashbord.AddLecture();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logo_pic_box = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addTeacher = new Student_Attendace_System.Dashbord.AddTeacher();
            this.sTudent1 = new Student_Attendace_System.Dashbord.AddStudent();
            this.addLecture1 = new Student_Attendace_System.Dashbord.AddLecture();
            this.addTeacher1 = new Student_Attendace_System.Dashbord.AddTeacher();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniLogoPicBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.Add_Faculty_btn);
            this.panel1.Controls.Add(this.logoLb2);
            this.panel1.Controls.Add(this.add_student_btn);
            this.panel1.Controls.Add(this.add_teacher_btn);
            this.panel1.Controls.Add(this.logoLb1);
            this.panel1.Controls.Add(this.leture_btn);
            this.panel1.Controls.Add(this.uniLogoPicBox);
            this.panel1.Controls.Add(this.report_btn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dashbord_btn);
            this.panel1.Controls.Add(this.log_out_btn);
            this.panel1.Controls.Add(this.addTeacher2);
            this.panel1.Controls.Add(this.addStudent1);
            this.panel1.Controls.Add(this.addLecture2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1081);
            this.panel1.TabIndex = 0;
            // 
            // logoLb2
            // 
            this.logoLb2.AutoSize = true;
            this.logoLb2.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.logoLb2.Location = new System.Drawing.Point(152, 112);
            this.logoLb2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.logoLb2.Name = "logoLb2";
            this.logoLb2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.logoLb2.Size = new System.Drawing.Size(218, 39);
            this.logoLb2.TabIndex = 16;
            this.logoLb2.Text = "University of Kelaniya\r";
            this.logoLb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoLb1
            // 
            this.logoLb1.AutoSize = true;
            this.logoLb1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.logoLb1.Location = new System.Drawing.Point(151, 41);
            this.logoLb1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.logoLb1.Name = "logoLb1";
            this.logoLb1.Size = new System.Drawing.Size(264, 74);
            this.logoLb1.TabIndex = 15;
            this.logoLb1.Text = "Student Attendance\r\nSystem";
            this.logoLb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uniLogoPicBox
            // 
            this.uniLogoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uniLogoPicBox.Image = global::Student_Attendace_System.Properties.Resources.university_of_kelaniya_logo;
            this.uniLogoPicBox.Location = new System.Drawing.Point(4, 28);
            this.uniLogoPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.uniLogoPicBox.Name = "uniLogoPicBox";
            this.uniLogoPicBox.Size = new System.Drawing.Size(136, 129);
            this.uniLogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uniLogoPicBox.TabIndex = 14;
            this.uniLogoPicBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.facultyLb);
            this.panel4.Controls.Add(this.uniLb);
            this.panel4.Location = new System.Drawing.Point(435, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1485, 128);
            this.panel4.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::Student_Attendace_System.Properties.Resources.icons8_setting_50__1____Copy;
            this.pictureBox3.Location = new System.Drawing.Point(1299, 28);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 56);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // facultyLb
            // 
            this.facultyLb.AutoSize = true;
            this.facultyLb.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.facultyLb.Location = new System.Drawing.Point(696, 11);
            this.facultyLb.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.facultyLb.Name = "facultyLb";
            this.facultyLb.Size = new System.Drawing.Size(535, 41);
            this.facultyLb.TabIndex = 0;
            this.facultyLb.Text = "Faculty of Computing and Technology\r\n";
            this.facultyLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uniLb
            // 
            this.uniLb.AutoSize = true;
            this.uniLb.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.uniLb.Location = new System.Drawing.Point(696, 63);
            this.uniLb.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.uniLb.Name = "uniLb";
            this.uniLb.Size = new System.Drawing.Size(281, 37);
            this.uniLb.TabIndex = 2;
            this.uniLb.Text = "University of Kelaniya\r\n";
            // 
            // Add_Faculty_btn
            // 
            this.Add_Faculty_btn.AccessibleName = "add_faculty_btn";
            this.Add_Faculty_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.Add_Faculty_btn.FlatAppearance.BorderSize = 0;
            this.Add_Faculty_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Faculty_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Faculty_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.Add_Faculty_btn.Image = global::Student_Attendace_System.Properties.Resources.school;
            this.Add_Faculty_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Faculty_btn.Location = new System.Drawing.Point(51, 538);
            this.Add_Faculty_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Add_Faculty_btn.Name = "Add_Faculty_btn";
            this.Add_Faculty_btn.Size = new System.Drawing.Size(319, 66);
            this.Add_Faculty_btn.TabIndex = 7;
            this.Add_Faculty_btn.Text = "Add Faculty";
            this.Add_Faculty_btn.UseVisualStyleBackColor = false;
            this.Add_Faculty_btn.Click += new System.EventHandler(this.Add_Faculty_btn_Click);
            // 
            // report_btn
            // 
            this.report_btn.AccessibleName = "report_btn";
            this.report_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.report_btn.FlatAppearance.BorderSize = 0;
            this.report_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.report_btn.Image = global::Student_Attendace_System.Properties.Resources.icons8_reports;
            this.report_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.report_btn.Location = new System.Drawing.Point(51, 685);
            this.report_btn.Margin = new System.Windows.Forms.Padding(0);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(319, 66);
            this.report_btn.TabIndex = 4;
            this.report_btn.Text = "Reports";
            this.report_btn.UseVisualStyleBackColor = false;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // leture_btn
            // 
            this.leture_btn.AccessibleName = "leture_btn";
            this.leture_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.leture_btn.FlatAppearance.BorderSize = 0;
            this.leture_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leture_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leture_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.leture_btn.Image = global::Student_Attendace_System.Properties.Resources.icons8_meeting_room_100;
            this.leture_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leture_btn.Location = new System.Drawing.Point(51, 614);
            this.leture_btn.Margin = new System.Windows.Forms.Padding(5);
            this.leture_btn.Name = "leture_btn";
            this.leture_btn.Size = new System.Drawing.Size(319, 66);
            this.leture_btn.TabIndex = 5;
            this.leture_btn.Text = "Lecture Scheduling";
            this.leture_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.leture_btn.UseVisualStyleBackColor = false;
            this.leture_btn.Click += new System.EventHandler(this.leture_btn_Click);
            // 
            // add_teacher_btn
            // 
            this.add_teacher_btn.AccessibleName = "add_teacher_btn";
            this.add_teacher_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.add_teacher_btn.FlatAppearance.BorderSize = 0;
            this.add_teacher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_teacher_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_teacher_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.add_teacher_btn.Image = global::Student_Attendace_System.Properties.Resources.icons8_teacher;
            this.add_teacher_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_teacher_btn.Location = new System.Drawing.Point(51, 462);
            this.add_teacher_btn.Margin = new System.Windows.Forms.Padding(5);
            this.add_teacher_btn.Name = "add_teacher_btn";
            this.add_teacher_btn.Size = new System.Drawing.Size(319, 66);
            this.add_teacher_btn.TabIndex = 6;
            this.add_teacher_btn.Text = "Add Teacher";
            this.add_teacher_btn.UseVisualStyleBackColor = false;
            this.add_teacher_btn.Click += new System.EventHandler(this.add_teacher_btn_Click);
            // 
            // add_student_btn
            // 
            this.add_student_btn.AccessibleName = "add_student_btn";
            this.add_student_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.add_student_btn.FlatAppearance.BorderSize = 0;
            this.add_student_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_student_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_student_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.add_student_btn.Image = global::Student_Attendace_System.Properties.Resources.icons8_student;
            this.add_student_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_student_btn.Location = new System.Drawing.Point(51, 386);
            this.add_student_btn.Margin = new System.Windows.Forms.Padding(5);
            this.add_student_btn.Name = "add_student_btn";
            this.add_student_btn.Size = new System.Drawing.Size(319, 66);
            this.add_student_btn.TabIndex = 3;
            this.add_student_btn.Text = "Add Student\r\n\r\n";
            this.add_student_btn.UseVisualStyleBackColor = false;
            this.add_student_btn.Click += new System.EventHandler(this.add_student_btn_Click_1);
            // 
            // dashbord_btn
            // 
            this.dashbord_btn.AccessibleName = "dashbord_btn";
            this.dashbord_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.dashbord_btn.FlatAppearance.BorderSize = 0;
            this.dashbord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbord_btn.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbord_btn.ForeColor = System.Drawing.Color.White;
            this.dashbord_btn.Image = global::Student_Attendace_System.Properties.Resources.icons8_dashboard_48;
            this.dashbord_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashbord_btn.Location = new System.Drawing.Point(51, 255);
            this.dashbord_btn.Margin = new System.Windows.Forms.Padding(5);
            this.dashbord_btn.Name = "dashbord_btn";
            this.dashbord_btn.Padding = new System.Windows.Forms.Padding(4, 0, 33, 0);
            this.dashbord_btn.Size = new System.Drawing.Size(319, 55);
            this.dashbord_btn.TabIndex = 2;
            this.dashbord_btn.Text = "Dashbord\r\n\r\n";
            this.dashbord_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashbord_btn.UseVisualStyleBackColor = false;
            this.dashbord_btn.Click += new System.EventHandler(this.dashbord_btn_Click);
            // 
            // log_out_btn
            // 
            this.log_out_btn.AccessibleName = "log_out_btn";
            this.log_out_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.log_out_btn.FlatAppearance.BorderSize = 0;
            this.log_out_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_out_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_btn.ForeColor = System.Drawing.Color.White;
            this.log_out_btn.Image = global::Student_Attendace_System.Properties.Resources.icons8_logout;
            this.log_out_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_out_btn.Location = new System.Drawing.Point(51, 964);
            this.log_out_btn.Margin = new System.Windows.Forms.Padding(5);
            this.log_out_btn.Name = "log_out_btn";
            this.log_out_btn.Size = new System.Drawing.Size(319, 46);
            this.log_out_btn.TabIndex = 9;
            this.log_out_btn.Text = "Log out\r\n\r\n\r\n\r\n";
            this.log_out_btn.UseVisualStyleBackColor = false;
            this.log_out_btn.Click += new System.EventHandler(this.log_out_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(437, 130);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1483, 951);
            this.panel5.TabIndex = 17;
            // 
            // addTeacher2
            // 
            this.addTeacher2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addTeacher2.ForeColor = System.Drawing.Color.White;
            this.addTeacher2.Location = new System.Drawing.Point(433, 134);
            this.addTeacher2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTeacher2.Name = "addTeacher2";
            this.addTeacher2.Size = new System.Drawing.Size(1485, 946);
            this.addTeacher2.TabIndex = 12;
            // 
            // addStudent1
            // 
            this.addStudent1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addStudent1.ForeColor = System.Drawing.Color.White;
            this.addStudent1.Location = new System.Drawing.Point(435, 134);
            this.addStudent1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStudent1.Name = "addStudent1";
            this.addStudent1.Size = new System.Drawing.Size(1485, 946);
            this.addStudent1.TabIndex = 11;
            // 
            // addLecture2
            // 
            this.addLecture2.ForeColor = System.Drawing.Color.White;
            this.addLecture2.Location = new System.Drawing.Point(435, 134);
            this.addLecture2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLecture2.Name = "addLecture2";
            this.addLecture2.Size = new System.Drawing.Size(1485, 946);
            this.addLecture2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 123);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 1081);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // logo_pic_box
            // 
            this.logo_pic_box.Location = new System.Drawing.Point(37, 0);
            this.logo_pic_box.Name = "logo_pic_box";
            this.logo_pic_box.Size = new System.Drawing.Size(358, 154);
            this.logo_pic_box.TabIndex = 12;
            this.logo_pic_box.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // addTeacher
            // 
            this.addTeacher.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addTeacher.ForeColor = System.Drawing.Color.White;
            this.addTeacher.Location = new System.Drawing.Point(0, 0);
            this.addTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(1114, 684);
            this.addTeacher.TabIndex = 0;
            // 
            // sTudent1
            // 
            this.sTudent1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sTudent1.ForeColor = System.Drawing.Color.White;
            this.sTudent1.Location = new System.Drawing.Point(0, 0);
            this.sTudent1.Margin = new System.Windows.Forms.Padding(2);
            this.sTudent1.Name = "sTudent1";
            this.sTudent1.Size = new System.Drawing.Size(1114, 684);
            this.sTudent1.TabIndex = 0;
            // 
            // addLecture1
            // 
            this.addLecture1.ForeColor = System.Drawing.Color.White;
            this.addLecture1.Location = new System.Drawing.Point(0, 0);
            this.addLecture1.Margin = new System.Windows.Forms.Padding(2);
            this.addLecture1.Name = "addLecture1";
            this.addLecture1.Size = new System.Drawing.Size(1114, 684);
            this.addLecture1.TabIndex = 0;
            // 
            // addTeacher1
            // 
            this.addTeacher1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addTeacher1.ForeColor = System.Drawing.Color.White;
            this.addTeacher1.Location = new System.Drawing.Point(0, 0);
            this.addTeacher1.Margin = new System.Windows.Forms.Padding(2);
            this.addTeacher1.Name = "addTeacher1";
            this.addTeacher1.Size = new System.Drawing.Size(1114, 684);
            this.addTeacher1.TabIndex = 0;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Dashbord_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1081);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dashbord_window";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniLogoPicBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dashbord_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Button add_student_btn;
        private System.Windows.Forms.Button add_teacher_btn;
        private System.Windows.Forms.Button leture_btn;
        private System.Windows.Forms.Button Add_Faculty_btn;
        private System.Windows.Forms.Button log_out_btn;
        private System.Windows.Forms.Button report_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AddLecture addLecture1;
        // private EventHandler report_btn_Click;
        private EventHandler add_student_btn_Click;
        private AddTeacher addTeacher1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AddStudent sTudent1;
        private AddTeacher addTeacher;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox logo_pic_box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AddTeacher addTeacher2;
        private AddStudent addStudent1;
        private AddLecture addLecture2;
        private Panel panel4;
        private Label facultyLb;
        private Label uniLb;
        private PictureBox pictureBox3;
        private PictureBox uniLogoPicBox;
        private Label logoLb1;
        private Label logoLb2;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}