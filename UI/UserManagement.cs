using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class UserManagement : Form
    {
        private readonly UserController userController;
        private readonly UserModel currentUser;
        private List<UserModel> userList = new List<UserModel>();

        private string resetTarget;

        public UserManagement(UserModel currentUser)
        {
            InitializeComponent();
            userController = new UserController();
            this.currentUser = currentUser;
            cmbRole.Items.AddRange(UserController.Roles);
            tabUserManagement.Deselected += (s, e) => { if (e.TabPage == tabPassword) SetOwnPasswordMode(); };
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            SetOwnPasswordMode();
        }

        private void LoadData()
        {
            userList = userController.GetAllUsers();
            BindGrid(FilterUsers());
        }

        private List<UserModel> FilterUsers()
        {
            string keyword = txtSearch.Text.Trim();
            return userList
                .Where(u => u.Username.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                         || (u.FullName ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        private void BindGrid(List<UserModel> users)
        {
            dgUsers.DataSource = null;
            dgUsers.DataSource = users.Select(u => new
            {
                u.Username,
                FullName = u.FullName,
                u.Role,
                Status = u.IsActive ? "Active" : "Inactive"
            }).ToList();

            GridFormatHelper.SetHeaders(dgUsers, ("FullName", "Full Name"));
            GridFormatHelper.SetColumnFillWeight(dgUsers, "Username", 25);
            GridFormatHelper.SetColumnFillWeight(dgUsers, "FullName", 40);
            GridFormatHelper.SetColumnFillWeight(dgUsers, "Role", 15);
            GridFormatHelper.SetColumnFillWeight(dgUsers, "Status", 15);

            foreach (DataGridViewRow row in dgUsers.Rows)
                if (row.Cells["Status"].Value?.ToString() == "Inactive")
                    row.DefaultCellStyle.ForeColor = Color.IndianRed;

            UpdateButtons();
        }

        private UserModel SelectedUser()
        {
            if (dgUsers.CurrentRow == null) return null;
            string username = dgUsers.CurrentRow.Cells["Username"].Value?.ToString();
            return userList.FirstOrDefault(u => u.Username == username);
        }

        private void UpdateButtons()
        {
            var user = SelectedUser();
            bool isSelf = user != null && user.Username == currentUser?.Username;

            btnToggleActive.Enabled = user != null && !isSelf;
            btnResetPassword.Enabled = user != null && !isSelf;
            btnToggleActive.Text = user != null && !user.IsActive ? "ACTIVATE" : "DEACTIVATE";
            btnToggleActive.IconChar = user != null && !user.IsActive
                ? FontAwesome.Sharp.IconChar.UserCheck
                : FontAwesome.Sharp.IconChar.UserSlash;
        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e) => UpdateButtons();

        private void txtSearch_TextChanged(object sender, EventArgs e) => BindGrid(FilterUsers());

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAddFields();
            tabUserManagement.SelectedTab = tabAdd;
            txtUsername.Focus();
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            var user = SelectedUser();
            if (user == null) return;

            bool activate = !user.IsActive;
            string action = activate ? "activate" : "deactivate";
            if (MessageBox.Show($"Are you sure you want to {action} '{user.Username}'?", "User Account",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                userController.SetActive(user.Username, activate, currentUser?.Username);
                LoadData();
                MessageBox.Show($"Account '{user.Username}' has been {action}d.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var user = SelectedUser();
            if (user == null) return;

            resetTarget = user.Username;
            lblPassHeader.Text = $"RESET PASSWORD FOR : {user.Username}";
            lblCurrentPass.Visible = txtCurrentPass.Visible = false;
            ClearPasswordFields();
            tabUserManagement.SelectedTab = tabPassword;
            txtNewPass.Focus();
        }

        private void SetOwnPasswordMode()
        {
            resetTarget = null;
            lblPassHeader.Text = $"CHANGE PASSWORD : {currentUser?.Username}";
            lblCurrentPass.Visible = txtCurrentPass.Visible = true;
            ClearPasswordFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new UserModel
                {
                    Username = txtUsername.Text,
                    FullName = txtFullName.Text,
                    Role = cmbRole.SelectedItem?.ToString(),
                    Password = txtPassword.Text
                };
                userController.Add(user, txtConfirm.Text);
                MessageBox.Show("New account has been successfully saved!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAddFields();
                tabUserManagement.SelectedTab = tabList;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAddFields();
            tabUserManagement.SelectedTab = tabList;
        }

        private void btnPassSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (resetTarget == null)
                {
                    userController.ChangePassword(currentUser?.Username, txtCurrentPass.Text,
                        txtNewPass.Text, txtConfirmPass.Text);

                    MessageBox.Show("Your password has been successfully changed!", "Change Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPasswordFields();
                    tabUserManagement.SelectedTab = tabList;
                }
                else
                {
                    userController.ResetPassword(resetTarget, txtNewPass.Text, txtConfirmPass.Text);
                    MessageBox.Show($"Password for '{resetTarget}' has been reset.", "Reset Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetOwnPasswordMode();
                    tabUserManagement.SelectedTab = tabList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPassClear_Click(object sender, EventArgs e)
        {
            SetOwnPasswordMode();
            tabUserManagement.SelectedTab = tabList;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            SetOwnPasswordMode();
            tabUserManagement.SelectedTab = tabPassword;
            txtCurrentPass.Focus();
        }

        private void ClearAddFields()
        {
            txtUsername.Text = "";
            txtFullName.Text = "";
            cmbRole.SelectedIndex = -1;
            txtPassword.Text = "";
            txtConfirm.Text = "";
        }

        private void ClearPasswordFields()
        {
            txtCurrentPass.Text = "";
            txtNewPass.Text = "";
            txtConfirmPass.Text = "";
        }
    }
}
