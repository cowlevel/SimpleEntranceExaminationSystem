namespace PresentationLayer
{
    partial class UCtrlExaminee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvExaminee = new System.Windows.Forms.DataGridView();
            this.colExamineeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastSchoolAttended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYearGraduated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExamTakes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTimeAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tabExaminee = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblReqFirstName = new System.Windows.Forms.Label();
            this.lblReqLastName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblReqContactNo = new System.Windows.Forms.Label();
            this.lblReqEmail = new System.Windows.Forms.Label();
            this.lblReqCity = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblReqAddress = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblReqYearGraduated = new System.Windows.Forms.Label();
            this.numYearGraduated = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.lblReqSchoolName = new System.Windows.Forms.Label();
            this.lblExamTakes = new System.Windows.Forms.Label();
            this.lblDateTimeAdded = new System.Windows.Forms.Label();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.btnExamResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminee)).BeginInit();
            this.tabExaminee.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearGraduated)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Gray;
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(479, 265);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(88, 26);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "S&HOW ALL";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(361, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPage
            // 
            this.lblPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPage.Location = new System.Drawing.Point(114, 550);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(145, 26);
            this.lblPage.TabIndex = 85;
            this.lblPage.Text = "Page 0 of 0";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gray;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(265, 550);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 26);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Gray;
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(20, 550);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(88, 26);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(385, 265);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 26);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(154, 265);
            this.txtSearch.MaxLength = 120;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 26);
            this.txtSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Teal;
            this.lblSearch.Location = new System.Drawing.Point(19, 265);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(129, 26);
            this.lblSearch.TabIndex = 84;
            this.lblSearch.Text = "Enter Name / Email";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(245, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightGray;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(129, 198);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(13, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&ADD NEW";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Teal;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(1, 1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1088, 26);
            this.lblStatus.TabIndex = 94;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvExaminee
            // 
            this.dgvExaminee.AllowUserToAddRows = false;
            this.dgvExaminee.AllowUserToDeleteRows = false;
            this.dgvExaminee.AllowUserToResizeRows = false;
            this.dgvExaminee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvExaminee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExaminee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExaminee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExaminee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExaminee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExamineeId,
            this.colName,
            this.colEmail,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colLastSchoolAttended,
            this.colYearGraduated,
            this.colAddress,
            this.colCity,
            this.colContactNo,
            this.colExamTakes,
            this.colDateTimeAdded});
            this.dgvExaminee.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvExaminee.Location = new System.Drawing.Point(14, 299);
            this.dgvExaminee.MultiSelect = false;
            this.dgvExaminee.Name = "dgvExaminee";
            this.dgvExaminee.ReadOnly = true;
            this.dgvExaminee.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExaminee.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExaminee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExaminee.Size = new System.Drawing.Size(1059, 245);
            this.dgvExaminee.TabIndex = 7;
            this.dgvExaminee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExaminee_CellClick);
            // 
            // colExamineeId
            // 
            this.colExamineeId.DataPropertyName = "ExamineeId";
            this.colExamineeId.HeaderText = "Examinee Id";
            this.colExamineeId.Name = "colExamineeId";
            this.colExamineeId.ReadOnly = true;
            this.colExamineeId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colExamineeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colExamineeId.Visible = false;
            this.colExamineeId.Width = 90;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "FullName";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colEmail.Width = 200;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Visible = false;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Visible = false;
            // 
            // colMiddleName
            // 
            this.colMiddleName.DataPropertyName = "MiddleName";
            this.colMiddleName.HeaderText = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            this.colMiddleName.Visible = false;
            // 
            // colLastSchoolAttended
            // 
            this.colLastSchoolAttended.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLastSchoolAttended.DataPropertyName = "LastSchoolAttended";
            this.colLastSchoolAttended.HeaderText = "Last School Attended";
            this.colLastSchoolAttended.Name = "colLastSchoolAttended";
            this.colLastSchoolAttended.ReadOnly = true;
            this.colLastSchoolAttended.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colYearGraduated
            // 
            this.colYearGraduated.DataPropertyName = "YearGraduated";
            this.colYearGraduated.HeaderText = "Year Graduated";
            this.colYearGraduated.Name = "colYearGraduated";
            this.colYearGraduated.ReadOnly = true;
            this.colYearGraduated.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colYearGraduated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colYearGraduated.Width = 110;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Visible = false;
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "City";
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            this.colCity.Visible = false;
            // 
            // colContactNo
            // 
            this.colContactNo.DataPropertyName = "ContactNo";
            this.colContactNo.HeaderText = "Contact No.";
            this.colContactNo.Name = "colContactNo";
            this.colContactNo.ReadOnly = true;
            this.colContactNo.Visible = false;
            // 
            // colExamTakes
            // 
            this.colExamTakes.DataPropertyName = "ExamTakes";
            this.colExamTakes.HeaderText = "Exam Takes";
            this.colExamTakes.Name = "colExamTakes";
            this.colExamTakes.ReadOnly = true;
            this.colExamTakes.Visible = false;
            // 
            // colDateTimeAdded
            // 
            this.colDateTimeAdded.DataPropertyName = "DateTimeAdded";
            this.colDateTimeAdded.HeaderText = "Date Time Added";
            this.colDateTimeAdded.Name = "colDateTimeAdded";
            this.colDateTimeAdded.ReadOnly = true;
            this.colDateTimeAdded.Visible = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(13, 257);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1060, 324);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape5,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1102, 609);
            this.shapeContainer1.TabIndex = 114;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape2.Enabled = false;
            this.rectangleShape2.Location = new System.Drawing.Point(828, 127);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(246, 57);
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape5.Enabled = false;
            this.rectangleShape5.Location = new System.Drawing.Point(828, 66);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(246, 57);
            // 
            // tabExaminee
            // 
            this.tabExaminee.Controls.Add(this.tabPage1);
            this.tabExaminee.Controls.Add(this.tabPage2);
            this.tabExaminee.Controls.Add(this.tabPage4);
            this.tabExaminee.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExaminee.Location = new System.Drawing.Point(13, 40);
            this.tabExaminee.Multiline = true;
            this.tabExaminee.Name = "tabExaminee";
            this.tabExaminee.SelectedIndex = 0;
            this.tabExaminee.Size = new System.Drawing.Size(811, 147);
            this.tabExaminee.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblReqFirstName);
            this.tabPage1.Controls.Add(this.lblReqLastName);
            this.tabPage1.Controls.Add(this.txtMiddleName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.ForeColor = System.Drawing.Color.Teal;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Examinee Name";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblReqFirstName
            // 
            this.lblReqFirstName.BackColor = System.Drawing.Color.LightCoral;
            this.lblReqFirstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqFirstName.ForeColor = System.Drawing.Color.White;
            this.lblReqFirstName.Location = new System.Drawing.Point(341, 45);
            this.lblReqFirstName.Name = "lblReqFirstName";
            this.lblReqFirstName.Size = new System.Drawing.Size(65, 26);
            this.lblReqFirstName.TabIndex = 98;
            this.lblReqFirstName.Text = "Required";
            this.lblReqFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReqFirstName.Visible = false;
            // 
            // lblReqLastName
            // 
            this.lblReqLastName.BackColor = System.Drawing.Color.LightCoral;
            this.lblReqLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqLastName.ForeColor = System.Drawing.Color.White;
            this.lblReqLastName.Location = new System.Drawing.Point(341, 13);
            this.lblReqLastName.Name = "lblReqLastName";
            this.lblReqLastName.Size = new System.Drawing.Size(65, 26);
            this.lblReqLastName.TabIndex = 97;
            this.lblReqLastName.Text = "Required";
            this.lblReqLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReqLastName.Visible = false;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.Enabled = false;
            this.txtMiddleName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(116, 77);
            this.txtMiddleName.MaxLength = 60;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(225, 26);
            this.txtMiddleName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 96;
            this.label5.Text = "Middle Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(116, 45);
            this.txtFirstName.MaxLength = 60;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(225, 26);
            this.txtFirstName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(12, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 26);
            this.label7.TabIndex = 95;
            this.label7.Text = "First Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(116, 13);
            this.txtLastName.MaxLength = 60;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 26);
            this.txtLastName.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(12, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 26);
            this.label10.TabIndex = 94;
            this.label10.Text = "Last Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblReqContactNo);
            this.tabPage2.Controls.Add(this.lblReqEmail);
            this.tabPage2.Controls.Add(this.lblReqCity);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtContactNo);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtCity);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.lblReqAddress);
            this.tabPage2.ForeColor = System.Drawing.Color.Teal;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contact";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblReqContactNo
            // 
            this.lblReqContactNo.BackColor = System.Drawing.Color.LightCoral;
            this.lblReqContactNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqContactNo.ForeColor = System.Drawing.Color.White;
            this.lblReqContactNo.Location = new System.Drawing.Point(724, 13);
            this.lblReqContactNo.Name = "lblReqContactNo";
            this.lblReqContactNo.Size = new System.Drawing.Size(65, 26);
            this.lblReqContactNo.TabIndex = 120;
            this.lblReqContactNo.Text = "Required";
            this.lblReqContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReqContactNo.Visible = false;
            // 
            // lblReqEmail
            // 
            this.lblReqEmail.BackColor = System.Drawing.Color.LightCoral;
            this.lblReqEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqEmail.ForeColor = System.Drawing.Color.White;
            this.lblReqEmail.Location = new System.Drawing.Point(724, 45);
            this.lblReqEmail.Name = "lblReqEmail";
            this.lblReqEmail.Size = new System.Drawing.Size(65, 26);
            this.lblReqEmail.TabIndex = 119;
            this.lblReqEmail.Text = "Required";
            this.lblReqEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReqEmail.Visible = false;
            // 
            // lblReqCity
            // 
            this.lblReqCity.BackColor = System.Drawing.Color.LightCoral;
            this.lblReqCity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqCity.ForeColor = System.Drawing.Color.White;
            this.lblReqCity.Location = new System.Drawing.Point(308, 77);
            this.lblReqCity.Name = "lblReqCity";
            this.lblReqCity.Size = new System.Drawing.Size(65, 26);
            this.lblReqCity.TabIndex = 118;
            this.lblReqCity.Text = "Required";
            this.lblReqCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReqCity.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(499, 45);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 26);
            this.txtEmail.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(409, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 26);
            this.label14.TabIndex = 117;
            this.label14.Text = "Email";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.White;
            this.txtContactNo.Enabled = false;
            this.txtContactNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(499, 13);
            this.txtContactNo.MaxLength = 60;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(225, 26);
            this.txtContactNo.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(409, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 26);
            this.label15.TabIndex = 116;
            this.label15.Text = "Contact No.";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(83, 13);
            this.txtAddress.MaxLength = 60;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(225, 58);
            this.txtAddress.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(12, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 26);
            this.label13.TabIndex = 113;
            this.label13.Text = "City";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.Enabled = false;
            this.txtCity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(83, 77);
            this.txtCity.MaxLength = 60;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(225, 26);
            this.txtCity.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(12, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 26);
            this.label11.TabIndex = 111;
            this.label11.Text = "Address";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReqAddress
            // 
            this.lblReqAddress.BackColor = System.Drawing.Color.LightCoral;
            this.lblReqAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqAddress.ForeColor = System.Drawing.Color.White;
            this.lblReqAddress.Location = new System.Drawing.Point(308, 13);
            this.lblReqAddress.Name = "lblReqAddress";
            this.lblReqAddress.Size = new System.Drawing.Size(65, 26);
            this.lblReqAddress.TabIndex = 110;
            this.lblReqAddress.Text = "Required";
            this.lblReqAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReqAddress.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtSchoolName);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.lblReqYearGraduated);
            this.tabPage4.Controls.Add(this.numYearGraduated);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.lblReqSchoolName);
            this.tabPage4.ForeColor = System.Drawing.Color.Teal;
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(803, 116);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Last School Attended";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.BackColor = System.Drawing.Color.White;
            this.txtSchoolName.Enabled = false;
            this.txtSchoolName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolName.Location = new System.Drawing.Point(128, 13);
            this.txtSchoolName.MaxLength = 60;
            this.txtSchoolName.Multiline = true;
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSchoolName.Size = new System.Drawing.Size(225, 58);
            this.txtSchoolName.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Teal;
            this.label18.Location = new System.Drawing.Point(12, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 26);
            this.label18.TabIndex = 114;
            this.label18.Text = "School Name";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReqYearGraduated
            // 
            this.lblReqYearGraduated.BackColor = System.Drawing.Color.LightCoral;
            this.lblReqYearGraduated.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqYearGraduated.ForeColor = System.Drawing.Color.White;
            this.lblReqYearGraduated.Location = new System.Drawing.Point(208, 77);
            this.lblReqYearGraduated.Name = "lblReqYearGraduated";
            this.lblReqYearGraduated.Size = new System.Drawing.Size(65, 26);
            this.lblReqYearGraduated.TabIndex = 113;
            this.lblReqYearGraduated.Text = "Required";
            this.lblReqYearGraduated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReqYearGraduated.Visible = false;
            // 
            // numYearGraduated
            // 
            this.numYearGraduated.Enabled = false;
            this.numYearGraduated.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numYearGraduated.Location = new System.Drawing.Point(128, 77);
            this.numYearGraduated.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numYearGraduated.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numYearGraduated.Name = "numYearGraduated";
            this.numYearGraduated.ReadOnly = true;
            this.numYearGraduated.Size = new System.Drawing.Size(80, 26);
            this.numYearGraduated.TabIndex = 21;
            this.numYearGraduated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numYearGraduated.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Teal;
            this.label20.Location = new System.Drawing.Point(12, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 26);
            this.label20.TabIndex = 111;
            this.label20.Text = "Year Graduated";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReqSchoolName
            // 
            this.lblReqSchoolName.BackColor = System.Drawing.Color.LightCoral;
            this.lblReqSchoolName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqSchoolName.ForeColor = System.Drawing.Color.White;
            this.lblReqSchoolName.Location = new System.Drawing.Point(353, 13);
            this.lblReqSchoolName.Name = "lblReqSchoolName";
            this.lblReqSchoolName.Size = new System.Drawing.Size(65, 26);
            this.lblReqSchoolName.TabIndex = 110;
            this.lblReqSchoolName.Text = "Required";
            this.lblReqSchoolName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReqSchoolName.Visible = false;
            // 
            // lblExamTakes
            // 
            this.lblExamTakes.BackColor = System.Drawing.Color.Transparent;
            this.lblExamTakes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTakes.ForeColor = System.Drawing.Color.Teal;
            this.lblExamTakes.Location = new System.Drawing.Point(829, 67);
            this.lblExamTakes.Name = "lblExamTakes";
            this.lblExamTakes.Size = new System.Drawing.Size(245, 26);
            this.lblExamTakes.TabIndex = 116;
            this.lblExamTakes.Text = "Exam take:";
            this.lblExamTakes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTimeAdded
            // 
            this.lblDateTimeAdded.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTimeAdded.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeAdded.ForeColor = System.Drawing.Color.Teal;
            this.lblDateTimeAdded.Location = new System.Drawing.Point(829, 128);
            this.lblDateTimeAdded.Name = "lblDateTimeAdded";
            this.lblDateTimeAdded.Size = new System.Drawing.Size(245, 56);
            this.lblDateTimeAdded.TabIndex = 117;
            this.lblDateTimeAdded.Text = "Date and time added:";
            this.lblDateTimeAdded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchResult.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchResult.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchResult.Location = new System.Drawing.Point(573, 265);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(496, 26);
            this.lblSearchResult.TabIndex = 118;
            this.lblSearchResult.Text = "Search result: ";
            this.lblSearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExamResult
            // 
            this.btnExamResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.btnExamResult.Enabled = false;
            this.btnExamResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.btnExamResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamResult.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamResult.ForeColor = System.Drawing.Color.White;
            this.btnExamResult.Location = new System.Drawing.Point(833, 94);
            this.btnExamResult.Name = "btnExamResult";
            this.btnExamResult.Size = new System.Drawing.Size(237, 26);
            this.btnExamResult.TabIndex = 22;
            this.btnExamResult.Text = "E&XAM RESULT";
            this.btnExamResult.UseVisualStyleBackColor = false;
            this.btnExamResult.Click += new System.EventHandler(this.btnExamResult_Click);
            // 
            // UCtrlExaminee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExamResult);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.lblDateTimeAdded);
            this.Controls.Add(this.lblExamTakes);
            this.Controls.Add(this.tabExaminee);
            this.Controls.Add(this.dgvExaminee);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UCtrlExaminee";
            this.Size = new System.Drawing.Size(1102, 609);
            this.Load += new System.EventHandler(this.UCtrlExaminee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminee)).EndInit();
            this.tabExaminee.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearGraduated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvExaminee;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TabControl tabExaminee;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblReqFirstName;
        private System.Windows.Forms.Label lblReqLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblReqAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblReqCity;
        private System.Windows.Forms.Label lblReqEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblReqYearGraduated;
        private System.Windows.Forms.NumericUpDown numYearGraduated;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblReqSchoolName;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Label lblExamTakes;
        private System.Windows.Forms.Label lblReqContactNo;
        private System.Windows.Forms.Label lblDateTimeAdded;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamineeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastSchoolAttended;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYearGraduated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamTakes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTimeAdded;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Button btnExamResult;
    }
}
