using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ValueObject;
using ValueObject.ViewModel;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class UCtrlUser : UserControl
    {
        #region PRIVATE VARIABLES
        private int _userCount;
        private int _userId;
        private UserBLL _userBLL;
        private List<UserViewModel> _userViewModelList;
        #endregion

        #region ENUM
        public enum Operation
        {
            Adding = 0,
            Editing = 1,
            Clear = 2
        }
        #endregion

        #region CONSTRUCTOR
        public UCtrlUser()
        {
            InitializeComponent();
            
            _userBLL = new UserBLL();   //  create UserBLL object
            PopulateUserDatagrid(); //  populate user datagridview
        }
        #endregion


        #region CONTROL EVENTS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&ADD NEW")
            {
                _userCount = _userBLL.GetUserCount() + 1;   //  get current number of users
                //_userCount = 1009;    //  testing :p

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
                string username = txtUsername.Text;

                _userCount = _userViewModelList.Where(u => u.Username == username)
                                               .Select(u => u.UserId).Single();

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
            User user;
            int dgvRowIndex;

            if (btnAdd.Text == "&CANCEL")   //  ADD NEW=====
            {
                errorList = new List<string>();

                user = new User(); //  create new User
                user.LastName = txtLastName.Text;
                user.FirstName = txtFirstName.Text;
                user.MiddleName = txtMiddleName.Text;
                user.Username = txtUsername.Text;
                user.UserLevel = cboUserLevel.Text;
                user.Pword = cboUserLevel.Text;
                user.AccountStatus = true;

                bool newUserNoError = _userBLL.InsertUser(user, out errorList);

                if (!newUserNoError)   //  if got error/validation result
                {
                    foreach (string error in errorList)
                    {
                        //Console.WriteLine(error);
                        if (error.Contains("LastName"))
                        {
                            txtLastName.Focus();
                            break;
                        }
                        else if (error.Contains("FirstName"))
                        {
                            txtFirstName.Focus();
                            break;
                        }
                        else if (error.Contains("UserLevel"))
                        {
                            cboUserLevel.Focus();
                            break;
                        }
                    }
                }
                else    //  no error
                {
                    _userViewModelList.Add(new UserViewModel
                    {
                        UserId = user.UserId,
                        LastName = user.LastName,
                        FirstName = user.FirstName,
                        MiddleName = user.MiddleName,
                        Username = user.Username,
                        UserLevel = user.UserLevel,
                        AccountStatus = user.AccountStatus
                    });

                    dgvRowIndex = dgvUser.Rows.Count;

                    SetSelectedDatagridviewRow(dgvRowIndex);
                    SetUIProperty(Operation.Clear);

                    //  message adding user success
                    MessageBox.Show("Successfuly added new user.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (btnEdit.Text == "&CANCEL")  //  EDIT=====
            {
                errorList = new List<string>();

                //  editing so get user from the selected user in the datagridview
                user = _userViewModelList.Where(u => u.UserId == _userId)
                                            .Select(u => new User
                                            {
                                                UserId = u.UserId,  //  assign user id (Primary Key) so it can be tracked by EF
                                                LastName = u.LastName,
                                                FirstName = u.FirstName,
                                                MiddleName = u.MiddleName,
                                                Username = u.Username,
                                                UserLevel = u.UserLevel,
                                                AccountStatus = u.AccountStatus
                                            }).SingleOrDefault();

                user.LastName = txtLastName.Text;
                user.FirstName = txtFirstName.Text;
                user.MiddleName = txtMiddleName.Text;
                user.Username = txtUsername.Text;
                user.UserLevel = cboUserLevel.Text;
                user.Pword = cboUserLevel.Text;
                user.AccountStatus = chkStatus.Checked;

                bool editUserOk = _userBLL.UpdateUser(user, out errorList);

                if (!editUserOk)   //  if got error/validation result
                {
                    foreach (string error in errorList)
                    {
                        //Console.WriteLine(error);
                        if (error.Contains("LastName"))
                        {
                            txtLastName.Focus();
                            break;
                        }
                        else if (error.Contains("FirstName"))
                        {
                            txtFirstName.Focus();
                            break;
                        }
                        else if (error.Contains("UserLevel"))
                        {
                            cboUserLevel.Focus();
                            break;
                        }
                    }
                }
                else    //  no error
                {
                    UserViewModel userViewModel = _userViewModelList.Where(u => u.UserId == _userId).SingleOrDefault();
                    
                    if (userViewModel != null)
                    {
                        userViewModel.LastName = txtLastName.Text;
                        userViewModel.FirstName = txtFirstName.Text;
                        userViewModel.MiddleName = txtMiddleName.Text;
                        userViewModel.Username = txtUsername.Text;
                        userViewModel.UserLevel = cboUserLevel.Text;
                        userViewModel.AccountStatus = chkStatus.Checked;
                    }

                    dgvRowIndex = _userViewModelList.IndexOf(userViewModel);

                    SetSelectedDatagridviewRow(dgvRowIndex);
                    SetUIProperty(Operation.Clear);

                    //  message edit user success
                    MessageBox.Show("Successfuly edited user.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (btnAdd.Text == "&ADD NEW"
                && btnEdit.Text == "&EDIT"
                && index > -1)
            {
                _userId = _userViewModelList[index].UserId; //  important for EDIT, get user id from selected user in datagridview

                txtLastName.Text = _userViewModelList[index].LastName;
                txtFirstName.Text = _userViewModelList[index].FirstName;
                txtMiddleName.Text = _userViewModelList[index].MiddleName;

                txtUsername.Text = _userViewModelList[index].Username;
                cboUserLevel.Text = _userViewModelList[index].UserLevel;
                chkStatus.Checked = _userViewModelList[index].AccountStatus;

                btnEdit.Enabled = true; //  enable EDIT button
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if ((btnAdd.Text == "&CANCEL" && txtLastName.Text.Replace(" ", "").Length != 0)
                || (btnEdit.Text == "&CANCEL" && txtLastName.Text.Replace(" ", "").Length != 0))
            {
                txtUsername.Text = txtLastName.Text.ToLower().Replace(" ", "") + _userCount.ToString("000");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUserByName();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SearchUserByName();
                e.Handled = true;   //  remove sound on enter? haha
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PopulateUserDatagrid();
            lblSearchResult.Text = string.Format("Search result: found {0} user(s)", _userViewModelList.Count);
        }
        #endregion


        #region PRIVATE METHODS
        private void PopulateUserDatagrid()
        {
            _userViewModelList = _userBLL.GetUserListViewModel();
            
            dgvUser.AutoGenerateColumns = false;

            //  check always if list got record, if got zero record then dont use it as data source to avoid some error. NOTE: must have at least 1 record before to use it as data source.
            if (_userViewModelList.Count > 0)
            {
                dgvUser.DataSource = _userViewModelList;
            }
            //MessageBox.Show(_userViewModelList.Count.ToString());
        }

        private void SearchUserByName()
        {
            if (txtSearch.Text.Replace(" ", "").Length != 0)
            {
                string namePart = txtSearch.Text;

                _userViewModelList = _userBLL.GetUserListByNameViewModel(namePart);
                dgvUser.DataSource = _userViewModelList;
                lblSearchResult.Text = string.Format("Search result: found {0} that contains '{1}'", _userViewModelList.Count, namePart);
            }
            else
            {
                lblSearchResult.Text = "Please enter name to search";
            }
        }

        private void SetUIProperty(Operation operation)
        {
            switch(operation)
            {
                case Operation.Adding:
                    lblStatus.Text = "        You are currently adding new user.";

                    btnAdd.Text = "&CANCEL";
                    btnAdd.BackColor = Color.LightCoral;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtLastName.Enabled = true;
                    txtLastName.Text = string.Empty;
                    txtFirstName.Enabled = true;
                    txtFirstName.Text = string.Empty;
                    txtMiddleName.Enabled = true;
                    txtMiddleName.Text = string.Empty;
                    txtUsername.Enabled = true;
                    txtUsername.Text = string.Empty;
                    cboUserLevel.Enabled = true;
                    cboUserLevel.SelectedIndex = -1;
                    chkStatus.Enabled = false;
                    chkStatus.Checked = true;

                    SetSearchingStatus(false);
                    ShowRequiredLabels(true);

                    txtLastName.Focus();

                    break;
                case Operation.Editing:
                    lblStatus.Text = "        You are currently editing user.";

                    btnAdd.Enabled = false;
                    btnEdit.Text = "&CANCEL";
                    btnEdit.BackColor = Color.LightCoral;
                    btnSave.Enabled = true;

                    txtLastName.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtMiddleName.Enabled = true;
                    txtUsername.Enabled = true;
                    cboUserLevel.Enabled = true;
                    chkStatus.Enabled = true;

                    SetSearchingStatus(false);
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

                    btnSave.Enabled = true;

                    txtLastName.Enabled = false;
                    txtLastName.Text = string.Empty;
                    txtFirstName.Enabled = false;
                    txtFirstName.Text = string.Empty;
                    txtMiddleName.Enabled = false;
                    txtMiddleName.Text = string.Empty;
                    txtUsername.Enabled = false;
                    txtUsername.Text = string.Empty;
                    cboUserLevel.Enabled = false;
                    cboUserLevel.SelectedIndex = -1;
                    chkStatus.Enabled = false;
                    chkStatus.Checked = false;

                    SetSearchingStatus(true);
                    ShowRequiredLabels(false);

                    break;
            }
        }

        private void SetSelectedDatagridviewRow(int index)
        {
            dgvUser.DataSource = null;
            dgvUser.DataSource = _userViewModelList;

            dgvUser.FirstDisplayedScrollingRowIndex = index;   //  scroll datagridview to selected index
            dgvUser.Rows[index].Selected = true;   //  set datagridview selected index
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
            lblReqFistName.Visible = show;
            lblReqUserLevel.Visible = show;
        }
        #endregion
    }
}