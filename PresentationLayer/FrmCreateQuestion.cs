using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;

namespace PresentationLayer
{
    public partial class FrmCreateQuestion : Form
    {
        private QuestionBankBLL _questionBankBLL;
        private List<QuestionBank> _questionBankList;
        private int _examId;

        public FrmCreateQuestion()
        {
            InitializeComponent();

            _questionBankBLL = new QuestionBankBLL();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void FrmCreateQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  set question bank list
            //((FrmMain)this.Owner).SetQuestionBank(_questionBankList);
        }


        private void cboItemNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItemNo.Items.Count > 0)
            {
                if (cboItemNo.SelectedIndex != cboItemNo.Items.Count-1)
                {
                    Console.WriteLine("Changing!");
                    cboItemNo.SelectedIndex = cboItemNo.Items.Count - 1;
                }
            }
        }

        private void SetQuestionBank()
        {
            _questionBankList = _questionBankBLL.GetQuestionBankList(_examId);
        }

        public void SetExamId(int examId)
        {
            this._examId = examId;
        }
    }
}