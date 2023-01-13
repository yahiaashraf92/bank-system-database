namespace BankSystem
{
    partial class inquiry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.no_employee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no_customer = new System.Windows.Forms.Button();
            this.noloans = new System.Windows.Forms.Button();
            this.loans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // no_employee
            // 
            this.no_employee.Location = new System.Drawing.Point(23, 116);
            this.no_employee.Name = "no_employee";
            this.no_employee.Size = new System.Drawing.Size(227, 23);
            this.no_employee.TabIndex = 0;
            this.no_employee.Text = "Branches with no employee";
            this.no_employee.UseVisualStyleBackColor = true;
            this.no_employee.Click += new System.EventHandler(this.no_employee_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Customer with  the max No of loans";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(23, 348);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(227, 23);
            this.customer.TabIndex = 2;
            this.customer.Text = "All Customer information";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 450);
            this.dataGridView1.TabIndex = 3;
            // 
            // no_customer
            // 
            this.no_customer.Location = new System.Drawing.Point(23, 52);
            this.no_customer.Name = "no_customer";
            this.no_customer.Size = new System.Drawing.Size(227, 23);
            this.no_customer.TabIndex = 4;
            this.no_customer.Text = "Branch with no customer";
            this.no_customer.UseVisualStyleBackColor = true;
            this.no_customer.Click += new System.EventHandler(this.no_customer_Click);
            // 
            // noloans
            // 
            this.noloans.Location = new System.Drawing.Point(23, 292);
            this.noloans.Name = "noloans";
            this.noloans.Size = new System.Drawing.Size(227, 23);
            this.noloans.TabIndex = 5;
            this.noloans.Text = "Customer with no  loans";
            this.noloans.UseVisualStyleBackColor = true;
            this.noloans.Click += new System.EventHandler(this.noloans_Click);
            // 
            // loans
            // 
            this.loans.Location = new System.Drawing.Point(23, 177);
            this.loans.Name = "loans";
            this.loans.Size = new System.Drawing.Size(227, 23);
            this.loans.TabIndex = 6;
            this.loans.Text = "Employee with max no of loans";
            this.loans.UseVisualStyleBackColor = true;
            this.loans.Click += new System.EventHandler(this.loans_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loans);
            this.Controls.Add(this.noloans);
            this.Controls.Add(this.no_customer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.no_employee);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button no_employee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button no_customer;
        private System.Windows.Forms.Button noloans;
        private System.Windows.Forms.Button loans;
    }
}