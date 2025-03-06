
using System.Data.SqlClient;

namespace CovidPatients
{
    public partial class frmPatients : Form
    {
        private SqlConnection conn;

        public frmPatients()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=COLLINS\SQLEXPRESS;Initial Catalog=CovidPatients;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtIdNo.Text = "";
            txtCountry.Text = "";
            dtpDOB.Value = DateTime.Today;
            cmbGender.SelectedIndex = -1;
            chkIsActive.Checked = true;
            txtName.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Patient name is required!");
                txtName.Focus();
                return;
            }

            if (txtIdNo.Text.Trim() == "")
            {
                MessageBox.Show("Patient Id is required!");
                txtIdNo.Focus();
                return;
            }
            try
            {
                // Do the database connection here...
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Data Source=COLLINS\SQLEXPRESS;Initial Catalog=CovidPatients;Integrated Security=True";
                    conn.Open();

                    // Code goes here
                    string sql = "INSERT INTO tblPatients (Names, IdNo, DOB, Gender, Country, IsActive) VALUES (@Name, @IdNo, @DOB, @Gender, @Country, @IsActive)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@IdNo", txtIdNo.Text);
                        cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                        cmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Patient record inserted successfully.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Connection Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}");
            }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openStripButton3_Click(object sender, EventArgs e)
        {
            frmSearchPatients frm = new frmSearchPatients();
            frm.ShowDialog();
            if (frm.selInt > 0)
            {
                displayInfo(frm.selInt);
            }
        }

        private void displayInfo(int id)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=COLLINS\SQLEXPRESS;Initial Catalog=CovidPatients;Integrated Security=True";

            conn.Open();

            string sql = "SELECT * FROM tblPatients WHERE PatientId=@PatientId";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@PatientId", id);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    txtName.Text = rd["Names"].ToString();
                    txtIdNo.Text = rd["IdNo"].ToString();
                    dtpDOB.Value = DateTime.Parse(rd["DOB"].ToString());
                    cmbGender.Text = rd["Gender"].ToString();
                    txtCountry.Text = rd["Country"].ToString();
                    chkIsActive.Checked = bool.Parse(rd["IsActive"].ToString());
                }
                conn.Close();
            }
        }
    }
}
