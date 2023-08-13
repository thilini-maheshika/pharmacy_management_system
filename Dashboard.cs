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
    public partial class Dashboard : Form
    {

        function fn = new function();
        String query;
        DataSet ds;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string username)
        {
            InitializeComponent();
            userName.Text = username;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole = 'Adminstrator'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);

            query = "select count(userRole) from users where userRole = 'Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, PharLabel);
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Dashboard dashboardForm = new Dashboard(userName.Text);
            dashboardForm.Show();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            AddUser adduserForm = new AddUser(userName.Text);
            adduserForm.Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            ViewUser viewuserForm = new ViewUser(userName.Text);
            viewuserForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Adminstrator ad = new Adminstrator(userName.Text);
            ad.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Profile pro = new Profile(userName.Text);
            pro.Show();
        }

        private void loadingbtn_Click(object sender, EventArgs e)
        {
            Dashboard_Load(this, null);
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Close();
        }
    }
}
