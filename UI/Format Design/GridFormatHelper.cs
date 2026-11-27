namespace UI
{
    internal static class GridFormatHelper
    {
        public static void FormatCurrencyColumns(DataGridView grid, params string[] columnNames)
        {
            foreach (string name in columnNames)
            {
                if (grid.Columns.Contains(name))
                {
                    grid.Columns[name].DefaultCellStyle.Format = "₱#,##0.00";
                    grid.Columns[name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        public static void ApplyModernStyle(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(230, 232, 238);
            grid.EnableHeadersVisualStyles = false;
            grid.RowTemplate.Height = 30;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 33, 74);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(34, 33, 74);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 233, 254);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(34, 33, 74);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 248, 251);
        }

        public static void HideColumns(DataGridView grid, params string[] columnNames)
        {
            foreach (string name in columnNames)
                if (grid.Columns.Contains(name))
                    grid.Columns[name].Visible = false;
        }

        public static void SetHeaders(DataGridView grid, params (string Column, string Header)[] headers)
        {
            foreach (var (column, header) in headers)
                if (grid.Columns.Contains(column))
                    grid.Columns[column].HeaderText = header;
        }

        public static void SetColumnFillWeight(DataGridView grid, string columnName, float weight)
        {
            if (grid.Columns.Contains(columnName))
                grid.Columns[columnName].FillWeight = weight;
        }

        public static void SetColumnFillWeights(DataGridView grid, params (string Column, float Weight)[] weights)
        {
            foreach (var (column, weight) in weights)
                SetColumnFillWeight(grid, column, weight);
        }

        public static void FormatDateColumns(DataGridView grid, params string[] columnNames)
        {
            foreach (string name in columnNames)
                if (grid.Columns.Contains(name))
                    grid.Columns[name].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
        }
    }
}
