using Guna.UI.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ViewUser : Form
    {

        function fn = new function();
        String query;

        public ViewUser()
        {
            InitializeComponent();
        }

        public ViewUser(string username)
        {
            InitializeComponent();
            userlabel.Text = username;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Adminstrator ad = new Adminstrator(userlabel.Text);
            ad.Show();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Dashboard dashboardForm = new Dashboard(userlabel.Text);
            dashboardForm.Show();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            AddUser adduserForm = new AddUser(userlabel.Text);
            adduserForm.Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            ViewUser viewuserForm = new ViewUser(userlabel.Text);
            viewuserForm.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Profile pro = new Profile(userlabel.Text);
            pro.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Close();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '" + txtusername.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        String username;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

                username = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM users WHERE username = '" + username + "'";
                fn.setData(query, "User Record Deleted Successfully!!");
                ViewUser_Load(this, null);
            }

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
