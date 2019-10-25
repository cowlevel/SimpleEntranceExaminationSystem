using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ValueObject;
using ValueObject.ViewModel;
using DatabaseAccessLayer;
using Utility;
using ValueObject.Report;

namespace BusinessLogicLayer
{
    public class ExamineeBLL
    {
        private bool _isValid;
        private ValueObjectValidator _objectValidator;
        private List<ValidationResult> _validationResults;
        private ExamineeDAL _examineeDAL;


        public ExamineeBLL()
        {
            _examineeDAL = new ExamineeDAL();
        }

        public bool InsertExaminee(Examinee examinee, out List<string> errorList)
        {
            errorList = new List<string>();
            _objectValidator = new ValueObjectValidator();
            _isValid = _objectValidator.TryValidate(examinee, out _validationResults);

            if (!_isValid)
            {
                foreach (var error in _validationResults)
                {
                    errorList.Add(error.ErrorMessage);
                }

                return false;
            }

            _examineeDAL.InsertExaminee(examinee);

            return true;
        }

        public void InsertExaminee(Examinee examinee)
        {
            _examineeDAL.InsertExaminee(examinee);
        }

        public bool UpdateExaminee(Examinee examinee, out List<string> errorList)
        {
            errorList = new List<string>();
            _objectValidator = new ValueObjectValidator();
            _isValid = _objectValidator.TryValidate(examinee, out _validationResults);

            if (!_isValid)
            {
                foreach (var error in _validationResults)
                {
                    errorList.Add(error.ErrorMessage);
                }

                return false;
            }
            //Console.WriteLine("BLL " + examinee.DateTimeAdded.ToString());
            _examineeDAL.UpdateExaminee(examinee);

            return true;
        }

        public void UpdateExaminee(Examinee examinee)
        {
            _examineeDAL.UpdateExaminee(examinee);
        }

        public void DeleteExaminee(int examineeId)
        {
            _examineeDAL.DeleteExaminee(examineeId);
        }

        public void IncreaseExamineeExamTaken(int examineeId)
        {
            _examineeDAL.IncreaseExamineeExamTaken(examineeId);
        }

        public int GetExamineeCount()
        {
            return _examineeDAL.GetExamineeCount();
        }

        public DateTime GetServerDateTime()
        {
            return _examineeDAL.GetServerDateTime();
        }

        public PagedResult<ExamineeViewModel> GetExamineeListViewModel(int pageNumber, int pageSize)
        {
            return _examineeDAL.GetExamineeListViewModel(pageNumber, pageSize);
        }

        public PagedResult<ExamineeViewModel> GetExamineeListByNameOrEmailViewModel(int pageNumber, int pageSize, string nameOrEmail)
        {
            return _examineeDAL.GetExamineeListByNameOrEmailViewModel(pageNumber, pageSize, nameOrEmail);
        }

        public List<ExamineeReport> GetExamineeList(DateTime startDate, DateTime? endDate = null)
        {
            return _examineeDAL.GetExamineeList(startDate, endDate);
        }
    }
}