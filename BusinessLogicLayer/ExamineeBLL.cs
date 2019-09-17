using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ValueObject;

namespace BusinessLogicLayer
{
    class ExamineeBLL
    {
        public ExamineeBLL()
        {

        }

        private Examinee _examinee;

        public Examinee Examinee
        {
            get { return _examinee; }
            set { _examinee = value; }
        }

        public Examinee GetExamineeX()
        {
            _examinee = new Examinee();
            _examinee.ExamineeId = 1;
            _examinee.LastName = "Canon";
            _examinee.FirstName = "Zergjill";
            _examinee.Birthdate = new DateTime(1989, 9, 1);
            _examinee.LastSchoolAttended = "STI";

            return _examinee;
        }


        public void InsertExaminee()
        {

        }

        public void UpdateExaminee()
        {

        }

        public void DeleteExaminee()
        {

        }

        public void GetExaminee()
        {

        }
    }
}