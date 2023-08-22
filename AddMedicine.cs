using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Management_System
{
    public partial class AddMedicine : Form
    {
        function fn = new function();
        String query;

        public AddMedicine()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pharmacist pm = new Pharmacist();
            pm.Show();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMediID.Text!= "" && txtMediName.Text!= "" && txtMediNumber.Text!="" && txtQty.Text!="" && txtPrice.Text != "")
            {
                String mid = txtMediID.Text;
                String mname = txtMediName.Text;
                String mnumber = txtMediNumber.Text;
                String mdate = txtManuDate.Text;
                String edate = txtExpDate.Text;
                Int64 qty = Int64.Parse(txtQty.Text);
                Int64 perunit = Int64.Parse(txtPrice.Text);

                query = "insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('"+mid+"' , '"+mname+"','"+mnumber+"','"+mdate+"','"+edate+"','"+qty+"','"+perunit+"')";
                fn.setData(query, "Medicine Added to Database");
                clearAll();
            }
            else
            {
                MessageBox.Show("Enter All Data!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtManuDate.ResetText();
            txtExpDate.ResetText();
            txtQty.Clear();
            txtPrice.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton7_Click(object sender, EventArgs e)
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
