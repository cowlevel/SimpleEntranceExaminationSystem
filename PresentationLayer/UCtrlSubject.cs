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
        private SubjectBLL _subjectBLL;
        private List<Subject> _subjectList;

        private int _subjectId;
        #endregion

        public UCtrlSubject()
        {
            InitializeComponent();

            _subjectBLL = new SubjectBLL();
            dgvSubject.AutoGenerateColumns = false;
            PopulateSubjectDatagridView();
        }

        private void UCtrlSubject_Load(object sender, EventArgs e)
        {
            dgvSubject.ClearSelection();
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
            Subject subject;

            if (btnAdd.Text == "&CANCEL")   //  ADD NEW
            {
                if (InputsAreValid())
                {
                    subject = new Subject(); //  create new Subject
                    subject.SubjectName = txtSubject.Text;
                    subject.Description = txtDescription.Text;

                    _subjectBLL.InsertSubject(subject);

                    PopulateSubjectDatagridView();
                    SetUIProperty(Operation.Clear);

                    lblStatus.Text = "  Successfully added new subject";
                }
            }

            if (btnEdit.Text == "&CANCEL")  //  EDIT
            {
                

                if (InputsAreValid())
                {
                    subject = _subjectList.Where(s => s.SubjectId == _subjectId).SingleOrDefault();

                    subject.SubjectName = txtSubject.Text;
                    subject.Description = txtDescription.Text;

                    _subjectBLL.UpdateSubject(subject);

                    PopulateSubjectDatagridView();
                    SetUIProperty(Operation.Clear);

                    lblStatus.Text = "  Successfully updated subject";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this subject?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _subjectBLL.DeleteSubject(_subjectId);

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
            dgvSubject.DataSource = null;
            //  check always if list got record, if got zero record then dont use it as data source to avoid some error. NOTE: must have at least 1 record before to use it as data source.
            if (_subjectList.Count > 0)
            {
                dgvSubject.DataSource = _subjectList;
            }
        }

        private void SetUIProperty(Operation operation)
        {
            switch (operation)
            {
                case Operation.Adding:
                    lblStatus.Text = "  You are currently adding new subject";

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
                    lblStatus.Text = "  You are currently editing subject";

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

        private bool InputsAreValid()
        {
            if (string.IsNullOrEmpty(txtSubject.Text))
            {
                lblStatus.Text = "  Please enter subject";
                txtSubject.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtDescription.Text))
            {
                lblStatus.Text = "  Please enter description";
                txtDescription.Focus();
                return false;
            }

            return true;
        }

        
    }
}