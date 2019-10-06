using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class SubjectViewModel
    {
        public SubjectViewModel()
        {

        }

        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public string Description { get; set; }

        public bool InExam { get; set; }


        public string InExamSymbol
        {
            get
            {
                return InExam ? "✓" : "✘";
            }
        }
    }
}