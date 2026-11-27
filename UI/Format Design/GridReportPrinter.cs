using System.Drawing.Printing;

namespace UI
{
    internal static class GridReportPrinter
    {
        private const float CellPadding = 8f;

        public static void Print(DataGridView grid, string title, string subtitle, params string[] footerLines)
        {
            var columns = grid.Columns.Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .OrderBy(c => c.DisplayIndex)
                .ToList();
            var rows = grid.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).ToList();

            if (rows.Count == 0)
            {
                MessageBox.Show("There are no records to print.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] headers = columns.Select(c => c.HeaderText).ToArray();
            string[][] cellText = rows
                .Select(r => columns.Select(c => r.Cells[c.Index].FormattedValue?.ToString() ?? "").ToArray())
                .ToArray();
            bool[] rightAligned = columns
                .Select(c => c.DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleRight || IsNumeric(c.ValueType))
                .ToArray();

            using var headerFont = new Font("Arial", 14, FontStyle.Bold);
            using var subHeaderFont = new Font("Arial", 10);
            using var tableHeaderFont = new Font("Arial", 8.5f, FontStyle.Bold);
            using var tableFont = new Font("Arial", 8.5f);

            var printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Margins = new Margins(30, 30, 30, 30);

            float[] natural = MeasureNaturalWidths(headers, cellText, tableHeaderFont, tableFont);
            var portrait = printDoc.DefaultPageSettings;
            float portraitWidth = portrait.PaperSize.Width - portrait.Margins.Left - portrait.Margins.Right;
            printDoc.DefaultPageSettings.Landscape = natural.Sum() > portraitWidth;

            int currentRow = 0;
            printDoc.BeginPrint += (s, e) => currentRow = 0;

            printDoc.PrintPage += (s, e) =>
            {
                Graphics g = e.Graphics!;
                float left = e.MarginBounds.Left;
                float width = e.MarginBounds.Width;
                float y = e.MarginBounds.Top;
                float bottom = e.MarginBounds.Bottom;
                var center = new StringFormat { Alignment = StringAlignment.Center };

                if (currentRow == 0)
                {
                    g.DrawString("Homexa", headerFont, Brushes.Black, left + width / 2, y, center);
                    y += headerFont.Height + 4;
                    g.DrawString(title.ToUpper(), subHeaderFont, Brushes.Black, left + width / 2, y, center);
                    y += subHeaderFont.Height + 2;
                    if (!string.IsNullOrEmpty(subtitle))
                    {
                        g.DrawString(subtitle, subHeaderFont, Brushes.Black, left + width / 2, y, center);
                        y += subHeaderFont.Height + 2;
                    }
                    g.DrawString($"Generated: {DateTime.Now:MMMM dd, yyyy hh:mm tt}", subHeaderFont, Brushes.Black, left + width / 2, y, center);
                    y += subHeaderFont.Height + 10;
                }

                float[] widths = FitWidths(natural, width);
                float[] xs = new float[widths.Length];
                for (int i = 1; i < widths.Length; i++)
                    xs[i] = xs[i - 1] + widths[i - 1];
                for (int i = 0; i < xs.Length; i++)
                    xs[i] += left;

                float headerHeight = RowHeight(g, headers, tableHeaderFont, widths);
                g.DrawLine(Pens.Black, left, y, left + width, y);
                y += 3;
                for (int i = 0; i < headers.Length; i++)
                    DrawCell(g, headers[i], tableHeaderFont, xs[i], widths[i], y, headerHeight, rightAligned[i]);
                y += headerHeight;
                g.DrawLine(Pens.Black, left, y, left + width, y);
                y += 3;

                float footerSpace = (tableHeaderFont.Height + 6) * (footerLines.Length + 1);
                bool firstOnPage = true;
                while (currentRow < cellText.Length)
                {
                    float rowHeight = RowHeight(g, cellText[currentRow], tableFont, widths);
                    if (!firstOnPage && y + rowHeight > bottom - footerSpace)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    for (int i = 0; i < widths.Length; i++)
                        DrawCell(g, cellText[currentRow][i], tableFont, xs[i], widths[i], y, rowHeight, rightAligned[i]);
                    y += rowHeight;
                    g.DrawLine(Pens.Gainsboro, left, y, left + width, y);
                    currentRow++;
                    firstOnPage = false;
                }

                y += 6;
                g.DrawLine(Pens.Black, left, y, left + width, y);
                y += 8;
                var rightFormat = new StringFormat { Alignment = StringAlignment.Far };
                foreach (string line in footerLines)
                {
                    g.DrawString(line, tableHeaderFont, Brushes.Black, left + width, y, rightFormat);
                    y += tableHeaderFont.Height + 6;
                }
                e.HasMorePages = false;
            };

            using var preview = new PrintPreviewDialog { Document = printDoc, Width = 1000, Height = 750 };
            preview.ShowDialog();
        }

        private static float[] MeasureNaturalWidths(string[] headers, string[][] cells, Font headerFont, Font font)
        {
            using var bmp = new Bitmap(1, 1);
            using var g = Graphics.FromImage(bmp);
            g.PageUnit = GraphicsUnit.Display;
            g.PageScale = 1f;
            float scale = 100f / g.DpiX;

            var widths = new float[headers.Length];
            for (int i = 0; i < headers.Length; i++)
            {
                float w = g.MeasureString(headers[i], headerFont).Width;
                foreach (var row in cells)
                    w = Math.Max(w, g.MeasureString(row[i], font).Width);
                widths[i] = w * scale + CellPadding + 2;
            }
            return widths;
        }

        internal static float[] FitWidths(float[] natural, float available)
        {
            float total = natural.Sum();
            if (total <= available)
                return natural.Select(w => w * available / total).ToArray();

            var result = new float[natural.Length];
            var open = Enumerable.Range(0, natural.Length).ToList();
            float remaining = available;
            while (true)
            {
                float share = remaining / open.Count;
                var fits = open.Where(i => natural[i] <= share).ToList();
                if (fits.Count == 0)
                {
                    float openTotal = open.Sum(i => natural[i]);
                    foreach (int i in open) result[i] = remaining * natural[i] / openTotal;
                    System.Diagnostics.Debug.Assert(Math.Abs(result.Sum() - available) < 1f, "columns must fill the page width exactly");
                    return result;
                }
                foreach (int i in fits)
                {
                    result[i] = natural[i];
                    remaining -= natural[i];
                    open.Remove(i);
                }
                if (open.Count == 0) return result;
            }
        }

        private static float RowHeight(Graphics g, string[] texts, Font font, float[] widths)
        {
            float h = font.GetHeight(g);
            for (int i = 0; i < texts.Length; i++)
                h = Math.Max(h, g.MeasureString(texts[i], font, (int)Math.Max(1, widths[i] - CellPadding)).Height);
            return h + 6;
        }

        private static void DrawCell(Graphics g, string text, Font font, float x, float w, float y, float h, bool right)
        {
            var format = new StringFormat
            {
                Alignment = right ? StringAlignment.Far : StringAlignment.Near,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.Character
            };
            g.DrawString(text, font, Brushes.Black, new RectangleF(x + CellPadding / 2, y, w - CellPadding, h), format);
        }

        private static bool IsNumeric(Type? t) =>
            t == typeof(int) || t == typeof(long) || t == typeof(decimal) || t == typeof(double) || t == typeof(float);
    }
}
