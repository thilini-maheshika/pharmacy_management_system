using System;
using System.Collections;
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
    public partial class Profile : Form
    {
        function fn = new function();
        String query;

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(string username)
        {
            InitializeComponent();
            labelUsername.Text = username;
            setProfile();
        }

        public void setProfile()
        {
            query = "select * from users where username = '" + labelUsername.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtuserrole.Text = ds.Tables[0].Rows[0][1].ToString();
                txtname.Text = ds.Tables[0].Rows[0][2].ToString();
                txtdob.Text = ds.Tables[0].Rows[0][3].ToString();
                txtmobile.Text = ds.Tables[0].Rows[0][4].ToString();
                txtemail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtpassword.Text = ds.Tables[0].Rows[0][7].ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Adminstrator ad = new Adminstrator(labelUsername.Text);
            ad.Show();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Dashboard dashboardForm = new Dashboard(labelUsername.Text);
            dashboardForm.Show();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            AddUser adduserForm = new AddUser(labelUsername.Text);
            adduserForm.Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            ViewUser viewuserForm = new ViewUser(labelUsername.Text);
            viewuserForm.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            // Show the DashboardForm
            Profile pro = new Profile(labelUsername.Text);
            pro.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Close();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            String role = txtuserrole.Text;
            String name = txtname.Text;
            String dob = txtdob.Text;
            String mobile = txtmobile.Text;
            String email = txtemail.Text;
            String username = labelUsername.Text;
            String password = txtpassword.Text;

            query = "update users set userRole = '"+role+"', name = '"+name+"' , dob = '"+dob+"' , mobile = '"+mobile+"' , email = '"+email+"' ,  pass = '"+password+"' where username = '"+username+"' ";
            fn.setData(query, "Profile Updated Successfully!");
        }

        private void labelUsername_Enter(object sender, EventArgs e)
        {
            
        }

        private void ResetForm()
        {
            setProfile();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
