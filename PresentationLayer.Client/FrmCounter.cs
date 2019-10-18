using System;
using System.Windows.Forms;

namespace PresentationLayer.Client
{
    public partial class FrmCounter : Form
    {
        private int _counter = 10;

        public FrmCounter(string caption)
        {
            InitializeComponent();

            lblCaption.Text = caption;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_counter == 0)
            {
                timer1.Enabled = false;
                this.Close();
            }

            lblCounter.Text = _counter.ToString();

            _counter -= 1;
        }
    }
}