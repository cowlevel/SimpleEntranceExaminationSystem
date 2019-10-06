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
        private SystemUserBLL _userBLL;
        private List<SystemUserViewModel> _userViewModelList;
        #endregion


        #region CONSTRUCTOR
        public UCtrlUser()
        {
            InitializeComponent();

            _userBLL = new SystemUserBLL();   //  create UserBLL object
            dgvUser.AutoGenerateColumns = false;    //  set to false because I'm using view model with more columns that are not needed
            PopulateUserDatagridView(); //  populate user datagridview
        }
        #endregion


        #region CONTROL EVENTS
        private void UCtrlUser_Load(object sender, EventArgs e)
        {
            dgvUser.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&ADD NEW")
            {
                _userCount = _userBLL.GetUserCount() + 1;   //  get current number of users plus 1 for new user and for its username

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
                string username = lblUsernameOutput.Text;

                _userId = _userViewModelList.Where(u => u.Username == username)
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
            SystemUser user;

            if (btnAdd.Text == "&CANCEL")   //  ADD NEW
            {
                if (InputsAreValid())
                {
                    user = new SystemUser(); //  create new User
                    user.LastName = txtLastName.Text;
                    user.FirstName = txtFirstName.Text;
                    user.MiddleName = txtMiddleName.Text;
                    user.Username = lblUsernameOutput.Text;
                    user.UserLevel = cboUserLevel.Text;
                    user.Pword = lblUsernameOutput.Text;
                    user.AccountStatus = true;

                    _userBLL.InsertUser(user);

                    PopulateUserDatagridView();
                    dgvUser.ClearSelection();
                    SetUIProperty(Operation.Clear);

                    lblStatus.Text = "  Successfully added new user";
                }
            }

            if (btnEdit.Text == "&CANCEL")  //  EDIT
            {
                if (InputsAreValid())
                {
                    //  editing so get user from the selected user in the datagridview
                    user = _userViewModelList.Where(u => u.UserId == _userId)
                                                .Select(u => new SystemUser
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
                    user.Username = lblUsernameOutput.Text;
                    user.UserLevel = cboUserLevel.Text;
                    user.AccountStatus = chkStatus.Checked;

                    _userBLL.UpdateUser(user);
                    //  update selected user in the list
                    SystemUserViewModel userViewModel = _userViewModelList.Where(u => u.UserId == _userId).SingleOrDefault();
                    userViewModel.LastName = txtLastName.Text;
                    userViewModel.FirstName = txtFirstName.Text;
                    userViewModel.MiddleName = txtMiddleName.Text;
                    userViewModel.Username = lblUsernameOutput.Text;
                    userViewModel.UserLevel = cboUserLevel.Text;
                    userViewModel.AccountStatus = chkStatus.Checked;

                    RefreshDataSource();
                    SetUIProperty(Operation.Clear);

                    lblStatus.Text = "  Successfully updated user";
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

                lblUsernameOutput.Text = _userViewModelList[index].Username;
                cboUserLevel.Text = _userViewModelList[index].UserLevel;
                chkStatus.Checked = _userViewModelList[index].AccountStatus;

                btnEdit.Enabled = true; //  enable EDIT button
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if ((btnAdd.Text == "&CANCEL" && txtLastName.Text.Replace(" ", "").Length != 0) 
                || (btnEdit.Text == "&CANCEL" && txtLastName.Text.Replace(" ", "").Length != 0))    //  ADD NEW
            {
                lblUsernameOutput.Text = txtLastName.Text.ToLower().Replace(" ", "") + _userCount.ToString("000");
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
            PopulateUserDatagridView();
            dgvUser.ClearSelection();
            lblSearchResult.Text = string.Format("Search result: found {0}", _userViewModelList.Count);
        }
        #endregion


        #region PRIVATE METHODS
        private void PopulateUserDatagridView()
        {
            _userViewModelList = _userBLL.GetUserListViewModel();
            dgvUser.DataSource = null;
            //  check always if list got record, if got zero record then dont use it as data source to avoid some error. NOTE: must have at least 1 record before to use it as data source.
            if (_userViewModelList.Count > 0)
            {
                dgvUser.DataSource = _userViewModelList;
            }
        }

        private void SearchUserByName()
        {
            if (txtSearch.Text.Replace(" ", "").Length != 0)
            {
                string namePart = txtSearch.Text;

                _userViewModelList = _userBLL.GetUserListByNameViewModel(namePart);
                dgvUser.DataSource = null;

                if (_userViewModelList.Count > 0)
                {
                    dgvUser.DataSource = _userViewModelList;
                }

                lblSearchResult.Text = string.Format("Search result: found {0} that contains '{1}'", _userViewModelList.Count, namePart);

                dgvUser.ClearSelection();
                SetUIProperty(Operation.Clear);
            }
            else
            {
                lblSearchResult.Text = "Please enter name to search";
            }
        }

        private bool InputsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lblStatus.Text = "  Please enter last name";
                txtLastName.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                lblStatus.Text = "  Please enter first name";
                txtFirstName.Focus();
                return false;
            }
            else if (cboUserLevel.SelectedIndex == -1)
            {
                lblStatus.Text = "  Please choose user level";
                cboUserLevel.Focus();
                return false;
            }
            else if (UserInfo.UserId == _userId
                    && UserInfo.UserLevel == "Administrator")
                    //&& string.Equals(cboUserLevel.Text, "Administrator", StringComparison.CurrentCultureIgnoreCase))
                    //&& chkStatus.Checked == true)
            {
                if (!string.Equals(cboUserLevel.Text, "Administrator", StringComparison.CurrentCultureIgnoreCase))
                {
                    lblStatus.Text = "  You cannot change your user level from being an administrator to clerk";
                    return false;
                }
                else
                {
                    if (chkStatus.Checked == false)
                    {
                        lblStatus.Text = "  You cannot deactivate your account";
                        return false;
                    }
                }
            }

            return true;
        }

        private void SetUIProperty(Operation operation)
        {
            switch(operation)
            {
                case Operation.Adding:
                    lblStatus.Text = "  You are currently adding new user";

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
                    lblUsernameOutput.Enabled = true;
                    lblUsernameOutput.Text = string.Empty;
                    cboUserLevel.Enabled = true;
                    cboUserLevel.SelectedIndex = -1;
                    chkStatus.Enabled = false;
                    chkStatus.Checked = true;

                    SetSearchingStatus(false);
                    ShowRequiredLabels(true);

                    txtLastName.Focus();

                    break;
                case Operation.Editing:
                    lblStatus.Text = "  You are currently editing user";

                    btnAdd.Enabled = false;
                    btnEdit.Text = "&CANCEL";
                    btnEdit.BackColor = Color.LightCoral;
                    btnSave.Enabled = true;

                    txtLastName.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtMiddleName.Enabled = true;
                    lblUsernameOutput.Enabled = true;
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
                    btnSave.Enabled = false;

                    txtLastName.Enabled = false;
                    txtLastName.Text = string.Empty;
                    txtFirstName.Enabled = false;
                    txtFirstName.Text = string.Empty;
                    txtMiddleName.Enabled = false;
                    txtMiddleName.Text = string.Empty;
                    lblUsernameOutput.Enabled = false;
                    lblUsernameOutput.Text = string.Empty;
                    cboUserLevel.Enabled = false;
                    cboUserLevel.SelectedIndex = -1;
                    chkStatus.Enabled = false;
                    chkStatus.Checked = false;

                    SetSearchingStatus(true);
                    ShowRequiredLabels(false);

                    break;
            }
        }

        private void RefreshDataSource()
        {
            dgvUser.DataSource = null;
            dgvUser.DataSource = _userViewModelList;
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
            lblReqUserLevel.Visible = show;
        }
        #endregion
    }
}