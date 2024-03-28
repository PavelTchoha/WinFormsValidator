using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace WinFormsValidator
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        // Event handler for when the form is loaded
        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC06\SQLEXPRESS; Initial Catalog=TennisDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM TennisCourts WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (comboBox1.SelectedItem != null)
                    conditions.Add("Flooring = @flooring");

                if (comboBox2.SelectedItem != null)
                    conditions.Add("Availability = @availability");

                if (comboBox3.SelectedItem != null)
                    conditions.Add("Position = @position");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                cmd.Parameters.AddWithValue("@flooring", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@availability", comboBox2.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@position", comboBox3.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form5 userInputForm = new Form5())
            {
                userInputForm.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Form6 userInputForm = new Form6())
            {
                userInputForm.ShowDialog();
            }
        }
    }
}