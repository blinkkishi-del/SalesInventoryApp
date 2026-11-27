namespace UI
{
    partial class DiscountForm
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
            btnScopeItem = new Button();
            btnScopeOrder = new Button();
            lblItem = new Label();
            lblItemValue = new Label();
            lblAmount = new Label();
            lblAmountValue = new Label();
            lblPercent = new Label();
            nudPercent = new NumericUpDown();
            btn5 = new Button();
            btn10 = new Button();
            btnSenior = new Button();
            btnNone = new Button();
            lblDiscount = new Label();
            lblDiscountValue = new Label();
            lblNewTotal = new Label();
            lblNewTotalValue = new Label();
            btnCancel = new Button();
            btnApply = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPercent).BeginInit();
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
            lblTitle.Text = "APPLY DISCOUNT";
            //
            // lblItem
            //
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Segoe UI", 10F);
            lblItem.ForeColor = Color.FromArgb(107, 114, 128);
            lblItem.Location = new Point(20, 114);
            lblItem.Name = "lblItem";
            lblItem.Text = "Item";
            //
            // lblItemValue
            //
            lblItemValue.AutoEllipsis = true;
            lblItemValue.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblItemValue.ForeColor = Color.FromArgb(34, 33, 74);
            lblItemValue.Location = new Point(20, 134);
            lblItemValue.Name = "lblItemValue";
            lblItemValue.Size = new Size(370, 24);
            //
            // lblAmount
            //
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 10F);
            lblAmount.ForeColor = Color.FromArgb(107, 114, 128);
            lblAmount.Location = new Point(20, 168);
            lblAmount.Name = "lblAmount";
            lblAmount.Text = "Line amount";
            //
            // lblAmountValue
            //
            lblAmountValue.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAmountValue.ForeColor = Color.FromArgb(34, 33, 74);
            lblAmountValue.Location = new Point(200, 166);
            lblAmountValue.Name = "lblAmountValue";
            lblAmountValue.Size = new Size(190, 24);
            lblAmountValue.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblPercent
            //
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("Segoe UI", 10F);
            lblPercent.ForeColor = Color.FromArgb(107, 114, 128);
            lblPercent.Location = new Point(20, 204);
            lblPercent.Name = "lblPercent";
            lblPercent.Text = "Discount %";
            //
            // nudPercent
            //
            nudPercent.BorderStyle = BorderStyle.FixedSingle;
            nudPercent.DecimalPlaces = 2;
            nudPercent.Font = new Font("Segoe UI", 12F);
            nudPercent.Location = new Point(20, 226);
            nudPercent.Name = "nudPercent";
            nudPercent.Size = new Size(130, 29);
            nudPercent.TabIndex = 0;
            nudPercent.ValueChanged += nudPercent_ValueChanged;
            //
            // btnScopeItem
            //
            btnScopeItem.FlatStyle = FlatStyle.Flat;
            btnScopeItem.FlatAppearance.BorderColor = Color.FromArgb(124, 58, 237);
            btnScopeItem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnScopeItem.Location = new Point(20, 62);
            btnScopeItem.Name = "btnScopeItem";
            btnScopeItem.Size = new Size(180, 36);
            btnScopeItem.TabIndex = 10;
            btnScopeItem.Text = "SELECTED ITEM";
            btnScopeItem.UseVisualStyleBackColor = false;
            btnScopeItem.Click += btnScopeItem_Click;
            //
            // btnScopeOrder
            //
            btnScopeOrder.FlatStyle = FlatStyle.Flat;
            btnScopeOrder.FlatAppearance.BorderColor = Color.FromArgb(124, 58, 237);
            btnScopeOrder.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnScopeOrder.Location = new Point(210, 62);
            btnScopeOrder.Name = "btnScopeOrder";
            btnScopeOrder.Size = new Size(180, 36);
            btnScopeOrder.TabIndex = 11;
            btnScopeOrder.Text = "WHOLE ORDER";
            btnScopeOrder.UseVisualStyleBackColor = false;
            btnScopeOrder.Click += btnScopeOrder_Click;
            //
            // btn5
            //
            btn5.BackColor = Color.White;
            btn5.FlatAppearance.BorderColor = Color.FromArgb(124, 58, 237);
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btn5.ForeColor = Color.FromArgb(124, 58, 237);
            btn5.Location = new Point(20, 266);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 32);
            btn5.TabIndex = 1;
            btn5.Text = "5%";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            //
            // btn10
            //
            btn10.BackColor = Color.White;
            btn10.FlatAppearance.BorderColor = Color.FromArgb(124, 58, 237);
            btn10.FlatStyle = FlatStyle.Flat;
            btn10.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btn10.ForeColor = Color.FromArgb(124, 58, 237);
            btn10.Location = new Point(98, 266);
            btn10.Name = "btn10";
            btn10.Size = new Size(70, 32);
            btn10.TabIndex = 2;
            btn10.Text = "10%";
            btn10.UseVisualStyleBackColor = false;
            btn10.Click += btn10_Click;
            //
            // btnSenior
            //
            btnSenior.BackColor = Color.White;
            btnSenior.FlatAppearance.BorderColor = Color.FromArgb(124, 58, 237);
            btnSenior.FlatStyle = FlatStyle.Flat;
            btnSenior.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSenior.ForeColor = Color.FromArgb(124, 58, 237);
            btnSenior.Location = new Point(176, 266);
            btnSenior.Name = "btnSenior";
            btnSenior.Size = new Size(140, 32);
            btnSenior.TabIndex = 3;
            btnSenior.Text = "20% Senior / PWD";
            btnSenior.UseVisualStyleBackColor = false;
            btnSenior.Click += btnSenior_Click;
            //
            // btnNone
            //
            btnNone.BackColor = Color.White;
            btnNone.FlatAppearance.BorderColor = Color.FromArgb(149, 165, 166);
            btnNone.FlatStyle = FlatStyle.Flat;
            btnNone.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnNone.ForeColor = Color.FromArgb(107, 114, 128);
            btnNone.Location = new Point(324, 266);
            btnNone.Name = "btnNone";
            btnNone.Size = new Size(66, 32);
            btnNone.TabIndex = 4;
            btnNone.Text = "None";
            btnNone.UseVisualStyleBackColor = false;
            btnNone.Click += btnNone_Click;
            //
            // lblDiscount
            //
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 10F);
            lblDiscount.ForeColor = Color.FromArgb(107, 114, 128);
            lblDiscount.Location = new Point(20, 316);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Text = "Discount";
            //
            // lblDiscountValue
            //
            lblDiscountValue.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDiscountValue.ForeColor = Color.FromArgb(231, 76, 60);
            lblDiscountValue.Location = new Point(200, 314);
            lblDiscountValue.Name = "lblDiscountValue";
            lblDiscountValue.Size = new Size(190, 24);
            lblDiscountValue.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblNewTotal
            //
            lblNewTotal.AutoSize = true;
            lblNewTotal.Font = new Font("Segoe UI", 10F);
            lblNewTotal.ForeColor = Color.FromArgb(107, 114, 128);
            lblNewTotal.Location = new Point(20, 346);
            lblNewTotal.Name = "lblNewTotal";
            lblNewTotal.Text = "New line total";
            //
            // lblNewTotalValue
            //
            lblNewTotalValue.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblNewTotalValue.ForeColor = Color.FromArgb(124, 58, 237);
            lblNewTotalValue.Location = new Point(200, 342);
            lblNewTotalValue.Name = "lblNewTotalValue";
            lblNewTotalValue.Size = new Size(190, 28);
            lblNewTotalValue.TextAlign = ContentAlignment.MiddleRight;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.FromArgb(149, 165, 166);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(20, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            //
            // btnApply
            //
            btnApply.BackColor = Color.FromArgb(46, 204, 113);
            btnApply.DialogResult = DialogResult.OK;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(220, 390);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(170, 40);
            btnApply.TabIndex = 5;
            btnApply.Text = "APPLY DISCOUNT";
            btnApply.UseVisualStyleBackColor = false;
            //
            // DiscountForm
            //
            AcceptButton = btnApply;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 249);
            CancelButton = btnCancel;
            ClientSize = new Size(410, 450);
            Controls.Add(panelHeader);
            Controls.Add(btnScopeItem);
            Controls.Add(btnScopeOrder);
            Controls.Add(lblItem);
            Controls.Add(lblItemValue);
            Controls.Add(lblAmount);
            Controls.Add(lblAmountValue);
            Controls.Add(lblPercent);
            Controls.Add(nudPercent);
            Controls.Add(btn5);
            Controls.Add(btn10);
            Controls.Add(btnSenior);
            Controls.Add(btnNone);
            Controls.Add(lblDiscount);
            Controls.Add(lblDiscountValue);
            Controls.Add(lblNewTotal);
            Controls.Add(lblNewTotalValue);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DiscountForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Discount";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPercent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnScopeItem;
        private Button btnScopeOrder;
        private Label lblItem;
        private Label lblItemValue;
        private Label lblAmount;
        private Label lblAmountValue;
        private Label lblPercent;
        private NumericUpDown nudPercent;
        private Button btn5;
        private Button btn10;
        private Button btnSenior;
        private Button btnNone;
        private Label lblDiscount;
        private Label lblDiscountValue;
        private Label lblNewTotal;
        private Label lblNewTotalValue;
        private Button btnCancel;
        private Button btnApply;
    }
}
