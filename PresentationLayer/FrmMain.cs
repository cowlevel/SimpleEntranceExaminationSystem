﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;
using ValueObject.ViewModel;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        private UCtrlExaminee _ctrlExaminee;
        private UCtrlExam _ctrlExam;
        private UCtrlUser _ctrlUser;
        private UCtrlPassword _ctrlPassword;
        private UCtrlSubject _ctrlSubject;

        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void SetButtonColor(string buttonName)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    if (control.Name != buttonName)
                    {
                        control.ForeColor = Color.Teal;
                        //(control as Button).FlatAppearance.BorderColor = Color.White;
                        (control as Button).BackColor = Color.White;
                    }
                    else
                    {
                        control.ForeColor = Color.White;
                        //(control as Button).FlatAppearance.BorderColor = Color.Teal;
                        (control as Button).BackColor = Color.Teal;
                    }
                }
            }
        }

        private void DisposePanelControl()
        {
            if (pnlMain.Controls.Count > 0)
            {
                pnlMain.Controls[0].Dispose();
            }
        }

        private void btnExaminee_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnExaminee");
            SetMarkerProperties(btnExaminee.Top);

            DisposePanelControl();
            _ctrlExaminee = new UCtrlExaminee();
            pnlMain.Controls.Add(_ctrlExaminee);

        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnCreateExam");
            SetMarkerProperties(btnCreateExam.Top);

            DisposePanelControl();
            _ctrlExam = new UCtrlExam();
            pnlMain.Controls.Add(_ctrlExam);

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnUser");
            SetMarkerProperties(btnUser.Top);

            DisposePanelControl();
            _ctrlUser = new UCtrlUser();
            pnlMain.Controls.Add(_ctrlUser);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnSettings");
            SetMarkerProperties(btnSettings.Top);

            lblMarker.Top = btnSettings.Top;
            lblMarker.Visible = true;

            DisposePanelControl();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnChangePassword");
            SetMarkerProperties(btnChangePassword.Top);

            DisposePanelControl();
            _ctrlPassword = new UCtrlPassword();
            pnlMain.Controls.Add(_ctrlPassword);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetMarkerProperties(int top)
        {
            lblMarker.Top = top;
            lblMarker.Visible = true;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* remove comment later
            ((FrmLogIn)Owner).Visible = true;
            ((FrmLogIn)Owner).Controls["txtUsername"].Focus();
            UserInfo.UserId = 0;
            UserInfo.CurrentUser = string.Empty;
            UserInfo.UserLevel = string.Empty;
             */
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnSubject");
            SetMarkerProperties(btnSubject.Top);

            DisposePanelControl();
            _ctrlSubject = new UCtrlSubject();
            pnlMain.Controls.Add(_ctrlSubject);
        }
    }
}