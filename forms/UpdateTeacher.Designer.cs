namespace forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTeacher));
            header = new Panel();
            close_button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            TDepartment = new TextBox();
            cancelAddTeacher = new Button();
            label5 = new Label();
            TEmail = new TextBox();
            label4 = new Label();
            TName = new TextBox();
            addTeacher = new Button();
            label3 = new Label();
            teacherID = new TextBox();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(224, 224, 224);
            header.CausesValidation = false;
            header.Controls.Add(close_button2);
            header.Dock = DockStyle.Top;
            header.Enabled = false;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(737, 54);
            header.TabIndex = 32;
            // 
            // close_button2
            // 
            close_button2.BackColor = Color.Transparent;
            close_button2.BackgroundImage = (Image)resources.GetObject("close_button2.BackgroundImage");
            close_button2.BackgroundImageLayout = ImageLayout.Zoom;
            close_button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            close_button2.FlatAppearance.BorderSize = 0;
            close_button2.FlatStyle = FlatStyle.Flat;
            close_button2.Location = new Point(691, 12);
            close_button2.Margin = new Padding(3, 4, 3, 4);
            close_button2.Name = "close_button2";
            close_button2.Size = new Size(29, 29);
            close_button2.TabIndex = 0;
            close_button2.TextAlign = ContentAlignment.BottomLeft;
            close_button2.UseVisualStyleBackColor = false;
            close_button2.Click += close_button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aktiv Grotesk", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(195, 61);
            label1.Name = "label1";
            label1.Size = new Size(374, 64);
            label1.TabIndex = 26;
            label1.Text = "UPDATE TEACHER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 204);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 34;
            label2.Text = "Department";
            // 
            // TDepartment
            // 
            TDepartment.Location = new Point(252, 204);
            TDepartment.Margin = new Padding(3, 4, 3, 4);
            TDepartment.Name = "TDepartment";
            TDepartment.Size = new Size(438, 27);
            TDepartment.TabIndex = 33;
            // 
            // cancelAddTeacher
            // 
            cancelAddTeacher.BackColor = Color.Maroon;
            cancelAddTeacher.BackgroundImageLayout = ImageLayout.Center;
            cancelAddTeacher.FlatStyle = FlatStyle.Flat;
            cancelAddTeacher.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelAddTeacher.ForeColor = SystemColors.ControlLightLight;
            cancelAddTeacher.Location = new Point(410, 378);
            cancelAddTeacher.Margin = new Padding(3, 4, 3, 4);
            cancelAddTeacher.Name = "cancelAddTeacher";
            cancelAddTeacher.Size = new Size(126, 45);
            cancelAddTeacher.TabIndex = 31;
            cancelAddTeacher.Text = "Cancel";
            cancelAddTeacher.UseVisualStyleBackColor = false;
            cancelAddTeacher.Click += cancelAddTeacher_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 318);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // TEmail
            // 
            TEmail.Location = new Point(251, 318);
            TEmail.Margin = new Padding(3, 4, 3, 4);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(438, 27);
            TEmail.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 262);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 28;
            label4.Text = "Name";
            // 
            // TName
            // 
            TName.Location = new Point(251, 262);
            TName.Margin = new Padding(3, 4, 3, 4);
            TName.Name = "TName";
            TName.Size = new Size(438, 27);
            TName.TabIndex = 27;
            // 
            // addTeacher
            // 
            addTeacher.BackColor = Color.Maroon;
            addTeacher.BackgroundImageLayout = ImageLayout.Center;
            addTeacher.FlatStyle = FlatStyle.Flat;
            addTeacher.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTeacher.ForeColor = SystemColors.ControlLightLight;
            addTeacher.Location = new Point(560, 378);
            addTeacher.Margin = new Padding(3, 4, 3, 4);
            addTeacher.Name = "addTeacher";
            addTeacher.Size = new Size(126, 45);
            addTeacher.TabIndex = 25;
            addTeacher.Text = "Update";
            addTeacher.UseVisualStyleBackColor = false;
            addTeacher.Click += addTeacher_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 146);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 36;
            label3.Text = "Teacher ID";
            // 
            // teacherID
            // 
            teacherID.Location = new Point(252, 146);
            teacherID.Margin = new Padding(3, 4, 3, 4);
            teacherID.Name = "teacherID";
            teacherID.Size = new Size(438, 27);
            teacherID.TabIndex = 35;
            // 
            // UpdateTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 452);
            Controls.Add(label3);
            Controls.Add(teacherID);
            Controls.Add(header);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(TDepartment);
            Controls.Add(cancelAddTeacher);
            Controls.Add(label5);
            Controls.Add(TEmail);
            Controls.Add(label4);
            Controls.Add(TName);
            Controls.Add(addTeacher);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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