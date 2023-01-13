using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSystem
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into EMPLOYEE values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("delete from EMPLOYEE where EMP_ID = " + textBox1.Text , con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loan form7 = new loan();

            this.Hide();
            form7.ShowDialog();
            form7 = null;
            this.Show();
        }
    }
}
