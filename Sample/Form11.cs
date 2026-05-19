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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();

            cboRole.Items.Clear();
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("User");

            cboSecurityQ.Items.Clear();
            cboSecurityQ.Items.Add("What is the name of your first pet?");
            cboSecurityQ.Items.Add("What city were you born in?");
            cboSecurityQ.Items.Add("What is your mother's maiden name?");
            cboSecurityQ.Items.Add("What was the name of your first school?");
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string role = cboRole.Text;
            string securityQ = cboSecurityQ.Text;
            string securityA = txtSecurityA.Text.Trim();

            if (firstName == "" || lastName == "" || email == "" ||
                password == "" || role == "" || securityQ == "" || securityA == "")
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Check duplicate email
                var check = new MySqlCommand("SELECT COUNT(*) FROM users WHERE Email=@e", conn);
                check.Parameters.AddWithValue("@e", email);
                if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("An account with this email already exists.", "Duplicate Email",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cmd = new MySqlCommand(
                    @"INSERT INTO users (Email, Password, FirstName, LastName, Role, Status, SecurityQ, SecurityA)
                      VALUES (@e, @p, @fn, @ln, @r, 1, @sq, @sa)", conn);

                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@fn", firstName);
                cmd.Parameters.AddWithValue("@ln", lastName);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.Parameters.AddWithValue("@sq", securityQ);
                cmd.Parameters.AddWithValue("@sa", securityA);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();

        }
    }
}
