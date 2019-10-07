using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class ExamineeFailureViewModel
    {
        public int WaitDays { get; set; }
        public DateTime? DateTimeModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}