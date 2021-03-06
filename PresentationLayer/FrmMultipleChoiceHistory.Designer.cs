﻿namespace PresentationLayer
{
    partial class FrmMultipleChoiceHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWrongAnswer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWrongAnswer2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWrongAnswer3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Teal;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1401, 30);
            this.lblStatus.TabIndex = 147;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemNo
            // 
            this.lblItemNo.BackColor = System.Drawing.Color.White;
            this.lblItemNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNo.ForeColor = System.Drawing.Color.Teal;
            this.lblItemNo.Location = new System.Drawing.Point(13, 40);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(229, 26);
            this.lblItemNo.TabIndex = 165;
            this.lblItemNo.Text = "Item No.";
            this.lblItemNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubject,
            this.colDescription,
            this.colWrongAnswer1,
            this.colWrongAnswer2,
            this.colWrongAnswer3,
            this.colInExam,
            this.colModifiedBy});
            this.dgvHistory.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHistory.Location = new System.Drawing.Point(17, 76);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistory.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(1354, 276);
            this.dgvHistory.TabIndex = 166;
            // 
            // colSubject
            // 
            this.colSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubject.DataPropertyName = "Question";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colSubject.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSubject.HeaderText = "Question";
            this.colSubject.MinimumWidth = 300;
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            this.colSubject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "CorrectAnswer";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDescription.HeaderText = "Answer";
            this.colDescription.MinimumWidth = 100;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDescription.Width = 150;
            // 
            // colWrongAnswer1
            // 
            this.colWrongAnswer1.DataPropertyName = "WrongAnswer1";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colWrongAnswer1.DefaultCellStyle = dataGridViewCellStyle4;
            this.colWrongAnswer1.HeaderText = "Wrong Answer 1";
            this.colWrongAnswer1.Name = "colWrongAnswer1";
            this.colWrongAnswer1.ReadOnly = true;
            this.colWrongAnswer1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWrongAnswer1.Width = 150;
            // 
            // colWrongAnswer2
            // 
            this.colWrongAnswer2.DataPropertyName = "WrongAnswer2";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colWrongAnswer2.DefaultCellStyle = dataGridViewCellStyle5;
            this.colWrongAnswer2.HeaderText = "Wrong Answer 2";
            this.colWrongAnswer2.Name = "colWrongAnswer2";
            this.colWrongAnswer2.ReadOnly = true;
            this.colWrongAnswer2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWrongAnswer2.Width = 150;
            // 
            // colWrongAnswer3
            // 
            this.colWrongAnswer3.DataPropertyName = "WrongAnswer3";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colWrongAnswer3.DefaultCellStyle = dataGridViewCellStyle6;
            this.colWrongAnswer3.HeaderText = "Wrong Answer 3";
            this.colWrongAnswer3.Name = "colWrongAnswer3";
            this.colWrongAnswer3.ReadOnly = true;
            this.colWrongAnswer3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWrongAnswer3.Width = 150;
            // 
            // colInExam
            // 
            this.colInExam.DataPropertyName = "DateTimeModified";
            dataGridViewCellStyle7.Format = "G";
            dataGridViewCellStyle7.NullValue = null;
            this.colInExam.DefaultCellStyle = dataGridViewCellStyle7;
            this.colInExam.HeaderText = "Date Time Modified";
            this.colInExam.Name = "colInExam";
            this.colInExam.ReadOnly = true;
            this.colInExam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colInExam.Width = 160;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.DataPropertyName = "ModifiedBy";
            this.colModifiedBy.HeaderText = "Modified By";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.ReadOnly = true;
            this.colModifiedBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colModifiedBy.Width = 200;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(16, 75);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1355, 277);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1383, 364);
            this.shapeContainer1.TabIndex = 167;
            this.shapeContainer1.TabStop = false;
            // 
            // FrmMultipleChoiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 364);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.lblItemNo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMultipleChoiceHistory";
            this.Text = "Question History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.DataGridView dgvHistory;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWrongAnswer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWrongAnswer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWrongAnswer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedBy;
    }
}