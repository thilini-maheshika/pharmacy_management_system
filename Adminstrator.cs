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
    public partial class Adminstrator : Form
    {
        function fn = new function();
        String query;

        public Adminstrator()
        {
            InitializeComponent();
        }

        private string loggedInUsername;

        public Adminstrator(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            lblLoggedInUser.Text = loggedInUsername;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the Profile form and pass the logged-in username
            Profile profileForm = new Profile(loggedInUsername);
            profileForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Dashboard dashboardForm = new Dashboard(lblLoggedInUser.Text);
            dashboardForm.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            AddUser adduserForm = new AddUser(lblLoggedInUser.Text);
            adduserForm.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            ViewUser viewuserForm = new ViewUser(lblLoggedInUser.Text);
            viewuserForm.Show();
        }
    }
}
