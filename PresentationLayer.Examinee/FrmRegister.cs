using BusinessLogicLayer;
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

namespace PresentationLayer.Examinee
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(() =>
            {
                Application.Run(new FrmStartExam());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (InputsAreValid())
            {
                //Examinee examinee = new Examinee(); //  create new Examinee
                //examinee.LastName = txtLastName.Text;
                //examinee.FirstName = txtFirstName.Text;
                //examinee.MiddleName = txtMiddleName.Text;
                //examinee.Address = txtAddress.Text;
                //examinee.City = txtCity.Text;
                //examinee.ContactNo = txtContactNo.Text;
                //examinee.Email = txtEmail.Text;
                //examinee.LastSchoolAttended = txtLastSchoolAttended.Text;
                //examinee.YearGraduated = (int)numYearGraduated.Value;
                //examinee.ExamTakes = 0;
                ////examinee.DateTimeAdded = DateTime.Now;    //  to DAL

                //ExamineeBLL examineeBLL = new ExamineeBLL();
                //examineeBLL.InsertExaminee(examinee);
            }
        }

        private bool InputsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lblStatus.Text = "  Please enter last name";
                txtLastName.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                lblStatus.Text = "  Please enter first name";
                txtFirstName.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                lblStatus.Text = "  Please enter address";
                txtAddress.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                lblStatus.Text = "  Pleas enter city";
                txtCity.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                lblStatus.Text = "  Please enter contact no.";
                txtContactNo.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblStatus.Text = "  Please enter email";
                txtEmail.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtLastSchoolAttended.Text))
            {
                lblStatus.Text = "  Please enter last school attended";
                txtLastSchoolAttended.Focus();
                return false;
            }

            return true;
        }
    }
}