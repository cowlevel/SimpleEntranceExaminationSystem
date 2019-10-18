namespace PresentationLayer
{
    partial class FrmTrueOrFalse
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.numItemNo = new System.Windows.Forms.NumericUpDown();
            this.lblTotalItemCount = new System.Windows.Forms.Label();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdbTrue = new System.Windows.Forms.RadioButton();
            this.rdbFalse = new System.Windows.Forms.RadioButton();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numItemNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Teal;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(595, 30);
            this.lblStatus.TabIndex = 146;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numItemNo
            // 
            this.numItemNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numItemNo.Location = new System.Drawing.Point(83, 40);
            this.numItemNo.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numItemNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemNo.Name = "numItemNo";
            this.numItemNo.ReadOnly = true;
            this.numItemNo.Size = new System.Drawing.Size(93, 26);
            this.numItemNo.TabIndex = 0;
            this.numItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numItemNo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numItemNo.ValueChanged += new System.EventHandler(this.numItemNo_ValueChanged);
            // 
            // lblTotalItemCount
            // 
            this.lblTotalItemCount.BackColor = System.Drawing.Color.White;
            this.lblTotalItemCount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemCount.ForeColor = System.Drawing.Color.Teal;
            this.lblTotalItemCount.Location = new System.Drawing.Point(425, 40);
            this.lblTotalItemCount.Name = "lblTotalItemCount";
            this.lblTotalItemCount.Size = new System.Drawing.Size(154, 26);
            this.lblTotalItemCount.TabIndex = 165;
            this.lblTotalItemCount.Text = "Total Item Count: ";
            this.lblTotalItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemNo
            // 
            this.lblItemNo.BackColor = System.Drawing.Color.White;
            this.lblItemNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNo.ForeColor = System.Drawing.Color.Teal;
            this.lblItemNo.Location = new System.Drawing.Point(13, 40);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(71, 26);
            this.lblItemNo.TabIndex = 166;
            this.lblItemNo.Text = "Item No.";
            this.lblItemNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightCoral;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(514, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 168;
            this.label6.Text = "Required";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.White;
            this.lblQuestion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Teal;
            this.lblQuestion.Location = new System.Drawing.Point(18, 78);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(496, 26);
            this.lblQuestion.TabIndex = 169;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.White;
            this.txtQuestion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(13, 104);
            this.txtQuestion.MaxLength = 350;
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(566, 73);
            this.txtQuestion.TabIndex = 1;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(13, 77);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(566, 27);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(591, 317);
            this.shapeContainer1.TabIndex = 170;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape3.Enabled = false;
            this.rectangleShape3.Location = new System.Drawing.Point(13, 210);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(566, 52);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape2.Enabled = false;
            this.rectangleShape2.Location = new System.Drawing.Point(13, 183);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(566, 27);
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.BackColor = System.Drawing.Color.White;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.ForeColor = System.Drawing.Color.Teal;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(18, 184);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(496, 26);
            this.lblCorrectAnswer.TabIndex = 171;
            this.lblCorrectAnswer.Text = "Choose Answer";
            this.lblCorrectAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightCoral;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(514, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 26);
            this.label7.TabIndex = 172;
            this.label7.Text = "Required";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(13, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdbTrue
            // 
            this.rdbTrue.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.rdbTrue.ForeColor = System.Drawing.Color.Teal;
            this.rdbTrue.Location = new System.Drawing.Point(32, 214);
            this.rdbTrue.Name = "rdbTrue";
            this.rdbTrue.Size = new System.Drawing.Size(252, 45);
            this.rdbTrue.TabIndex = 2;
            this.rdbTrue.TabStop = true;
            this.rdbTrue.Text = "TRUE";
            this.rdbTrue.UseVisualStyleBackColor = true;
            // 
            // rdbFalse
            // 
            this.rdbFalse.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.rdbFalse.ForeColor = System.Drawing.Color.Teal;
            this.rdbFalse.Location = new System.Drawing.Point(312, 214);
            this.rdbFalse.Name = "rdbFalse";
            this.rdbFalse.Size = new System.Drawing.Size(252, 45);
            this.rdbFalse.TabIndex = 3;
            this.rdbFalse.TabStop = true;
            this.rdbFalse.Text = "FALSE";
            this.rdbFalse.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Gray;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(470, 269);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(110, 40);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "&HISTORY";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // FrmTrueOrFalse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 317);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.rdbFalse);
            this.Controls.Add(this.rdbTrue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.numItemNo);
            this.Controls.Add(this.lblTotalItemCount);
            this.Controls.Add(this.lblItemNo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTrueOrFalse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "True or False";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTrueOrFalse_FormClosing);
            this.Load += new System.EventHandler(this.FrmTrueOrFalse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numItemNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown numItemNo;
        private System.Windows.Forms.Label lblTotalItemCount;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdbTrue;
        private System.Windows.Forms.RadioButton rdbFalse;
        private System.Windows.Forms.Button btnHistory;
    }
}