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
    public partial class Form14 : Form
    {

        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            LoadColleges();
            LoadYearLevels();
            LoadAthletes();

        }

        void LoadColleges()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            string sql = "SELECT CollegeID, CollegeName FROM college";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAthletes.AutoGenerateColumns = true;
            cmbCollege.DataSource = dt;
            cmbCollege.DisplayMember = "CollegeName";
            cmbCollege.ValueMember = "CollegeID";
            cmbCollege.SelectedIndex = -1;
        }

        void LoadYearLevels()
        {
            cmbYear.Items.Clear();
            cmbYear.Items.Add(1);
            cmbYear.Items.Add(2);
            cmbYear.Items.Add(3);
            cmbYear.Items.Add(4);
            cmbYear.SelectedIndex = -1;
        }

        void LoadAthletes()
        {


            using var conn = DBConnection.GetConnection();
            conn.Open();

            string sql = @"SELECT a.AthleteID,
                      a.LastName,
                      a.FirstName,
                      a.MiddleName,
                      a.YearLevel,
                      c.CollegeName
               FROM athlete a
               LEFT JOIN college c
               ON a.CollegeID = c.CollegeID";

            MySqlDataAdapter adapter =
                new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dgvAthletes.AutoGenerateColumns = true;
            dgvAthletes.DataSource = dt;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (txtAthleteID.Text == "" || txtFirstName.Text == "" ||
                txtLastName.Text == "" || cmbCollege.SelectedIndex == -1 ||
                cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var conn = DBConnection.GetConnection();
            conn.Open();

            // FIX: correct column names are CollegeID and YearLevel, not College and Year
            string sql = @"INSERT INTO athlete (AthleteID, LastName, FirstName, MiddleName, YearLevel, CollegeID)
                           VALUES (@id, @ln, @fn, @mn, @yr, @col)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtAthleteID.Text));
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@mn", txtMiddleName.Text);
            // FIX: send integer values, not text
            cmd.Parameters.AddWithValue("@yr", int.Parse(cmbYear.Text));
            if (cmbCollege.SelectedValue == null)
            {
                MessageBox.Show("Please select a college.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cmd.Parameters.AddWithValue("@col", int.Parse(cmbCollege.SelectedValue.ToString()!));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Athlete added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAthletes();
            ClearFields();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAthleteID.Text == "")
            {
                MessageBox.Show("Please select an athlete to update.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var conn = DBConnection.GetConnection();
            conn.Open();

            // FIX: correct column names CollegeID and YearLevel
            string sql = @"UPDATE athlete
                           SET LastName   = @ln,
                               FirstName  = @fn,
                               MiddleName = @mn,
                               YearLevel  = @yr,
                               CollegeID  = @col
                           WHERE AthleteID = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@mn", txtMiddleName.Text);
            // FIX: send integer values, not text
            cmd.Parameters.AddWithValue("@yr", int.Parse(cmbYear.Text));
            if (cmbCollege.SelectedValue == null)
            {
                MessageBox.Show("Please select a college.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cmd.Parameters.AddWithValue("@col", int.Parse(cmbCollege.SelectedValue.ToString()!));
            cmd.Parameters.AddWithValue("@id", int.Parse(txtAthleteID.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Athlete updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAthletes();
            ClearFields();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAthleteID.Text == "")
            {
                MessageBox.Show("Please select an athlete to delete.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this athlete?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using var conn = DBConnection.GetConnection();
                    conn.Open();
                    string sql = "DELETE FROM athlete WHERE AthleteID = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtAthleteID.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Athlete deleted successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAthletes();
                    ClearFields();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(
                        "Cannot delete this athlete. They may have existing records in other tables.\n\nDetails: " + ex.Message,
                        "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            txtAthleteID.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";  // FIX: was missing in btnClear
            txtLastName.Text = "";
            cmbCollege.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
        }

        private void dgvAthletes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // blocks header row clicks

            DataGridViewRow row = dgvAthletes.Rows[e.RowIndex];

            string athleteIDStr = row.Cells["AthleteID"].Value?.ToString() ?? "";
            if (!int.TryParse(athleteIDStr, out int athleteID)) return; // blocks empty rows

            txtAthleteID.Text = athleteIDStr;
            txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
            txtMiddleName.Text = row.Cells["MiddleName"].Value?.ToString() ?? "";
            cmbYear.Text = row.Cells["YearLevel"].Value?.ToString() ?? "";

            using var conn = DBConnection.GetConnection();
            conn.Open();
            string sql = "SELECT CollegeID FROM athlete WHERE AthleteID = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", athleteID); // use the already-parsed int
            object result = cmd.ExecuteScalar();
            if (result != null)
                cmbCollege.SelectedValue = result;
        }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void txtAthleteID_TextChanged(object sender, EventArgs e) { }
        private void txtFirstName_TextChanged(object sender, EventArgs e) { }
        private void txtMiddleName_TextChanged(object sender, EventArgs e) { }
        private void txtLastName_TextChanged(object sender, EventArgs e) { }
        private void cmbCollege_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button9_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
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

        private void button10_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
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
