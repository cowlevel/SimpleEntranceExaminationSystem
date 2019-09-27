using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DatabaseAccessLayer
{
    public class QuestionBankDAL
    {
        private ExaminationContext _context;

        public QuestionBankDAL()
        {

        }

        public List<QuestionBank> GetQuestionBankList(int examId)
        {
            List<QuestionBank> questionBankList;

            using (_context = new ExaminationContext())
            {
                questionBankList = _context.QuestionBank
                    .Where(q => q.ExamId == examId)
                    .ToList();
            }

            return questionBankList;
        }
    }
}
