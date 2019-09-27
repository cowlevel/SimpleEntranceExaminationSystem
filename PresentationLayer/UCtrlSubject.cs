using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class UCtrlSubject : UserControl
    {
        #region PRIVATE VARIABLES
        private int _subjectCount;
        private int _subjectId;
        private SubjectBLL _subjectBLL;
        private List<Subject> _subjectList;
        #endregion

        public UCtrlSubject()
        {
            InitializeComponent();

            dgvSubject.AutoGenerateColumns = false;

            _subjectBLL = new SubjectBLL();
            PopulateSubjectDatagridView();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&ADD NEW")
            {
                SetUIProperty(Operation.Adding);
            }
            else
            {
                SetUIProperty(Operation.Clear);
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
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> errorList; //  list of string to store error message, for validation
            Subject subject;

            if (btnAdd.Text == "&CANCEL")   //  ADD NEW=====
            {
                subject = new Subject(); //  create new Subject
                subject.SubjectName = txtSubject.Text;
                subject.Description = txtDescription.Text;

                errorList = new List<string>();
                bool newUserNoError = _subjectBLL.InsertSubject(subject, out errorList);

                if (!newUserNoError)   //  if got error/validation result
                {
                    foreach (string error in errorList)
                    {
                        //Console.WriteLine(error);
                        if (error.Contains("SubjectName"))
                        {
                            txtSubject.Focus();
                            break;
                        }
                        else if (error.Contains("Description"))
                        {
                            txtDescription.Focus();
                            break;
                        }
                    }
                }
                else    //  no error
                {
                    //_userViewModelList.Add(new SystemUserViewModel
                    //{
                    //    UserId = user.UserId,
                    //    LastName = user.LastName,
                    //    FirstName = user.FirstName,
                    //    MiddleName = user.MiddleName,
                    //    Username = user.Username,
                    //    UserLevel = user.UserLevel,
                    //    AccountStatus = user.AccountStatus
                    //});

                    //dgvUser.DataSource = null;
                    //dgvUser.DataSource = _userViewModelList;

                    PopulateSubjectDatagridView();
                    SetUIProperty(Operation.Clear);

                    //  message adding user success
                    MessageBox.Show("Successfuly added new subject.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (btnEdit.Text == "&CANCEL")  //  EDIT=====
            {
                //  editing so get user from the selected user in the datagridview
                subject = _subjectList.Where(s => s.SubjectId == _subjectId)
                                            .Select(s => new Subject
                                            {
                                                SubjectId = s.SubjectId,  //  assign user id (Primary Key) so it can be tracked by EF
                                                SubjectName = s.SubjectName,
                                                Description = s.Description
                                            }).SingleOrDefault();

                subject.SubjectName = txtSubject.Text;
                subject.Description = txtDescription.Text;

                errorList = new List<string>();
                bool editUserOk = _subjectBLL.UpdateSubject(subject, out errorList);

                if (!editUserOk)   //  if got error/validation result
                {
                    foreach (string error in errorList)
                    {
                        //Console.WriteLine(error);
                        if (error.Contains("SubjectName"))
                        {
                            txtSubject.Focus();
                            break;
                        }
                        else if (error.Contains("Description"))
                        {
                            txtDescription.Focus();
                            break;
                        }
                    }
                }
                else    //  no error
                {
                    //subject = _subjectList.Where(s => s.SubjectId == _subjectId).SingleOrDefault();

                    //if (subject != null)
                    //{
                    //    subject.SubjectName = txtSubject.Text;
                    //    subject.Description = txtDescription.Text;
                    //}

                    //  RefreshDataSource();

                    PopulateSubjectDatagridView();
                    SetUIProperty(Operation.Clear);

                    //  message edit user success
                    MessageBox.Show("Successfuly edited subject.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this subject?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _subjectBLL.DeleteSubject(_subjectId);

                //RefreshDataSource();
                PopulateSubjectDatagridView();
                SetUIProperty(Operation.Clear);
            }
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (btnAdd.Text == "&ADD NEW"
                && btnEdit.Text == "&EDIT"
                && index > -1)
            {
                _subjectId = _subjectList[index].SubjectId; //  important for EDIT, get user id from selected user in datagridview

                txtSubject.Text = _subjectList[index].SubjectName;
                txtDescription.Text = _subjectList[index].Description;

                btnEdit.Enabled = true; //  enable EDIT button
                btnDelete.Enabled = true;   //  enable DELETE button
            }
        }

        private void PopulateSubjectDatagridView()
        {
            _subjectList = _subjectBLL.GetSubjectList();

            //  check always if list got record, if got zero record then dont use it as data source to avoid some error. NOTE: must have at least 1 record before to use it as data source.
            if (_subjectList.Count > 0)
            {
                dgvSubject.DataSource = _subjectList;
            }
            else
            {
                dgvSubject.DataSource = null;
            }
            //MessageBox.Show(_userViewModelList.Count.ToString());
        }

        private void RefreshDataSource()
        {
            dgvSubject.DataSource = null;
            dgvSubject.DataSource = _subjectList;
        }

        private void SetUIProperty(Operation operation)
        {
            switch (operation)
            {
                case Operation.Adding:
                    lblStatus.Text = "        You are currently adding new subject.";

                    btnAdd.Text = "&CANCEL";
                    btnAdd.BackColor = Color.LightCoral;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;

                    txtSubject.Enabled = true;
                    txtSubject.Text = string.Empty;
                    txtDescription.Enabled = true;
                    txtDescription.Text = string.Empty;

                    ShowRequiredLabels(true);

                    txtSubject.Focus();
                    break;
                case Operation.Editing:
                    lblStatus.Text = "        You are currently editing subject.";

                    btnAdd.Enabled = false;
                    btnEdit.Text = "&CANCEL";
                    btnEdit.BackColor = Color.LightCoral;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;

                    txtSubject.Enabled = true;
                    txtDescription.Enabled = true;

                    ShowRequiredLabels(true);
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

                    txtSubject.Enabled = false;
                    txtSubject.Text = string.Empty;
                    txtDescription.Enabled = false;
                    txtDescription.Text = string.Empty;

                    ShowRequiredLabels(false);
                    break;
            }
        }

        private void ShowRequiredLabels(bool show)
        {
            lblReqSubject.Visible = show;
            lblReqDescription.Visible = show;
        }
    }
}