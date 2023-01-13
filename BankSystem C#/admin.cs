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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into BANK values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from BANK ", con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Branch form5 = new Branch();
            this.Hide();

            form5.ShowDialog();
            form5 = null;
            this.Show();
        }
    }
}
