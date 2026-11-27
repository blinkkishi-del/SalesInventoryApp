namespace UI
{
    partial class CategoryManagement
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
            tabCategoryManagement = new TabControl();
            tabList = new TabPage();
            dgCategories = new DataGridView();
            panelFooter = new Panel();
            lblCount = new Label();
            lblNote = new Label();
            panelToolbar = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            tabAdd = new TabPage();
            panelCard = new Panel();
            tableFields = new TableLayoutPanel();
            lblCategoryID = new Label();
            lblCategoryIdValue = new Label();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            lblHint = new Label();
            flowButtons = new FlowLayoutPanel();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            panelHeader = new Panel();
            lblAdding = new Label();
            tabCategoryManagement.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategories).BeginInit();
            panelFooter.SuspendLayout();
            panelToolbar.SuspendLayout();
            tabAdd.SuspendLayout();
            panelCard.SuspendLayout();
            tableFields.SuspendLayout();
            flowButtons.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            //
            // tabCategoryManagement
            //
            tabCategoryManagement.Appearance = TabAppearance.FlatButtons;
            tabCategoryManagement.Controls.Add(tabList);
            tabCategoryManagement.Controls.Add(tabAdd);
            tabCategoryManagement.Dock = DockStyle.Fill;
            tabCategoryManagement.ItemSize = new Size(0, 1);
            tabCategoryManagement.Location = new Point(0, 0);
            tabCategoryManagement.Name = "tabCategoryManagement";
            tabCategoryManagement.SelectedIndex = 0;
            tabCategoryManagement.Size = new Size(1007, 550);
            tabCategoryManagement.SizeMode = TabSizeMode.Fixed;
            tabCategoryManagement.TabIndex = 0;
            tabCategoryManagement.TabStop = false;
            //
            // tabList
            //
            tabList.BackColor = Color.FromArgb(34, 33, 74);
            tabList.Controls.Add(dgCategories);
            tabList.Controls.Add(panelFooter);
            tabList.Controls.Add(panelToolbar);
            tabList.Location = new Point(4, 5);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(16, 8, 16, 8);
            tabList.Size = new Size(999, 541);
            tabList.TabIndex = 0;
            tabList.Text = "Categories";
            //
            // panelToolbar
            //
            panelToolbar.Controls.Add(lblSearch);
            panelToolbar.Controls.Add(txtSearch);
            panelToolbar.Controls.Add(btnAdd);
            panelToolbar.Controls.Add(btnUpdate);
            panelToolbar.Controls.Add(btnDelete);
            panelToolbar.Controls.Add(btnRefresh);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(16, 8);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(967, 66);
            panelToolbar.TabIndex = 0;
            //
            // lblSearch
            //
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.Gainsboro;
            lblSearch.Location = new Point(0, 4);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Search";
            //
            // txtSearch
            //
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(0, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search categories";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            //
            // btnAdd
            //
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 22;
            btnAdd.Location = new Point(499, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ADD NEW";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // btnUpdate
            //
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(24, 161, 251);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnUpdate.IconColor = Color.White;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 22;
            btnUpdate.Location = new Point(623, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 38);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "MODIFY";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnDelete
            //
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 22;
            btnDelete.Location = new Point(737, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 38);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // btnRefresh
            //
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(108, 117, 125);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 22;
            btnRefresh.Location = new Point(851, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            //
            // dgCategories
            //
            dgCategories.Dock = DockStyle.Fill;
            dgCategories.Location = new Point(16, 74);
            dgCategories.Name = "dgCategories";
            dgCategories.Size = new Size(967, 423);
            dgCategories.TabIndex = 5;
            dgCategories.SelectionChanged += dgCategories_SelectionChanged;
            dgCategories.CellDoubleClick += dgCategories_CellDoubleClick;
            //
            // panelFooter
            //
            panelFooter.Controls.Add(lblNote);
            panelFooter.Controls.Add(lblCount);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(16, 497);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(967, 36);
            panelFooter.TabIndex = 6;
            //
            // lblCount
            //
            lblCount.Dock = DockStyle.Left;
            lblCount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCount.ForeColor = Color.FromArgb(111, 207, 151);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(400, 36);
            lblCount.Text = "0 categories";
            lblCount.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblNote
            //
            lblNote.Dock = DockStyle.Fill;
            lblNote.Font = new Font("Segoe UI", 10F);
            lblNote.ForeColor = Color.Silver;
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(400, 36);
            lblNote.Text = "Double-click a row to modify.";
            lblNote.TextAlign = ContentAlignment.MiddleRight;
            //
            // tabAdd
            //
            tabAdd.AutoScroll = true;
            tabAdd.BackColor = Color.FromArgb(34, 33, 74);
            tabAdd.Controls.Add(panelCard);
            tabAdd.Controls.Add(panelHeader);
            tabAdd.Location = new Point(4, 5);
            tabAdd.Name = "tabAdd";
            tabAdd.Size = new Size(999, 541);
            tabAdd.TabIndex = 1;
            tabAdd.Text = "Add / Modify";
            //
            // panelHeader
            //
            panelHeader.Controls.Add(lblAdding);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(24, 0, 0, 0);
            panelHeader.Size = new Size(999, 64);
            panelHeader.TabIndex = 0;
            //
            // lblAdding
            //
            lblAdding.Dock = DockStyle.Fill;
            lblAdding.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblAdding.ForeColor = Color.White;
            lblAdding.Name = "lblAdding";
            lblAdding.Text = "ADD NEW CATEGORY";
            lblAdding.TextAlign = ContentAlignment.MiddleLeft;
            //
            // panelCard
            //
            panelCard.Anchor = AnchorStyles.Top;
            panelCard.BackColor = Color.FromArgb(44, 43, 92);
            panelCard.Controls.Add(tableFields);
            panelCard.Location = new Point(170, 76);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(24, 20, 24, 16);
            panelCard.Size = new Size(660, 250);
            panelCard.TabIndex = 1;
            //
            // tableFields
            //
            tableFields.ColumnCount = 2;
            tableFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableFields.Controls.Add(lblCategoryID, 0, 0);
            tableFields.Controls.Add(lblCategoryName, 1, 0);
            tableFields.Controls.Add(lblCategoryIdValue, 0, 1);
            tableFields.Controls.Add(txtCategoryName, 1, 1);
            tableFields.Controls.Add(lblHint, 0, 2);
            tableFields.Controls.Add(flowButtons, 0, 3);
            tableFields.Dock = DockStyle.Fill;
            tableFields.Name = "tableFields";
            tableFields.RowCount = 4;
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableFields.TabIndex = 0;
            tableFields.SetColumnSpan(lblHint, 2);
            tableFields.SetColumnSpan(flowButtons, 2);
            //
            // lblCategoryID
            //
            lblCategoryID.Dock = DockStyle.Fill;
            lblCategoryID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCategoryID.ForeColor = Color.Silver;
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Text = "Category ID (auto-generated)";
            lblCategoryID.TextAlign = ContentAlignment.BottomLeft;
            //
            // lblCategoryIdValue
            //
            lblCategoryIdValue.BackColor = Color.FromArgb(60, 59, 110);
            lblCategoryIdValue.Dock = DockStyle.Fill;
            lblCategoryIdValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCategoryIdValue.ForeColor = Color.White;
            lblCategoryIdValue.Margin = new Padding(3, 4, 12, 12);
            lblCategoryIdValue.Name = "lblCategoryIdValue";
            lblCategoryIdValue.Padding = new Padding(8, 0, 0, 0);
            lblCategoryIdValue.Text = "-";
            lblCategoryIdValue.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblCategoryName
            //
            lblCategoryName.Dock = DockStyle.Fill;
            lblCategoryName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCategoryName.ForeColor = Color.Silver;
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Text = "Category Name *";
            lblCategoryName.TextAlign = ContentAlignment.BottomLeft;
            //
            // txtCategoryName
            //
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Dock = DockStyle.Fill;
            txtCategoryName.Font = new Font("Segoe UI", 12F);
            txtCategoryName.Margin = new Padding(3, 4, 12, 12);
            txtCategoryName.MaxLength = 30;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.TabIndex = 0;
            //
            // lblHint
            //
            lblHint.Dock = DockStyle.Fill;
            lblHint.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblHint.ForeColor = Color.Silver;
            lblHint.Name = "lblHint";
            lblHint.Text = "Renaming also updates every product in this category.";
            lblHint.TextAlign = ContentAlignment.TopLeft;
            //
            // flowButtons
            //
            flowButtons.Controls.Add(btnCancel);
            flowButtons.Controls.Add(btnSave);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Name = "flowButtons";
            flowButtons.TabIndex = 1;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCancel.IconColor = Color.White;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 22;
            btnCancel.Margin = new Padding(8, 8, 12, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 44);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "CANCEL";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 22;
            btnSave.Margin = new Padding(8, 8, 0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 44);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // CategoryManagement
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 550);
            Controls.Add(tabCategoryManagement);
            Name = "CategoryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            Load += CategoryManagement_Load;
            tabCategoryManagement.ResumeLayout(false);
            tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCategories).EndInit();
            panelFooter.ResumeLayout(false);
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            tabAdd.ResumeLayout(false);
            panelCard.ResumeLayout(false);
            tableFields.ResumeLayout(false);
            tableFields.PerformLayout();
            flowButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCategoryManagement;
        private TabPage tabList;
        private TabPage tabAdd;
        private Panel panelToolbar;
        private Label lblSearch;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private DataGridView dgCategories;
        private Panel panelFooter;
        private Label lblCount;
        private Label lblNote;
        private Panel panelHeader;
        private Label lblAdding;
        private Panel panelCard;
        private TableLayoutPanel tableFields;
        private Label lblCategoryID;
        private Label lblCategoryIdValue;
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private Label lblHint;
        private FlowLayoutPanel flowButtons;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}
