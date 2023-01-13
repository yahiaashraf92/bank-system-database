namespace BankSystem
{
    partial class menu
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
            this.Customer = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.inquiry = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(26, 195);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(88, 23);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(187, 195);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(108, 23);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // inquiry
            // 
            this.inquiry.Location = new System.Drawing.Point(527, 195);
            this.inquiry.Name = "inquiry";
            this.inquiry.Size = new System.Drawing.Size(75, 23);
            this.inquiry.TabIndex = 2;
            this.inquiry.Text = "inquiry";
            this.inquiry.UseVisualStyleBackColor = true;
            this.inquiry.Click += new System.EventHandler(this.inquiry_Click);
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(375, 195);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(75, 23);
            this.Admin.TabIndex = 3;
            this.Admin.Text = "admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 393);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.inquiry);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Customer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button inquiry;
        private System.Windows.Forms.Button Admin;
    }
}

