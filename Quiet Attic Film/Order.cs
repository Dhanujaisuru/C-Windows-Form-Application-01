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
    public partial class Order : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8I464NC;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True");
        string oi, on;

        public Order()
        {
            InitializeComponent();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quiet_Attic_Film_ProductionDataSet12.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter1.Fill(this.quiet_Attic_Film_ProductionDataSet12.Order);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtOI.Clear();
            txtON.Clear();
            txtOI.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string insert = "insert into [Order] values ('" + oi + "','" + on + "')";
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

        private void loaddata()
        {
            oi = txtOI.Text;
            on = txtON.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string update = "update [Order] set Order_Name = '" + on + "' where Order_ID = '" + oi + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Update successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                string delete = "Delete From [Order] where Order_ID = '" + oi + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order delete Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

        private void txtOI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string search = "select * From [Order] Where Order_ID = '" + oi + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    txtOI.Text = read["Order_ID"].ToString();
                    txtON.Text = read["Order_Name"].ToString();

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

        private void loadgridview()
        {
            con.Open();
            string data = "select * from [Order]";
            SqlDataAdapter adpt = new SqlDataAdapter(data, con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dgvOrder.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }  
}

