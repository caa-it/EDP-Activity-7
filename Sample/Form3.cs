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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string pass = textBox2.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter email and password.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                string sql = "SELECT UserID, Role, Status FROM users WHERE Email=@e AND Password=@p";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@p", pass);

                using var rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    int status = rdr.GetInt32("Status");
                    string role = rdr["Role"].ToString() ?? "";

                    if (status == 0)
                    {
                        MessageBox.Show("Your account is inactive. Contact the administrator.",
                            "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    rdr.Close();

                    // Route by role: Admin goes to admin panel, User goes to dashboard
                    if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        Form10 form10 = new Form10();
                        form10.Show();
                    }
                    else
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox1.PlaceholderText = "Email address";
            textBox2.PlaceholderText = "Password";
        }
    }
}
