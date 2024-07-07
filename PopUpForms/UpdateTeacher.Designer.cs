using System.Drawing;
using System.Windows.Forms;

namespace Student_Attendace_System.PopUpForms
{
    partial class UpdateTeacher
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
            this.label2 = new System.Windows.Forms.Label();
            this.TDepartment = new System.Windows.Forms.TextBox();
            this.cancelAddTeacher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.addTeacher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherID = new System.Windows.Forms.TextBox();
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
            this.header.Size = new System.Drawing.Size(737, 43);
            this.header.TabIndex = 32;
            // 
            // close_button2
            // 
            this.close_button2.BackColor = System.Drawing.Color.Transparent;
            this.close_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_button2.FlatAppearance.BorderSize = 0;
            this.close_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button2.Location = new System.Drawing.Point(691, 10);
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
            this.label1.Location = new System.Drawing.Point(195, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 46);
            this.label1.TabIndex = 26;
            this.label1.Text = "UPDATE TEACHER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Department";
            // 
            // TDepartment
            // 
            this.TDepartment.Location = new System.Drawing.Point(252, 163);
            this.TDepartment.Name = "TDepartment";
            this.TDepartment.Size = new System.Drawing.Size(438, 22);
            this.TDepartment.TabIndex = 33;
            // 
            // cancelAddTeacher
            // 
            this.cancelAddTeacher.BackColor = System.Drawing.Color.Maroon;
            this.cancelAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelAddTeacher.Location = new System.Drawing.Point(410, 302);
            this.cancelAddTeacher.Name = "cancelAddTeacher";
            this.cancelAddTeacher.Size = new System.Drawing.Size(126, 36);
            this.cancelAddTeacher.TabIndex = 31;
            this.cancelAddTeacher.Text = "Cancel";
            this.cancelAddTeacher.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email";
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(251, 254);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(438, 22);
            this.TEmail.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(251, 210);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(438, 22);
            this.TName.TabIndex = 27;
            // 
            // addTeacher
            // 
            this.addTeacher.BackColor = System.Drawing.Color.Maroon;
            this.addTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTeacher.Location = new System.Drawing.Point(560, 302);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(126, 36);
            this.addTeacher.TabIndex = 25;
            this.addTeacher.Text = "Update";
            this.addTeacher.UseVisualStyleBackColor = false;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Teacher ID";
            // 
            // teacherID
            // 
            this.teacherID.Location = new System.Drawing.Point(252, 117);
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(438, 22);
            this.teacherID.TabIndex = 35;
            // 
            // UpdateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacherID);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TDepartment);
            this.Controls.Add(this.cancelAddTeacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.addTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateTeacher";
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
        private Label label2;
        private TextBox TDepartment;
        private Button cancelAddTeacher;
        private Label label5;
        private TextBox TEmail;
        private Label label4;
        private TextBox TName;
        private Button addTeacher;
        private Label label3;
        private TextBox teacherID;
    }
}