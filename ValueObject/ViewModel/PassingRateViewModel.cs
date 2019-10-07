using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class PassingRateViewModel
    {
        public PassingRateViewModel()
        {

        }

        public string Rate { get; set; }

        public DateTime? DateTimeModified { get; set; }

        public string ModifiedBy { get; set; }
    }
}