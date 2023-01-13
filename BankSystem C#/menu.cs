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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee form6 = new Employee();

            this.Hide();
            form6.ShowDialog();
            form6 = null;
            this.Show();
        }

        private void inquiry_Click(object sender, EventArgs e)
        {
            inquiry form2 = new inquiry();
            
            this.Hide();
            form2.ShowDialog();
            form2 = null;
            this.Show();


        }

        private void Customer_Click(object sender, EventArgs e)
        {
            Cutomer form3 = new Cutomer();
            this.Hide();

            form3.ShowDialog();
            form3 = null;
            this.Show();


        }

        private void Admin_Click(object sender, EventArgs e)
        {
            admin form4 = new admin();
            this.Hide();

            form4.ShowDialog();
            form4 = null;
            this.Show();

        }
    }
}
