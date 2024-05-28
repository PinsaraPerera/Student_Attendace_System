using System;

namespace DashBord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashbord_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.log_out_btn = new System.Windows.Forms.Button();
            this.setting_btn = new System.Windows.Forms.Button();
            this.add_teacher_btn = new System.Windows.Forms.Button();
            this.leture_btn = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.add_student_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addLecture3 = new DashBord.AddLecture();
            this.addLecture2 = new DashBord.AddLecture();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.addTeacher = new DashBord.AddTeacher();
            this.sTudent1 = new DashBord.STudent();
            this.addLecture1 = new DashBord.AddLecture();
            this.addTeacher1 = new DashBord.AddTeacher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.dashbord_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.log_out_btn);
            this.panel1.Controls.Add(this.setting_btn);
            this.panel1.Controls.Add(this.add_teacher_btn);
            this.panel1.Controls.Add(this.leture_btn);
            this.panel1.Controls.Add(this.report_btn);
            this.panel1.Controls.Add(this.add_student_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 1016);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dashbord_btn
            // 
            this.dashbord_btn.AccessibleName = "dashbord_btn";
            this.dashbord_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.dashbord_btn.FlatAppearance.BorderSize = 0;
            this.dashbord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbord_btn.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbord_btn.ForeColor = System.Drawing.Color.White;
            this.dashbord_btn.Image = ((System.Drawing.Image)(resources.GetObject("dashbord_btn.Image")));
            this.dashbord_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashbord_btn.Location = new System.Drawing.Point(44, 250);
            this.dashbord_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashbord_btn.Name = "dashbord_btn";
            this.dashbord_btn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dashbord_btn.Size = new System.Drawing.Size(403, 59);
            this.dashbord_btn.TabIndex = 2;
            this.dashbord_btn.Text = "Dashbord\r\n\r\n";
            this.dashbord_btn.UseVisualStyleBackColor = false;
            this.dashbord_btn.Click += new System.EventHandler(this.dashbord_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 229);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // log_out_btn
            // 
            this.log_out_btn.AccessibleName = "log_out_btn";
            this.log_out_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.log_out_btn.FlatAppearance.BorderSize = 0;
            this.log_out_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_out_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_btn.ForeColor = System.Drawing.Color.White;
            this.log_out_btn.Image = ((System.Drawing.Image)(resources.GetObject("log_out_btn.Image")));
            this.log_out_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_out_btn.Location = new System.Drawing.Point(44, 878);
            this.log_out_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.log_out_btn.Name = "log_out_btn";
            this.log_out_btn.Size = new System.Drawing.Size(403, 53);
            this.log_out_btn.TabIndex = 9;
            this.log_out_btn.Text = "Log out\r\n\r\n\r\n\r\n";
            this.log_out_btn.UseVisualStyleBackColor = false;
            this.log_out_btn.Click += new System.EventHandler(this.log_out_btn_Click);
            // 
            // setting_btn
            // 
            this.setting_btn.AccessibleName = "setting_btn";
            this.setting_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.setting_btn.FlatAppearance.BorderSize = 0;
            this.setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.setting_btn.Image = ((System.Drawing.Image)(resources.GetObject("setting_btn.Image")));
            this.setting_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting_btn.Location = new System.Drawing.Point(44, 601);
            this.setting_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(281, 54);
            this.setting_btn.TabIndex = 7;
            this.setting_btn.Text = "Settings";
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click_1);
            // 
            // add_teacher_btn
            // 
            this.add_teacher_btn.AccessibleName = "add_teacher_btn";
            this.add_teacher_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.add_teacher_btn.FlatAppearance.BorderSize = 0;
            this.add_teacher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_teacher_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_teacher_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.add_teacher_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_teacher_btn.Image")));
            this.add_teacher_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_teacher_btn.Location = new System.Drawing.Point(44, 405);
            this.add_teacher_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_teacher_btn.Name = "add_teacher_btn";
            this.add_teacher_btn.Size = new System.Drawing.Size(259, 54);
            this.add_teacher_btn.TabIndex = 6;
            this.add_teacher_btn.Text = "Add Teacher";
            this.add_teacher_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_teacher_btn.UseVisualStyleBackColor = false;
            this.add_teacher_btn.Click += new System.EventHandler(this.add_teacher_btn_Click_1);
            // 
            // leture_btn
            // 
            this.leture_btn.AccessibleName = "leture_btn";
            this.leture_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.leture_btn.FlatAppearance.BorderSize = 0;
            this.leture_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leture_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leture_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.leture_btn.Image = ((System.Drawing.Image)(resources.GetObject("leture_btn.Image")));
            this.leture_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leture_btn.Location = new System.Drawing.Point(44, 470);
            this.leture_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leture_btn.Name = "leture_btn";
            this.leture_btn.Size = new System.Drawing.Size(336, 54);
            this.leture_btn.TabIndex = 5;
            this.leture_btn.Text = "Lecture Scheduling";
            this.leture_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.leture_btn.UseVisualStyleBackColor = false;
            this.leture_btn.Click += new System.EventHandler(this.leture_btn_Click);
            // 
            // report_btn
            // 
            this.report_btn.AccessibleName = "report_btn";
            this.report_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.report_btn.FlatAppearance.BorderSize = 0;
            this.report_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.report_btn.Image = ((System.Drawing.Image)(resources.GetObject("report_btn.Image")));
            this.report_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.report_btn.Location = new System.Drawing.Point(44, 535);
            this.report_btn.Margin = new System.Windows.Forms.Padding(0);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(281, 54);
            this.report_btn.TabIndex = 4;
            this.report_btn.Text = "Reports";
            this.report_btn.UseVisualStyleBackColor = false;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click_1);
            // 
            // add_student_btn
            // 
            this.add_student_btn.AccessibleName = "add_student_btn";
            this.add_student_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(218)))));
            this.add_student_btn.FlatAppearance.BorderSize = 0;
            this.add_student_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_student_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_student_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.add_student_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_student_btn.Image")));
            this.add_student_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_student_btn.Location = new System.Drawing.Point(44, 340);
            this.add_student_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_student_btn.Name = "add_student_btn";
            this.add_student_btn.Size = new System.Drawing.Size(259, 54);
            this.add_student_btn.TabIndex = 3;
            this.add_student_btn.Text = "Add Student\r\n\r\n";
            this.add_student_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_student_btn.UseVisualStyleBackColor = false;
            this.add_student_btn.Click += new System.EventHandler(this.add_student_btn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.addLecture3);
            this.panel2.Controls.Add(this.addLecture2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(464, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1459, 151);
            this.panel2.TabIndex = 1;
            // 
            // addLecture3
            // 
            this.addLecture3.ForeColor = System.Drawing.Color.White;
            this.addLecture3.Location = new System.Drawing.Point(83, 57);
            this.addLecture3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLecture3.Name = "addLecture3";
            this.addLecture3.Size = new System.Drawing.Size(8, 7);
            this.addLecture3.TabIndex = 5;
            // 
            // addLecture2
            // 
            this.addLecture2.ForeColor = System.Drawing.Color.White;
            this.addLecture2.Location = new System.Drawing.Point(147, 92);
            this.addLecture2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLecture2.Name = "addLecture2";
            this.addLecture2.Size = new System.Drawing.Size(8, 7);
            this.addLecture2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1293, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 71);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.label3.Location = new System.Drawing.Point(1048, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "University of Kelaniya\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.label1.Location = new System.Drawing.Point(669, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty of Computing and Technology\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // addTeacher
            // 
            this.addTeacher.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addTeacher.ForeColor = System.Drawing.Color.White;
            this.addTeacher.Location = new System.Drawing.Point(460, 157);
            this.addTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(1485, 930);
            this.addTeacher.TabIndex = 11;
            // 
            // sTudent1
            // 
            this.sTudent1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sTudent1.ForeColor = System.Drawing.Color.White;
            this.sTudent1.Location = new System.Drawing.Point(460, 157);
            this.sTudent1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sTudent1.Name = "sTudent1";
            this.sTudent1.Size = new System.Drawing.Size(1485, 930);
            this.sTudent1.TabIndex = 0;
            this.sTudent1.Load += new System.EventHandler(this.sTudent1_Load);
            // 
            // addLecture1
            // 
            this.addLecture1.ForeColor = System.Drawing.Color.White;
            this.addLecture1.Location = new System.Drawing.Point(460, 157);
            this.addLecture1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLecture1.Name = "addLecture1";
            this.addLecture1.Size = new System.Drawing.Size(1491, 930);
            this.addLecture1.TabIndex = 2;
            this.addLecture1.Load += new System.EventHandler(this.addLecture1_Load);
            // 
            // addTeacher1
            // 
            this.addTeacher1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addTeacher1.ForeColor = System.Drawing.Color.White;
            this.addTeacher1.Location = new System.Drawing.Point(0, 0);
            this.addTeacher1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTeacher1.Name = "addTeacher1";
            this.addTeacher1.Size = new System.Drawing.Size(1485, 842);
            this.addTeacher1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1923, 1016);
            this.Controls.Add(this.addTeacher);
            this.Controls.Add(this.sTudent1);
            this.Controls.Add(this.addLecture1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

       /* private void report_btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void add_student_btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

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
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Button log_out_btn;
        private System.Windows.Forms.Button report_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AddLecture addLecture1;
       // private EventHandler report_btn_Click;
        private EventHandler add_student_btn_Click;
        private AddTeacher addTeacher1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private STudent sTudent1;
        private AddLecture addLecture2;
        private AddLecture addLecture3;
        private AddTeacher addTeacher;
    }
}

