using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;
using ValueObject.ViewModel;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        private UCtrlExaminee _ctrlExaminee;
        private UCtrlExamCode _ctrlExamCode;
        private UCtrlExam _ctrlExam;
        private UCtrlUser _ctrlUser;
        private UCtrlPassword _ctrlPassword;
        private UCtrlSubject _ctrlSubject;
        private UCtrlSettings _ctrlSettings;
        private UCtrlReport _ctrlReport;
        
        public FrmMain()
        {
            InitializeComponent();

            if (UserInfo.UserLevel == "Clerk")
            {
                btnReport.Left = btnCreateExam.Left;
                btnReport.Top = btnCreateExam.Top;

                btnCreateExam.Visible = false;
                btnUser.Visible = false;
                btnSubject.Visible = false;
                btnSettings.Visible = false;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = string.Format("WELCOME {0}", UserInfo.CurrentUser.ToUpper());
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserInfo.CurrentUser = string.Empty;
                UserInfo.UserId = 0;
                UserInfo.UserLevel = string.Empty;

                Thread thread = new Thread(() =>
                {
                    Application.Run(new FrmLogIn());
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                e.Cancel = true;
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

            DisposePanelControl();
            _ctrlSettings = new UCtrlSettings();
            pnlMain.Controls.Add(_ctrlSettings);
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

        private void btnSubject_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnSubject");
            SetMarkerProperties(btnSubject.Top);

            DisposePanelControl();
            _ctrlSubject = new UCtrlSubject();
            pnlMain.Controls.Add(_ctrlSubject);
        }

        public void SetCtrlExamDataSource()
        {
            _ctrlExam.SetExamDatagridViewDataScource();
        }

        private void SetMarkerProperties(int top)
        {
            lblMarker.Top = top;
            lblMarker.Visible = true;
        }

        private void SetButtonColor(string buttonName)
        {
            foreach (Button control in this.Controls.OfType<Button>())
            {
                //if (control is Button)
                //{
                    if (control.Name != buttonName)
                    {
                        control.ForeColor = Color.Teal;
                        //(control as Button).FlatAppearance.BorderColor = Color.White;
                        //(control as Button).BackColor = Color.White;
                        control.BackColor = Color.White;
                    }
                    else
                    {
                        control.ForeColor = Color.White;
                        //(control as Button).FlatAppearance.BorderColor = Color.Teal;
                        //(control as Button).BackColor = Color.Teal;
                        control.BackColor = Color.Teal;
                    }
                //}
            }
        }

        private void DisposePanelControl()
        {
            if (pnlMain.Controls.Count > 0)
            {
                pnlMain.Controls[0].Dispose();
            }
        }

        private void btnExamCode_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnExamCode");
            SetMarkerProperties(btnExamCode.Top);

            DisposePanelControl();
            _ctrlExamCode = new UCtrlExamCode();
            pnlMain.Controls.Add(_ctrlExamCode);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SetButtonColor("btnReport");
            SetMarkerProperties(btnReport.Top);

            DisposePanelControl();
            _ctrlReport = new UCtrlReport();
            pnlMain.Controls.Add(_ctrlReport);
        }
    }
}