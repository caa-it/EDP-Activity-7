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
    public partial class Form10 : Form
    {
        DataTable accountsTable = new DataTable();
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadRoles();
        }

        void LoadRoles()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("User");
            cmbRole.SelectedIndex = -1;
        }
        private void LoadAccounts()
        {
            try
            {
                using var conn = DBConnection.GetConnection();

                conn.Open();

                var cmd = new MySqlCommand(
                    @"SELECT
                        UserID,
                        FirstName,
                        LastName,
                        Email,
                        Role,
                        CASE
                            WHEN Status = 1 THEN 'Active'
                            ELSE 'Inactive'
                        END AS Status
                      FROM users",
                    conn
                );

                var adapter = new MySqlDataAdapter(cmd);

                accountsTable = new DataTable();

                adapter.Fill(accountsTable);

                dgvAccounts.DataSource = accountsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvAccounts.Rows[e.RowIndex];

            txtUserID.Text = row.Cells[0].Value?.ToString() ?? "";
            txtFirstName.Text = row.Cells[1].Value?.ToString() ?? "";
            txtLastName.Text = row.Cells[2].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells[3].Value?.ToString() ?? "";
            txtPassword.Text = row.Cells[4].Value?.ToString() ?? "";
            cmbRole.Text = row.Cells[5].Value?.ToString() ?? "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" ||
              txtFirstName.Text == "" ||
              txtLastName.Text == "" ||
              txtEmail.Text == "" ||
              txtPassword.Text == "" ||
              cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                string sql = @"INSERT INTO users
                               (UserID, FirstName, LastName, Email, Password, Role, Status)
                               VALUES
                               (@id, @fn, @ln, @em, @pw, @role, @status)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(txtUserID.Text));
                cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
                cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                cmd.Parameters.AddWithValue("@status", 1);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAccounts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("Please select an account to update.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                string sql = @"UPDATE users
                               SET FirstName = @fn,
                                   LastName = @ln,
                                   Email = @em,
                                   Password = @pw,
                                   Role = @role
                               WHERE UserID = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
                cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtUserID.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAccounts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtUserID.Text == "")
            {
                MessageBox.Show("Please select an account to delete.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this account?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using var conn = DBConnection.GetConnection();
                    conn.Open();

                    string sql = "DELETE FROM users WHERE UserID = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtUserID.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account deleted successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAccounts();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete error: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
