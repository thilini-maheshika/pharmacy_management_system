using Guna.UI.WinForms;
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
    public partial class MedicineValidityCheck : Form
    {

        function fn = new function();
        String query;

        public MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MedicineValidityCheck mv = new MedicineValidityCheck();
            mv.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pharmacist dashboardForm = new Pharmacist();
            dashboardForm.Show();
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCheck.SelectedIndex == 0)
            {
                query = "select * from medic where eDate >= getDate()";
                setDataGrid(query, "Valid Medicines", Color.Green);
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select * from medic where eDate <= getDate()";
                setDataGrid(query, "Expired Medicines", Color.Red);

            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from medic";
                setDataGrid(query, "All Medicines", Color.Black);
            }
        }

        private void setDataGrid(String query,String labelName,Color color)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            setLabel.Text = labelName;
            setLabel.ForeColor = color;
        }

        private void MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setLabel.Text = "";

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
    }
}
