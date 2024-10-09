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
    public partial class Location : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8I464NC;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True");
        string li, ln, st, cs, zip;

        public Location()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void Location_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quiet_Attic_Film_ProductionDataSet11.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter1.Fill(this.quiet_Attic_Film_ProductionDataSet11.Location);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string insert = "insert into Location values ('" + li + "','" + ln + "','" + st + "','"+ cs +"','"+ zip +"')";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string update = "update Location set Location_Name ='" + ln + "',Street='" + st + "',City_or_State ='"+cs+"',Zip_Code ='"+zip+"' where Location_ID = '" + li + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Location Update successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                string delete = "Delete From Location where Location_ID = '" + li + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Location delete Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

        private void txtLI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string search = "select * from Location Where Location_ID = '" + li + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    txtLI.Text = read["Location_ID"].ToString();
                    txtLN.Text = read["Location_Name"].ToString();
                    txtST.Text = read["Street"].ToString();
                    txtCS.Text = read["City_or_State"].ToString();
                    txtZC.Text = read["Zip_Code"].ToString();

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
            txtLI.Clear();
            txtLN.Clear();
            txtST.Clear();
            txtCS.Clear();
            txtZC.Clear();
            txtLI.Focus();
        }
         
        private void loaddata()
        {
            li = txtLI.Text;
            ln = txtLN.Text;
            st = txtST.Text;
            cs = txtCS.Text;
            zip = txtZC.Text;
        }

        private void loadgridview()
        {
            con.Open();
            string data = "select * from Location";
            SqlDataAdapter adpt = new SqlDataAdapter(data, con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dgvLocation.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }
}
