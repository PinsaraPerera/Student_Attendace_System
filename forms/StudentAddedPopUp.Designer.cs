﻿namespace StudentsManagementSystemForm
{
    partial class StudentAddedPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAddedPopUp));
            button2 = new Button();
            header = new Panel();
            close_button = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Aktiv Grotesk W01 Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(211, 114);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(70, 28);
            button2.TabIndex = 11;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(224, 224, 224);
            header.CausesValidation = false;
            header.Controls.Add(close_button);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(493, 39);
            header.TabIndex = 13;
            header.Paint += header_Paint;
            // 
            // close_button
            // 
            close_button.BackColor = Color.Transparent;
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Zoom;
            close_button.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.Location = new Point(466, 10);
            close_button.Margin = new Padding(3, 4, 3, 4);
            close_button.Name = "close_button";
            close_button.Size = new Size(17, 19);
            close_button.TabIndex = 0;
            close_button.TextAlign = ContentAlignment.BottomLeft;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(108, 68);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aktiv Grotesk W01 Thin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(133, 68);
            label1.Name = "label1";
            label1.Size = new Size(244, 20);
            label1.TabIndex = 4;
            label1.Text = "Student Added Successfully";
            label1.Click += label2_Click;
            // 
            // StudentAddedPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 174);
            Controls.Add(header);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentAddedPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}