namespace PresentationLayer.Client
{
    partial class FrmExam
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
            this.components = new System.ComponentModel.Container();
            this.lblType = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectChoice = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblExamType = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLimit = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.chkTrue = new System.Windows.Forms.CheckBox();
            this.chkFalse = new System.Windows.Forms.CheckBox();
            this.chkChoice1 = new System.Windows.Forms.CheckBox();
            this.chkChoice2 = new System.Windows.Forms.CheckBox();
            this.chkChoice3 = new System.Windows.Forms.CheckBox();
            this.chkChoice4 = new System.Windows.Forms.CheckBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Teal;
            this.lblType.Location = new System.Drawing.Point(1000, 589);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(130, 27);
            this.lblType.TabIndex = 172;
            this.lblType.Text = "Type The Answer";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblType.Visible = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.White;
            this.txtAnswer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(1003, 619);
            this.txtAnswer.MaxLength = 200;
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer.Size = new System.Drawing.Size(972, 68);
            this.txtAnswer.TabIndex = 0;
            this.txtAnswer.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Teal;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(1, 1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1024, 26);
            this.lblStatus.TabIndex = 166;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.LightYellow;
            this.lblQuestion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(13, 147);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1000, 245);
            this.lblQuestion.TabIndex = 167;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gray;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(12, 739);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(250, 68);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "NEXT >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.Teal;
            this.lblSubject.Location = new System.Drawing.Point(13, 40);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(789, 25);
            this.lblSubject.TabIndex = 169;
            this.lblSubject.Text = "Subject:";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape4.Enabled = false;
            this.rectangleShape4.Location = new System.Drawing.Point(12, 39);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(792, 26);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectChoice,
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1,
            this.rectangleShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(1026, 828);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // rectChoice
            // 
            this.rectChoice.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectChoice.Enabled = false;
            this.rectChoice.Location = new System.Drawing.Point(12, 401);
            this.rectChoice.Name = "rectChoice";
            this.rectChoice.Size = new System.Drawing.Size(1002, 290);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape3.Enabled = false;
            this.rectangleShape3.Location = new System.Drawing.Point(12, 146);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(1002, 246);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape2.Enabled = false;
            this.rectangleShape2.Location = new System.Drawing.Point(513, 70);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(291, 26);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(12, 70);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(496, 26);
            // 
            // lblExamType
            // 
            this.lblExamType.BackColor = System.Drawing.Color.Transparent;
            this.lblExamType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamType.ForeColor = System.Drawing.Color.Teal;
            this.lblExamType.Location = new System.Drawing.Point(13, 71);
            this.lblExamType.Name = "lblExamType";
            this.lblExamType.Size = new System.Drawing.Size(495, 25);
            this.lblExamType.TabIndex = 171;
            this.lblExamType.Text = "Examination Type:";
            this.lblExamType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItems
            // 
            this.lblItems.BackColor = System.Drawing.Color.Transparent;
            this.lblItems.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.ForeColor = System.Drawing.Color.Teal;
            this.lblItems.Location = new System.Drawing.Point(514, 71);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(288, 25);
            this.lblItems.TabIndex = 172;
            this.lblItems.Text = "Items:";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeLimit
            // 
            this.lblTimeLimit.BackColor = System.Drawing.Color.Teal;
            this.lblTimeLimit.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLimit.ForeColor = System.Drawing.Color.White;
            this.lblTimeLimit.Location = new System.Drawing.Point(808, 39);
            this.lblTimeLimit.Name = "lblTimeLimit";
            this.lblTimeLimit.Size = new System.Drawing.Size(206, 57);
            this.lblTimeLimit.TabIndex = 174;
            this.lblTimeLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.Teal;
            this.lblCounter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.White;
            this.lblCounter.Location = new System.Drawing.Point(12, 116);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(187, 25);
            this.lblCounter.TabIndex = 175;
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkTrue
            // 
            this.chkTrue.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.chkTrue.Location = new System.Drawing.Point(12, 766);
            this.chkTrue.Name = "chkTrue";
            this.chkTrue.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.chkTrue.Size = new System.Drawing.Size(499, 109);
            this.chkTrue.TabIndex = 0;
            this.chkTrue.Text = "True";
            this.chkTrue.UseVisualStyleBackColor = true;
            this.chkTrue.Visible = false;
            this.chkTrue.CheckedChanged += new System.EventHandler(this.chkTrue_CheckedChanged);
            this.chkTrue.MouseEnter += new System.EventHandler(this.chkTrue_MouseEnter);
            this.chkTrue.MouseLeave += new System.EventHandler(this.chkTrue_MouseLeave);
            // 
            // chkFalse
            // 
            this.chkFalse.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.chkFalse.Location = new System.Drawing.Point(514, 766);
            this.chkFalse.Name = "chkFalse";
            this.chkFalse.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.chkFalse.Size = new System.Drawing.Size(499, 109);
            this.chkFalse.TabIndex = 1;
            this.chkFalse.Text = "False";
            this.chkFalse.UseVisualStyleBackColor = true;
            this.chkFalse.Visible = false;
            this.chkFalse.CheckedChanged += new System.EventHandler(this.chkFalse_CheckedChanged);
            this.chkFalse.MouseEnter += new System.EventHandler(this.chkFalse_MouseEnter);
            this.chkFalse.MouseLeave += new System.EventHandler(this.chkFalse_MouseLeave);
            // 
            // chkChoice1
            // 
            this.chkChoice1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.chkChoice1.Location = new System.Drawing.Point(13, 402);
            this.chkChoice1.Name = "chkChoice1";
            this.chkChoice1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkChoice1.Size = new System.Drawing.Size(1001, 70);
            this.chkChoice1.TabIndex = 0;
            this.chkChoice1.UseVisualStyleBackColor = true;
            this.chkChoice1.Visible = false;
            this.chkChoice1.CheckedChanged += new System.EventHandler(this.chkChoice1_CheckedChanged);
            this.chkChoice1.MouseEnter += new System.EventHandler(this.chkChoice1_MouseEnter);
            this.chkChoice1.MouseLeave += new System.EventHandler(this.chkChoice1_MouseLeave);
            // 
            // chkChoice2
            // 
            this.chkChoice2.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.chkChoice2.Location = new System.Drawing.Point(13, 475);
            this.chkChoice2.Name = "chkChoice2";
            this.chkChoice2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkChoice2.Size = new System.Drawing.Size(1001, 70);
            this.chkChoice2.TabIndex = 1;
            this.chkChoice2.UseVisualStyleBackColor = true;
            this.chkChoice2.Visible = false;
            this.chkChoice2.CheckedChanged += new System.EventHandler(this.chkChoice2_CheckedChanged);
            this.chkChoice2.MouseEnter += new System.EventHandler(this.chkChoice2_MouseEnter);
            this.chkChoice2.MouseLeave += new System.EventHandler(this.chkChoice2_MouseLeave);
            // 
            // chkChoice3
            // 
            this.chkChoice3.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.chkChoice3.Location = new System.Drawing.Point(13, 548);
            this.chkChoice3.Name = "chkChoice3";
            this.chkChoice3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkChoice3.Size = new System.Drawing.Size(1001, 70);
            this.chkChoice3.TabIndex = 2;
            this.chkChoice3.UseVisualStyleBackColor = true;
            this.chkChoice3.Visible = false;
            this.chkChoice3.CheckedChanged += new System.EventHandler(this.chkChoice3_CheckedChanged);
            this.chkChoice3.MouseEnter += new System.EventHandler(this.chkChoice3_MouseEnter);
            this.chkChoice3.MouseLeave += new System.EventHandler(this.chkChoice3_MouseLeave);
            // 
            // chkChoice4
            // 
            this.chkChoice4.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.chkChoice4.Location = new System.Drawing.Point(13, 621);
            this.chkChoice4.Name = "chkChoice4";
            this.chkChoice4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkChoice4.Size = new System.Drawing.Size(1001, 70);
            this.chkChoice4.TabIndex = 3;
            this.chkChoice4.UseVisualStyleBackColor = true;
            this.chkChoice4.Visible = false;
            this.chkChoice4.CheckedChanged += new System.EventHandler(this.chkChoice4_CheckedChanged);
            this.chkChoice4.MouseEnter += new System.EventHandler(this.chkChoice4_MouseEnter);
            this.chkChoice4.MouseLeave += new System.EventHandler(this.chkChoice4_MouseLeave);
            // 
            // lblSelect
            // 
            this.lblSelect.BackColor = System.Drawing.Color.LightCoral;
            this.lblSelect.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.White;
            this.lblSelect.Location = new System.Drawing.Point(279, 739);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(736, 68);
            this.lblSelect.TabIndex = 177;
            this.lblSelect.Text = "Please select/enter answer!";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelect.Visible = false;
            // 
            // FrmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 828);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.chkChoice4);
            this.Controls.Add(this.chkChoice3);
            this.Controls.Add(this.chkChoice2);
            this.Controls.Add(this.chkChoice1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.chkTrue);
            this.Controls.Add(this.chkFalse);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblTimeLimit);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblExamType);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEST";
            this.Load += new System.EventHandler(this.FrmExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSubject;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblExamType;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeLimit;
        private System.Windows.Forms.Label lblCounter;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.CheckBox chkTrue;
        private System.Windows.Forms.CheckBox chkFalse;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectChoice;
        private System.Windows.Forms.CheckBox chkChoice1;
        private System.Windows.Forms.CheckBox chkChoice2;
        private System.Windows.Forms.CheckBox chkChoice3;
        private System.Windows.Forms.CheckBox chkChoice4;
        private System.Windows.Forms.Label lblSelect;
    }
}