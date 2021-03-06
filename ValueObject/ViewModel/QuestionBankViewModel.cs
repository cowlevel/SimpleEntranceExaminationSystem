﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class QuestionBankViewModel
    {
        public int ExamId { get; set; }

        public int QuestionId { get; set; }

        public int QuestionNumber { get; set; }

        public string Question { get; set; }

        public string CorrectAnswer { get; set; }

        public string WrongAnswer1 { get; set; }

        public string WrongAnswer2 { get; set; }

        public string WrongAnswer3 { get; set; }

        public int IncompleteQuestion { get; set; }
    }
}