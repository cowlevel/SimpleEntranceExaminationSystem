namespace PresentationLayer
{
    partial class FrmExamResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSubjResult = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboExamCode = new System.Windows.Forms.ComboBox();
            this.lblIssuedBy = new System.Windows.Forms.Label();
            this.lblDateTimeIssued = new System.Windows.Forms.Label();
            this.lblExamDateTime = new System.Windows.Forms.Label();
            this.lblPassingRate = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rectangleShape8 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubjResult
            // 
            this.dgvSubjResult.AllowUserToAddRows = false;
            this.dgvSubjResult.AllowUserToDeleteRows = false;
            this.dgvSubjResult.AllowUserToResizeRows = false;
            this.dgvSubjResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvSubjResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubjResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colEmail,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colDetails});
            this.dgvSubjResult.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSubjResult.Location = new System.Drawing.Point(13, 138);
            this.dgvSubjResult.MultiSelect = false;
            this.dgvSubjResult.Name = "dgvSubjResult";
            this.dgvSubjResult.ReadOnly = true;
            this.dgvSubjResult.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjResult.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubjResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjResult.Size = new System.Drawing.Size(706, 197);
            this.dgvSubjResult.TabIndex = 1;
            this.dgvSubjResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjResult_CellClick);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(13, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 26);
            this.label10.TabIndex = 95;
            this.label10.Text = "Select Exam Code";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Teal;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(1, 1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(729, 26);
            this.lblStatus.TabIndex = 96;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboExamCode
            // 
            this.cboExamCode.BackColor = System.Drawing.Color.White;
            this.cboExamCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamCode.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExamCode.FormattingEnabled = true;
            this.cboExamCode.Location = new System.Drawing.Point(139, 40);
            this.cboExamCode.Name = "cboExamCode";
            this.cboExamCode.Size = new System.Drawing.Size(146, 26);
            this.cboExamCode.TabIndex = 0;
            this.cboExamCode.SelectedIndexChanged += new System.EventHandler(this.cboExamCode_SelectedIndexChanged);
            // 
            // lblIssuedBy
            // 
            this.lblIssuedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblIssuedBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedBy.ForeColor = System.Drawing.Color.Teal;
            this.lblIssuedBy.Location = new System.Drawing.Point(13, 108);
            this.lblIssuedBy.Name = "lblIssuedBy";
            this.lblIssuedBy.Size = new System.Drawing.Size(350, 25);
            this.lblIssuedBy.TabIndex = 97;
            this.lblIssuedBy.Text = "Issued By:";
            this.lblIssuedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTimeIssued
            // 
            this.lblDateTimeIssued.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTimeIssued.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeIssued.ForeColor = System.Drawing.Color.Teal;
            this.lblDateTimeIssued.Location = new System.Drawing.Point(13, 77);
            this.lblDateTimeIssued.Name = "lblDateTimeIssued";
            this.lblDateTimeIssued.Size = new System.Drawing.Size(348, 25);
            this.lblDateTimeIssued.TabIndex = 98;
            this.lblDateTimeIssued.Text = "Issued On:";
            this.lblDateTimeIssued.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExamDateTime
            // 
            this.lblExamDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblExamDateTime.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamDateTime.ForeColor = System.Drawing.Color.Teal;
            this.lblExamDateTime.Location = new System.Drawing.Point(369, 108);
            this.lblExamDateTime.Name = "lblExamDateTime";
            this.lblExamDateTime.Size = new System.Drawing.Size(349, 25);
            this.lblExamDateTime.TabIndex = 99;
            this.lblExamDateTime.Text = "Exam Date Time:";
            this.lblExamDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassingRate
            // 
            this.lblPassingRate.BackColor = System.Drawing.Color.Transparent;
            this.lblPassingRate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassingRate.ForeColor = System.Drawing.Color.Teal;
            this.lblPassingRate.Location = new System.Drawing.Point(369, 77);
            this.lblPassingRate.Name = "lblPassingRate";
            this.lblPassingRate.Size = new System.Drawing.Size(349, 25);
            this.lblPassingRate.TabIndex = 100;
            this.lblPassingRate.Text = "Passing Rate:";
            this.lblPassingRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Teal;
            this.lblResult.Location = new System.Drawing.Point(368, 41);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(350, 25);
            this.lblResult.TabIndex = 101;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "SubjectName";
            this.colName.HeaderText = "Subject";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Items";
            this.colEmail.HeaderText = "Items";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colEmail.Width = 70;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "PassingScore";
            this.colLastName.HeaderText = "Passing Score";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLastName.Width = 115;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "Score";
            this.colFirstName.HeaderText = "Score";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFirstName.Width = 70;
            // 
            // colMiddleName
            // 
            this.colMiddleName.DataPropertyName = "Result";
            this.colMiddleName.HeaderText = "Result";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            this.colMiddleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMiddleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMiddleName.Width = 70;
            // 
            // colDetails
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            this.colDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDetails.HeaderText = "";
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            this.colDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDetails.Text = "DETAILS";
            this.colDetails.UseColumnTextForButtonValue = true;
            // 
            // rectangleShape8
            // 
            this.rectangleShape8.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape8.Enabled = false;
            this.rectangleShape8.Location = new System.Drawing.Point(367, 40);
            this.rectangleShape8.Name = "rectangleShape8";
            this.rectangleShape8.Size = new System.Drawing.Size(351, 26);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape5,
            this.rectangleShape4,
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1,
            this.rectangleShape8});
            this.shapeContainer1.Size = new System.Drawing.Size(731, 345);
            this.shapeContainer1.TabIndex = 102;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(368, 76);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(351, 26);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape2.Enabled = false;
            this.rectangleShape2.Location = new System.Drawing.Point(12, 76);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(351, 26);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape3.Enabled = false;
            this.rectangleShape3.Location = new System.Drawing.Point(368, 107);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(351, 26);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape4.Enabled = false;
            this.rectangleShape4.Location = new System.Drawing.Point(12, 107);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(351, 26);
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape5.Enabled = false;
            this.rectangleShape5.Location = new System.Drawing.Point(12, 138);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(707, 197);
            // 
            // FrmExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 345);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPassingRate);
            this.Controls.Add(this.lblExamDateTime);
            this.Controls.Add(this.lblDateTimeIssued);
            this.Controls.Add(this.lblIssuedBy);
            this.Controls.Add(this.cboExamCode);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvSubjResult);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExamResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Result";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubjResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboExamCode;
        private System.Windows.Forms.Label lblIssuedBy;
        private System.Windows.Forms.Label lblDateTimeIssued;
        private System.Windows.Forms.Label lblExamDateTime;
        private System.Windows.Forms.Label lblPassingRate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewButtonColumn colDetails;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape8;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
    }
}