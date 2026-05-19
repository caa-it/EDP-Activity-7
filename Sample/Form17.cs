using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Sample
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        private void Form17_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            LoadAthletes();
            LoadPositions();
            LoadResults();
        }

        void LoadAthletes()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = @"SELECT AthleteID,
                                  CONCAT(FirstName, ' ', LastName) AS AthleteName
                           FROM athlete";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbAthlete.DataSource = dt;
            cmbAthlete.DisplayMember = "AthleteName";
            cmbAthlete.ValueMember = "AthleteID";
            cmbAthlete.SelectedIndex = -1;
        }


        void LoadPositions()
        {
            cmbPosition.Items.Clear();

            cmbPosition.Items.Add(1);
            cmbPosition.Items.Add(2);
            cmbPosition.Items.Add(3);

            cmbPosition.SelectedIndex = -1;
        }


        void LoadResults()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = @"
        SELECT
            r.ResultID,
            r.AthleteID,
            CONCAT(a.FirstName, ' ', a.LastName) AS Athlete,
            r.Position,
            r.Medal
        FROM result r
        LEFT JOIN athlete a
            ON r.AthleteID = a.AthleteID";

            MySqlDataAdapter adapter =
                new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvResults.AutoGenerateColumns = true;
            dgvResults.DataSource = dt;


            var colAthlete = dgvResults.Columns["AthleteID"];
            if (colAthlete != null)
            {
                colAthlete.Visible = false;
            }
        }


        private void txtResultID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtResultID.Text == "" ||
               cmbAthlete.SelectedIndex == -1 ||
               cmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = @"
    INSERT INTO result
    (ResultID, AthleteID, Position)
    VALUES
    (@rid, @aid, @pos)";

            MySqlCommand cmd =
                new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@rid", int.Parse(txtResultID.Text));

            cmd.Parameters.AddWithValue("@aid", Convert.ToInt32(cmbAthlete.SelectedValue));

            cmd.Parameters.AddWithValue("@pos", int.Parse(cmbPosition.Text));

            cmd.ExecuteNonQuery();

            MessageBox.Show(
                "Result added successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Trigger automatically assigns medal
            LoadResults();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            txtResultID.Text = "";
            cmbAthlete.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
        }
        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvResults.Rows[e.RowIndex];

            txtResultID.Text = row.Cells["ResultID"].Value?.ToString() ?? "";

            cmbAthlete.SelectedValue = row.Cells["AthleteID"].Value!;

            cmbPosition.Text = row.Cells["Position"].Value?.ToString() ?? "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
