using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public struct SubjectScore
    {
        public string SubjectName { get; set; }
        public int Score { get; set; }
        public int ItemCount { get; set; }
    }
}
