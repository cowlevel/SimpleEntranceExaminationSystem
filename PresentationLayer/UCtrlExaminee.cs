﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using ValueObject;
using ValueObject.ViewModel;
using Utility;

namespace PresentationLayer
{
    public partial class UCtrlExaminee : UserControl
    {
        #region PRIVATE VARIABLES
        public const int PAGE_SIZE = 10;    //  for paging
        public const int MINIMUM_PAGE_NUMBER = 1;   //  for paging

        private int _pageNumber = 1;    //  for paging
        private int _examineeId;
        private string _nameOrEmailPart;
        private bool _isFromSearch;

        private ExamineeBLL _examineeBLL;
        private PagedResult<ExamineeViewModel> _examineeViewModelList;  //  for paging
        #endregion

        public UCtrlExaminee()
        {
            InitializeComponent();

            numYearGraduated.Maximum = DateTime.Now.Year + 1;
            numYearGraduated.Value = numYearGraduated.Maximum - 1;
            dgvExaminee.AutoGenerateColumns = false;

            _examineeBLL = new ExamineeBLL();
            PopulateExamineeDatagridView();

            if (_examineeViewModelList.PageCount > MINIMUM_PAGE_NUMBER)
            {
                btnNext.Enabled = true;
            }
        }

        private void UCtrlExaminee_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&ADD NEW")
            {
                SetUIProperty(Operation.Adding);

                //Console.WriteLine(_pageNumber+" "+ MINIMUM_PAGE_NUMBER);
                //if (_pageNumber > MINIMUM_PAGE_NUMBER)
                //{
                //    btnPrevious.Enabled = true;
                //}
                //else
                //{
                //    btnPrevious.Enabled = false;
                //}

                
            }
            else
            {
                SetUIProperty(Operation.Clear);
                //Console.WriteLine(_pageNumber + " " + MINIMUM_PAGE_NUMBER);
                //if (_pageNumber > MINIMUM_PAGE_NUMBER)
                //{
                //    btnPrevious.Enabled = true;
                //}
                //else
                //{
                //    btnPrevious.Enabled = false;
                //}

                //if (_pageNumber < _examineeViewModelList.PageCount)
                //{
                //    btnNext.Enabled = true;
                //}
                //else
                //{
                //    btnNext.Enabled = false;
                //}
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "&EDIT")
            {
                SetUIProperty(Operation.Editing);
            }
            else
            {
                SetUIProperty(Operation.Clear);

                //Console.WriteLine(_pageNumber + " " + MINIMUM_PAGE_NUMBER);
                //if (_pageNumber > MINIMUM_PAGE_NUMBER)
                //{
                //    btnPrevious.Enabled = true;
                //}
                //else
                //{
                //    btnPrevious.Enabled = false;
                //}

                //if (_pageNumber < _examineeViewModelList.PageCount)
                //{
                //    btnNext.Enabled = true;
                //}
                //else
                //{
                //    btnNext.Enabled = false;
                //}
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> errorList;//  list of string to store error message, for validation
            Examinee examinee;

            if (btnAdd.Text == "&CANCEL")   //  ADD NEW=====
            {
                examinee = new Examinee(); //  create new Examinee
                examinee.LastName = txtLastName.Text;
                examinee.FirstName = txtFirstName.Text;
                examinee.MiddleName = txtMiddleName.Text;
                examinee.Address = txtAddress.Text;
                examinee.City = txtCity.Text;
                examinee.ContactNo = txtContactNo.Text;
                examinee.Email = txtEmail.Text;
                examinee.LastSchoolAttended = txtSchoolName.Text;
                examinee.YearGraduated = (int)numYearGraduated.Value;
                examinee.ExamTakes = 0;
                //examinee.DateTimeAdded = DateTime.Now;    //  to BLL

                errorList = new List<string>();
                bool newExamineeNoError = _examineeBLL.InsertExaminee(examinee, out errorList);

                if (!newExamineeNoError)   //  if got error/validation result
                {
                    foreach (string error in errorList)
                    {
                        if (error.Contains("LastName"))
                        {
                            SetControlFocus(0, txtLastName);
                            break;
                        }
                        else if (error.Contains("FirstName"))
                        {
                            SetControlFocus(0, txtFirstName);
                            break;
                        }

                        else if (error.Contains("Address"))
                        {
                            SetControlFocus(1, txtAddress);
                            break;
                        }
                        else if (error.Contains("City"))
                        {
                            SetControlFocus(1, txtCity);
                            break;
                        }
                        else if (error.Contains("ContactNo"))
                        {
                            SetControlFocus(1, txtContactNo);
                            break;
                        }
                        else if (error.Contains("Email"))
                        {
                            SetControlFocus(1, txtEmail);
                            break;
                        }

                        else if (error.Contains("LastSchoolAttended"))
                        {
                            SetControlFocus(2, txtSchoolName);
                            break;
                        }
                        else if (error.Contains("YearGraduated"))
                        {
                            SetControlFocus(2, numYearGraduated);
                            break;
                        }
                    }
                }
                else    //  no error
                {
                    //if (dgvExaminee.Rows.Count < PAGE_SIZE)
                    //{
                    //    _examineeViewModelList.Results.Add(new ExamineeViewModel
                    //    {
                    //        ExamineeId = examinee.ExamineeId,
                    //        LastName = examinee.LastName,
                    //        FirstName = examinee.FirstName,
                    //        MiddleName = examinee.MiddleName,
                    //        Address = examinee.Address,
                    //        City = examinee.City,
                    //        ContactNo = examinee.ContactNo,
                    //        Email = examinee.Email,
                    //        LastSchoolAttended = examinee.LastSchoolAttended,
                    //        YearGraduated = examinee.YearGraduated,
                    //        ExamTakes = examinee.ExamTakes,
                    //        DateTimeAdded = examinee.DateTimeAdded
                    //    });

                    //    //SetSelectedDatagridviewRow(dgvRowIndex);
                    //}
                    //else
                    //{
                    //    PopulateExamineeDatagrid();     //  repopulate datagridview
                    //}

                    //  repopulate datagridview
                    if (_isFromSearch)
                    {
                        SearchExamineeByNameOrEmail(_nameOrEmailPart);
                    }
                    else
                    {
                        PopulateExamineeDatagridView();
                    }
                    
                    SetUIProperty(Operation.Clear);

                    //  message adding user success
                    MessageBox.Show("Successfuly added new examinee.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (btnEdit.Text == "&CANCEL")  //  EDIT=====
            {
                //  editing so get user from the selected user in the datagridview
                examinee = _examineeViewModelList.Results.Where(ex => ex.ExamineeId == _examineeId)
                                            .Select(ex => new Examinee
                                            {
                                                ExamineeId = ex.ExamineeId,  //  assign user id (Primary Key) so it can be tracked by EF
                                                LastName = ex.LastName,
                                                FirstName = ex.FirstName,
                                                MiddleName = ex.MiddleName,
                                                Address = ex.Address,
                                                City = ex.City,
                                                ContactNo = ex.ContactNo,
                                                Email = ex.Email,
                                                LastSchoolAttended = ex.LastSchoolAttended,
                                                YearGraduated = ex.YearGraduated,
                                                ExamTakes = ex.ExamTakes
                                            }).SingleOrDefault();

                examinee.LastName = txtLastName.Text;
                examinee.FirstName = txtFirstName.Text;
                examinee.MiddleName = txtMiddleName.Text;
                examinee.Address = txtAddress.Text;
                examinee.City = txtCity.Text;
                examinee.ContactNo = txtContactNo.Text;
                examinee.Email = txtEmail.Text;
                examinee.LastSchoolAttended = txtSchoolName.Text;
                examinee.YearGraduated = (int)numYearGraduated.Value;
                //examinee.ExamTakes = 0;
                //examinee.DateTimeAdded = DateTime.Now;    //  to BLL

                errorList = new List<string>();
                bool editExamineeOk = _examineeBLL.UpdateExaminee(examinee, out errorList);

                if (!editExamineeOk)   //  if got error/validation result
                {
                    foreach (string error in errorList)
                    {
                        //Console.WriteLine(error);
                        if (error.Contains("LastName"))
                        {
                            SetControlFocus(0, txtLastName);
                            break;
                        }
                        else if (error.Contains("FirstName"))
                        {
                            SetControlFocus(0, txtFirstName);
                            break;
                        }

                        else if (error.Contains("Address"))
                        {
                            SetControlFocus(1, txtAddress);
                            break;
                        }
                        else if (error.Contains("City"))
                        {
                            SetControlFocus(1, txtCity);
                            break;
                        }
                        else if (error.Contains("ContactNo"))
                        {
                            SetControlFocus(1, txtContactNo);
                            break;
                        }
                        else if (error.Contains("Email"))
                        {
                            SetControlFocus(1, txtEmail);
                            break;
                        }

                        else if (error.Contains("LastSchoolAttended"))
                        {
                            SetControlFocus(2, txtSchoolName);
                            break;
                        }
                        else if (error.Contains("YearGraduated"))
                        {
                            SetControlFocus(2, numYearGraduated);
                            break;
                        }
                    }
                }
                else    //  no error
                {
                    ExamineeViewModel examineeViewModel = _examineeViewModelList.Results.Where(ex => ex.ExamineeId == _examineeId).SingleOrDefault();

                    if (examineeViewModel != null)
                    {
                        examineeViewModel.LastName = txtLastName.Text;
                        examineeViewModel.FirstName = txtFirstName.Text;
                        examineeViewModel.MiddleName = txtMiddleName.Text;
                        examineeViewModel.Address = txtAddress.Text;
                        examineeViewModel.City = txtCity.Text;
                        examineeViewModel.ContactNo = txtContactNo.Text;
                        examineeViewModel.Email = txtEmail.Text;
                        examineeViewModel.LastSchoolAttended = txtSchoolName.Text;
                        examineeViewModel.YearGraduated = (int)numYearGraduated.Value;
                    }

                   // Console.WriteLine(examineeViewModel.DateTimeAdded.ToString());

                    RefreshDataSource();
                    SetUIProperty(Operation.Clear);

                    //  message edit user success
                    MessageBox.Show("Successfuly edited user.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this examinee?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _examineeBLL.DeleteExaminee(_examineeId);

                int rows = dgvExaminee.Rows.Count;

                if (rows == 1 && _examineeViewModelList.PageCount != 1)
                {
                    _pageNumber -= 1;
                    Console.WriteLine("more page count");

                    if (_isFromSearch)
                    {
                        SearchExamineeByNameOrEmail(_nameOrEmailPart);
                    }
                    else
                    {
                        PopulateExamineeDatagridView();
                    }
                }
                else if (rows == 1 && _examineeViewModelList.PageCount <= 1)
                {
                    _isFromSearch = false;
                    _pageNumber = 1;
                    Console.WriteLine("reset");

                    if (_isFromSearch)
                    {
                        SearchExamineeByNameOrEmail(_nameOrEmailPart);
                    }
                    else
                    {
                        PopulateExamineeDatagridView();
                    }
                }
                else
                {
                    Console.WriteLine("last line");
                    if (_isFromSearch)
                    {
                        SearchExamineeByNameOrEmail(_nameOrEmailPart);
                    }
                    else
                    {
                        PopulateExamineeDatagridView();
                    }
                }

                //PopulateExamineeDatagridView();
                SetUIProperty(Operation.Clear);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _pageNumber -= 1;

            if (_pageNumber >= MINIMUM_PAGE_NUMBER)
            {
                if (_isFromSearch)
                {
                    Console.WriteLine("SEARCH PREV");
                    SearchExamineeByNameOrEmail(_nameOrEmailPart);
                }
                else
                {
                    PopulateExamineeDatagridView();
                }

                //SetUIProperty(Operation.Clear);
                ClearExamineeUI();
                SetNavButtonEnabled();


                //btnNext.Enabled = true;

                //if (_pageNumber == MINIMUM_PAGE_NUMBER)  
                //{
                //    btnPrevious.Enabled = false;
                //}
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _pageNumber += 1;

            if (_pageNumber <= _examineeViewModelList.PageCount)
            {
                if (_isFromSearch)
                {
                    Console.WriteLine("SEARCH NEXT");
                    SearchExamineeByNameOrEmail(_nameOrEmailPart);
                }
                else
                {
                    PopulateExamineeDatagridView();
                }

                //SetUIProperty(Operation.Clear);
                ClearExamineeUI();
                SetNavButtonEnabled();


                //btnPrevious.Enabled = true;

                //if (_pageNumber == _examineeViewModelList.PageCount)
                //{
                //    btnNext.Enabled = false;
                //}
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Replace(" ", "").Length != 0)
            {
                _isFromSearch = true;   //  from searching
                _pageNumber = 1;    //  reset page number to 1
                _nameOrEmailPart = txtSearch.Text;  //  get entered name/email part

                SearchExamineeByNameOrEmail(_nameOrEmailPart);

                lblSearchResult.Text = string.Format("Search result: found {0} that contains '{1}'", _examineeViewModelList.RowCount, _nameOrEmailPart);
                btnPrevious.Enabled = false;

                ClearExamineeUI();
                //SetUIProperty(Operation.Clear);
            }
            else
            {
                lblSearchResult.Text = "Please enter name to search";
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;

            _isFromSearch = false;  //  set _isFromSearch to false
            _pageNumber = 1;    //  reset page number to 1

            PopulateExamineeDatagridView();
            SetNavButtonEnabled();

            lblSearchResult.Text = string.Format("Search result: found {0}", _examineeViewModelList.RowCount);
        }

        #region PRIVATE METHODS
        private void SearchExamineeByNameOrEmail(string nameOrEmailPart)
        {
            _examineeViewModelList = _examineeBLL.GetExamineeListByNameOrEmailViewModel(_pageNumber, PAGE_SIZE, nameOrEmailPart);

            SetDataSourceAndPageText();

            SetNavButtonEnabled();

            //if (_pageNumber < _examineeViewModelList.PageCount)
            //{
            //    btnPrevious.Enabled = true;
            //}
            //else
            //{
            //    btnPrevious.Enabled = false;
            //}
            ////btnPrevious.Enabled = _pageNumber < _examineeViewModelList.PageCount;

            //if (_examineeViewModelList.PageCount > MINIMUM_PAGE_NUMBER)
            //{
            //    btnNext.Enabled = true;
            //}
            //else
            //{
            //    btnNext.Enabled = false;
            //}
            ////btnNext.Enabled = _examineeViewModelList.PageCount > MINIMUM_PAGE_NUMBER;
        }

        private void PopulateExamineeDatagridView()
        {
            _examineeViewModelList = _examineeBLL.GetExamineeListViewModel(_pageNumber, PAGE_SIZE);

            SetDataSourceAndPageText();
        }

        private void SetDataSourceAndPageText()
        {
            //  check always if list got record, if got zero record then dont use it as data source to avoid some error. NOTE: must have at least 1 record before to use it as data source.
            if (_examineeViewModelList.Results.Count > 0)
            {
                dgvExaminee.DataSource = _examineeViewModelList.Results;
                lblPage.Text = string.Format("Page {0} of {1}", _pageNumber, _examineeViewModelList.PageCount);
            }
            else
            {
                dgvExaminee.DataSource = null;
                lblPage.Text = string.Format("Page {0} of {1}", 0, 0);
            }
        }

        private void ClearExamineeUI()
        {
            txtLastName.Enabled = false;
            txtLastName.Text = string.Empty;
            txtFirstName.Enabled = false;
            txtFirstName.Text = string.Empty;
            txtMiddleName.Enabled = false;
            txtMiddleName.Text = string.Empty;

            txtAddress.Enabled = false;
            txtAddress.Text = string.Empty;
            txtCity.Enabled = false;
            txtCity.Text = string.Empty;

            txtContactNo.Enabled = false;
            txtContactNo.Text = string.Empty;
            txtEmail.Enabled = false;
            txtEmail.Text = string.Empty;

            txtSchoolName.Enabled = false;
            txtSchoolName.Text = string.Empty;
            numYearGraduated.Enabled = false;
            numYearGraduated.Value = numYearGraduated.Maximum - 1;

            lblExamTakes.Text = "Exam taken:";
            lblDateTimeAdded.Text = "Date and time added:";

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void SetUIProperty(Operation operation)
        {
            switch (operation)
            {
                case Operation.Adding:
                    lblStatus.Text = "        You are currently adding new examinee.";

                    btnAdd.Text = "&CANCEL";
                    btnAdd.BackColor = Color.LightCoral;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;

                    txtLastName.Enabled = true;
                    txtLastName.Text = string.Empty;
                    txtFirstName.Enabled = true;
                    txtFirstName.Text = string.Empty;
                    txtMiddleName.Enabled = true;
                    txtMiddleName.Text = string.Empty;

                    txtAddress.Enabled = true;
                    txtAddress.Text = string.Empty;
                    txtCity.Enabled = true;
                    txtCity.Text = string.Empty;

                    txtContactNo.Enabled = true;
                    txtContactNo.Text = string.Empty;
                    txtEmail.Enabled = true;
                    txtEmail.Text = string.Empty;

                    txtSchoolName.Enabled = true;
                    txtSchoolName.Text = string.Empty;
                    numYearGraduated.Enabled = true;
                    numYearGraduated.Value = DateTime.Now.Year;

                    lblExamTakes.Text = string.Empty;
                    lblDateTimeAdded.Text = string.Empty;

                    tabExaminee.SelectTab(0);   //  set selected tab
                    txtLastName.Focus();

                    ShowRequiredLabels(true);
                    SetSearchingStatus(false);

                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    
                    break;
                case Operation.Editing:
                    lblStatus.Text = "        You are currently editing examinee.";

                    btnAdd.Enabled = false;
                    btnEdit.Text = "&CANCEL";
                    btnEdit.BackColor = Color.LightCoral;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;

                    txtLastName.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtMiddleName.Enabled = true;

                    txtAddress.Enabled = true;
                    txtCity.Enabled = true;

                    txtContactNo.Enabled = true;
                    txtEmail.Enabled = true;

                    txtSchoolName.Enabled = true;
                    numYearGraduated.Enabled = true;
                    
                    ShowRequiredLabels(true);
                    SetSearchingStatus(false);

                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;

                    break;
                case Operation.Clear:
                    lblStatus.Text = string.Empty;

                    btnAdd.Text = "&ADD NEW";
                    btnAdd.BackColor = Color.FromArgb(67, 166, 235);
                    btnAdd.Enabled = true;
                    btnEdit.Text = "&EDIT";
                    btnEdit.BackColor = Color.LightGray;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;

                    txtLastName.Enabled = false;
                    txtLastName.Text = string.Empty;
                    txtFirstName.Enabled = false;
                    txtFirstName.Text = string.Empty;
                    txtMiddleName.Enabled = false;
                    txtMiddleName.Text = string.Empty;

                    txtAddress.Enabled = false;
                    txtAddress.Text = string.Empty;
                    txtCity.Enabled = false;
                    txtCity.Text = string.Empty;

                    txtContactNo.Enabled = false;
                    txtContactNo.Text = string.Empty;
                    txtEmail.Enabled = false;
                    txtEmail.Text = string.Empty;

                    txtSchoolName.Enabled = false;
                    txtSchoolName.Text = string.Empty;
                    numYearGraduated.Enabled = false;
                    numYearGraduated.Value = numYearGraduated.Maximum - 1;

                    lblExamTakes.Text = "Exam taken:";
                    lblDateTimeAdded.Text = "Date and time added:";

                    tabExaminee.SelectTab(0);   //  set selected tab

                    ShowRequiredLabels(false);
                    SetSearchingStatus(true);
                    SetNavButtonEnabled();

                    break;
            }
        }

        private void SetNavButtonEnabled()
        {
            //if (_pageNumber > MINIMUM_PAGE_NUMBER)
            //{
            //    btnPrevious.Enabled = true;
            //}
            //else
            //{
            //    btnPrevious.Enabled = false;
            //}
            btnPrevious.Enabled = _pageNumber > MINIMUM_PAGE_NUMBER ? true : false;

            //if (_pageNumber < _examineeViewModelList.PageCount)
            //{
            //    btnNext.Enabled = true;
            //}
            //else
            //{
            //    btnNext.Enabled = false;
            //}
            btnNext.Enabled = _pageNumber < _examineeViewModelList.PageCount ? true : false;
        }

        private void SetControlFocus(int tabIndex, Control control)
        {
            tabExaminee.SelectTab(tabIndex);
            control.Focus();
        }
        
        private void RefreshDataSource()
        {
            dgvExaminee.DataSource = null;
            dgvExaminee.DataSource = _examineeViewModelList.Results;
        }
        
        private void SetSearchingStatus(bool isEnabled)
        {
            txtSearch.Enabled = isEnabled;
            btnSearch.Enabled = isEnabled;
            btnShowAll.Enabled = isEnabled;
        }

        private void ShowRequiredLabels(bool show)
        {
            lblReqLastName.Visible = show;
            lblReqFirstName.Visible = show;

            lblReqAddress.Visible = show;
            lblReqCity.Visible = show;
            lblReqContactNo.Visible = show;
            lblReqEmail.Visible = show;

            lblReqSchoolName.Visible = show;
            lblReqYearGraduated.Visible = show;
        }
        #endregion

        private void dgvExaminee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (btnAdd.Text == "&ADD NEW"
                && btnEdit.Text == "&EDIT"
                && index > -1)
            {
                _examineeId = _examineeViewModelList.Results[index].ExamineeId; //  important for EDIT, get user id from selected user in datagridview

                txtLastName.Text = _examineeViewModelList.Results[index].LastName;
                txtFirstName.Text = _examineeViewModelList.Results[index].FirstName;
                txtMiddleName.Text = _examineeViewModelList.Results[index].MiddleName;

                txtAddress.Text = _examineeViewModelList.Results[index].Address;
                txtCity.Text = _examineeViewModelList.Results[index].City;
                txtContactNo.Text = _examineeViewModelList.Results[index].ContactNo;
                txtEmail.Text = _examineeViewModelList.Results[index].Email;

                txtSchoolName.Text = _examineeViewModelList.Results[index].LastSchoolAttended;
                numYearGraduated.Value = _examineeViewModelList.Results[index].YearGraduated;

                lblExamTakes.Text = string.Format("Exam takes: {0} time(s)", _examineeViewModelList.Results[index].ExamTakes);
                lblDateTimeAdded.Text = string.Format("Date and time added:\n{0}", _examineeViewModelList.Results[index].DateTimeAdded);

                btnEdit.Enabled = true; //  enable EDIT button

                //if (_examineeViewModelList.Results[index].ExamTakes == 0)
                //{
                //    btnDelete.Enabled = true;
                //}
                //else
                //{
                //    btnDelete.Enabled = false;
                //}

                btnDelete.Enabled = _examineeViewModelList.Results[index].ExamTakes == 0 ? true : false;
            }
        }
    }
}