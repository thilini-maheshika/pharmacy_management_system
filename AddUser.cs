﻿using System;
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
    public partial class AddUser : Form
    {

        function fn = new function();
        String query;

        public AddUser()
        {
            InitializeComponent();
        }

        public AddUser(string username)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            String role = txtuserrole.Text;
            String name = txtname.Text; 
            String dob = txtdob.Text;
            Int64 mobile = Int64.Parse(txtmobile.Text);
            String email = txtemail.Text;
            String username = txtusername.Text;
            String password = txtpassword.Text;

            try{
                query = "insert into users (userRole ,name, dob, mobile,email,username,pass) values ('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + password + "' )";
                fn.setData(query, "Sign Up Successfully");
                clearAll();
            }
            catch(Exception)
            {
                MessageBox.Show("Username Already Exists!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtname.Clear();
            txtdob.ResetText();
            txtmobile.Clear();
            txtemail.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtuserrole.SelectedIndex = -1;
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + txtusername.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox2.ImageLocation = @"D:\\C#\\Pharmacy\\yes.png";
            }
            else
            {
                pictureBox2.ImageLocation = @"D:\\C#\\Pharmacy\\no.png";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Adminstrator ad = new Adminstrator(userlabel.Text);
            ad.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Close();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
