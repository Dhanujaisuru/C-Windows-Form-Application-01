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
    public partial class Production : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8I464NC;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True");
        string pi, pn, type;
        int days;

        public Production()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void Production_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quiet_Attic_Film_ProductionDataSet3.Production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.quiet_Attic_Film_ProductionDataSet3.Production);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string insert = "insert into Production values ('" + pi + "','" + pn + "','" + type + "','" + days + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save Successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                loadgridview();
                con.Close();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string update = "update Production set Production_Name ='" + pn + "',Production_Type='" + type + "',No_Of_Days ='" + days + "' where Production_ID = '"+pi+"'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Production Update successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                string delete = "Delete From Production where Production_ID = '" + pi + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Production delete Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                string search = "select * from Production Where Production_ID = '" + pi + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    txtPI.Text = read["Production_ID"].ToString();
                    txtPN.Text = read["Production_Name"].ToString();
                    cmbPT.Text = read["Production_Type"].ToString();
                    txtND.Text = read["No_Of_Days"].ToString();

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

        private void loaddata()
        {
            pi = txtPI.Text;
            pn = txtPN.Text;
            type = cmbPT.Text;
            //days = int.Parse(txtND.Text);
            Int32.TryParse(txtND.Text, out days);
        }

        private void Clear()
        {
            txtPI.Clear();
            txtPN.Clear();
            cmbPT.ResetText();
            txtND.Clear();
            txtPI.Focus();
        }

        private void loadgridview()
        {
            con.Open();
            string data = "select * from Production";
            SqlDataAdapter adpt = new SqlDataAdapter(data, con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dgvProduction.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }
}
