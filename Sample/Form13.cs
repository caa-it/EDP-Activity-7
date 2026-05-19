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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            LoadDashboardCounts();
        }

        void LoadDashboardCounts()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Total athletes
                label7.Text = GetCount(conn, "SELECT COUNT(*) FROM athlete").ToString();

                // Medal results
                label4.Text = GetCount(conn, "SELECT COUNT(*) FROM result").ToString();

                // Scheduled events
                label6.Text = GetCount(conn, "SELECT COUNT(*) FROM events").ToString();

                // Colleges
                label12.Text = GetCount(conn, "SELECT COUNT(*) FROM college").ToString();

                // Sports
                label10.Text = GetCount(conn, "SELECT COUNT(*) FROM sport").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard load error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int GetCount(MySqlConnection conn, string sql)
        {
            var cmd = new MySqlCommand(sql, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void button12_Click_1(object sender, EventArgs e)
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
