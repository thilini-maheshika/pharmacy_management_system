using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {

        function fn = new function();
        String query;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

            query = "select * from users";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if(txtusername.Text == "root" && txtpassword.Text == "root")
                {
                    Adminstrator admin = new Adminstrator("root");
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username = '" + txtusername.Text + "' and pass = '" + txtpassword.Text + "'";
                ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    String username = ds.Tables[0].Rows[0][2].ToString();
                    if (role == "Adminstrator")
                    {
                        Adminstrator admin = new Adminstrator(username);
                        admin.Show();
                        this.Hide();

                    }else if (role == "Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

            // Set the PasswordChar property to '*' programmatically
            txtpassword.PasswordChar = '*';
        }
    }
}
