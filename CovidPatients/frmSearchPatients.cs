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
using System.Xml.Linq;

namespace CovidPatients
{
    public partial class frmSearchPatients : Form
    {
        public int selInt { get; set; }


        private SqlConnection conn;
        private TextBox txtName; // Changed from object to TextBox
        private TextBox txtIdNo; // Added missing TextBox fields
        private DateTimePicker dtpDOB; // Added missing DateTimePicker field
        private ComboBox cmbGender; // Added missing ComboBox field
        private TextBox txtCountry; // Added missing TextBox field
        private CheckBox chkIsActive; // Added missing CheckBox field

        public frmSearchPatients()
        {
            InitializeComponent();
            conn = new SqlConnection();
            // Initialize controls here
            txtName = new TextBox();
            txtIdNo = new TextBox();
            dtpDOB = new DateTimePicker();
            cmbGender = new ComboBox();
            txtCountry = new TextBox();
            chkIsActive = new CheckBox();

            // Add these controls to the form's Controls collection
            Controls.Add(txtName);
            Controls.Add(txtIdNo);
            Controls.Add(dtpDOB);
            Controls.Add(cmbGender);
            Controls.Add(txtCountry);
            Controls.Add(chkIsActive);
        }

        private void frmSearchPatients_Load(object sender, EventArgs e)
        {

            conn.ConnectionString = @"Data Source=COLLINS\SQLEXPRESS;Initial Catalog=CovidPatients;Integrated Security=True";
            conn.Open();

            string sql = "SELECT * FROM tblPatients WHERE Names LIKE @Name";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Name", "%" + txtName.Text + "%");

                SqlDataReader rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    ListViewItem item = new ListViewItem(rd[0].ToString());
                    item.SubItems.Add(rd[1].ToString());
                    item.SubItems.Add(rd[2].ToString());
                    item.SubItems.Add(rd[3].ToString());
                    item.SubItems.Add(rd[4].ToString());
                    item.SubItems.Add(rd[5].ToString());
                    item.SubItems.Add(rd[6].ToString());
                    lstPatients.Items.Add(item);
                }
            }
        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPatients.FocusedItem == null) return;

            int i = lstPatients.FocusedItem.Index;
            label1.Text = lstPatients.Items[i].Text + "Name: " + lstPatients.Items[i].SubItems[1].Text + "Id No." + lstPatients.Items[i].SubItems[2].Text;
            this.selInt = int.Parse(lstPatients.Items[i].Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstPatients_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearchPatients_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
