using DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class QuestionBankBLL
    {
        private QuestionBankDAL _questionBankDAL;

        public QuestionBankBLL()
        {
            _questionBankDAL = new QuestionBankDAL();
        }

        public List<QuestionBank> GetQuestionBankList(int examId)
        {
            return _questionBankDAL.GetQuestionBankList(examId);
        }
    }
}
