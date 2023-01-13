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
    public partial class loan : Form
    {
        public loan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select b.LOAN_NUM , b.SSN , l.LOAN_TYPE , c.CUST_NAME , e.EMP_NAME from BORROWER as b left join LOAN as l on b.LOAN_NUM = l.LOAN_NUM left join CUSTOMER as c on b.SSN = c.SSN left join EMPLOYEE as e on b.EMP_ID = e.EMP_ID", con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from LOAN", con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }
    }
}
