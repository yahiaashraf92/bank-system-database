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
    public partial class loan_accept : Form
    {
        public loan_accept()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label2.Text = loan_request.SetValueForText1;
            label3.Text = loan_request.SetValueForText2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-300TPK7\\SQLEXPRESS;Initial Catalog=Bank System;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into BORROWER values (" + loan_request.SetValueForText2 + ", " + loan_request.SetValueForText1 + ", " + textBox1.Text + ")", con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
