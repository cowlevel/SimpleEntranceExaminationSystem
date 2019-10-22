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

namespace PresentationLayer.Client
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string examCode = txtExamCode.Text;
            ExamineeTakeBLL examineeTakeBLL = new ExamineeTakeBLL();
            ExamineeTake examineeTake = examineeTakeBLL.GetExamineeTakeInfo(examCode);

            if (examineeTake != null)
            {
                examineeTakeBLL.SetExamineeTakeChildInfo(examineeTake);

                Thread thread = new Thread(() =>
                {
                    //FrmExam frmExam = new FrmExam();
                    //frmExam.ExamineeTakeInfo = examineeTake;
                    //Application.Run(frmExam);
                    Application.Run(new FrmExam(examineeTake));

                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

                this.Close();
            }
            else
            {
                lblStatus.Text = "  Invalid Exam Code!";
            }
        }
    }

    public static class ShuffleMode
    {
        private static Random rng = new Random();

        public static void ShuffleX<T>(this IList<T> list)
        {
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}