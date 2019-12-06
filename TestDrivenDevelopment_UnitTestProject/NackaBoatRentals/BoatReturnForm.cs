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
using NackaBoatRentals.Helpers;

namespace NackaBoatRentals
{
    public partial class BoatReturnForm : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public BoatReturnForm()
        {
            InitializeComponent();
        }

        private void BoatReturnForm_Load(object sender, EventArgs e)
        {
            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["NackaBoatRentals.Properties.Settings.BoatRentalsDB"].ToString();
            con = new SqlConnection(connectionString);

            // display table
            display();
        }
        public void clearFields()
        {
            txtBoatNumber.Text = string.Empty;
        }
        public void display()
        {
            // on intialise display boats table
            cmd = new SqlCommand("select BoatNumber as 'Boat Number', BoatName as 'Boat Name', BoatCategory as 'Boat Category', BoatDateOfPurchase as 'Date of Purchase', BoatYearBuilt as 'Year Built' from Boats where BoatNumber in (select BoatNumber from BoatRentals where Cost=0)", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridViewRentedBoats.DataSource = ds.Tables[0];

            // make read only
            dataGridViewRentedBoats.ReadOnly = true;
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void btnBoatReturned_Click(object sender, EventArgs e)
        {
            //validating BoatNumber
            int iBoatNumber = 0;
            bool isDataValidated = true;
            DateTime dtReturnTime;
            DateTime dtRentTime = DateTime.Now;
            string strBoatCategory="";
            int iTotalCost = 0;
            int iMinutes = 0;

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
            //Combine date and time input
            dtReturnTime = this.dtReturnDate.Value.Date + this.dtReturnTime.Value.TimeOfDay;

            // open connection
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //Getting rented boats details
            SqlCommand command = new SqlCommand("Select RentalTime, BoatCategory from BoatRentals where BoatNumber=@bNumber and Cost=0", con);
            command.Parameters.AddWithValue("@bNumber", iBoatNumber);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    if(reader.HasRows)
                    {
                        dtRentTime = DateTime.Parse(reader["RentalTime"].ToString()).ToLocalTime();
                        strBoatCategory = reader["BoatCategory"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("This boat has not been rented out.");
                        isDataValidated = false;
                    }
                }
            }

            if(dtReturnTime < dtRentTime)
            {
                MessageBox.Show("This boat rental time is after return time, which is invalid");
                isDataValidated = false;
            }

            TimeSpan span = dtReturnTime.Subtract(dtRentTime);

            //Calculating the minutes between the two rented and return dates;
            iMinutes = (int)span.TotalMinutes;
            iTotalCost = CostCalculationsHelper.TotalCost(strBoatCategory.TrimEnd(), iMinutes);

            //Only save data in database if validation is succesful.
            if (isDataValidated)
            {
                try
                {
                    SqlCommand cmdUpdate = new SqlCommand("Update BoatRentals Set ReturnTime = @returnTime, Cost = @cost where BoatNumber = @bNumber and Cost=0", con);
                    cmdUpdate.Parameters.AddWithValue("@returnTime", dtReturnTime.ToLocalTime());
                    cmdUpdate.Parameters.AddWithValue("@cost", iTotalCost);
                    cmdUpdate.Parameters.AddWithValue("@bNumber", iBoatNumber);
                    
                    int result = cmdUpdate.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Boat returned and record succesfully updated.");
                        display();
                        clearFields();
                        this.lblCost.Text = iTotalCost.ToString() + " SEK";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please make sure all information is provided correctly.\nIf you still get an error then contact NackaBoatRentals support. Error message:" + ex.Message);
                }
            }
        }
    }
}
