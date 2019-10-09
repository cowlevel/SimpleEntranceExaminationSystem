using DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject.ViewModel;

namespace BusinessLogicLayer
{
    public class ExamineeTakeBLL
    {
        private ExamineeTakeDAL _examineeTakeDAL;

        public ExamineeTakeBLL()
        {
            _examineeTakeDAL = new ExamineeTakeDAL();
        }

        public List<ExamineeTakeStatusViewModel> GetExamineeTakeStatusViewModel(int currentDaysToWait)
        {
            return _examineeTakeDAL.GetExamineeTakeStatusViewModel(currentDaysToWait);
        }
    }
}