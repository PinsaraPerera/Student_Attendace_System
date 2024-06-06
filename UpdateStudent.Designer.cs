namespace StudentsManagementSystemForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudent));
            this.header = new System.Windows.Forms.Panel();
            this.close_button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.header.Size = new System.Drawing.Size(734, 43);
            this.header.TabIndex = 26;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // close_button2
            // 
            this.close_button2.BackColor = System.Drawing.Color.Transparent;
            this.close_button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button2.BackgroundImage")));
            this.close_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_button2.FlatAppearance.BorderSize = 0;
            this.close_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button2.Location = new System.Drawing.Point(695, 10);
            this.close_button2.Name = "close_button2";
            this.close_button2.Size = new System.Drawing.Size(29, 23);
            this.close_button2.TabIndex = 0;
            this.close_button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.close_button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aktiv Grotesk", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(181, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 64);
            this.label1.TabIndex = 16;
            this.label1.Text = "UPDATE STUDENT";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.comboBox2.Location = new System.Drawing.Point(252, 226);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(438, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bachelor of Engineering Technology",
            "Bachelor of Information and Communication Technology",
            "Bachelor of Science Honours in Computer Science"});
            this.comboBox1.Location = new System.Drawing.Point(252, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(438, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Aktiv Grotesk W01 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(410, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aktiv Grotesk W01 Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Student Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(252, 317);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(438, 22);
            this.textBox4.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aktiv Grotesk W01 Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Student ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(252, 272);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(438, 22);
            this.textBox3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aktiv Grotesk W01 Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Academic Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aktiv Grotesk W01 Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Degree Program";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Aktiv Grotesk W01 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(560, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 473);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "UpdateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button close_button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}