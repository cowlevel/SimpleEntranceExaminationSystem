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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExaminee = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboExamCode = new System.Windows.Forms.ComboBox();
            this.lblIssuedBy = new System.Windows.Forms.Label();
            this.lblDateTimeIssued = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExaminee
            // 
            this.dgvExaminee.AllowUserToAddRows = false;
            this.dgvExaminee.AllowUserToDeleteRows = false;
            this.dgvExaminee.AllowUserToResizeRows = false;
            this.dgvExaminee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvExaminee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExaminee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExaminee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExaminee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExaminee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colEmail,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colDetails});
            this.dgvExaminee.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvExaminee.Location = new System.Drawing.Point(12, 176);
            this.dgvExaminee.MultiSelect = false;
            this.dgvExaminee.Name = "dgvExaminee";
            this.dgvExaminee.ReadOnly = true;
            this.dgvExaminee.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExaminee.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExaminee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExaminee.Size = new System.Drawing.Size(707, 245);
            this.dgvExaminee.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "FullName";
            this.colName.HeaderText = "Subject";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Items";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colEmail.Width = 70;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Passing Score";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 115;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "Score";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Width = 70;
            // 
            // colMiddleName
            // 
            this.colMiddleName.DataPropertyName = "MiddleName";
            this.colMiddleName.HeaderText = "Result";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            this.colMiddleName.Width = 70;
            // 
            // colDetails
            // 
            this.colDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDetails.HeaderText = "Details";
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            this.colDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDetails.UseColumnTextForButtonValue = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(12, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 26);
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
            this.cboExamCode.Enabled = false;
            this.cboExamCode.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExamCode.FormattingEnabled = true;
            this.cboExamCode.Location = new System.Drawing.Point(152, 36);
            this.cboExamCode.Name = "cboExamCode";
            this.cboExamCode.Size = new System.Drawing.Size(146, 26);
            this.cboExamCode.TabIndex = 0;
            // 
            // lblIssuedBy
            // 
            this.lblIssuedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblIssuedBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedBy.ForeColor = System.Drawing.Color.Teal;
            this.lblIssuedBy.Location = new System.Drawing.Point(12, 91);
            this.lblIssuedBy.Name = "lblIssuedBy";
            this.lblIssuedBy.Size = new System.Drawing.Size(707, 26);
            this.lblIssuedBy.TabIndex = 97;
            this.lblIssuedBy.Text = "Issued By:";
            this.lblIssuedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTimeIssued
            // 
            this.lblDateTimeIssued.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTimeIssued.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeIssued.ForeColor = System.Drawing.Color.Teal;
            this.lblDateTimeIssued.Location = new System.Drawing.Point(12, 65);
            this.lblDateTimeIssued.Name = "lblDateTimeIssued";
            this.lblDateTimeIssued.Size = new System.Drawing.Size(378, 26);
            this.lblDateTimeIssued.TabIndex = 98;
            this.lblDateTimeIssued.Text = "Date and Time Issued:";
            this.lblDateTimeIssued.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 99;
            this.label1.Text = "Exam Date Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(338, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 26);
            this.label2.TabIndex = 100;
            this.label2.Text = "Passing Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDateTimeIssued);
            this.Controls.Add(this.lblIssuedBy);
            this.Controls.Add(this.cboExamCode);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvExaminee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExamResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Result";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExaminee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewButtonColumn colDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboExamCode;
        private System.Windows.Forms.Label lblIssuedBy;
        private System.Windows.Forms.Label lblDateTimeIssued;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}