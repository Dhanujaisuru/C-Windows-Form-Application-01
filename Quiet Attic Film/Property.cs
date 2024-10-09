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

namespace Quiet_Attic_Film
{
    public partial class Property : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8I464NC;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True");
        string pi, pn, type;

        public Property()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string insert = "insert into Property values ('" + pi + "','" + pn + "','" + type + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save Successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                loadgridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While inserting" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void Property_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quiet_Attic_Film_ProductionDataSet4.Property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter.Fill(this.quiet_Attic_Film_ProductionDataSet4.Property);

        }

        private void loaddata()
        {
            pi = txtPI.Text;
            pn = txtPN.Text;
            type = cmbPT.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string update = "update Property set Property_Name ='" + pn + "',Property_Type='" + type + "' where Property_ID = '" + pi + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Property Update successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Clear();
                loadgridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string delete = "Delete From Property where Property_ID = '" + pi + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Property delete Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                Clear();
                loadgridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While deleting" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtPI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string search = "select * from Property Where Property_ID = '" + pi + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    txtPI.Text = read["Property_ID"].ToString();
                    txtPN.Text = read["Property_Name"].ToString();
                    cmbPT.Text = read["Property_Type"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Search" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtPI.Clear();
            txtPN.Clear();
            cmbPT.ResetText();
            txtPI.Focus();
        }

        private void loadgridview()
        {
            con.Open();
            string data = "select * from Property";
            SqlDataAdapter adpt = new SqlDataAdapter(data, con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dgvProperty.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }
}
