namespace PresentationLayer
{
    partial class UCtrlSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPassingRate = new System.Windows.Forms.DataGridView();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTimeModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPassingRate = new System.Windows.Forms.Label();
            this.btnSetRate = new System.Windows.Forms.Button();
            this.lblExample = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numPassingRate = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvExamineeFailure = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numWaitDays = new System.Windows.Forms.NumericUpDown();
            this.lblExamineeFail = new System.Windows.Forms.Label();
            this.lblWaitDays = new System.Windows.Forms.Label();
            this.btnSetDays = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.colExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExaminationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArchieve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rectangleShape7 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassingRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassingRate)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamineeFailure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitDays)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 11F);
            this.tabControl1.Location = new System.Drawing.Point(13, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPassingRate);
            this.tabPage1.Controls.Add(this.lblPassingRate);
            this.tabPage1.Controls.Add(this.btnSetRate);
            this.tabPage1.Controls.Add(this.lblExample);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numPassingRate);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.shapeContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Passing Rate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPassingRate
            // 
            this.dgvPassingRate.AllowUserToAddRows = false;
            this.dgvPassingRate.AllowUserToDeleteRows = false;
            this.dgvPassingRate.AllowUserToResizeRows = false;
            this.dgvPassingRate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvPassingRate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPassingRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPassingRate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPassingRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassingRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRate,
            this.colDateTimeModified,
            this.colModifiedBy});
            this.dgvPassingRate.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPassingRate.Location = new System.Drawing.Point(13, 102);
            this.dgvPassingRate.MultiSelect = false;
            this.dgvPassingRate.Name = "dgvPassingRate";
            this.dgvPassingRate.ReadOnly = true;
            this.dgvPassingRate.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPassingRate.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPassingRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassingRate.Size = new System.Drawing.Size(1031, 397);
            this.dgvPassingRate.TabIndex = 120;
            // 
            // colRate
            // 
            this.colRate.DataPropertyName = "Rate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colRate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colRate.HeaderText = "Passing Rate";
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            this.colRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRate.Width = 110;
            // 
            // colDateTimeModified
            // 
            this.colDateTimeModified.DataPropertyName = "DateTimeModified";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.colDateTimeModified.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDateTimeModified.HeaderText = "Date Time";
            this.colDateTimeModified.Name = "colDateTimeModified";
            this.colDateTimeModified.ReadOnly = true;
            this.colDateTimeModified.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDateTimeModified.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDateTimeModified.Width = 200;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colModifiedBy.DataPropertyName = "ModifiedBy";
            this.colModifiedBy.HeaderText = "Modified By";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.ReadOnly = true;
            this.colModifiedBy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colModifiedBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblPassingRate
            // 
            this.lblPassingRate.BackColor = System.Drawing.Color.Transparent;
            this.lblPassingRate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassingRate.ForeColor = System.Drawing.Color.Teal;
            this.lblPassingRate.Location = new System.Drawing.Point(13, 14);
            this.lblPassingRate.Name = "lblPassingRate";
            this.lblPassingRate.Size = new System.Drawing.Size(323, 33);
            this.lblPassingRate.TabIndex = 119;
            this.lblPassingRate.Text = "The Current Passing Rate Is:";
            this.lblPassingRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetRate
            // 
            this.btnSetRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSetRate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSetRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetRate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetRate.ForeColor = System.Drawing.Color.White;
            this.btnSetRate.Location = new System.Drawing.Point(227, 59);
            this.btnSetRate.Name = "btnSetRate";
            this.btnSetRate.Size = new System.Drawing.Size(110, 26);
            this.btnSetRate.TabIndex = 2;
            this.btnSetRate.Text = "&SET";
            this.btnSetRate.UseVisualStyleBackColor = false;
            this.btnSetRate.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblExample
            // 
            this.lblExample.BackColor = System.Drawing.Color.Transparent;
            this.lblExample.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExample.ForeColor = System.Drawing.Color.Teal;
            this.lblExample.Location = new System.Drawing.Point(347, 14);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(697, 72);
            this.lblExample.TabIndex = 117;
            this.lblExample.Text = "Ex. Subject \'A\' with total item of 100";
            this.lblExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(196, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 26);
            this.label1.TabIndex = 114;
            this.label1.Text = "%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPassingRate
            // 
            this.numPassingRate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPassingRate.Location = new System.Drawing.Point(110, 59);
            this.numPassingRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPassingRate.Name = "numPassingRate";
            this.numPassingRate.ReadOnly = true;
            this.numPassingRate.Size = new System.Drawing.Size(80, 26);
            this.numPassingRate.TabIndex = 1;
            this.numPassingRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPassingRate.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numPassingRate.ValueChanged += new System.EventHandler(this.numPassingRate_ValueChanged);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Teal;
            this.label20.Location = new System.Drawing.Point(12, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 26);
            this.label20.TabIndex = 113;
            this.label20.Text = "Passing Rate";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape6,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1052, 507);
            this.shapeContainer1.TabIndex = 121;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape3.Enabled = false;
            this.rectangleShape3.Location = new System.Drawing.Point(343, 10);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(698, 73);
            // 
            // rectangleShape6
            // 
            this.rectangleShape6.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape6.Enabled = false;
            this.rectangleShape6.Location = new System.Drawing.Point(9, 10);
            this.rectangleShape6.Name = "rectangleShape6";
            this.rectangleShape6.Size = new System.Drawing.Size(324, 34);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(9, 102);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1032, 394);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvExamineeFailure);
            this.tabPage2.Controls.Add(this.numWaitDays);
            this.tabPage2.Controls.Add(this.lblExamineeFail);
            this.tabPage2.Controls.Add(this.lblWaitDays);
            this.tabPage2.Controls.Add(this.btnSetDays);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.shapeContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Examinee Failure";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvExamineeFailure
            // 
            this.dgvExamineeFailure.AllowUserToAddRows = false;
            this.dgvExamineeFailure.AllowUserToDeleteRows = false;
            this.dgvExamineeFailure.AllowUserToResizeRows = false;
            this.dgvExamineeFailure.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvExamineeFailure.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvExamineeFailure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExamineeFailure.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvExamineeFailure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamineeFailure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvExamineeFailure.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvExamineeFailure.Location = new System.Drawing.Point(13, 102);
            this.dgvExamineeFailure.MultiSelect = false;
            this.dgvExamineeFailure.Name = "dgvExamineeFailure";
            this.dgvExamineeFailure.ReadOnly = true;
            this.dgvExamineeFailure.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExamineeFailure.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExamineeFailure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamineeFailure.Size = new System.Drawing.Size(1031, 397);
            this.dgvExamineeFailure.TabIndex = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "WaitDays";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "Days To Wait";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateTimeModified";
            dataGridViewCellStyle5.Format = "G";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ModifiedBy";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modified By";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // numWaitDays
            // 
            this.numWaitDays.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWaitDays.Location = new System.Drawing.Point(110, 59);
            this.numWaitDays.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numWaitDays.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numWaitDays.Name = "numWaitDays";
            this.numWaitDays.ReadOnly = true;
            this.numWaitDays.Size = new System.Drawing.Size(80, 26);
            this.numWaitDays.TabIndex = 124;
            this.numWaitDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWaitDays.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numWaitDays.ValueChanged += new System.EventHandler(this.numWaitDays_ValueChanged);
            // 
            // lblExamineeFail
            // 
            this.lblExamineeFail.BackColor = System.Drawing.Color.Transparent;
            this.lblExamineeFail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamineeFail.ForeColor = System.Drawing.Color.Teal;
            this.lblExamineeFail.Location = new System.Drawing.Point(347, 14);
            this.lblExamineeFail.Name = "lblExamineeFail";
            this.lblExamineeFail.Size = new System.Drawing.Size(697, 72);
            this.lblExamineeFail.TabIndex = 123;
            this.lblExamineeFail.Text = "Please set day(s) to wait for failed examinee";
            this.lblExamineeFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWaitDays
            // 
            this.lblWaitDays.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitDays.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitDays.ForeColor = System.Drawing.Color.Teal;
            this.lblWaitDays.Location = new System.Drawing.Point(13, 14);
            this.lblWaitDays.Name = "lblWaitDays";
            this.lblWaitDays.Size = new System.Drawing.Size(323, 33);
            this.lblWaitDays.TabIndex = 122;
            this.lblWaitDays.Text = "Please set days to wait";
            this.lblWaitDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetDays
            // 
            this.btnSetDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSetDays.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSetDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDays.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDays.ForeColor = System.Drawing.Color.White;
            this.btnSetDays.Location = new System.Drawing.Point(227, 59);
            this.btnSetDays.Name = "btnSetDays";
            this.btnSetDays.Size = new System.Drawing.Size(110, 26);
            this.btnSetDays.TabIndex = 120;
            this.btnSetDays.Text = "&SET";
            this.btnSetDays.UseVisualStyleBackColor = false;
            this.btnSetDays.Click += new System.EventHandler(this.btnSetDays_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 121;
            this.label3.Text = "Wait Days:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape5,
            this.rectangleShape4,
            this.rectangleShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(1052, 507);
            this.shapeContainer2.TabIndex = 126;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape5.Enabled = false;
            this.rectangleShape5.Location = new System.Drawing.Point(343, 10);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(698, 73);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape4.Enabled = false;
            this.rectangleShape4.Location = new System.Drawing.Point(9, 10);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(324, 34);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape2.Enabled = false;
            this.rectangleShape2.Location = new System.Drawing.Point(9, 101);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(1032, 395);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvExam);
            this.tabPage3.Controls.Add(this.shapeContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1058, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Exam Archieve";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvExam
            // 
            this.dgvExam.AllowUserToAddRows = false;
            this.dgvExam.AllowUserToDeleteRows = false;
            this.dgvExam.AllowUserToResizeRows = false;
            this.dgvExam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExamId,
            this.colSubject,
            this.colExaminationType,
            this.colTimeLimit,
            this.colItemCount,
            this.colArchieve});
            this.dgvExam.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvExam.Location = new System.Drawing.Point(12, 14);
            this.dgvExam.MultiSelect = false;
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.ReadOnly = true;
            this.dgvExam.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExam.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExam.Size = new System.Drawing.Size(1032, 482);
            this.dgvExam.TabIndex = 4;
            this.dgvExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellClick);
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
            // colArchieve
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            this.colArchieve.DefaultCellStyle = dataGridViewCellStyle7;
            this.colArchieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colArchieve.HeaderText = "";
            this.colArchieve.Name = "colArchieve";
            this.colArchieve.ReadOnly = true;
            this.colArchieve.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colArchieve.Text = "RESTORE";
            this.colArchieve.UseColumnTextForButtonValue = true;
            this.colArchieve.Width = 90;
            // 
            // rectangleShape7
            // 
            this.rectangleShape7.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape7.Enabled = false;
            this.rectangleShape7.Location = new System.Drawing.Point(11, 14);
            this.rectangleShape7.Name = "rectangleShape7";
            this.rectangleShape7.Size = new System.Drawing.Size(1033, 484);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape7});
            this.shapeContainer3.Size = new System.Drawing.Size(1058, 513);
            this.shapeContainer3.TabIndex = 5;
            this.shapeContainer3.TabStop = false;
            // 
            // UCtrlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStatus);
            this.Name = "UCtrlSettings";
            this.Size = new System.Drawing.Size(1094, 622);
            this.Load += new System.EventHandler(this.UCtrlSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassingRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassingRate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamineeFailure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitDays)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numPassingRate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Button btnSetRate;
        private System.Windows.Forms.Label lblPassingRate;
        private System.Windows.Forms.DataGridView dgvPassingRate;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numWaitDays;
        private System.Windows.Forms.Label lblExamineeFail;
        private System.Windows.Forms.Label lblWaitDays;
        private System.Windows.Forms.Button btnSetDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTimeModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedBy;
        private System.Windows.Forms.DataGridView dgvExamineeFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExaminationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCount;
        private System.Windows.Forms.DataGridViewButtonColumn colArchieve;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape7;
    }
}
