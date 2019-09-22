﻿namespace PresentationLayer
{
    partial class UCtrlUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblUserLevelReq = new System.Windows.Forms.Label();
            this.lblFistNameReq = new System.Windows.Forms.Label();
            this.lblLastNameReq = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.cboUserLevel = new System.Windows.Forms.ComboBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(767, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "&SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(447, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 46;
            this.label1.Text = "Enter Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Teal;
            this.checkBox1.Location = new System.Drawing.Point(124, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(225, 26);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Deactivate Account Status";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblUserLevelReq
            // 
            this.lblUserLevelReq.BackColor = System.Drawing.Color.LightCoral;
            this.lblUserLevelReq.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLevelReq.ForeColor = System.Drawing.Color.White;
            this.lblUserLevelReq.Location = new System.Drawing.Point(349, 183);
            this.lblUserLevelReq.Name = "lblUserLevelReq";
            this.lblUserLevelReq.Size = new System.Drawing.Size(65, 26);
            this.lblUserLevelReq.TabIndex = 45;
            this.lblUserLevelReq.Text = "Required";
            this.lblUserLevelReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserLevelReq.Visible = false;
            // 
            // lblFistNameReq
            // 
            this.lblFistNameReq.BackColor = System.Drawing.Color.LightCoral;
            this.lblFistNameReq.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFistNameReq.ForeColor = System.Drawing.Color.White;
            this.lblFistNameReq.Location = new System.Drawing.Point(349, 57);
            this.lblFistNameReq.Name = "lblFistNameReq";
            this.lblFistNameReq.Size = new System.Drawing.Size(65, 26);
            this.lblFistNameReq.TabIndex = 44;
            this.lblFistNameReq.Text = "Required";
            this.lblFistNameReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFistNameReq.Visible = false;
            // 
            // lblLastNameReq
            // 
            this.lblLastNameReq.BackColor = System.Drawing.Color.LightCoral;
            this.lblLastNameReq.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameReq.ForeColor = System.Drawing.Color.White;
            this.lblLastNameReq.Location = new System.Drawing.Point(349, 20);
            this.lblLastNameReq.Name = "lblLastNameReq";
            this.lblLastNameReq.Size = new System.Drawing.Size(65, 26);
            this.lblLastNameReq.TabIndex = 43;
            this.lblLastNameReq.Text = "Required";
            this.lblLastNameReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLastNameReq.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(536, 29);
            this.txtSearch.MaxLength = 120;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(255, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightGray;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(139, 283);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(23, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&ADD NEW";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Teal;
            this.lblUsername.Location = new System.Drawing.Point(20, 145);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 26);
            this.lblUsername.TabIndex = 42;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(124, 146);
            this.txtUsername.MaxLength = 64;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(225, 26);
            this.txtUsername.TabIndex = 10;
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblUserLevel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLevel.ForeColor = System.Drawing.Color.Teal;
            this.lblUserLevel.Location = new System.Drawing.Point(20, 183);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(98, 26);
            this.lblUserLevel.TabIndex = 39;
            this.lblUserLevel.Text = "User Level";
            this.lblUserLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboUserLevel
            // 
            this.cboUserLevel.BackColor = System.Drawing.Color.White;
            this.cboUserLevel.Enabled = false;
            this.cboUserLevel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserLevel.FormattingEnabled = true;
            this.cboUserLevel.Items.AddRange(new object[] {
            "Exam Creator",
            "Administrator"});
            this.cboUserLevel.Location = new System.Drawing.Point(124, 183);
            this.cboUserLevel.Name = "cboUserLevel";
            this.cboUserLevel.Size = new System.Drawing.Size(225, 26);
            this.cboUserLevel.TabIndex = 11;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddleName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.Teal;
            this.lblMiddleName.Location = new System.Drawing.Point(20, 94);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(98, 26);
            this.lblMiddleName.TabIndex = 36;
            this.lblMiddleName.Text = "Middle Name";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Teal;
            this.lblFirstName.Location = new System.Drawing.Point(20, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(98, 26);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.Enabled = false;
            this.txtMiddleName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(124, 94);
            this.txtMiddleName.MaxLength = 60;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(225, 26);
            this.txtMiddleName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(124, 57);
            this.txtFirstName.MaxLength = 60;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(225, 26);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(124, 20);
            this.txtLastName.MaxLength = 60;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 26);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Teal;
            this.lblLastName.Location = new System.Drawing.Point(20, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(98, 26);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(861, 29);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 26);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(437, 20);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(522, 302);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(999, 361);
            this.shapeContainer1.TabIndex = 48;
            this.shapeContainer1.TabStop = false;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserId,
            this.colName,
            this.colUsername,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colUserLevel,
            this.colStatus});
            this.dgvUser.Location = new System.Drawing.Point(-24, 46);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(1047, 268);
            this.dgvUser.TabIndex = 49;
            // 
            // colUserId
            // 
            this.colUserId.DataPropertyName = "UserId";
            this.colUserId.HeaderText = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.ReadOnly = true;
            this.colUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUserId.Visible = false;
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
            // colUsername
            // 
            this.colUsername.DataPropertyName = "Username";
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUsername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUsername.Width = 220;
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
            // colUserLevel
            // 
            this.colUserLevel.DataPropertyName = "UserLevel";
            this.colUserLevel.HeaderText = "User Level";
            this.colUserLevel.Name = "colUserLevel";
            this.colUserLevel.ReadOnly = true;
            this.colUserLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUserLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUserLevel.Width = 120;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "AccountStatusFormat";
            this.colStatus.HeaderText = "Account Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStatus.Width = 120;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.colAccountStatus});
            this.dataGridView1.Location = new System.Drawing.Point(23, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 150);
            this.dataGridView1.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn1.HeaderText = "User Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn4.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Middle Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn6.HeaderText = "Username";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserLevel";
            this.dataGridViewTextBoxColumn7.HeaderText = "User Level";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // colAccountStatus
            // 
            this.colAccountStatus.DataPropertyName = "AccountStatusFormat";
            this.colAccountStatus.HeaderText = "Account Status";
            this.colAccountStatus.Name = "colAccountStatus";
            // 
            // UCtrlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblUserLevelReq);
            this.Controls.Add(this.lblFistNameReq);
            this.Controls.Add(this.lblLastNameReq);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUserLevel);
            this.Controls.Add(this.cboUserLevel);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UCtrlUser";
            this.Size = new System.Drawing.Size(999, 361);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblUserLevelReq;
        private System.Windows.Forms.Label lblFistNameReq;
        private System.Windows.Forms.Label lblLastNameReq;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.ComboBox cboUserLevel;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnReset;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountStatus;
    }
}