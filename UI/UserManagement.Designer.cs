namespace UI
{
    partial class UserManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabUserManagement = new TabControl();
            tabList = new TabPage();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnResetPassword = new FontAwesome.Sharp.IconButton();
            btnToggleActive = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnChangePassword = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            dgUsers = new DataGridView();
            tabAdd = new TabPage();
            panel3 = new Panel();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirm = new Label();
            txtConfirm = new TextBox();
            panel2 = new Panel();
            lblAdding = new Label();
            tabPassword = new TabPage();
            panel5 = new Panel();
            btnPassClear = new FontAwesome.Sharp.IconButton();
            btnPassSave = new FontAwesome.Sharp.IconButton();
            lblCurrentPass = new Label();
            txtCurrentPass = new TextBox();
            lblNewPass = new Label();
            txtNewPass = new TextBox();
            lblConfirmPass = new Label();
            txtConfirmPass = new TextBox();
            panel4 = new Panel();
            lblPassHeader = new Label();
            tabUserManagement.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            tabAdd.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tabPassword.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            //
            // tabUserManagement
            //
            tabUserManagement.Appearance = TabAppearance.FlatButtons;
            tabUserManagement.ItemSize = new Size(0, 1);
            tabUserManagement.SizeMode = TabSizeMode.Fixed;
            tabUserManagement.TabStop = false;
            tabUserManagement.Controls.Add(tabList);
            tabUserManagement.Controls.Add(tabAdd);
            tabUserManagement.Controls.Add(tabPassword);
            tabUserManagement.Dock = DockStyle.Fill;
            tabUserManagement.Location = new Point(0, 0);
            tabUserManagement.Name = "tabUserManagement";
            tabUserManagement.SelectedIndex = 0;
            tabUserManagement.Size = new Size(1007, 550);
            tabUserManagement.TabIndex = 0;
            //
            // tabList
            //
            tabList.BackColor = Color.FromArgb(34, 33, 74);
            tabList.Controls.Add(btnRefresh);
            tabList.Controls.Add(btnResetPassword);
            tabList.Controls.Add(btnToggleActive);
            tabList.Controls.Add(btnChangePassword);
            tabList.Controls.Add(btnAdd);
            tabList.Controls.Add(txtSearch);
            tabList.Controls.Add(dgUsers);
            tabList.ForeColor = Color.Black;
            tabList.Location = new Point(4, 24);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3);
            tabList.Size = new Size(999, 522);
            tabList.TabIndex = 0;
            tabList.Text = "Accounts";
            //
            // btnRefresh
            //
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 23;
            btnRefresh.Location = new Point(884, 22);
            btnRefresh.BackColor = Color.FromArgb(108,117,125);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconColor = Color.White;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnResetPassword
            //
            btnResetPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResetPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnResetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResetPassword.IconSize = 23;
            btnResetPassword.Location = new Point(714, 22);
            btnResetPassword.BackColor = Color.FromArgb(253,126,20);
            btnResetPassword.Cursor = Cursors.Hand;
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.IconColor = Color.White;
            btnResetPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(164, 38);
            btnResetPassword.TabIndex = 3;
            btnResetPassword.Text = "RESET PASSWORD";
            btnResetPassword.Click += btnResetPassword_Click;
            //
            // btnToggleActive
            //
            btnToggleActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToggleActive.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            btnToggleActive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnToggleActive.IconSize = 23;
            btnToggleActive.Location = new Point(564, 22);
            btnToggleActive.BackColor = Color.FromArgb(23,162,184);
            btnToggleActive.Cursor = Cursors.Hand;
            btnToggleActive.FlatAppearance.BorderSize = 0;
            btnToggleActive.FlatStyle = FlatStyle.Flat;
            btnToggleActive.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnToggleActive.ForeColor = Color.White;
            btnToggleActive.IconColor = Color.White;
            btnToggleActive.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnToggleActive.UseVisualStyleBackColor = false;
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Size = new Size(144, 38);
            btnToggleActive.TabIndex = 2;
            btnToggleActive.Text = "DEACTIVATE";
            btnToggleActive.Click += btnToggleActive_Click;
            //
            // btnChangePassword
            //
            btnChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangePassword.BackColor = Color.FromArgb(124, 58, 237);
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            btnChangePassword.IconColor = Color.White;
            btnChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChangePassword.IconSize = 22;
            btnChangePassword.Location = new Point(262, 22);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(168, 38);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "MY PASSWORD";
            btnChangePassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            //
            // btnAdd
            //
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 23;
            btnAdd.Location = new Point(436, 22);
            btnAdd.BackColor = Color.FromArgb(60,179,113);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconColor = Color.White;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ADD NEW";
            btnAdd.Click += btnAdd_Click;
            //
            // txtSearch
            //
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(8, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Accounts Here";
            txtSearch.Size = new Size(240, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            //
            // dgUsers
            //
            dgUsers.AllowUserToAddRows = false;
            dgUsers.AllowUserToDeleteRows = false;
            dgUsers.AllowUserToResizeColumns = false;
            dgUsers.AllowUserToResizeRows = false;
            dgUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsers.BackgroundColor = Color.White;
            dgUsers.BorderStyle = BorderStyle.None;
            dgUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgUsers.EnableHeadersVisualStyles = false;
            dgUsers.GridColor = Color.FromArgb(230, 232, 238);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(237, 233, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(247, 248, 251);
            dgUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgUsers.Location = new Point(8, 65);
            dgUsers.MultiSelect = false;
            dgUsers.Name = "dgUsers";
            dgUsers.ReadOnly = true;
            dgUsers.RowHeadersVisible = false;
            dgUsers.RowTemplate.Height = 32;
            dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsers.Size = new Size(983, 440);
            dgUsers.TabIndex = 5;
            dgUsers.SelectionChanged += dgUsers_SelectionChanged;
            //
            // tabAdd
            //
            tabAdd.BackColor = Color.FromArgb(34, 33, 74);
            tabAdd.Controls.Add(panel3);
            tabAdd.Controls.Add(panel2);
            tabAdd.ForeColor = Color.FromArgb(34, 33, 74);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(999, 522);
            tabAdd.TabIndex = 1;
            tabAdd.Text = "Add Account";
            //
            // panel3
            //
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(lblUsername);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(lblFullName);
            panel3.Controls.Add(txtFullName);
            panel3.Controls.Add(lblRole);
            panel3.Controls.Add(cmbRole);
            panel3.Controls.Add(lblPassword);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(lblConfirm);
            panel3.Controls.Add(txtConfirm);
            panel3.Location = new Point(20, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(960, 330);
            panel3.TabIndex = 48;
            //
            // lblUsername
            //
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(41, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(103, 24);
            lblUsername.TabIndex = 50;
            lblUsername.Text = "Username";
            //
            // txtUsername
            //
            txtUsername.Font = new Font("Arial", 14F);
            txtUsername.Location = new Point(41, 30);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(260, 29);
            txtUsername.TabIndex = 0;
            //
            // lblFullName
            //
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(337, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(103, 24);
            lblFullName.TabIndex = 51;
            lblFullName.Text = "Full Name";
            //
            // txtFullName
            //
            txtFullName.Font = new Font("Arial", 14F);
            txtFullName.Location = new Point(337, 30);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(320, 29);
            txtFullName.TabIndex = 1;
            //
            // lblRole
            //
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(693, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(52, 24);
            lblRole.TabIndex = 52;
            lblRole.Text = "Role";
            //
            // cmbRole
            //
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Arial", 14F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(693, 30);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(220, 30);
            cmbRole.TabIndex = 2;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(41, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 24);
            lblPassword.TabIndex = 53;
            lblPassword.Text = "Password";
            //
            // txtPassword
            //
            txtPassword.Font = new Font("Arial", 14F);
            txtPassword.Location = new Point(41, 130);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 29);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            //
            // lblConfirm
            //
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblConfirm.ForeColor = Color.White;
            lblConfirm.Location = new Point(337, 100);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(183, 24);
            lblConfirm.TabIndex = 54;
            lblConfirm.Text = "Confirm Password";
            //
            // txtConfirm
            //
            txtConfirm.Font = new Font("Arial", 14F);
            txtConfirm.Location = new Point(337, 130);
            txtConfirm.MaxLength = 50;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(320, 29);
            txtConfirm.TabIndex = 4;
            txtConfirm.UseSystemPasswordChar = true;
            //
            // btnSave
            //
            btnSave.Location = new Point(337, 220);
            btnSave.BackColor = Color.FromArgb(34,139,34);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 22;
            btnSave.IconColor = Color.White;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 49);
            btnSave.TabIndex = 5;
            btnSave.Text = "SAVE";
            btnSave.Click += btnSave_Click;
            //
            // btnCancel
            //
            btnCancel.Location = new Point(500, 226);
            btnCancel.BackColor = Color.FromArgb(108,117,125);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 22;
            btnCancel.IconColor = Color.White;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 38);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "CANCEL";
            btnCancel.Click += btnCancel_Click;
            //
            // panel2
            //
            panel2.Controls.Add(lblAdding);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 70);
            panel2.TabIndex = 47;
            //
            // lblAdding
            //
            lblAdding.AutoSize = true;
            lblAdding.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdding.ForeColor = Color.White;
            lblAdding.Location = new Point(18, 21);
            lblAdding.Name = "lblAdding";
            lblAdding.Size = new Size(245, 29);
            lblAdding.TabIndex = 0;
            lblAdding.Text = "CREATE NEW ACCOUNT :";
            //
            // tabPassword
            //
            tabPassword.BackColor = Color.FromArgb(34, 33, 74);
            tabPassword.Controls.Add(panel5);
            tabPassword.Controls.Add(panel4);
            tabPassword.ForeColor = Color.FromArgb(34, 33, 74);
            tabPassword.Location = new Point(4, 24);
            tabPassword.Name = "tabPassword";
            tabPassword.Padding = new Padding(3);
            tabPassword.Size = new Size(999, 522);
            tabPassword.TabIndex = 2;
            tabPassword.Text = "Change Password";
            //
            // panel5
            //
            panel5.Anchor = AnchorStyles.Top;
            panel5.Controls.Add(btnPassClear);
            panel5.Controls.Add(btnPassSave);
            panel5.Controls.Add(lblCurrentPass);
            panel5.Controls.Add(txtCurrentPass);
            panel5.Controls.Add(lblNewPass);
            panel5.Controls.Add(txtNewPass);
            panel5.Controls.Add(lblConfirmPass);
            panel5.Controls.Add(txtConfirmPass);
            panel5.Location = new Point(20, 80);
            panel5.Name = "panel5";
            panel5.Size = new Size(960, 330);
            panel5.TabIndex = 48;
            //
            // lblCurrentPass
            //
            lblCurrentPass.AutoSize = true;
            lblCurrentPass.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblCurrentPass.ForeColor = Color.White;
            lblCurrentPass.Location = new Point(41, 0);
            lblCurrentPass.Name = "lblCurrentPass";
            lblCurrentPass.Size = new Size(180, 24);
            lblCurrentPass.TabIndex = 50;
            lblCurrentPass.Text = "Current Password";
            //
            // txtCurrentPass
            //
            txtCurrentPass.Font = new Font("Arial", 14F);
            txtCurrentPass.Location = new Point(41, 30);
            txtCurrentPass.MaxLength = 50;
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.Size = new Size(260, 29);
            txtCurrentPass.TabIndex = 0;
            txtCurrentPass.UseSystemPasswordChar = true;
            //
            // lblNewPass
            //
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblNewPass.ForeColor = Color.White;
            lblNewPass.Location = new Point(337, 0);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(153, 24);
            lblNewPass.TabIndex = 51;
            lblNewPass.Text = "New Password";
            //
            // txtNewPass
            //
            txtNewPass.Font = new Font("Arial", 14F);
            txtNewPass.Location = new Point(337, 30);
            txtNewPass.MaxLength = 50;
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(260, 29);
            txtNewPass.TabIndex = 1;
            txtNewPass.UseSystemPasswordChar = true;
            //
            // lblConfirmPass
            //
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblConfirmPass.ForeColor = Color.White;
            lblConfirmPass.Location = new Point(633, 0);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(230, 24);
            lblConfirmPass.TabIndex = 52;
            lblConfirmPass.Text = "Confirm New Password";
            //
            // txtConfirmPass
            //
            txtConfirmPass.Font = new Font("Arial", 14F);
            txtConfirmPass.Location = new Point(633, 30);
            txtConfirmPass.MaxLength = 50;
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(260, 29);
            txtConfirmPass.TabIndex = 2;
            txtConfirmPass.UseSystemPasswordChar = true;
            //
            // btnPassSave
            //
            btnPassSave.Location = new Point(337, 120);
            btnPassSave.BackColor = Color.FromArgb(34,139,34);
            btnPassSave.Cursor = Cursors.Hand;
            btnPassSave.FlatAppearance.BorderSize = 0;
            btnPassSave.FlatStyle = FlatStyle.Flat;
            btnPassSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnPassSave.ForeColor = Color.White;
            btnPassSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnPassSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPassSave.IconSize = 22;
            btnPassSave.IconColor = Color.White;
            btnPassSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPassSave.UseVisualStyleBackColor = false;
            btnPassSave.Name = "btnPassSave";
            btnPassSave.Size = new Size(140, 49);
            btnPassSave.TabIndex = 3;
            btnPassSave.Text = "SAVE";
            btnPassSave.Click += btnPassSave_Click;
            //
            // btnPassClear
            //
            btnPassClear.Location = new Point(500, 126);
            btnPassClear.BackColor = Color.FromArgb(108,117,125);
            btnPassClear.Cursor = Cursors.Hand;
            btnPassClear.FlatAppearance.BorderSize = 0;
            btnPassClear.FlatStyle = FlatStyle.Flat;
            btnPassClear.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnPassClear.ForeColor = Color.White;
            btnPassClear.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnPassClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPassClear.IconSize = 22;
            btnPassClear.IconColor = Color.White;
            btnPassClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPassClear.UseVisualStyleBackColor = false;
            btnPassClear.Name = "btnPassClear";
            btnPassClear.Size = new Size(98, 38);
            btnPassClear.TabIndex = 4;
            btnPassClear.Text = "CANCEL";
            btnPassClear.Click += btnPassClear_Click;
            //
            // panel4
            //
            panel4.Controls.Add(lblPassHeader);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(993, 70);
            panel4.TabIndex = 47;
            //
            // lblPassHeader
            //
            lblPassHeader.AutoSize = true;
            lblPassHeader.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassHeader.ForeColor = Color.White;
            lblPassHeader.Location = new Point(18, 21);
            lblPassHeader.Name = "lblPassHeader";
            lblPassHeader.Size = new Size(245, 29);
            lblPassHeader.TabIndex = 0;
            lblPassHeader.Text = "CHANGE PASSWORD :";
            //
            // UserManagement
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 550);
            Controls.Add(tabUserManagement);
            Name = "UserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Management";
            Load += UserManagement_Load;
            tabUserManagement.ResumeLayout(false);
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            tabAdd.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPassword.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabUserManagement;
        private TabPage tabList;
        private TabPage tabAdd;
        private TabPage tabPassword;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnResetPassword;
        private FontAwesome.Sharp.IconButton btnToggleActive;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnChangePassword;
        private TextBox txtSearch;
        private DataGridView dgUsers;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private Panel panel2;
        private Label lblAdding;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton btnPassClear;
        private FontAwesome.Sharp.IconButton btnPassSave;
        private Label lblCurrentPass;
        private TextBox txtCurrentPass;
        private Label lblNewPass;
        private TextBox txtNewPass;
        private Label lblConfirmPass;
        private TextBox txtConfirmPass;
        private Panel panel4;
        private Label lblPassHeader;
    }
}
