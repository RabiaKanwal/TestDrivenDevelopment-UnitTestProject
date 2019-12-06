using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NackaBoatRentals
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoatReturned_Click(object sender, EventArgs e)
        {
            this.Hide();
            BoatReturnForm boatReturnForm = new BoatReturnForm();
            boatReturnForm.Show();
        }

        private void btnRentBoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentBoatForm rentBoatForm = new RentBoatForm();
            rentBoatForm.Show();
        }
    }
}
