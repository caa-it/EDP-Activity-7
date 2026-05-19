using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sample
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            LoadSports();
            LoadVenues();
            LoadRounds();
            LoadEvents();
        }

        void LoadSports()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = "SELECT SportID, SportName FROM sport";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbSport.DataSource = dt;
            cmbSport.DisplayMember = "SportName";
            cmbSport.ValueMember = "SportID";
            cmbSport.SelectedIndex = -1;
        }

        void LoadVenues()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = "SELECT VenueID, VenueName FROM venue";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbVenue.DataSource = dt;
            cmbVenue.DisplayMember = "VenueName";
            cmbVenue.ValueMember = "VenueID";
            cmbVenue.SelectedIndex = -1;
        }

        void LoadRounds()
        {
            cmbRound.Items.Clear();

            cmbRound.Items.Add("Elimination");
            cmbRound.Items.Add("Quarter Finals");
            cmbRound.Items.Add("Semi Finals");
            cmbRound.Items.Add("Finals");

            cmbRound.SelectedIndex = -1;
        }

        void LoadEvents()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = @"
                SELECT 
                    e.EventID,
                    s.SportName,
                    v.VenueName,
                    e.EventDate,
                    e.Round
                FROM events e
                LEFT JOIN sport s
                    ON e.SportID = s.SportID
                LEFT JOIN venue v
                    ON e.VenueID = v.VenueID";

            MySqlDataAdapter adapter =
                new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvEvents.AutoGenerateColumns = true;
            dgvEvents.DataSource = dt;
        }

        private void cmbSport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRound_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text == "" ||
              cmbSport.SelectedIndex == -1 ||
              cmbVenue.SelectedIndex == -1 ||
              cmbRound.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = @"
                INSERT INTO events
                (EventID, SportID, VenueID, EventDate, Round)
                VALUES
                (@id, @sport, @venue, @date, @round)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id",
                int.Parse(txtEventID.Text));

            cmd.Parameters.AddWithValue("@sport",
                Convert.ToInt32(cmbSport.SelectedValue));

            cmd.Parameters.AddWithValue("@venue",
                Convert.ToInt32(cmbVenue.SelectedValue));

            cmd.Parameters.AddWithValue("@date",
                dtpDate.Value.Date);

            cmd.Parameters.AddWithValue("@round",
                cmbRound.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show(
                "Event added successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadEvents();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text == "")
            {
                MessageBox.Show(
                    "Please select an event.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = @"
                UPDATE events
                SET SportID = @sport,
                    VenueID = @venue,
                    EventDate = @date,
                    Round = @round
                WHERE EventID = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@sport",
                Convert.ToInt32(cmbSport.SelectedValue));

            cmd.Parameters.AddWithValue("@venue",
                Convert.ToInt32(cmbVenue.SelectedValue));

            cmd.Parameters.AddWithValue("@date",
                dtpDate.Value.Date);

            cmd.Parameters.AddWithValue("@round",
                cmbRound.Text);

            cmd.Parameters.AddWithValue("@id",
                int.Parse(txtEventID.Text));

            cmd.ExecuteNonQuery();

            MessageBox.Show(
                "Event updated successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadEvents();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text == "")
            {
                MessageBox.Show(
                    "Please select an event.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (MessageBox.Show(
                "Are you sure you want to delete this event?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using var conn = DBConnection.GetConnection();
                    conn.Open();

                    string sql =
                        "DELETE FROM events WHERE EventID = @id";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id",
                        int.Parse(txtEventID.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Event deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadEvents();
                    ClearFields();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            txtEventID.Text = "";
            cmbSport.SelectedIndex = -1;
            cmbVenue.SelectedIndex = -1;
            cmbRound.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row =
                dgvEvents.Rows[e.RowIndex];

            txtEventID.Text =
                row.Cells["EventID"].Value?.ToString() ?? "";

            cmbSport.Text =
                row.Cells["SportName"].Value?.ToString() ?? "";

            cmbVenue.Text =
                row.Cells["VenueName"].Value?.ToString() ?? "";

            cmbRound.Text =
                row.Cells["Round"].Value?.ToString() ?? "";

            if (DateTime.TryParse(
                row.Cells["EventDate"].Value?.ToString(),
                out DateTime eventDate))
            {
                dtpDate.Value = eventDate;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
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
