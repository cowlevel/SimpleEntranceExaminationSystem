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
using ValueObject.ViewModel;

namespace PresentationLayer
{
    public partial class FrmTOFWTAHistory : Form
    {
        public FrmTOFWTAHistory()
        {
            InitializeComponent();
            
            dgvHistory.AutoGenerateColumns = false;
        }

        public void SetItemNo(int itemNo)
        {
            lblItemNo.Text = string.Format("Item No. {0}", itemNo);
        }

        public void SetHistory(int questionId)
        {
            QuestionBankBLL questionBankBLL = new QuestionBankBLL();
            List<QuestionBankHistoryViewModel> historyViewModel = questionBankBLL.GetQuestionBankHistoryViewModelList(questionId);

            dgvHistory.DataSource = null;

            if (historyViewModel != null)
            {
                dgvHistory.DataSource = historyViewModel;
                dgvHistory.ClearSelection();
            }
        }
    }
}