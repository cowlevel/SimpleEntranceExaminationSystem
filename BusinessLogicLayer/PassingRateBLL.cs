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
    public class PassingRateBLL
    {
        private PassingRateDAL _passingRateDAL;

        public PassingRateBLL()
        {
            _passingRateDAL = new PassingRateDAL();
        }

        public int GetCurrentPassingRate()
        {
            return _passingRateDAL.GetCurrentPassingRate();
        }

        public List<PassingRateViewModel> GetPassingRateHistory()
        {
            return _passingRateDAL.GetPassingRateHistory();
        }

        public void SetPassingRate(PassingRate passingRate)
        {
            _passingRateDAL.SetPassingRate(passingRate);
        }
    }
}