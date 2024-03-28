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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            RefreshReservations();
        }

        private void RefreshReservations()
        {
            using (var sqlCon = new SqlConnection(@"Data Source=LAB109PC06\SQLEXPRESS; Initial Catalog=TennisDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT CourtNumber, GuestName, phoneNumber FROM Reservations", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.CurrentRow != null)
            {
                // Assuming your primary key or a unique identifier for the reservations is in the first column
                var reservationId = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // Adjust the index if needed

                // Confirmation dialog
                var confirmResult = MessageBox.Show("Are you sure to delete this reservation?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (var sqlCon = new SqlConnection(@"Data Source=LAB109PC06\SQLEXPRESS; Initial Catalog=TennisDB; Integrated Security=True;"))
                        {
                            sqlCon.Open();
                            string query = "DELETE FROM Reservations WHERE CourtNumber = @CourtNumber";
                            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

                            sqlCmd.Parameters.AddWithValue("@CourtNumber", reservationId);

                            int rowsAffected = sqlCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Reservation deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshReservations();
                            }
                            else
                            {
                                MessageBox.Show("Deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to delete.", "Select Reservation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
