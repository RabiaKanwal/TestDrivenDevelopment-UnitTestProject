using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace NackaBoatRentals
{
    public partial class RentBoatForm : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public RentBoatForm()
        {
            InitializeComponent();
        }

        private void RentBoatForm_Load(object sender, EventArgs e)
        {
            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["NackaBoatRentals.Properties.Settings.BoatRentalsDB"].ToString();
            con = new SqlConnection(connectionString);

            // display table
            display();
        }

        public void display()
        {
            // on intialise display boats table
            cmd = new SqlCommand("select BoatNumber as 'Boat Number', BoatName as 'Boat Name', BoatCategory as 'Boat Category', BoatDateOfPurchase as 'Date of Purchase', BoatYearBuilt as 'Year Built' from Boats where BoatNumber not in (select BoatNumber from BoatRentals where Cost=0)", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridViewAvailableBoats.DataSource = ds.Tables[0];

            // make read only
            dataGridViewAvailableBoats.ReadOnly = true;
        }

        public void clearFields()
        {
            txtBoatNumber.Text = string.Empty;
            txtBookingNumber.Text = string.Empty;
            txtSocialSecurityNumber.Text = string.Empty;
        }

        private void btnRentBoat_Click(object sender, EventArgs e)
        {
            //validating BoatNumber
            int iBoatNumber=0;
            int iBookingNumber=0;
            bool isDataValidated = true;
            DateTime RentTime;
            try
            {
                iBoatNumber = Convert.ToInt32(this.txtBoatNumber.Text);
                if (iBoatNumber <= 0)
                {
                    MessageBox.Show("Please choose a valid boat number greater than 0");
                }
            }
            catch
            {
                MessageBox.Show("Booking number should be positive please enter a valid booking number");
                isDataValidated = false;
            }
            // validating BoatCategory
            try
            {
                iBookingNumber = Convert.ToInt32(this.txtBookingNumber.Text);
                if (iBookingNumber <= 0)
                {
                    MessageBox.Show("Booking number should be positive please enter a valid booking number");
                    isDataValidated = false;
                }
            }
            catch
            {
                MessageBox.Show("Please provide an integer for booking number");
                isDataValidated = false;
            }
            // validating SocialSecurityNumber
            Regex regxSocialSecurityNumber = new Regex(@"^\d{6}-\d{4}$");
            if (!regxSocialSecurityNumber.IsMatch(this.txtSocialSecurityNumber.Text))
            {
                MessageBox.Show("Please provide a valid social security number with format XXXXXX-XXXX");
                isDataValidated = false;
            }
            // validating Boat Category Combo box
            if (this.cmbBoatCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a valid boat category");
                isDataValidated = false;
            }
            //Combine date and time input
            RentTime = this.dtRentDate.Value.Date + this.dtRentTime.Value.TimeOfDay;
            //CultureInfoConverter cultureInfo = new CultureInfoConverter();
            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();
            //Only save data in database if validation is succesful.
            if (isDataValidated)
            {
                try
                {
                    string strQuery = "insert into BoatRentals values(@BoatNumber, @BookingNumber, @SocialSecurityNumber, @BoatCategory, @RentalTime, @ReturnTime, @Cost)";
                
                    cmd = new SqlCommand(strQuery, con);
                    cmd.Parameters.AddWithValue("@BoatNumber", iBoatNumber);
                    cmd.Parameters.AddWithValue("@BookingNumber", iBookingNumber);
                    cmd.Parameters.AddWithValue("@SocialSecurityNumber", this.txtSocialSecurityNumber.Text);
                    cmd.Parameters.AddWithValue("@BoatCategory", this.cmbBoatCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RentalTime", RentTime.ToLocalTime());
                    cmd.Parameters.AddWithValue("@ReturnTime", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cost", 0);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Boat successfully rented.");
                        display();
                        clearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please make sure all information is provided correctly.\nIf you still get an error then contact NackaBoatRentals support. Error message:" + ex.Message);
                }
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }


    }
}
