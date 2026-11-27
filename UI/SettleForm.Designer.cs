namespace UI
{
    partial class SettleForm
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
            panelHeader = new Panel();
            lblTitle = new Label();
            lblTotal = new Label();
            lblTotalValue = new Label();
            lblCash = new Label();
            txtCash = new TextBox();
            tableKeypad = new TableLayoutPanel();
            flowQuick = new FlowLayoutPanel();
            lblChange = new Label();
            lblChangeValue = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(34, 33, 74);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(410, 50);
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "SETTLE PAYMENT";
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.ForeColor = Color.FromArgb(75, 85, 99);
            lblTotal.Location = new Point(20, 66);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Amount to pay";
            //
            // lblTotalValue
            //
            lblTotalValue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(124, 58, 237);
            lblTotalValue.Location = new Point(170, 60);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(220, 32);
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblCash
            //
            lblCash.AutoSize = true;
            lblCash.Font = new Font("Segoe UI", 11F);
            lblCash.ForeColor = Color.FromArgb(75, 85, 99);
            lblCash.Location = new Point(20, 108);
            lblCash.Name = "lblCash";
            lblCash.Text = "Cash received";
            //
            // txtCash
            //
            txtCash.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtCash.Location = new Point(170, 102);
            txtCash.MaxLength = 12;
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(220, 36);
            txtCash.TabIndex = 0;
            txtCash.TextAlign = HorizontalAlignment.Right;
            txtCash.TextChanged += txtCash_TextChanged;
            //
            // flowQuick
            //
            flowQuick.Location = new Point(17, 148);
            flowQuick.Name = "flowQuick";
            flowQuick.Size = new Size(376, 40);
            //
            // tableKeypad
            //
            tableKeypad.ColumnCount = 3;
            tableKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableKeypad.Location = new Point(17, 194);
            tableKeypad.Name = "tableKeypad";
            tableKeypad.RowCount = 4;
            tableKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableKeypad.Size = new Size(376, 200);
            //
            // lblChange
            //
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 11F);
            lblChange.ForeColor = Color.FromArgb(75, 85, 99);
            lblChange.Location = new Point(20, 408);
            lblChange.Name = "lblChange";
            lblChange.Text = "Change";
            //
            // lblChangeValue
            //
            lblChangeValue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblChangeValue.ForeColor = Color.FromArgb(22, 163, 74);
            lblChangeValue.Location = new Point(170, 402);
            lblChangeValue.Name = "lblChangeValue";
            lblChangeValue.Size = new Size(220, 32);
            lblChangeValue.TextAlign = ContentAlignment.MiddleRight;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.FromArgb(149, 165, 166);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(20, 448);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 44);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            //
            // btnConfirm
            //
            btnConfirm.BackColor = Color.FromArgb(46, 204, 113);
            btnConfirm.DialogResult = DialogResult.OK;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(200, 448);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(190, 44);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "CONFIRM PAYMENT";
            btnConfirm.UseVisualStyleBackColor = false;
            //
            // SettleForm
            //
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 249);
            CancelButton = btnCancel;
            ClientSize = new Size(410, 510);
            Controls.Add(panelHeader);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalValue);
            Controls.Add(lblCash);
            Controls.Add(txtCash);
            Controls.Add(flowQuick);
            Controls.Add(tableKeypad);
            Controls.Add(lblChange);
            Controls.Add(lblChangeValue);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettleForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Payment";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblTotal;
        private Label lblTotalValue;
        private Label lblCash;
        private TextBox txtCash;
        private FlowLayoutPanel flowQuick;
        private TableLayoutPanel tableKeypad;
        private Label lblChange;
        private Label lblChangeValue;
        private Button btnCancel;
        private Button btnConfirm;
    }
}
