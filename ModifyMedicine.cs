using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class ModifyMedicine : Form
    {
        function fn = new function();
        String query;

        public ModifyMedicine()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtMediID.Text != "")
            {
                query = "select * from medic where mid ='" + txtMediID.Text + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMediName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMediNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtManuDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtExpDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtQty.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No medicine with ID : " + txtMediID.Text + " exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtManuDate.ResetText();
            txtExpDate.ResetText();
            txtQty.Clear();
            txtPrice.Clear();

            if (txtaddqty.Text != "0")
            {
                txtaddqty.Text = "0";
            }
            else
            {
                txtaddqty.Text = "0";
            }
        }

        Int64 totalqty;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMediName.Text;
            String mnumber = txtMediNumber.Text;
            String mdate = txtManuDate.Text;
            String edate = txtExpDate.Text;
            Int64 qty = Int64.Parse(txtQty.Text);
            Int64 addqty = Int64.Parse(txtaddqty.Text);
            Int64 unitprice = Int64.Parse(txtPrice.Text);

            totalqty = qty + addqty;

            query = "update medic set mname = '" + mname + "' ,mnumber ='" + mnumber + "' , mDate ='" + mdate + "',eDate ='" + edate + "' ,quantity ='" + totalqty + "',perUnit = '" + unitprice + "' where mid = '" + txtMediID.Text + "' ";
            fn.setData(query, "Data Updated Successfully!!");
            clearAll();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pharmacist dashboardForm = new Pharmacist();
            dashboardForm.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pharmacist dashboardForm = new Pharmacist();
            dashboardForm.Show();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddMedicine add = new AddMedicine();
            add.Show();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewMedicine vm = new ViewMedicine();
            vm.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.Hide();

            ModifyMedicine mm = new ModifyMedicine();
            mm.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            SellMedicine sm = new SellMedicine();
            sm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Close();
        }
    }
}
