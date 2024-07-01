namespace StudentsManagementSystemForm
{
    partial class AddFaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFaculty));
            header = new Panel();
            close_button2 = new Button();
            cancelAddFac = new Button();
            label5 = new Label();
            fName = new TextBox();
            facultyID = new Label();
            fID = new TextBox();
            label1 = new Label();
            addfac = new Button();
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
            header.TabIndex = 30;
            // 
            // close_button2
            // 
            close_button2.BackColor = Color.Transparent;
            close_button2.BackgroundImage = (Image)resources.GetObject("close_button2.BackgroundImage");
            close_button2.BackgroundImageLayout = ImageLayout.Zoom;
            close_button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            close_button2.FlatAppearance.BorderSize = 0;
            close_button2.FlatStyle = FlatStyle.Flat;
            close_button2.Location = new Point(687, 12);
            close_button2.Margin = new Padding(3, 4, 3, 4);
            close_button2.Name = "close_button2";
            close_button2.Size = new Size(29, 29);
            close_button2.TabIndex = 0;
            close_button2.TextAlign = ContentAlignment.BottomLeft;
            close_button2.UseVisualStyleBackColor = false;
            close_button2.Click += close_button2_Click;
            // 
            // cancelAddFac
            // 
            cancelAddFac.BackColor = Color.Maroon;
            cancelAddFac.BackgroundImageLayout = ImageLayout.Center;
            cancelAddFac.FlatStyle = FlatStyle.Flat;
            cancelAddFac.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelAddFac.ForeColor = SystemColors.ControlLightLight;
            cancelAddFac.Location = new Point(410, 309);
            cancelAddFac.Margin = new Padding(3, 4, 3, 4);
            cancelAddFac.Name = "cancelAddFac";
            cancelAddFac.Size = new Size(126, 45);
            cancelAddFac.TabIndex = 29;
            cancelAddFac.Text = "Cancel";
            cancelAddFac.UseVisualStyleBackColor = false;
            cancelAddFac.Click += cancelAddFac_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(36, 242);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 28;
            label5.Text = "Name";
            // 
            // fName
            // 
            fName.Location = new Point(252, 242);
            fName.Margin = new Padding(3, 4, 3, 4);
            fName.Name = "fName";
            fName.Size = new Size(438, 27);
            fName.TabIndex = 27;
            fName.TextChanged += fName_TextChanged;
            // 
            // facultyID
            // 
            facultyID.AutoSize = true;
            facultyID.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            facultyID.ForeColor = Color.Black;
            facultyID.Location = new Point(36, 186);
            facultyID.Name = "facultyID";
            facultyID.Size = new Size(102, 21);
            facultyID.TabIndex = 26;
            facultyID.Text = "Faculty ID";
            // 
            // fID
            // 
            fID.Location = new Point(252, 186);
            fID.Margin = new Padding(3, 4, 3, 4);
            fID.Name = "fID";
            fID.Size = new Size(438, 27);
            fID.TabIndex = 25;
            fID.TextChanged += fID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aktiv Grotesk", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(230, 69);
            label1.Name = "label1";
            label1.Size = new Size(296, 64);
            label1.TabIndex = 24;
            label1.Text = "ADD FACULTY";
            // 
            // addfac
            // 
            addfac.BackColor = Color.Maroon;
            addfac.BackgroundImageLayout = ImageLayout.Center;
            addfac.FlatStyle = FlatStyle.Flat;
            addfac.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addfac.ForeColor = SystemColors.ControlLightLight;
            addfac.Location = new Point(560, 309);
            addfac.Margin = new Padding(3, 4, 3, 4);
            addfac.Name = "addfac";
            addfac.Size = new Size(126, 45);
            addfac.TabIndex = 23;
            addfac.Text = "Add";
            addfac.UseVisualStyleBackColor = false;
            addfac.Click += addfac_Click;
            // 
            // AddFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 418);
            Controls.Add(header);
            Controls.Add(cancelAddFac);
            Controls.Add(label5);
            Controls.Add(fName);
            Controls.Add(facultyID);
            Controls.Add(fID);
            Controls.Add(label1);
            Controls.Add(addfac);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddFaculty";
            StartPosition = FormStartPosition.CenterScreen;
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button close_button2;
        private System.Windows.Forms.Button cancelAddFac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label facultyID;
        private System.Windows.Forms.TextBox fID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addfac;
    }
}