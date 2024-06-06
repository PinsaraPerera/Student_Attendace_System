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
            this.close_button2 = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_button2
            // 
            this.close_button2.BackColor = System.Drawing.Color.Transparent;
            this.close_button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button2.BackgroundImage")));
            this.close_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_button2.FlatAppearance.BorderSize = 0;
            this.close_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button2.Location = new System.Drawing.Point(692, 10);
            this.close_button2.Name = "close_button2";
            this.close_button2.Size = new System.Drawing.Size(29, 23);
            this.close_button2.TabIndex = 0;
            this.close_button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.close_button2.UseVisualStyleBackColor = false;
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
            this.header.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aktiv Grotesk W01 Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 90;
            this.label5.Text = "Faculty Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(220, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(472, 22);
            this.textBox4.TabIndex = 89;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Aktiv Grotesk W01 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(416, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 92;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Aktiv Grotesk W01 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(566, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 91;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Aktiv Grotesk W01 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(268, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 36);
            this.button3.TabIndex = 93;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // AddFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 193);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_button2;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}