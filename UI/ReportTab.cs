using System.ComponentModel;
using System.Data;

namespace UI
{
    public partial class ReportTab : UserControl
    {
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ReportTitle { get; set; } = "Report";
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<DateTime, DateTime, DataTable>? LoadData { get; set; }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<DataGridView>? FormatGrid { get; set; }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<DataTable, string[]>? Summary { get; set; }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool UseDateRange
        {
            get => useDateRange;
            set => lblFrom.Visible = dtpFrom.Visible = lblTo.Visible = dtpTo.Visible = useDateRange = value;
        }
        private bool useDateRange = true;

        public DateTime From => dtpFrom.Value.Date <= dtpTo.Value.Date ? dtpFrom.Value.Date : dtpTo.Value.Date;
        public DateTime To => dtpFrom.Value.Date <= dtpTo.Value.Date ? dtpTo.Value.Date : dtpFrom.Value.Date;

        private bool ready;

        public ReportTab()
        {
            InitializeComponent();
            GridFormatHelper.ApplyModernStyle(dgReport);
        }

        private void ReportTab_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpTo.Value = today;
            ready = true;
            Reload();
        }

        public void Reload()
        {
            if (!ready || LoadData == null) return;
            try
            {
                DateTime from = dtpFrom.Value.Date, to = dtpTo.Value.Date;
                if (from > to) (from, to) = (to, from);

                DataTable dt = LoadData(from, to);
                dgReport.DataSource = null;
                dgReport.DataSource = dt;
                FormatGrid?.Invoke(dgReport);
                lblSummary.Text = string.Join("      ", Summary?.Invoke(dt) ?? new[] { $"Records: {dt.Rows.Count}" });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading {ReportTitle}:\n{ex.Message}", "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dates_Changed(object sender, EventArgs e) => Reload();

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string range = UseDateRange
                ? $"{dtpFrom.Value:MMMM dd, yyyy} - {dtpTo.Value:MMMM dd, yyyy}"
                : $"As of {DateTime.Now:MMMM dd, yyyy hh:mm tt}";
            var footer = dgReport.DataSource is DataTable dt && Summary != null ? Summary(dt) : Array.Empty<string>();
            GridReportPrinter.Print(dgReport, ReportTitle, range, footer);
        }
    }
}
