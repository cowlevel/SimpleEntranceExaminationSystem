using DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using ValueObject.ViewModel;

namespace BusinessLogicLayer
{
    public class QuestionBankBLL
    {
        //private bool _isValid;
        //private ValueObjectValidator _objectValidator;
        //private List<ValidationResult> _validationResults;
        private QuestionBankDAL _questionBankDAL;

        public QuestionBankBLL()
        {
            _questionBankDAL = new QuestionBankDAL();
        }

        public bool InsertQuestion(QuestionBank question)
        {
            _questionBankDAL.InsertQuestion(question);

            return true;
        }

        public bool UpdateQuestion(QuestionBank question)
        {
            _questionBankDAL.UpdateQuestion(question);

            return true;
        }

        //public bool DeleteQuestion(QuestionBank question)
        //{
        //    _questionBankDAL.DeleteQuestion(question);

        //    return true;
        //}

        public List<QuestionBank> GetQuestionBankList(int examId)
        {
            return _questionBankDAL.GetQuestionBankList(examId);
        }

        public List<QuestionBankHistoryViewModel> GetQuestionBankHistoryViewModelList(int questionId)
        {
            return _questionBankDAL.GetQuestionBankHistoryViewModelList(questionId);
        }
    }
}