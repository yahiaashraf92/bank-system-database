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
    public partial class Cutomer : Form
    {
        public Cutomer()
        {
            InitializeComponent();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into CUSTOMER values (" + SSN.Text + ", '" + Cust_Name.Text + "'," + Phone.Text + ", ' " +  City.Text +  " ' , ' " +  Street.Text +  "' )",  con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("UPdATE CUSTOMER SET cust_name =  '" + Cust_Name.Text + "', phone = " + Phone.Text + ", city =  ' " + City.Text + " ' ,  street = ' " + Street.Text + "'  where SSN = '" + SSN.Text + " ' ", con);

            cmd.ExecuteNonQuery();

            con.Close();

        }

        private void showList_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from CUSTOMER ", con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM CUSTOMER where SSN  =  '" + SSN.Text + " ' ", con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loan_request form8 = new loan_request();
            this.Hide();

            form8.ShowDialog();
            form8 = null;
            this.Show();
        }

        private void Cutomer_Load(object sender, EventArgs e)
        {

        }
    }
}
