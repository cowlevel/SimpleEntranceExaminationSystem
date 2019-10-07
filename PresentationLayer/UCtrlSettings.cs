using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
using ValueObject;
using ValueObject.ViewModel;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class UCtrlSettings : UserControl
    {
        private PassingRateBLL _passingRateBLL;
        private List<PassingRateViewModel> _passingRateViewModelList;
        private int _currentPassingRate;

        private ExamineeFailureBLL _examineeFailureBLL;
        private List<ExamineeFailureViewModel> _examineeFailureViewModelList;
        private int _currentWaitDays;

        public UCtrlSettings()
        {
            InitializeComponent();
            

            _passingRateBLL = new PassingRateBLL();
            _currentPassingRate = _passingRateBLL.GetCurrentPassingRate();
            _examineeFailureBLL = new ExamineeFailureBLL();
            _currentWaitDays = _examineeFailureBLL.GetCurrentWaitDays();

            dgvPassingRate.AutoGenerateColumns = false;
            dgvExamineeFailure.AutoGenerateColumns = false;

            SetPassingRateDefaultSettings();
            SetWaitDaysDefaultSettings();
        }

        private void UCtrlSettings_Load(object sender, EventArgs e)
        {
            dgvPassingRate.ClearSelection();
            dgvExamineeFailure.ClearSelection();
        }

        private void numPassingRate_ValueChanged(object sender, EventArgs e)
        {
            SetPassingRateExampleText();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int newPassingRate = (int)numPassingRate.Value;

            DialogResult result = MessageBox.Show(this, string.Format("Set the passing rate to {0}%?", newPassingRate), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PassingRate passingRate = new PassingRate();
                passingRate.Rate = newPassingRate;
                passingRate.UserId = UserInfo.UserId;

                _passingRateBLL.SetPassingRate(passingRate);

                SetPassingRateHistory();

                lblPassingRate.Text = string.Format("The Current Passing Rate Is: {0}%", newPassingRate);
                lblStatus.Text = "  Successfully set passing rate";
            }
        }

        private void SetPassingRateDefaultSettings()
        {
            if (_currentPassingRate == 0)
            {
                lblPassingRate.Text = "Please set the passing rate";
                numPassingRate.Value = 50;
                SetPassingRateExampleText();
            }
            else
            {
                numPassingRate.Value = _currentPassingRate;
                lblPassingRate.Text = string.Format("The Current Passing Rate Is: {0}%", _currentPassingRate);
                SetPassingRateExampleText();
            }

            SetPassingRateHistory();
        }

        private void SetPassingRateExampleText()
        {
            int sampleTotal = 100;
            double passingScore = Compute.GetPercentage((double)numPassingRate.Value, sampleTotal);
            lblExample.Text = string.Format("Example: subject 'A' with total item of {0}\nPassing rate is {1}%\nThe passing score is {2}", sampleTotal, numPassingRate.Value, Math.Round(passingScore));
        }

        private void SetPassingRateHistory()
        {
            _passingRateViewModelList = _passingRateBLL.GetPassingRateHistory();
            dgvPassingRate.DataSource = null;

            if (_passingRateViewModelList.Count > 0)
            {
                dgvPassingRate.DataSource = _passingRateViewModelList;
                dgvPassingRate.ClearSelection();
            }
        }



        private void numWaitDays_ValueChanged(object sender, EventArgs e)
        {
            //lblExamineeFail.Text = string.Format("Failed examinee must wait for {0} day(s) to get another exam.", (int)numWaitDays.Value);
        }

        private void btnSetDays_Click(object sender, EventArgs e)
        {
            int newWaitDays = (int)numWaitDays.Value;

            DialogResult result = MessageBox.Show(this, string.Format("Set the days to wait to {0} days?", newWaitDays), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ExamineeFailure examineeFailureWaitDays = new ExamineeFailure();
                examineeFailureWaitDays.WaitDays = newWaitDays;
                examineeFailureWaitDays.UserId = UserInfo.UserId;

                _examineeFailureBLL.SetWaitDays(examineeFailureWaitDays);

                SetWaitDaysHistory();

                lblWaitDays.Text = string.Format("The Current Days To Wait is {0} days", newWaitDays);
                lblExamineeFail.Text = string.Format("Failed examinee must wait for {0} days to get another exam.", newWaitDays);
                lblStatus.Text = "  Successfully set wait days";
            }
        }

        private void SetWaitDaysDefaultSettings()
        {
            if (_currentWaitDays == 0)
            {
                lblWaitDays.Text = "Please set days to wait";
                numWaitDays.Value = 60;
                lblExamineeFail.Text = "Please set days to wait for failed examinee";
            }
            else
            {
                numWaitDays.Value = _currentWaitDays;
                lblWaitDays.Text = string.Format("Days to wait: {0}", _currentWaitDays);
                lblExamineeFail.Text = string.Format("Failed examinee must wait for {0} days to get another exam.", _currentWaitDays);
            }

            SetWaitDaysHistory();
        }

        private void SetWaitDaysHistory()
        {
            _examineeFailureViewModelList = _examineeFailureBLL.GetWaitDaysHistory(); ;
            dgvExamineeFailure.DataSource = null;

            if (_examineeFailureViewModelList.Count > 0)
            {
                dgvExamineeFailure.DataSource = _examineeFailureViewModelList;
                dgvExamineeFailure.ClearSelection();
            }
        }
    }
}