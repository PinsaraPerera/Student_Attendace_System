using System.Drawing;
using System.Windows.Forms;

namespace Student_Attendace_System.PopUpForms
{
    partial class UpdateStudent
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Panel();
            this.close_button2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.student_name = new System.Windows.Forms.Label();
            this.stName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.student_no = new System.Windows.Forms.Label();
            this.StNum = new System.Windows.Forms.TextBox();
            this.degree_id = new System.Windows.Forms.Label();
            this.dID = new System.Windows.Forms.TextBox();
            this.specialization_id = new System.Windows.Forms.Label();
            this.specializationId = new System.Windows.Forms.TextBox();
            this.facultyName = new System.Windows.Forms.TextBox();
            this.faculty = new System.Windows.Forms.Label();
            this.department_id = new System.Windows.Forms.Label();
            this.departmentName = new System.Windows.Forms.TextBox();
            this.img = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startingYr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailAdd = new System.Windows.Forms.TextBox();
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
            this.header.Size = new System.Drawing.Size(729, 43);
            this.header.TabIndex = 27;
            // 
            // close_button2
            // 
            this.close_button2.BackColor = System.Drawing.Color.Transparent;
            this.close_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_button2.FlatAppearance.BorderSize = 0;
            this.close_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button2.Location = new System.Drawing.Point(688, 10);
            this.close_button2.Name = "close_button2";
            this.close_button2.Size = new System.Drawing.Size(29, 23);
            this.close_button2.TabIndex = 0;
            this.close_button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.close_button2.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(415, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.ForeColor = System.Drawing.Color.Black;
            this.student_name.Location = new System.Drawing.Point(36, 147);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(136, 22);
            this.student_name.TabIndex = 23;
            this.student_name.Text = "Student Name";
            // 
            // stName
            // 
            this.stName.Location = new System.Drawing.Point(252, 147);
            this.stName.Name = "stName";
            this.stName.Size = new System.Drawing.Size(438, 22);
            this.stName.TabIndex = 22;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(36, 246);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(0, 22);
            this.email.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(197, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "UPDATE STUDENT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(565, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // student_no
            // 
            this.student_no.AutoSize = true;
            this.student_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_no.ForeColor = System.Drawing.Color.Black;
            this.student_no.Location = new System.Drawing.Point(36, 114);
            this.student_no.Name = "student_no";
            this.student_no.Size = new System.Drawing.Size(154, 22);
            this.student_no.TabIndex = 30;
            this.student_no.Text = "Student Number";
            // 
            // StNum
            // 
            this.StNum.Location = new System.Drawing.Point(252, 114);
            this.StNum.Name = "StNum";
            this.StNum.Size = new System.Drawing.Size(438, 22);
            this.StNum.TabIndex = 29;
            // 
            // degree_id
            // 
            this.degree_id.AutoSize = true;
            this.degree_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_id.ForeColor = System.Drawing.Color.Black;
            this.degree_id.Location = new System.Drawing.Point(36, 182);
            this.degree_id.Name = "degree_id";
            this.degree_id.Size = new System.Drawing.Size(100, 22);
            this.degree_id.TabIndex = 32;
            this.degree_id.Text = "Degree ID";
            // 
            // dID
            // 
            this.dID.Location = new System.Drawing.Point(252, 182);
            this.dID.Name = "dID";
            this.dID.Size = new System.Drawing.Size(438, 22);
            this.dID.TabIndex = 31;
            // 
            // specialization_id
            // 
            this.specialization_id.AutoSize = true;
            this.specialization_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialization_id.ForeColor = System.Drawing.Color.Black;
            this.specialization_id.Location = new System.Drawing.Point(36, 214);
            this.specialization_id.Name = "specialization_id";
            this.specialization_id.Size = new System.Drawing.Size(159, 22);
            this.specialization_id.TabIndex = 34;
            this.specialization_id.Text = "Specialization ID";
            // 
            // specializationId
            // 
            this.specializationId.Location = new System.Drawing.Point(252, 214);
            this.specializationId.Name = "specializationId";
            this.specializationId.Size = new System.Drawing.Size(438, 22);
            this.specializationId.TabIndex = 33;
            // 
            // facultyName
            // 
            this.facultyName.Location = new System.Drawing.Point(252, 278);
            this.facultyName.Name = "facultyName";
            this.facultyName.Size = new System.Drawing.Size(438, 22);
            this.facultyName.TabIndex = 35;
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty.ForeColor = System.Drawing.Color.Black;
            this.faculty.Location = new System.Drawing.Point(36, 278);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(75, 22);
            this.faculty.TabIndex = 36;
            this.faculty.Text = "Faculty";
            // 
            // department_id
            // 
            this.department_id.AutoSize = true;
            this.department_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_id.ForeColor = System.Drawing.Color.Black;
            this.department_id.Location = new System.Drawing.Point(36, 308);
            this.department_id.Name = "department_id";
            this.department_id.Size = new System.Drawing.Size(138, 22);
            this.department_id.TabIndex = 38;
            this.department_id.Text = "Department ID";
            // 
            // departmentName
            // 
            this.departmentName.Location = new System.Drawing.Point(252, 308);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(438, 22);
            this.departmentName.TabIndex = 37;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(252, 340);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(438, 22);
            this.img.TabIndex = 39;
            // 
            // image
            // 
            this.image.AutoSize = true;
            this.image.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.ForeColor = System.Drawing.Color.Black;
            this.image.Location = new System.Drawing.Point(36, 340);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(63, 22);
            this.image.TabIndex = 40;
            this.image.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Starting Year";
            // 
            // startingYr
            // 
            this.startingYr.Location = new System.Drawing.Point(252, 370);
            this.startingYr.Name = "startingYr";
            this.startingYr.Size = new System.Drawing.Size(438, 22);
            this.startingYr.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Email";
            // 
            // emailAdd
            // 
            this.emailAdd.Location = new System.Drawing.Point(253, 246);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.Size = new System.Drawing.Size(438, 22);
            this.emailAdd.TabIndex = 43;
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startingYr);
            this.Controls.Add(this.image);
            this.Controls.Add(this.img);
            this.Controls.Add(this.department_id);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.facultyName);
            this.Controls.Add(this.specialization_id);
            this.Controls.Add(this.specializationId);
            this.Controls.Add(this.degree_id);
            this.Controls.Add(this.dID);
            this.Controls.Add(this.student_no);
            this.Controls.Add(this.StNum);
            this.Controls.Add(this.header);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.stName);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateStudent";
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel header;
        private Button close_button2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button2;
        private Label student_name;
        private TextBox stName;
        private Label email;
        private Label label3;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label student_no;
        private TextBox StNum;
        private Label degree_id;
        private TextBox dID;
        private Label specialization_id;
        private TextBox specializationId;
        private TextBox facultyName;
        private Label faculty;
        private Label department_id;
        private TextBox departmentName;
        private TextBox img;
        private Label image;
        private Label label2;
        private TextBox startingYr;
        private TextBox emailAdd;
    }
}