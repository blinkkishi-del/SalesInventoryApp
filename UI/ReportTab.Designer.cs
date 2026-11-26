namespace UI
{
    partial class ReportTab
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnPrint = new FontAwesome.Sharp.IconButton();
            dgReport = new DataGridView();
            lblSummary = new Label();
            ((System.ComponentModel.ISupportInitialize)dgReport).BeginInit();
            SuspendLayout();
            //
            // lblFrom
            //
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFrom.ForeColor = Color.Gainsboro;
            lblFrom.Location = new Point(10, 8);
            lblFrom.Name = "lblFrom";
            lblFrom.Text = "From";
            //
            // dtpFrom
            //
            dtpFrom.Font = new Font("Segoe UI", 11F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(10, 30);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(150, 27);
            dtpFrom.TabIndex = 0;
            dtpFrom.ValueChanged += Dates_Changed;
            //
            // lblTo
            //
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTo.ForeColor = Color.Gainsboro;
            lblTo.Location = new Point(175, 8);
            lblTo.Name = "lblTo";
            lblTo.Text = "To";
            //
            // dtpTo
            //
            dtpTo.Font = new Font("Segoe UI", 11F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(175, 30);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(150, 27);
            dtpTo.TabIndex = 1;
            dtpTo.ValueChanged += Dates_Changed;
            //
            // btnPrint
            //
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrint.IconSize = 23;
            btnPrint.Location = new Point(868, 22);
            btnPrint.BackColor = Color.FromArgb(124,58,237);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.IconColor = Color.White;
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(107, 38);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "PRINT";
            btnPrint.Click += btnPrint_Click;
            //
            // dgReport
            //
            dgReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgReport.Location = new Point(10, 70);
            dgReport.Name = "dgReport";
            dgReport.Size = new Size(965, 390);
            dgReport.TabIndex = 3;
            //
            // lblSummary
            //
            lblSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSummary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSummary.ForeColor = Color.FromArgb(111, 207, 151);
            lblSummary.Location = new Point(10, 468);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(965, 28);
            lblSummary.TextAlign = ContentAlignment.MiddleRight;
            //
            // ReportTab
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            Controls.Add(lblFrom);
            Controls.Add(dtpFrom);
            Controls.Add(lblTo);
            Controls.Add(dtpTo);
            Controls.Add(btnPrint);
            Controls.Add(dgReport);
            Controls.Add(lblSummary);
            Name = "ReportTab";
            Size = new Size(985, 500);
            Load += ReportTab_Load;
            ((System.ComponentModel.ISupportInitialize)dgReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private FontAwesome.Sharp.IconButton btnPrint;
        private DataGridView dgReport;
        private Label lblSummary;
    }
}
