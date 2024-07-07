using System.Drawing;
using System.Windows.Forms;

namespace Student_Attendace_System.PopUpForms
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
            this.header = new System.Windows.Forms.Panel();
            this.cancelAddFac = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.facultyID = new System.Windows.Forms.Label();
            this.fID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addfac = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.header.CausesValidation = false;
            this.header.Controls.Add(this.guna2Button1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Enabled = false;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(726, 43);
            this.header.TabIndex = 30;
            // 
            // cancelAddFac
            // 
            this.cancelAddFac.BackColor = System.Drawing.Color.Maroon;
            this.cancelAddFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelAddFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddFac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelAddFac.Location = new System.Drawing.Point(410, 247);
            this.cancelAddFac.Name = "cancelAddFac";
            this.cancelAddFac.Size = new System.Drawing.Size(126, 36);
            this.cancelAddFac.TabIndex = 29;
            this.cancelAddFac.Text = "Cancel";
            this.cancelAddFac.UseVisualStyleBackColor = false;
            this.cancelAddFac.Click += new System.EventHandler(this.cancelAddFac_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Name";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(252, 194);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(438, 22);
            this.fName.TabIndex = 27;
            // 
            // facultyID
            // 
            this.facultyID.AutoSize = true;
            this.facultyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyID.ForeColor = System.Drawing.Color.Black;
            this.facultyID.Location = new System.Drawing.Point(36, 149);
            this.facultyID.Name = "facultyID";
            this.facultyID.Size = new System.Drawing.Size(100, 22);
            this.facultyID.TabIndex = 26;
            this.facultyID.Text = "Faculty ID";
            // 
            // fID
            // 
            this.fID.Location = new System.Drawing.Point(252, 149);
            this.fID.Name = "fID";
            this.fID.Size = new System.Drawing.Size(438, 22);
            this.fID.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(230, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "ADD FACULTY";
            // 
            // addfac
            // 
            this.addfac.BackColor = System.Drawing.Color.Maroon;
            this.addfac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addfac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addfac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addfac.Location = new System.Drawing.Point(560, 247);
            this.addfac.Name = "addfac";
            this.addfac.Size = new System.Drawing.Size(126, 36);
            this.addfac.TabIndex = 23;
            this.addfac.Text = "Add";
            this.addfac.UseVisualStyleBackColor = false;
            this.addfac.Click += new System.EventHandler(this.addfac_Click_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Empty;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.SystemColors.Window;
            this.guna2Button1.Image = global::Student_Attendace_System.Properties.Resources.close;
            this.guna2Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2Button1.Location = new System.Drawing.Point(693, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(33, 35);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // AddFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 334);
            this.Controls.Add(this.header);
            this.Controls.Add(this.cancelAddFac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.facultyID);
            this.Controls.Add(this.fID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addfac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button cancelAddFac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label facultyID;
        private System.Windows.Forms.TextBox fID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addfac;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}