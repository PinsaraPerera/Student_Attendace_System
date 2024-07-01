namespace StudentsManagementSystemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewLecture));
            header = new Panel();
            close_button2 = new Button();
            label1 = new Label();
            cancelLecCreate = new Button();
            label4 = new Label();
            subCode = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lecCreate = new Button();
            label6 = new Label();
            facName = new TextBox();
            label7 = new Label();
            lecID = new TextBox();
            label8 = new Label();
            lecHall = new TextBox();
            lecDay = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            lecStart = new TextBox();
            label11 = new Label();
            label12 = new Label();
            lecEnd = new TextBox();
            degname = new TextBox();
            acadYear = new TextBox();
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
            header.Size = new Size(725, 54);
            header.TabIndex = 26;
            // 
            // close_button2
            // 
            close_button2.BackColor = Color.Transparent;
            close_button2.BackgroundImage = (Image)resources.GetObject("close_button2.BackgroundImage");
            close_button2.BackgroundImageLayout = ImageLayout.Zoom;
            close_button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            close_button2.FlatAppearance.BorderSize = 0;
            close_button2.FlatStyle = FlatStyle.Flat;
            close_button2.Location = new Point(685, 12);
            close_button2.Margin = new Padding(3, 4, 3, 4);
            close_button2.Name = "close_button2";
            close_button2.Size = new Size(29, 29);
            close_button2.TabIndex = 0;
            close_button2.TextAlign = ContentAlignment.BottomLeft;
            close_button2.UseVisualStyleBackColor = false;
            close_button2.Click += close_button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aktiv Grotesk", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(114, 70);
            label1.Name = "label1";
            label1.Size = new Size(506, 64);
            label1.TabIndex = 16;
            label1.Text = "CREATE A NEW LECTURE";
            // 
            // cancelLecCreate
            // 
            cancelLecCreate.BackColor = Color.Maroon;
            cancelLecCreate.BackgroundImageLayout = ImageLayout.Center;
            cancelLecCreate.FlatStyle = FlatStyle.Flat;
            cancelLecCreate.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelLecCreate.ForeColor = SystemColors.ControlLightLight;
            cancelLecCreate.Location = new Point(413, 660);
            cancelLecCreate.Margin = new Padding(3, 4, 3, 4);
            cancelLecCreate.Name = "cancelLecCreate";
            cancelLecCreate.Size = new Size(126, 45);
            cancelLecCreate.TabIndex = 23;
            cancelLecCreate.Text = "Cancel";
            cancelLecCreate.UseVisualStyleBackColor = false;
            cancelLecCreate.Click += cancelLecCreate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 360);
            label4.Name = "label4";
            label4.Size = new Size(176, 21);
            label4.TabIndex = 20;
            label4.Text = "Add Subject Code";
            // 
            // subCode
            // 
            subCode.Location = new Point(252, 360);
            subCode.Margin = new Padding(3, 4, 3, 4);
            subCode.Name = "subCode";
            subCode.Size = new Size(158, 27);
            subCode.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 302);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 18;
            label3.Text = "Academic Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 242);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 17;
            label2.Text = "Degree Program";
            // 
            // lecCreate
            // 
            lecCreate.BackColor = Color.Maroon;
            lecCreate.BackgroundImageLayout = ImageLayout.Center;
            lecCreate.FlatStyle = FlatStyle.Flat;
            lecCreate.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecCreate.ForeColor = SystemColors.ControlLightLight;
            lecCreate.Location = new Point(563, 660);
            lecCreate.Margin = new Padding(3, 4, 3, 4);
            lecCreate.Name = "lecCreate";
            lecCreate.Size = new Size(126, 45);
            lecCreate.TabIndex = 15;
            lecCreate.Text = "Create";
            lecCreate.UseVisualStyleBackColor = false;
            lecCreate.Click += lecCreate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(35, 185);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 27;
            label6.Text = "Faculty";
            // 
            // facName
            // 
            facName.Location = new Point(252, 185);
            facName.Margin = new Padding(3, 4, 3, 4);
            facName.Name = "facName";
            facName.Size = new Size(438, 27);
            facName.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(35, 417);
            label7.Name = "label7";
            label7.Size = new Size(129, 21);
            label7.TabIndex = 30;
            label7.Text = "Lecturer's ID";
            // 
            // lecID
            // 
            lecID.Location = new Point(251, 417);
            lecID.Margin = new Padding(3, 4, 3, 4);
            lecID.Name = "lecID";
            lecID.Size = new Size(438, 27);
            lecID.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(35, 473);
            label8.Name = "label8";
            label8.Size = new Size(129, 21);
            label8.TabIndex = 32;
            label8.Text = "Lecturer Hall";
            // 
            // lecHall
            // 
            lecHall.Location = new Point(251, 473);
            lecHall.Margin = new Padding(3, 4, 3, 4);
            lecHall.Name = "lecHall";
            lecHall.Size = new Size(438, 27);
            lecHall.TabIndex = 31;
            // 
            // lecDay
            // 
            lecDay.FormattingEnabled = true;
            lecDay.Items.AddRange(new object[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" });
            lecDay.Location = new Point(251, 527);
            lecDay.Margin = new Padding(3, 4, 3, 4);
            lecDay.Name = "lecDay";
            lecDay.Size = new Size(438, 28);
            lecDay.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(35, 527);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 33;
            label9.Text = "Lecture Day";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(35, 583);
            label10.Name = "label10";
            label10.Size = new Size(139, 21);
            label10.TabIndex = 36;
            label10.Text = "Lecturer Time";
            // 
            // lecStart
            // 
            lecStart.Location = new Point(321, 583);
            lecStart.Margin = new Padding(3, 4, 3, 4);
            lecStart.Name = "lecStart";
            lecStart.Size = new Size(98, 27);
            lecStart.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(252, 583);
            label11.Name = "label11";
            label11.Size = new Size(63, 21);
            label11.TabIndex = 37;
            label11.Text = "Start:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(453, 583);
            label12.Name = "label12";
            label12.Size = new Size(50, 21);
            label12.TabIndex = 39;
            label12.Text = "End:";
            // 
            // lecEnd
            // 
            lecEnd.Location = new Point(522, 583);
            lecEnd.Margin = new Padding(3, 4, 3, 4);
            lecEnd.Name = "lecEnd";
            lecEnd.Size = new Size(98, 27);
            lecEnd.TabIndex = 38;
            // 
            // degname
            // 
            degname.Location = new Point(251, 242);
            degname.Margin = new Padding(3, 4, 3, 4);
            degname.Name = "degname";
            degname.Size = new Size(438, 27);
            degname.TabIndex = 51;
            // 
            // acadYear
            // 
            acadYear.Location = new Point(251, 300);
            acadYear.Margin = new Padding(3, 4, 3, 4);
            acadYear.Name = "acadYear";
            acadYear.Size = new Size(158, 27);
            acadYear.TabIndex = 52;
            // 
            // CreateNewLecture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 738);
            Controls.Add(acadYear);
            Controls.Add(degname);
            Controls.Add(label12);
            Controls.Add(lecEnd);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(lecStart);
            Controls.Add(lecDay);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lecHall);
            Controls.Add(label7);
            Controls.Add(lecID);
            Controls.Add(facName);
            Controls.Add(label6);
            Controls.Add(header);
            Controls.Add(label1);
            Controls.Add(cancelLecCreate);
            Controls.Add(label4);
            Controls.Add(subCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lecCreate);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateNewLecture";
            StartPosition = FormStartPosition.CenterScreen;
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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