using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Diagnostics;
using System.IO;


namespace Sample
{
    public partial class Form5 : Form
    {
        private DataTable currentReportTable = new DataTable();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            LoadReportChoices();
        }

        void LoadReportChoices()
        {
            cmbReport.Items.Clear();
            cmbReport.Items.Add("Athlete Report");
            cmbReport.Items.Add("Event Report");
            cmbReport.Items.Add("Result Report");
            cmbReport.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void About_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbReport.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a report type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = cmbReport.Text;

            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = "";

            switch (selectedReport)
            {
                case "Athlete Report":
                    sql = "SELECT * FROM athlete";
                    break;

                case "Event Report":
                    sql = @"
                        SELECT x`
                            e.EventID,
                            s.SportName,
                            v.VenueName,
                            e.EventDate,
                            e.Round
                        FROM events e
                        LEFT JOIN sport s ON e.SportID = s.SportID
                        LEFT JOIN venue v ON e.VenueID = v.VenueID";
                    break;

                case "Result Report":
                    sql = @"
                        SELECT 
                            r.ResultID,
                            a.AthleteID,
                            CONCAT(a.FirstName, ' ', a.LastName) AS AthleteName,
                            r.Position,
                            r.Medal
                        FROM result r
                        LEFT JOIN athlete a ON r.AthleteID = a.AthleteID";
                    break;
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            currentReportTable = dt;

            dgvReport.AutoGenerateColumns = true;
            dgvReport.DataSource = dt;
        }

        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.DataSource == null)
            {
                MessageBox.Show("No data to export.", "Export",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "SystemReport.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    // =========================
                    // SHEET 1 — REPORT DATA
                    // =========================
                    var ws = workbook.Worksheets.Add("Report");

                    int row = 1;

                    ws.Range("C1:F1").Merge();
                    ws.Cell("C1").Value = "PLAYON Sports Management System";

                    ws.Cell("C1").Style.Font.Bold = true;
                    ws.Cell("C1").Style.Font.FontSize = 20;
                    ws.Cell("C1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    row = 3;
                    ws.Cell(row, 1).Value = "SPORTS MANAGEMENT SYSTEM REPORT";
                    ws.Range(row, 1, row, dgvReport.Columns.Count).Merge();

                    ws.Cell(row, 1).Style.Font.Bold = true;
                    ws.Cell(row, 1).Style.Font.FontSize = 16;

                    row += 2;

                    try
                    {
                        string logoPath = Path.Combine(Application.StartupPath, "Images", "logo.png");

                        if (File.Exists(logoPath))
                        {
                            var image = ws.AddPicture(logoPath)
                                          .MoveTo(ws.Cell("A1"))
                                          .WithSize(80, 80);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Logo image not found.");
                    }

                    // DATA
                    for (int i = 0; i < dgvReport.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvReport.Columns.Count; j++)
                        {
                            ws.Cell(row + i, j + 1).Value =
                                dgvReport.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    int lastRow = row + dgvReport.Rows.Count + 2;

                    ws.Cell(lastRow, 1).Value = "Prepared by:";
                    ws.Cell(lastRow + 2, 1).Value = "______________________";
                    ws.Cell(lastRow + 3, 1).Value = "System Administrator";

                    ws.Columns().AdjustToContents();

                    // =========================
                    // SHEET 2 — STATISTICS ONLY (NO CHART CODE)
                    // =========================
                    var ws2 = workbook.Worksheets.Add("Statistics");

                    DataTable dt = (DataTable)dgvReport.DataSource;

                    ws2.Cell(1, 1).Value = "DISTRIBUTION ANALYSIS";
                    ws2.Cell(1, 1).Style.Font.Bold = true;
                    ws2.Cell(1, 1).Style.Font.FontSize = 14;

                    ws2.Cell(3, 1).Value = "Category";
                    ws2.Cell(3, 2).Value = "Count";


                    row = 4;

                    if (cmbReport.Text == "Athlete Report")
                    {
                        var grouped = dt.AsEnumerable()
                            .GroupBy(r => r["CollegeID"]?.ToString())
                            .Select(g => new
                            {
                                Category = g.Key ?? "Unknown",
                                Count = g.Count()
                            });

                        foreach (var item in grouped)
                        {
                            ws2.Cell(row, 1).Value = item.Category;
                            ws2.Cell(row, 2).Value = item.Count;
                            row++;
                        }
                    }
                    else if (cmbReport.Text == "Event Report")
                    {
                        var grouped = dt.AsEnumerable()
                            .GroupBy(r => r["SportName"]?.ToString())
                            .Select(g => new
                            {
                                Category = g.Key ?? "Unknown",
                                Count = g.Count()
                            });

                        foreach (var item in grouped)
                        {
                            ws2.Cell(row, 1).Value = item.Category;
                            ws2.Cell(row, 2).Value = item.Count;
                            row++;
                        }
                    }
                    else if (cmbReport.Text == "Result Report")
                    {
                        var grouped = dt.AsEnumerable()
                            .GroupBy(r => r["Medal"]?.ToString())
                            .Select(g => new
                            {
                                Category = g.Key ?? "No Medal",
                                Count = g.Count()
                            });

                        foreach (var item in grouped)
                        {
                            ws2.Cell(row, 1).Value = item.Category;
                            ws2.Cell(row, 2).Value = item.Count;
                            row++;
                        }
                    }

                    // =========================
                    // SAVE FILE
                    // =========================
                    workbook.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Excel exported successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
