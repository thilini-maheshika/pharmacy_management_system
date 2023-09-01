using DGVPrinterHelper;
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
    public partial class SellMedicine : Form
    {
        function fn = new function();
        String query;
        DataSet ds;

        public SellMedicine()
        {
            InitializeComponent();
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MedicineValidityCheck mv = new MedicineValidityCheck();
            mv.Show();
        }

        private void SellMedicine_Load(object sender, EventArgs e)
        {
            query = "select mname from medic where eDate >= getDate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i =0; i< ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pharmacist pm = new Pharmacist();
            pm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medic where mname like '" + txtSearch.Text + "%' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnit.Clear();

            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMediName.Text = name;

            query = "select mid,eDate,perUnit from medic where mname ='"+name+"'";
            ds = fn.getData(query);

            txtMediId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoOfUnit_TextChanged(object sender, EventArgs e)
        {
            if(txtNoOfUnit.Text != "")
            {
                Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoOfUnit.Text);
                Int64 totalamount = unitprice * noOfUnit;
                txtTotPrice.Text = totalamount.ToString();
            }
            else
            {
                txtTotPrice.Clear();
            }
        }

        protected int n , totalamount = 0;
        protected Int64 quantity, newquantity;

        int valueAmount;
        String valueId;
        protected Int64 noOfUnit;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

                valueAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueId != "")
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid ='"+valueId+"'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newquantity = quantity + noOfUnit;

                    query = "update medic set quantity = '" + newquantity + "' where mid = '" + valueId + "'";
                    fn.setData(query, "Medicine Removed from cart");
                    totalamount = totalamount - valueAmount;
                    price_label.Text = "Rs ." + totalamount.ToString();
                }
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + price_label.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);


            totalamount = 0;
            price_label.Text = "Rs . 00";
            dataGridView1.DataSource = 0;
            MessageBox.Show("Your Purchase is Success!! ", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if(txtMediId.Text != "")
            {
                query = "select quantity from medic where mid = '"+txtMediId.Text+"'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newquantity = quantity - Int64.Parse(txtNoOfUnit.Text);

                if(newquantity >= 0)
                {
                    n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = txtMediId.Text;
                    dataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                    dataGridView1.Rows[n].Cells[2].Value = txtExpDate.Text;
                    dataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    dataGridView1.Rows[n].Cells[4].Value = txtNoOfUnit.Text;
                    dataGridView1.Rows[n].Cells[5].Value = txtTotPrice.Text;

                    totalamount = totalamount + int.Parse(txtTotPrice.Text);
                    price_label.Text = "Rs. " + totalamount.ToString();

                    query = "update medic set quantity = '" + newquantity + "' where mid = '" + txtMediId.Text + "'";
                    fn.setData(query, "Medicine Added");
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock. \n Only " + quantity + " left","Warning !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }

                ClearAll();
            }
            else
            {
                MessageBox.Show("Select Medicine First!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearAll()
        {
            txtMediId.Clear();
            txtMediName.Clear();
            txtExpDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnit.Clear();
            txtTotPrice.Clear();
        }
    }
}
