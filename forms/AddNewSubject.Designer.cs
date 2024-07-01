namespace StudentsManagementSystemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSubject));
            header = new Panel();
            close_button2 = new Button();
            label1 = new Label();
            degreeName = new ComboBox();
            cancelAddNewSub = new Button();
            label4 = new Label();
            academicYear = new TextBox();
            label3 = new Label();
            label2 = new Label();
            addNewSub = new Button();
            label6 = new Label();
            subCode = new TextBox();
            subName = new TextBox();
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
            close_button2.Location = new Point(683, 12);
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
            label1.Location = new Point(168, 70);
            label1.Name = "label1";
            label1.Size = new Size(406, 64);
            label1.TabIndex = 16;
            label1.Text = "ADD NEW SUBJECT";
            // 
            // degreeName
            // 
            degreeName.FormattingEnabled = true;
            degreeName.Items.AddRange(new object[] { "Bachelor of Engineering Technology (BET) ", "Bachelor of Information and Communication Technology (BICT)", "Bachelor of Science Honours in Computer Science" });
            degreeName.Location = new Point(252, 302);
            degreeName.Margin = new Padding(3, 4, 3, 4);
            degreeName.Name = "degreeName";
            degreeName.Size = new Size(438, 28);
            degreeName.TabIndex = 25;
            // 
            // cancelAddNewSub
            // 
            cancelAddNewSub.BackColor = Color.Maroon;
            cancelAddNewSub.BackgroundImageLayout = ImageLayout.Center;
            cancelAddNewSub.FlatStyle = FlatStyle.Flat;
            cancelAddNewSub.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelAddNewSub.ForeColor = SystemColors.ControlLightLight;
            cancelAddNewSub.Location = new Point(414, 428);
            cancelAddNewSub.Margin = new Padding(3, 4, 3, 4);
            cancelAddNewSub.Name = "cancelAddNewSub";
            cancelAddNewSub.Size = new Size(126, 45);
            cancelAddNewSub.TabIndex = 23;
            cancelAddNewSub.Text = "Cancel";
            cancelAddNewSub.UseVisualStyleBackColor = false;
            cancelAddNewSub.Click += cancelAddNewSub_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 360);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 20;
            label4.Text = "Year";
            // 
            // academicYear
            // 
            academicYear.Location = new Point(252, 360);
            academicYear.Margin = new Padding(3, 4, 3, 4);
            academicYear.Name = "academicYear";
            academicYear.Size = new Size(158, 27);
            academicYear.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 302);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 18;
            label3.Text = "Degree";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 242);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 17;
            label2.Text = "Subject Name";
            // 
            // addNewSub
            // 
            addNewSub.BackColor = Color.Maroon;
            addNewSub.BackgroundImageLayout = ImageLayout.Center;
            addNewSub.FlatStyle = FlatStyle.Flat;
            addNewSub.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewSub.ForeColor = SystemColors.ControlLightLight;
            addNewSub.Location = new Point(564, 428);
            addNewSub.Margin = new Padding(3, 4, 3, 4);
            addNewSub.Name = "addNewSub";
            addNewSub.Size = new Size(126, 45);
            addNewSub.TabIndex = 15;
            addNewSub.Text = "Add";
            addNewSub.UseVisualStyleBackColor = false;
            addNewSub.Click += addNewSub_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(35, 185);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 27;
            label6.Text = "Subject Code";
            // 
            // subCode
            // 
            subCode.Location = new Point(252, 185);
            subCode.Margin = new Padding(3, 4, 3, 4);
            subCode.Name = "subCode";
            subCode.Size = new Size(438, 27);
            subCode.TabIndex = 28;
            subCode.TextChanged += subCode_TextChanged;
            // 
            // subName
            // 
            subName.Location = new Point(252, 240);
            subName.Margin = new Padding(3, 4, 3, 4);
            subName.Name = "subName";
            subName.Size = new Size(438, 27);
            subName.TabIndex = 51;
            // 
            // AddNewSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 520);
            Controls.Add(subName);
            Controls.Add(subCode);
            Controls.Add(label6);
            Controls.Add(header);
            Controls.Add(label1);
            Controls.Add(degreeName);
            Controls.Add(cancelAddNewSub);
            Controls.Add(label4);
            Controls.Add(academicYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addNewSub);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddNewSubject";
            StartPosition = FormStartPosition.CenterScreen;
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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