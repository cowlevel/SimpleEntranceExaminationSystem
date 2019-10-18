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

namespace PresentationLayer.Examinee
{
    public partial class FrmStartExam : Form
    {
        public FrmStartExam()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(() =>
            {
                Application.Run(new FrmRegister());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
