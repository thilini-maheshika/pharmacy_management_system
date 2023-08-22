using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Management_System
{
    public partial class ViewMedicine : Form
    {
        function fn = new function();
        String query;

        public ViewMedicine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddMedicine add = new AddMedicine();
            add.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pharmacist dashboardForm = new Pharmacist();
            dashboardForm.Show();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewMedicine vm = new ViewMedicine();
            vm.Show();
        }

        private void ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pharmacist dashboardForm = new Pharmacist();
            dashboardForm.Show();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + txtmedi.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        String medicineId;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               medicineId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM medic WHERE mid = '" + medicineId + "'";
                fn.setData(query, "Medicine Record Deleted Successfully!!");
                ViewMedicine_Load(this, null);
            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.Hide();

            ModifyMedicine mm = new ModifyMedicine();
            mm.Show();
        }
    }
}
