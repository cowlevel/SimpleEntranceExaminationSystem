using BusinessLogicLayer;
using System;
using System.Threading;
using System.Windows.Forms;
using ValueObject;

namespace PresentationLayer.Client
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        
        private void btnTakeExam_Click(object sender, EventArgs e)
        {

            if (SettingsAreOK())
            {
                this.Close();

                Thread thread = new Thread(() =>
                {
                    Application.Run(new FrmStartExam());
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Cant proceed to take exam.\nPlease notify clerk that some settings were incomplete.\nThank you.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (InputsAreValid())
            {
                Examinee examinee = new Examinee
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    MiddleName = txtMiddleName.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    ContactNo = txtContactNo.Text,
                    Email = txtEmail.Text,
                    LastSchoolAttended = txtLastSchoolAttended.Text,
                    YearGraduated = (int)numYearGraduated.Value,
                    ExamTakes = 0
                }; //  create new Examinee
                //examinee.DateTimeAdded = DateTime.Now;    //  to DAL

                ExamineeBLL examineeBLL = new ExamineeBLL();
                examineeBLL.InsertExaminee(examinee);

                txtLastName.Text = string.Empty;
                txtFirstName.Text = string.Empty;
                txtMiddleName.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtContactNo.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtLastSchoolAttended.Text = string.Empty;

                lblStatus.Text = string.Empty;

                MessageBox.Show(this, "Successfully registered!\nPlease get your exam code then start your exam.\nThank you.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool SettingsAreOK()
        {
            PassingRateBLL passingRateBLL = new PassingRateBLL();
            int passingRate = passingRateBLL.GetCurrentPassingRate();

            if (passingRate == 0)
            {
                //Console.WriteLine("PASSING RATE NOT SET");
                return false;
            }

            ExamineeFailureBLL examineeFailureBLL = new ExamineeFailureBLL();
            int currentWaitDays = examineeFailureBLL.GetCurrentWaitDays();

            if (currentWaitDays == 0)
            {
                //Console.WriteLine("WAIT DAYS NOT SET");
                return false;
            }

            ExamBLL examBLL = new ExamBLL();
            bool isIncomplete = false;
            isIncomplete = examBLL.HasIncompleteExam();

            if (isIncomplete)
            {
                //Console.WriteLine("INCOMPLETE ACTIVE EXAM");
                return false;
            }

            return true;
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

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            numYearGraduated.Maximum = DateTime.Now.Year + 1;
            numYearGraduated.Value = numYearGraduated.Maximum - 1;

            //timer = new System.Timers.Timer(50);
            //timer.SynchronizingObject = this;
            //// Hook up the Elapsed event for the timer.
            //timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //timer.Enabled = true;
        }

        //private void OnTimedEvent(object sender, ElapsedEventArgs e)
        //{
        //    counter += 50;

        //    if (counter == 1000)
        //    {
        //        counter = 0;
        //        number -= 1;
        //        //Invoke(new Action(() => { Text = number.ToString(); }));
        //        Text = number.ToString();
        //    }

        //    Console.WriteLine(DateTime.Now.ToString("d MMM yyyy h:mm:ss.fff"));
        //}

        //System.Timers.Timer timer;
        //int counter = 0;
        //int number = 10;
    }
}