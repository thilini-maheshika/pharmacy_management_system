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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pharmacist pm = new Pharmacist();
            pm.Show();
        }
    }
}
