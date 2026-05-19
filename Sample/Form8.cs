using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sample
{
    public partial class Form8 : Form
    {
        private string _email;

        public Form8(string email)
        {
            InitializeComponent();
            _email = email;
            LoadSecurityQuestion();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void LoadSecurityQuestion()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                var cmd = new MySqlCommand(
                    "SELECT SecurityQ FROM users WHERE Email=@e AND Status=1", conn);
                cmd.Parameters.AddWithValue("@e", _email);

                var question = cmd.ExecuteScalar()?.ToString();

                if (question != null)
                    label12.Text = question;
                else
                {
                    MessageBox.Show("No security question found for this account.",
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string answer = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please enter your answer.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                var cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM users WHERE Email=@e AND SecurityA=@a AND Status=1", conn);
                cmd.Parameters.AddWithValue("@e", _email);
                cmd.Parameters.AddWithValue("@a", answer);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Incorrect answer. Please try again.", "Wrong Answer",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Clear();
                    textBox2.Focus();
                    return;
                }

                Form9 form9 = new Form9(_email);
                form9.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }

}

