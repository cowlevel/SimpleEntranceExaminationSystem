using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DatabaseAccessLayer;
using ValueObject.ViewModel;
using ValueObject;

namespace BusinessLogicLayer
{
    public class ExamBLL
    {
        private ExamDAL _examDAL;


        public ExamBLL()
        {
            _examDAL = new ExamDAL();
        }

        public bool InsertExam(Exam exam)
        {
            _examDAL.InsertExam(exam);

            return true;
        }

        public void SendExamToArchieve(int examId)
        {
            _examDAL.SendExamToArchieve(examId);
        }

        public void DeleteExam(int examId)
        {
            _examDAL.DeleteExam(examId);
        }

        public List<ExamViewModel> GetExamViewModelList()
        {
            return _examDAL.GetExamViewModelList();
        }

        public List<Exam> GetActiveExamList()
        {
            return _examDAL.GetActiveExamList();
        }

        public DateTime GetDateTime()
        {
            return _examDAL.GetDateTime();
        }
    }
}