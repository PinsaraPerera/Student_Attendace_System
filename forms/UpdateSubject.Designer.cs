namespace forms
{
    partial class UpdateSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSubject));
            header = new Panel();
            close_button2 = new Button();
            subName = new TextBox();
            subCode = new TextBox();
            label6 = new Label();
            label1 = new Label();
            degreeName = new ComboBox();
            cancelAddNewSub = new Button();
            label4 = new Label();
            academicYear = new TextBox();
            label3 = new Label();
            label2 = new Label();
            addNewSub = new Button();
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
            header.Size = new Size(726, 54);
            header.TabIndex = 60;
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
            // subName
            // 
            subName.Location = new Point(252, 241);
            subName.Margin = new Padding(3, 4, 3, 4);
            subName.Name = "subName";
            subName.Size = new Size(438, 27);
            subName.TabIndex = 63;
            // 
            // subCode
            // 
            subCode.Location = new Point(252, 186);
            subCode.Margin = new Padding(3, 4, 3, 4);
            subCode.Name = "subCode";
            subCode.Size = new Size(438, 27);
            subCode.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(35, 186);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 61;
            label6.Text = "Subject Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aktiv Grotesk", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(193, 89);
            label1.Name = "label1";
            label1.Size = new Size(372, 64);
            label1.TabIndex = 53;
            label1.Text = "UPDATE SUBJECT";
            // 
            // degreeName
            // 
            degreeName.FormattingEnabled = true;
            degreeName.Items.AddRange(new object[] { "Bachelor of Engineering Technology (BET) ", "Bachelor of Information and Communication Technology (BICT)", "Bachelor of Science Honours in Computer Science" });
            degreeName.Location = new Point(252, 303);
            degreeName.Margin = new Padding(3, 4, 3, 4);
            degreeName.Name = "degreeName";
            degreeName.Size = new Size(438, 28);
            degreeName.TabIndex = 59;
            // 
            // cancelAddNewSub
            // 
            cancelAddNewSub.BackColor = Color.Maroon;
            cancelAddNewSub.BackgroundImageLayout = ImageLayout.Center;
            cancelAddNewSub.FlatStyle = FlatStyle.Flat;
            cancelAddNewSub.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelAddNewSub.ForeColor = SystemColors.ControlLightLight;
            cancelAddNewSub.Location = new Point(414, 429);
            cancelAddNewSub.Margin = new Padding(3, 4, 3, 4);
            cancelAddNewSub.Name = "cancelAddNewSub";
            cancelAddNewSub.Size = new Size(126, 45);
            cancelAddNewSub.TabIndex = 58;
            cancelAddNewSub.Text = "Cancel";
            cancelAddNewSub.UseVisualStyleBackColor = false;
            cancelAddNewSub.Click += cancelAddNewSub_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 361);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 57;
            label4.Text = "Year";
            // 
            // academicYear
            // 
            academicYear.Location = new Point(252, 361);
            academicYear.Margin = new Padding(3, 4, 3, 4);
            academicYear.Name = "academicYear";
            academicYear.Size = new Size(158, 27);
            academicYear.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 303);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 55;
            label3.Text = "Degree";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 243);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 54;
            label2.Text = "Subject Name";
            // 
            // addNewSub
            // 
            addNewSub.BackColor = Color.Maroon;
            addNewSub.BackgroundImageLayout = ImageLayout.Center;
            addNewSub.FlatStyle = FlatStyle.Flat;
            addNewSub.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewSub.ForeColor = SystemColors.ControlLightLight;
            addNewSub.Location = new Point(564, 429);
            addNewSub.Margin = new Padding(3, 4, 3, 4);
            addNewSub.Name = "addNewSub";
            addNewSub.Size = new Size(126, 45);
            addNewSub.TabIndex = 52;
            addNewSub.Text = "Update";
            addNewSub.UseVisualStyleBackColor = false;
            addNewSub.Click += addNewSub_Click;
            // 
            // UpdateSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 517);
            Controls.Add(header);
            Controls.Add(subName);
            Controls.Add(subCode);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(degreeName);
            Controls.Add(cancelAddNewSub);
            Controls.Add(label4);
            Controls.Add(academicYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addNewSub);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateSubject";
            StartPosition = FormStartPosition.CenterScreen;
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private Button close_button2;
        private TextBox subName;
        private TextBox subCode;
        private Label label6;
        private Label label1;
        private ComboBox degreeName;
        private Button cancelAddNewSub;
        private Label label4;
        private TextBox academicYear;
        private Label label3;
        private Label label2;
        private Button addNewSub;
    }
}