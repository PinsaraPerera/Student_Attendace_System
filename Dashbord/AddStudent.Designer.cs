using System.Windows.Forms;
using System;

namespace Student_Attendace_System.Dashbord
{
    partial class AddStudent
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
            this.add_std_btn = new System.Windows.Forms.Button();
            this.student_lb = new System.Windows.Forms.Label();
            this.serch_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.search_txtBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.showAll_btn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dataView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.chekBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starting_yr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.add_std_btn);
            this.panel1.Controls.Add(this.student_lb);
            this.panel1.Location = new System.Drawing.Point(21, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 50);
            this.panel1.TabIndex = 0;
            // 
            // add_std_btn
            // 
            this.add_std_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.add_std_btn.FlatAppearance.BorderSize = 0;
            this.add_std_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_std_btn.Image = global::Student_Attendace_System.Properties.Resources.icons8_list_50;
            this.add_std_btn.Location = new System.Drawing.Point(15, 2);
            this.add_std_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_std_btn.Name = "add_std_btn";
            this.add_std_btn.Size = new System.Drawing.Size(40, 44);
            this.add_std_btn.TabIndex = 15;
            this.add_std_btn.UseVisualStyleBackColor = false;
            this.add_std_btn.Click += new System.EventHandler(this.add_std_btn_Click);
            // 
            // student_lb
            // 
            this.student_lb.AutoSize = true;
            this.student_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_lb.ForeColor = System.Drawing.Color.White;
            this.student_lb.Location = new System.Drawing.Point(102, 2);
            this.student_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.student_lb.Name = "student_lb";
            this.student_lb.Size = new System.Drawing.Size(306, 36);
            this.student_lb.TabIndex = 1;
            this.student_lb.Text = "ADD NEW STUDENT\r\n";
            // 
            // serch_btn
            // 
            this.serch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.serch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serch_btn.Location = new System.Drawing.Point(446, 108);
            this.serch_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serch_btn.Name = "serch_btn";
            this.serch_btn.Size = new System.Drawing.Size(132, 31);
            this.serch_btn.TabIndex = 2;
            this.serch_btn.Text = "Search Student\r\n";
            this.serch_btn.UseVisualStyleBackColor = false;
            this.serch_btn.Click += new System.EventHandler(this.serch_btn_Click);
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
            this.search_txtBox.BackColor = System.Drawing.SystemColors.Window;
            this.search_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_txtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.search_txtBox.Location = new System.Drawing.Point(21, 108);
            this.search_txtBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.search_txtBox.Name = "search_txtBox";
            this.search_txtBox.Size = new System.Drawing.Size(398, 29);
            this.search_txtBox.TabIndex = 4;
            this.search_txtBox.Text = "CS_2020_001";
            this.search_txtBox.TextChanged += new System.EventHandler(this.search_txtBox_TextChanged);
            this.search_txtBox.Enter += new System.EventHandler(this.search_txtBox_Enter);
            this.search_txtBox.Leave += new System.EventHandler(this.search_txtBox_Leave);
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
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(965, 208);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 27);
            this.button4.TabIndex = 15;
            this.button4.Text = "Bulk Delete\r\n";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // showAll_btn
            // 
            this.showAll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.showAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_btn.Location = new System.Drawing.Point(594, 108);
            this.showAll_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(37, 31);
            this.showAll_btn.TabIndex = 17;
            this.showAll_btn.Text = "All";
            this.showAll_btn.UseVisualStyleBackColor = false;
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.AllowUserToResizeColumns = false;
            this.dataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.dataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
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
            this.dataView.ColumnHeadersHeight = 50;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chekBox,
            this.stdId,
            this.StdName,
            this.degreeId,
            this.special_Id,
            this.email,
            this.Faculty_Id,
            this.department_id,
            this.image,
            this.starting_yr,
            this.btnUpdate,
            this.btnDelete});
            this.dataView.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataView.Location = new System.Drawing.Point(20, 262);
            this.dataView.MaximumSize = new System.Drawing.Size(1057, 349);
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
            this.dataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(14)))), ((int)(((byte)(7)))));
            this.dataView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataView.Size = new System.Drawing.Size(1057, 342);
            this.dataView.TabIndex = 21;
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
            this.dataView.ThemeStyle.HeaderStyle.Height = 50;
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
            // chekBox
            // 
            this.chekBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.chekBox.FillWeight = 152.2842F;
            this.chekBox.HeaderText = "";
            this.chekBox.MinimumWidth = 10;
            this.chekBox.Name = "chekBox";
            this.chekBox.ReadOnly = true;
            this.chekBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chekBox.Width = 20;
            // 
            // stdId
            // 
            this.stdId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stdId.FillWeight = 94.19064F;
            this.stdId.HeaderText = "Std Id";
            this.stdId.MinimumWidth = 6;
            this.stdId.Name = "stdId";
            this.stdId.ReadOnly = true;
            this.stdId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stdId.Width = 120;
            // 
            // StdName
            // 
            this.StdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StdName.FillWeight = 94.19064F;
            this.StdName.HeaderText = "Student Name";
            this.StdName.MinimumWidth = 6;
            this.StdName.Name = "StdName";
            this.StdName.ReadOnly = true;
            this.StdName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StdName.Width = 200;
            // 
            // degreeId
            // 
            this.degreeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.degreeId.FillWeight = 94.19064F;
            this.degreeId.HeaderText = "Degree";
            this.degreeId.MinimumWidth = 6;
            this.degreeId.Name = "degreeId";
            this.degreeId.ReadOnly = true;
            this.degreeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.degreeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.degreeId.Width = 200;
            // 
            // special_Id
            // 
            this.special_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.special_Id.FillWeight = 94.19064F;
            this.special_Id.HeaderText = "Specialization";
            this.special_Id.MinimumWidth = 6;
            this.special_Id.Name = "special_Id";
            this.special_Id.ReadOnly = true;
            this.special_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.special_Id.Width = 150;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.FillWeight = 94.19064F;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.email.Width = 150;
            // 
            // Faculty_Id
            // 
            this.Faculty_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Faculty_Id.FillWeight = 94.19064F;
            this.Faculty_Id.HeaderText = "Faculty";
            this.Faculty_Id.MinimumWidth = 6;
            this.Faculty_Id.Name = "Faculty_Id";
            this.Faculty_Id.ReadOnly = true;
            this.Faculty_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Faculty_Id.Width = 130;
            // 
            // department_id
            // 
            this.department_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.department_id.FillWeight = 94.19064F;
            this.department_id.HeaderText = "Department";
            this.department_id.MinimumWidth = 6;
            this.department_id.Name = "department_id";
            this.department_id.ReadOnly = true;
            this.department_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.department_id.Width = 120;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.image.FillWeight = 94.19064F;
            this.image.HeaderText = "Image Location";
            this.image.MinimumWidth = 6;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // starting_yr
            // 
            this.starting_yr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.starting_yr.DefaultCellStyle = dataGridViewCellStyle3;
            this.starting_yr.FillWeight = 94.19064F;
            this.starting_yr.HeaderText = "Starting year";
            this.starting_yr.MinimumWidth = 6;
            this.starting_yr.Name = "starting_yr";
            this.starting_yr.ReadOnly = true;
            this.starting_yr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.starting_yr.Width = 85;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnUpdate.HeaderText = "Update";
            this.btnUpdate.MinimumWidth = 6;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ReadOnly = true;
            this.btnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseColumnTextForButtonValue = true;
            this.btnUpdate.Width = 70;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 70;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.search_txtBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.serch_btn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(1164, 745);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DataGridViewTextBoxColumn Std_ID;
        private DataGridViewTextBoxColumn report;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label student_lb;
       
        private System.Windows.Forms.Button serch_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox search_txtBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button add_std_btn;
        private PaintEventHandler panel1_Paint;
        private EventHandler create_lecture_btn_Click;
        private EventHandler lecture_lb_Click;
        private EventHandler button5_Click;
        private EventHandler AddLecture_Load;
        private Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Timer timer1;
        private ToolStrip toolStrip1;
        private Button showAll_btn;
        #endregion

        private ColorDialog colorDialog1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2DataGridView dataView;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
        private DataGridViewCheckBoxColumn chekBox;
        private DataGridViewTextBoxColumn stdId;
        private DataGridViewTextBoxColumn StdName;
        private DataGridViewTextBoxColumn degreeId;
        private DataGridViewTextBoxColumn special_Id;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Faculty_Id;
        private DataGridViewTextBoxColumn department_id;
        private DataGridViewTextBoxColumn image;
        private DataGridViewTextBoxColumn starting_yr;
        private DataGridViewButtonColumn btnUpdate;
        private DataGridViewButtonColumn btnDelete;
    }
}
