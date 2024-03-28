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

namespace WinFormsValidator
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC06\SQLEXPRESS; Initial Catalog=TennisDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Check if the table is available
                string availabilityQuery = "SELECT Availability FROM TennisCourts WHERE CourtNumber = @CourtNumber";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@CourtNumber", textBox3.Text);
                string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availabilityResult.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    // Table is available, proceed with booking
                    string insertQuery = "INSERT INTO Reservations VALUES (@GuestNumber, @GuestName, @CourtNumber)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    // Set parameters based on selected values
                    insertCmd.Parameters.AddWithValue("@GuestNumber", textBox1.Text);
                    insertCmd.Parameters.AddWithValue("@GuestName", textBox2.Text);
                    insertCmd.Parameters.AddWithValue("@CourtNumber", textBox3.Text);

                    insertCmd.ExecuteNonQuery();

                    // Update table availability status
                    string updateAvailabilityQuery = "UPDATE TennisCourts SET Availability = 'Unavailable' WHERE CourtNumber = @CourtNumber";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@CourtNumber", textBox3.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Successful!");
                }
                else
                {
                    // Table is not available
                    MessageBox.Show("Sorry, the court is not available for booking.");
                }
            }
        }
    }
}
