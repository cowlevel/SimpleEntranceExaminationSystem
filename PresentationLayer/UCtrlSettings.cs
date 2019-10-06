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

namespace PresentationLayer
{
    public partial class UCtrlSettings : UserControl
    {
        public UCtrlSettings()
        {
            InitializeComponent();
        }

        private void numPassingRate_ValueChanged(object sender, EventArgs e)
        {
            //int passingScore = Compute.GetPercentage((int)numPassingRate.Value, 100);
            SetExampleText();
        }

        private void UCtrlSettings_Load(object sender, EventArgs e)
        {
            numPassingRate.Value = 50;
            SetExampleText();
        }

        private void SetExampleText()
        {
            int sampleTotal = 100;
            double passingScore = Compute.GetPercentage((double)numPassingRate.Value, sampleTotal);
            lblExample.Text = string.Format("Example: subject 'A' with total item of {0}\nPassing rate is {1}%\nThe passing score is {1}", sampleTotal, numPassingRate.Value, Math.Round(passingScore));
        }
    }
}