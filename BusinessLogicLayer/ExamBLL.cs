using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DatabaseAccessLayer;
using ValueObject.ViewModel;

namespace BusinessLogicLayer
{
    public class ExamBLL
    {
        private ExamDAL _examDAL;

        public ExamBLL()
        {
            _examDAL = new ExamDAL();
        }

        public List<ExamViewModel> GetExamViewModelList()
        {
            return _examDAL.GetExamViewModelList();
        }
    }
}
