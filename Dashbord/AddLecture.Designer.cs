namespace Student_Attendace_System.Dashbord
{
    
        partial class AddLecture
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

            #region Component Designer generated code

            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_lecture_btn = new System.Windows.Forms.Button();
            this.lecture_lb = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.search_txtBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.showAll_btn = new System.Windows.Forms.Button();
            this.dataView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.chekBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academic_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecture_hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.create_lecture_btn);
            this.panel1.Controls.Add(this.lecture_lb);
            this.panel1.Location = new System.Drawing.Point(21, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 50);
            this.panel1.TabIndex = 0;
            // 
            // create_lecture_btn
            // 
            this.create_lecture_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.create_lecture_btn.FlatAppearance.BorderSize = 0;
            this.create_lecture_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_lecture_btn.Image = global::Student_Attendace_System.Properties.Resources.icons8_list_50;
            this.create_lecture_btn.Location = new System.Drawing.Point(16, 3);
            this.create_lecture_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.create_lecture_btn.Name = "create_lecture_btn";
            this.create_lecture_btn.Size = new System.Drawing.Size(40, 44);
            this.create_lecture_btn.TabIndex = 15;
            this.create_lecture_btn.UseVisualStyleBackColor = false;
            this.create_lecture_btn.Click += new System.EventHandler(this.create_lecture_btn_Click);
            // 
            // lecture_lb
            // 
            this.lecture_lb.AutoSize = true;
            this.lecture_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecture_lb.ForeColor = System.Drawing.Color.White;
            this.lecture_lb.Location = new System.Drawing.Point(102, 2);
            this.lecture_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lecture_lb.Name = "lecture_lb";
            this.lecture_lb.Size = new System.Drawing.Size(393, 36);
            this.lecture_lb.TabIndex = 1;
            this.lecture_lb.Text = "CREATE A NEW LECTURE";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(446, 108);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(132, 31);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search Subject\r\n";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(764, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(6, 6);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // search_txtBox
            // 
            this.search_txtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.search_txtBox.Location = new System.Drawing.Point(21, 108);
            this.search_txtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_txtBox.Name = "search_txtBox";
            this.search_txtBox.Size = new System.Drawing.Size(398, 29);
            this.search_txtBox.TabIndex = 4;
            this.search_txtBox.Text = "Enter Lecture Id";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 201);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 29);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Year";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(21, 201);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(398, 29);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Degree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Degree Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(442, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Academic Year";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(603, 197);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "Filter";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(946, 201);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 31);
            this.button4.TabIndex = 12;
            this.button4.Text = "Bulk Delete\r\n\r\n";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // showAll_btn
            // 
            this.showAll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.showAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_btn.Location = new System.Drawing.Point(590, 108);
            this.showAll_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(37, 31);
            this.showAll_btn.TabIndex = 18;
            this.showAll_btn.Text = "All";
            this.showAll_btn.UseVisualStyleBackColor = false;
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.dataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView.ColumnHeadersHeight = 45;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chekBox,
            this.lecId,
            this.faculty,
            this.degree,
            this.academic_year,
            this.subject_code,
            this.teacher_id,
            this.day,
            this.start_time,
            this.end_time,
            this.lecture_hall,
            this.updateBtn,
            this.deletBtn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataView.Location = new System.Drawing.Point(21, 259);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataView.RowHeadersVisible = false;
            this.dataView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.dataView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataView.Size = new System.Drawing.Size(1057, 348);
            this.dataView.TabIndex = 22;
            this.dataView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dataView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            this.dataView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.dataView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.dataView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataView.ThemeStyle.HeaderStyle.Height = 45;
            this.dataView.ThemeStyle.ReadOnly = true;
            this.dataView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.RowsStyle.Height = 22;
            this.dataView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Image = global::Student_Attendace_System.Properties.Resources.icons8_back_30;
            this.back_btn.Location = new System.Drawing.Point(997, 630);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(81, 34);
            this.back_btn.TabIndex = 14;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // chekBox
            // 
            this.chekBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chekBox.FillWeight = 152.2842F;
            this.chekBox.HeaderText = "";
            this.chekBox.MinimumWidth = 10;
            this.chekBox.Name = "chekBox";
            this.chekBox.ReadOnly = true;
            this.chekBox.Width = 20;
            // 
            // lecId
            // 
            this.lecId.FillWeight = 35.49452F;
            this.lecId.HeaderText = "Lecture Id";
            this.lecId.MinimumWidth = 6;
            this.lecId.Name = "lecId";
            this.lecId.ReadOnly = true;
            this.lecId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lecId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // faculty
            // 
            this.faculty.FillWeight = 35.49452F;
            this.faculty.HeaderText = "Faculty";
            this.faculty.MinimumWidth = 6;
            this.faculty.Name = "faculty";
            this.faculty.ReadOnly = true;
            // 
            // degree
            // 
            this.degree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.degree.FillWeight = 35.49452F;
            this.degree.HeaderText = "Degree";
            this.degree.MinimumWidth = 6;
            this.degree.Name = "degree";
            this.degree.ReadOnly = true;
            this.degree.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.degree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.degree.Width = 150;
            // 
            // academic_year
            // 
            this.academic_year.FillWeight = 35.49452F;
            this.academic_year.HeaderText = "Academic year";
            this.academic_year.MinimumWidth = 6;
            this.academic_year.Name = "academic_year";
            this.academic_year.ReadOnly = true;
            // 
            // subject_code
            // 
            this.subject_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.subject_code.FillWeight = 35.49452F;
            this.subject_code.HeaderText = "Subject code";
            this.subject_code.MinimumWidth = 6;
            this.subject_code.Name = "subject_code";
            this.subject_code.ReadOnly = true;
            // 
            // teacher_id
            // 
            this.teacher_id.FillWeight = 35.49452F;
            this.teacher_id.HeaderText = "Teacher";
            this.teacher_id.MinimumWidth = 6;
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.ReadOnly = true;
            // 
            // day
            // 
            this.day.FillWeight = 35.49452F;
            this.day.HeaderText = "Day";
            this.day.MinimumWidth = 6;
            this.day.Name = "day";
            this.day.ReadOnly = true;
            // 
            // start_time
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.start_time.DefaultCellStyle = dataGridViewCellStyle3;
            this.start_time.FillWeight = 35.49452F;
            this.start_time.HeaderText = "Start time";
            this.start_time.MinimumWidth = 6;
            this.start_time.Name = "start_time";
            this.start_time.ReadOnly = true;
            // 
            // end_time
            // 
            this.end_time.FillWeight = 37.6837F;
            this.end_time.HeaderText = "End time";
            this.end_time.MinimumWidth = 6;
            this.end_time.Name = "end_time";
            this.end_time.ReadOnly = true;
            // 
            // lecture_hall
            // 
            this.lecture_hall.FillWeight = 37.6837F;
            this.lecture_hall.HeaderText = "Lecture hall";
            this.lecture_hall.MinimumWidth = 6;
            this.lecture_hall.Name = "lecture_hall";
            this.lecture_hall.ReadOnly = true;
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.updateBtn.FillWeight = 298.8227F;
            this.updateBtn.HeaderText = "Update";
            this.updateBtn.MinimumWidth = 6;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ReadOnly = true;
            this.updateBtn.Text = "update";
            this.updateBtn.UseColumnTextForButtonValue = true;
            this.updateBtn.Width = 70;
            // 
            // deletBtn
            // 
            this.deletBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deletBtn.FillWeight = 495.3789F;
            this.deletBtn.HeaderText = "Delete";
            this.deletBtn.MinimumWidth = 6;
            this.deletBtn.Name = "deletBtn";
            this.deletBtn.ReadOnly = true;
            this.deletBtn.Text = "Delete";
            this.deletBtn.UseColumnTextForButtonValue = true;
            this.deletBtn.Width = 70;
            // 
            // AddLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.search_txtBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataView);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddLecture";
            this.Size = new System.Drawing.Size(1114, 684);
            this.Load += new System.EventHandler(this.AddLecture_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Panel panel1;
            private System.Windows.Forms.Label lecture_lb;
   
            private System.Windows.Forms.Button search_btn;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.TextBox search_txtBox;
            private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
            private System.ComponentModel.BackgroundWorker backgroundWorker1;
            private System.Windows.Forms.ComboBox comboBox1;
            private System.Windows.Forms.ComboBox comboBox2;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Button button3;
            private System.Windows.Forms.Button button4;
            private System.Windows.Forms.Button back_btn;
            private System.Windows.Forms.Button create_lecture_btn;
            private System.Windows.Forms.Button showAll_btn;
        private Guna.UI2.WinForms.Guna2DataGridView dataView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chekBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecId;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn academic_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecture_hall;
        private System.Windows.Forms.DataGridViewButtonColumn updateBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deletBtn;
    }
}


