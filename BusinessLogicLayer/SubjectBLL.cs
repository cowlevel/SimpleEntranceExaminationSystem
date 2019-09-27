using DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class SubjectBLL
    {
        private bool _isValid;
        private ValueObjectValidator _objectValidator;
        private List<ValidationResult> _validationResults;
        private SubjectDAL _subjectDAL;

        public SubjectBLL()
        {
            _subjectDAL = new SubjectDAL();
        }

        public bool InsertSubject(Subject subject, out List<string> errorList)
        {
            if (subject == null)
            {
                throw new ArgumentNullException(nameof(subject));
            }

            errorList = new List<string>();
            _objectValidator = new ValueObjectValidator();
            _isValid = _objectValidator.TryValidate(subject, out _validationResults);

            if (!_isValid)
            {
                foreach (var error in _validationResults)
                {
                    errorList.Add(error.ErrorMessage);
                }

                return false;
            }

            _subjectDAL.InsertSubject(subject);

            return true;
        }

        public bool UpdateSubject(Subject subject, out List<string> errorList)
        {
            errorList = new List<string>();
            _objectValidator = new ValueObjectValidator();
            _isValid = _objectValidator.TryValidate(subject, out _validationResults);

            if (!_isValid)
            {
                foreach (var error in _validationResults)
                {
                    errorList.Add(error.ErrorMessage);
                }

                return false;
            }

            _subjectDAL.UpdateSubject(subject);

            return true;
        }

        public bool DeleteSubject(int subjectId)
        {
            _subjectDAL.DeleteSubject(subjectId);

            return false;
        }

        public List<Subject> GetSubjectList()
        {
            return _subjectDAL.GetSubjectList();
        }
    }
}
