namespace forms
{
    partial class UpdateStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudent));
            header = new Panel();
            close_button2 = new Button();
            button2 = new Button();
            student_name = new Label();
            stName = new TextBox();
            email = new Label();
            label1 = new Label();
            button1 = new Button();
            student_no = new Label();
            StNum = new TextBox();
            degree_id = new Label();
            dID = new TextBox();
            specialization_id = new Label();
            specializationId = new TextBox();
            facultyName = new TextBox();
            faculty = new Label();
            department_id = new Label();
            departmentName = new TextBox();
            img = new TextBox();
            image = new Label();
            label2 = new Label();
            startingYr = new TextBox();
            label3 = new Label();
            emailAdd = new TextBox();
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
            header.Size = new Size(729, 54);
            header.TabIndex = 27;
            header.Paint += header_Paint;
            // 
            // close_button2
            // 
            close_button2.BackColor = Color.Transparent;
            close_button2.BackgroundImage = (Image)resources.GetObject("close_button2.BackgroundImage");
            close_button2.BackgroundImageLayout = ImageLayout.Zoom;
            close_button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            close_button2.FlatAppearance.BorderSize = 0;
            close_button2.FlatStyle = FlatStyle.Flat;
            close_button2.Location = new Point(688, 12);
            close_button2.Margin = new Padding(3, 4, 3, 4);
            close_button2.Name = "close_button2";
            close_button2.Size = new Size(29, 29);
            close_button2.TabIndex = 0;
            close_button2.TextAlign = ContentAlignment.BottomLeft;
            close_button2.UseVisualStyleBackColor = false;
            close_button2.Click += close_button2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(415, 528);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(126, 45);
            button2.TabIndex = 24;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // student_name
            // 
            student_name.AutoSize = true;
            student_name.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            student_name.ForeColor = Color.Black;
            student_name.Location = new Point(36, 184);
            student_name.Name = "student_name";
            student_name.Size = new Size(142, 21);
            student_name.TabIndex = 23;
            student_name.Text = "Student Name";
            // 
            // stName
            // 
            stName.Location = new Point(252, 184);
            stName.Margin = new Padding(3, 4, 3, 4);
            stName.Name = "stName";
            stName.Size = new Size(438, 27);
            stName.TabIndex = 22;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.Black;
            email.Location = new Point(36, 308);
            email.Name = "email";
            email.Size = new Size(0, 21);
            email.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aktiv Grotesk", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(197, 57);
            label1.Name = "label1";
            label1.Size = new Size(376, 64);
            label1.TabIndex = 17;
            label1.Text = "UPDATE STUDENT";
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Aktiv Grotesk W01 Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(565, 528);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 45);
            button1.TabIndex = 16;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // student_no
            // 
            student_no.AutoSize = true;
            student_no.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            student_no.ForeColor = Color.Black;
            student_no.Location = new Point(36, 142);
            student_no.Name = "student_no";
            student_no.Size = new Size(162, 21);
            student_no.TabIndex = 30;
            student_no.Text = "Student Number";
            // 
            // StNum
            // 
            StNum.Location = new Point(252, 142);
            StNum.Margin = new Padding(3, 4, 3, 4);
            StNum.Name = "StNum";
            StNum.Size = new Size(438, 27);
            StNum.TabIndex = 29;
            StNum.TextChanged += textstudent_no_TextChanged;
            // 
            // degree_id
            // 
            degree_id.AutoSize = true;
            degree_id.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            degree_id.ForeColor = Color.Black;
            degree_id.Location = new Point(36, 227);
            degree_id.Name = "degree_id";
            degree_id.Size = new Size(102, 21);
            degree_id.TabIndex = 32;
            degree_id.Text = "Degree ID";
            // 
            // dID
            // 
            dID.Location = new Point(252, 227);
            dID.Margin = new Padding(3, 4, 3, 4);
            dID.Name = "dID";
            dID.Size = new Size(438, 27);
            dID.TabIndex = 31;
            // 
            // specialization_id
            // 
            specialization_id.AutoSize = true;
            specialization_id.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialization_id.ForeColor = Color.Black;
            specialization_id.Location = new Point(36, 268);
            specialization_id.Name = "specialization_id";
            specialization_id.Size = new Size(165, 21);
            specialization_id.TabIndex = 34;
            specialization_id.Text = "Specialization ID";
            // 
            // specializationId
            // 
            specializationId.Location = new Point(252, 268);
            specializationId.Margin = new Padding(3, 4, 3, 4);
            specializationId.Name = "specializationId";
            specializationId.Size = new Size(438, 27);
            specializationId.TabIndex = 33;
            // 
            // facultyName
            // 
            facultyName.Location = new Point(252, 347);
            facultyName.Margin = new Padding(3, 4, 3, 4);
            facultyName.Name = "facultyName";
            facultyName.Size = new Size(438, 27);
            facultyName.TabIndex = 35;
            // 
            // faculty
            // 
            faculty.AutoSize = true;
            faculty.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            faculty.ForeColor = Color.Black;
            faculty.Location = new Point(36, 347);
            faculty.Name = "faculty";
            faculty.Size = new Size(77, 21);
            faculty.TabIndex = 36;
            faculty.Text = "Faculty";
            faculty.Click += label2_Click;
            // 
            // department_id
            // 
            department_id.AutoSize = true;
            department_id.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            department_id.ForeColor = Color.Black;
            department_id.Location = new Point(36, 385);
            department_id.Name = "department_id";
            department_id.Size = new Size(146, 21);
            department_id.TabIndex = 38;
            department_id.Text = "Department ID";
            // 
            // departmentName
            // 
            departmentName.Location = new Point(252, 385);
            departmentName.Margin = new Padding(3, 4, 3, 4);
            departmentName.Name = "departmentName";
            departmentName.Size = new Size(438, 27);
            departmentName.TabIndex = 37;
            // 
            // img
            // 
            img.Location = new Point(252, 425);
            img.Margin = new Padding(3, 4, 3, 4);
            img.Name = "img";
            img.Size = new Size(438, 27);
            img.TabIndex = 39;
            // 
            // image
            // 
            image.AutoSize = true;
            image.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            image.ForeColor = Color.Black;
            image.Location = new Point(36, 425);
            image.Name = "image";
            image.Size = new Size(67, 21);
            image.TabIndex = 40;
            image.Text = "Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 463);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 42;
            label2.Text = "Starting Year";
            // 
            // startingYr
            // 
            startingYr.Location = new Point(252, 463);
            startingYr.Margin = new Padding(3, 4, 3, 4);
            startingYr.Name = "startingYr";
            startingYr.Size = new Size(438, 27);
            startingYr.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Aktiv Grotesk W01 Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(37, 307);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 44;
            label3.Text = "Email";
            // 
            // emailAdd
            // 
            emailAdd.Location = new Point(253, 307);
            emailAdd.Margin = new Padding(3, 4, 3, 4);
            emailAdd.Name = "emailAdd";
            emailAdd.Size = new Size(438, 27);
            emailAdd.TabIndex = 43;
            // 
            // UpdateStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 601);
            Controls.Add(label3);
            Controls.Add(emailAdd);
            Controls.Add(label2);
            Controls.Add(startingYr);
            Controls.Add(image);
            Controls.Add(img);
            Controls.Add(department_id);
            Controls.Add(departmentName);
            Controls.Add(faculty);
            Controls.Add(facultyName);
            Controls.Add(specialization_id);
            Controls.Add(specializationId);
            Controls.Add(degree_id);
            Controls.Add(dID);
            Controls.Add(student_no);
            Controls.Add(StNum);
            Controls.Add(header);
            Controls.Add(button2);
            Controls.Add(student_name);
            Controls.Add(stName);
            Controls.Add(email);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateStudent";
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private Button close_button2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button2;
        private Label student_name;
        private TextBox stName;
        private Label email;
        private Label label3;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label student_no;
        private TextBox StNum;
        private Label degree_id;
        private TextBox dID;
        private Label specialization_id;
        private TextBox specializationId;
        private TextBox facultyName;
        private Label faculty;
        private Label department_id;
        private TextBox departmentName;
        private TextBox img;
        private Label image;
        private Label label2;
        private TextBox startingYr;
        private TextBox emailAdd;
    }
}
