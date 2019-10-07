namespace PresentationLayer
{
    partial class UCtrlExam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cboExamType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label5 = new System.Windows.Forms.Label();
            this.numTimeLimit = new System.Windows.Forms.NumericUpDown();
            this.lblOutputTimeLimit = new System.Windows.Forms.Label();
            this.lblReqLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numItems = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAddedBy = new System.Windows.Forms.Label();
            this.lblDateTimeAdded = new System.Windows.Forms.Label();
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIncompleteItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalExam = new System.Windows.Forms.Label();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.lblTotalTimeLimit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.colExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExaminationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colArchieve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Teal;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(1, 1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1088, 26);
            this.lblStatus.TabIndex = 50;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Teal;
            this.lblLastName.Location = new System.Drawing.Point(13, 40);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 26);
            this.lblLastName.TabIndex = 51;
            this.lblLastName.Text = "Subject";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvExam
            // 
            this.dgvExam.AllowUserToAddRows = false;
            this.dgvExam.AllowUserToDeleteRows = false;
            this.dgvExam.AllowUserToResizeRows = false;
            this.dgvExam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExamId,
            this.colSubject,
            this.colExaminationType,
            this.colTimeLimit,
            this.colItemCount,
            this.colAddDelete,
            this.colArchieve,
            this.colDelete});
            this.dgvExam.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvExam.Location = new System.Drawing.Point(14, 170);
            this.dgvExam.MultiSelect = false;
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.ReadOnly = true;
            this.dgvExam.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExam.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExam.Size = new System.Drawing.Size(1059, 223);
            this.dgvExam.TabIndex = 3;
            this.dgvExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellClick);
            // 
            // cboSubject
            // 
            this.cboSubject.BackColor = System.Drawing.Color.White;
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(113, 40);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(730, 26);
            this.cboSubject.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(914, 40);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 58);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "&CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cboExamType
            // 
            this.cboExamType.BackColor = System.Drawing.Color.White;
            this.cboExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExamType.FormattingEnabled = true;
            this.cboExamType.Location = new System.Drawing.Point(113, 72);
            this.cboExamType.Name = "cboExamType";
            this.cboExamType.Size = new System.Drawing.Size(195, 26);
            this.cboExamType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 55;
            this.label2.Text = "Exam Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(13, 134);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1060, 259);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1091, 617);
            this.shapeContainer1.TabIndex = 56;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape2.Enabled = false;
            this.rectangleShape2.Location = new System.Drawing.Point(13, 411);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(1060, 170);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(424, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 60;
            this.label5.Text = "Time Limit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTimeLimit
            // 
            this.numTimeLimit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimeLimit.Location = new System.Drawing.Point(506, 72);
            this.numTimeLimit.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numTimeLimit.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTimeLimit.Name = "numTimeLimit";
            this.numTimeLimit.ReadOnly = true;
            this.numTimeLimit.Size = new System.Drawing.Size(80, 26);
            this.numTimeLimit.TabIndex = 62;
            this.numTimeLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTimeLimit.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numTimeLimit.ValueChanged += new System.EventHandler(this.numTimeLimit_ValueChanged);
            // 
            // lblOutputTimeLimit
            // 
            this.lblOutputTimeLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputTimeLimit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTimeLimit.ForeColor = System.Drawing.Color.Black;
            this.lblOutputTimeLimit.Location = new System.Drawing.Point(503, 101);
            this.lblOutputTimeLimit.Name = "lblOutputTimeLimit";
            this.lblOutputTimeLimit.Size = new System.Drawing.Size(148, 26);
            this.lblOutputTimeLimit.TabIndex = 63;
            this.lblOutputTimeLimit.Text = "15 minutes";
            // 
            // lblReqLastName
            // 
            this.lblReqLastName.BackColor = System.Drawing.Color.LightCoral;
            this.lblReqLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqLastName.ForeColor = System.Drawing.Color.White;
            this.lblReqLastName.Location = new System.Drawing.Point(308, 72);
            this.lblReqLastName.Name = "lblReqLastName";
            this.lblReqLastName.Size = new System.Drawing.Size(65, 26);
            this.lblReqLastName.TabIndex = 98;
            this.lblReqLastName.Text = "Required";
            this.lblReqLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(586, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 99;
            this.label1.Text = "Required";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(843, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 100;
            this.label3.Text = "Required";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(708, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 101;
            this.label4.Text = "Items";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numItems
            // 
            this.numItems.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numItems.Location = new System.Drawing.Point(763, 72);
            this.numItems.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numItems.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numItems.Name = "numItems";
            this.numItems.ReadOnly = true;
            this.numItems.Size = new System.Drawing.Size(80, 26);
            this.numItems.TabIndex = 102;
            this.numItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numItems.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightCoral;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(843, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 103;
            this.label6.Text = "Required";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddedBy
            // 
            this.lblAddedBy.BackColor = System.Drawing.Color.Gray;
            this.lblAddedBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedBy.ForeColor = System.Drawing.Color.White;
            this.lblAddedBy.Location = new System.Drawing.Point(19, 139);
            this.lblAddedBy.Name = "lblAddedBy";
            this.lblAddedBy.Size = new System.Drawing.Size(523, 26);
            this.lblAddedBy.TabIndex = 117;
            this.lblAddedBy.Text = "Created By:";
            this.lblAddedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTimeAdded
            // 
            this.lblDateTimeAdded.BackColor = System.Drawing.Color.Gray;
            this.lblDateTimeAdded.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeAdded.ForeColor = System.Drawing.Color.White;
            this.lblDateTimeAdded.Location = new System.Drawing.Point(546, 139);
            this.lblDateTimeAdded.Name = "lblDateTimeAdded";
            this.lblDateTimeAdded.Size = new System.Drawing.Size(522, 26);
            this.lblDateTimeAdded.TabIndex = 118;
            this.lblDateTimeAdded.Text = "Date and Time Created:";
            this.lblDateTimeAdded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            this.dgvTotal.AllowUserToResizeRows = false;
            this.dgvTotal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTotal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.colIncompleteItem});
            this.dgvTotal.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTotal.Location = new System.Drawing.Point(14, 446);
            this.dgvTotal.MultiSelect = false;
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTotal.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTotal.Size = new System.Drawing.Size(789, 135);
            this.dgvTotal.TabIndex = 119;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TotalTimeLimit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Time Limit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalItem";
            this.dataGridViewTextBoxColumn5.HeaderText = "Items";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // colIncompleteItem
            // 
            this.colIncompleteItem.DataPropertyName = "TotalIncompleteItem";
            this.colIncompleteItem.HeaderText = "Incomplete Item";
            this.colIncompleteItem.Name = "colIncompleteItem";
            this.colIncompleteItem.ReadOnly = true;
            this.colIncompleteItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIncompleteItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIncompleteItem.Visible = false;
            this.colIncompleteItem.Width = 120;
            // 
            // lblTotalExam
            // 
            this.lblTotalExam.BackColor = System.Drawing.Color.Gray;
            this.lblTotalExam.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExam.ForeColor = System.Drawing.Color.White;
            this.lblTotalExam.Location = new System.Drawing.Point(808, 446);
            this.lblTotalExam.Name = "lblTotalExam";
            this.lblTotalExam.Size = new System.Drawing.Size(260, 40);
            this.lblTotalExam.TabIndex = 120;
            this.lblTotalExam.Text = "No. Of Subject With Exam: 0";
            this.lblTotalExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.BackColor = System.Drawing.Color.Gray;
            this.lblTotalItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItem.ForeColor = System.Drawing.Color.White;
            this.lblTotalItem.Location = new System.Drawing.Point(808, 536);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(260, 40);
            this.lblTotalItem.TabIndex = 121;
            this.lblTotalItem.Text = "Total No. Of Item: 0";
            this.lblTotalItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalTimeLimit
            // 
            this.lblTotalTimeLimit.BackColor = System.Drawing.Color.Gray;
            this.lblTotalTimeLimit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTimeLimit.ForeColor = System.Drawing.Color.White;
            this.lblTotalTimeLimit.Location = new System.Drawing.Point(808, 491);
            this.lblTotalTimeLimit.Name = "lblTotalTimeLimit";
            this.lblTotalTimeLimit.Size = new System.Drawing.Size(260, 40);
            this.lblTotalTimeLimit.TabIndex = 122;
            this.lblTotalTimeLimit.Text = "Total Time Limit: 0";
            this.lblTotalTimeLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1049, 26);
            this.label9.TabIndex = 123;
            this.label9.Text = "Summary";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colExamId
            // 
            this.colExamId.DataPropertyName = "ExamId";
            this.colExamId.HeaderText = "Exam Id";
            this.colExamId.Name = "colExamId";
            this.colExamId.ReadOnly = true;
            this.colExamId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colExamId.Visible = false;
            // 
            // colSubject
            // 
            this.colSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubject.DataPropertyName = "SubjectName";
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            this.colSubject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colExaminationType
            // 
            this.colExaminationType.DataPropertyName = "ExaminationTypeString";
            this.colExaminationType.HeaderText = "Exam Type";
            this.colExaminationType.Name = "colExaminationType";
            this.colExaminationType.ReadOnly = true;
            this.colExaminationType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colExaminationType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colExaminationType.Width = 130;
            // 
            // colTimeLimit
            // 
            this.colTimeLimit.DataPropertyName = "TimeLimitString";
            this.colTimeLimit.HeaderText = "Time Limit";
            this.colTimeLimit.Name = "colTimeLimit";
            this.colTimeLimit.ReadOnly = true;
            this.colTimeLimit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTimeLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTimeLimit.Width = 150;
            // 
            // colItemCount
            // 
            this.colItemCount.DataPropertyName = "FullQuestionCount";
            this.colItemCount.HeaderText = "Items";
            this.colItemCount.Name = "colItemCount";
            this.colItemCount.ReadOnly = true;
            this.colItemCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItemCount.Width = 80;
            // 
            // colAddDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.colAddDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAddDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colAddDelete.HeaderText = "";
            this.colAddDelete.Name = "colAddDelete";
            this.colAddDelete.ReadOnly = true;
            this.colAddDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAddDelete.Text = "QUESTION";
            this.colAddDelete.UseColumnTextForButtonValue = true;
            // 
            // colArchieve
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            this.colArchieve.DefaultCellStyle = dataGridViewCellStyle3;
            this.colArchieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colArchieve.HeaderText = "";
            this.colArchieve.Name = "colArchieve";
            this.colArchieve.ReadOnly = true;
            this.colArchieve.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colArchieve.Text = "ARCHIEVE";
            this.colArchieve.UseColumnTextForButtonValue = true;
            this.colArchieve.Width = 90;
            // 
            // colDelete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.Text = "DELETE";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 70;
            // 
            // UCtrlExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalTimeLimit);
            this.Controls.Add(this.lblTotalItem);
            this.Controls.Add(this.lblTotalExam);
            this.Controls.Add(this.dgvTotal);
            this.Controls.Add(this.lblDateTimeAdded);
            this.Controls.Add(this.lblAddedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReqLastName);
            this.Controls.Add(this.lblOutputTimeLimit);
            this.Controls.Add(this.numTimeLimit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboExamType);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cboSubject);
            this.Controls.Add(this.dgvExam);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UCtrlExam";
            this.Size = new System.Drawing.Size(1091, 617);
            this.Load += new System.EventHandler(this.UCtrlExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cboExamType;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTimeLimit;
        private System.Windows.Forms.Label lblOutputTimeLimit;
        private System.Windows.Forms.Label lblReqLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAddedBy;
        private System.Windows.Forms.Label lblDateTimeAdded;
        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.Label lblTotalExam;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.Label lblTotalTimeLimit;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncompleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExaminationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCount;
        private System.Windows.Forms.DataGridViewButtonColumn colAddDelete;
        private System.Windows.Forms.DataGridViewButtonColumn colArchieve;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
