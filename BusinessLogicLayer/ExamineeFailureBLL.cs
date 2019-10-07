using DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using ValueObject.ViewModel;

namespace BusinessLogicLayer
{
    public class ExamineeFailureBLL
    {
        private ExamineeFailureDAL _examineeFailureDAL;

        public ExamineeFailureBLL()
        {
            _examineeFailureDAL = new ExamineeFailureDAL();
        }

        public int GetCurrentWaitDays()
        {
            return _examineeFailureDAL.GetCurrentWaitDays();
        }

        public List<ExamineeFailureViewModel> GetWaitDaysHistory()
        {
            return _examineeFailureDAL.GetWaitDaysHistory();
        }

        public void SetWaitDays(ExamineeFailure examineeFailure)
        {
            _examineeFailureDAL.SetWaitDays(examineeFailure);
        }
    }
}
