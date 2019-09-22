using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject.ViewModel;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
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

            lblMarker.Top = btnExaminee.Top;
            lblMarker.Visible = true;

            DisposePanelControl();
            UCtrlExaminee ctrlExaminee = new UCtrlExaminee();
            pnlMain.Controls.Add(ctrlExaminee);

        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnCreateExam");

            lblMarker.Top = btnCreateExam.Top;
            lblMarker.Visible = true;

            DisposePanelControl();


        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnSubject");

            lblMarker.Top = btnSubject.Top;
            lblMarker.Visible = true;

            DisposePanelControl();
            UCtrlSubject ctrlSubject = new UCtrlSubject();
            pnlMain.Controls.Add(ctrlSubject);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnUser");

            lblMarker.Top = btnUser.Top;
            lblMarker.Visible = true;

            DisposePanelControl();
            UCtrlUser ctrlUser = new UCtrlUser();
            pnlMain.Controls.Add(ctrlUser);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnSettings");

            lblMarker.Top = btnSettings.Top;
            lblMarker.Visible = true;

            DisposePanelControl();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnChangePassword");

            lblMarker.Top = btnChangePassword.Top;
            lblMarker.Visible = true;

            DisposePanelControl();
            UCtrlPassword ctrlPassword = new UCtrlPassword();
            pnlMain.Controls.Add(ctrlPassword);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}