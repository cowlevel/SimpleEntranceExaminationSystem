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
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numPassingRate = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExample = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblPassingRate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPassingRate)).BeginInit();
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
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 11F);
            this.tabControl1.Location = new System.Drawing.Point(13, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPassingRate);
            this.tabPage1.Controls.Add(this.btnSet);
            this.tabPage1.Controls.Add(this.lblExample);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numPassingRate);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Passing Rate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Examinee Take Days";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numPassingRate
            // 
            this.numPassingRate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPassingRate.Location = new System.Drawing.Point(110, 59);
            this.numPassingRate.Minimum = new decimal(new int[] {
            10,
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
            // lblExample
            // 
            this.lblExample.BackColor = System.Drawing.Color.Gray;
            this.lblExample.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExample.ForeColor = System.Drawing.Color.White;
            this.lblExample.Location = new System.Drawing.Point(12, 108);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(325, 121);
            this.lblExample.TabIndex = 117;
            this.lblExample.Text = "Ex. Subject \'A\' with total item of 100";
            this.lblExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Location = new System.Drawing.Point(227, 59);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(110, 26);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "&SET";
            this.btnSet.UseVisualStyleBackColor = false;
            // 
            // lblPassingRate
            // 
            this.lblPassingRate.BackColor = System.Drawing.Color.Gray;
            this.lblPassingRate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassingRate.ForeColor = System.Drawing.Color.White;
            this.lblPassingRate.Location = new System.Drawing.Point(12, 13);
            this.lblPassingRate.Name = "lblPassingRate";
            this.lblPassingRate.Size = new System.Drawing.Size(325, 26);
            this.lblPassingRate.TabIndex = 119;
            this.lblPassingRate.Text = "The Current Passing Rate Is:";
            this.lblPassingRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCtrlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStatus);
            this.Name = "UCtrlSettings";
            this.Size = new System.Drawing.Size(1094, 638);
            this.Load += new System.EventHandler(this.UCtrlSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPassingRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numPassingRate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblPassingRate;
    }
}
