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
    public partial class Form9 : Form
    {
        private string _email;

        public Form9(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newPassword = textBox1.Text;
            string confirmPassword = textBox2.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a new password.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Clear();
                textBox2.Focus();
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                
                var upd = new MySqlCommand(
                    "UPDATE users SET Password=@p WHERE Email=@e", conn);
                upd.Parameters.AddWithValue("@p", newPassword);
                upd.Parameters.AddWithValue("@e", _email);
                upd.ExecuteNonQuery();

                MessageBox.Show("Password reset successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new Form3().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                var cmd = new MySqlCommand(
                    "SELECT SecurityQ FROM users WHERE Email=@e", conn);
                cmd.Parameters.AddWithValue("@e", _email);
                var question = cmd.ExecuteScalar()?.ToString() ?? string.Empty;

                new Form8(_email).Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
