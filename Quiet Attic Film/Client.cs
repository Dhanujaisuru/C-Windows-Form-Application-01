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
    public partial class Client : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8I464NC;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True");
        string ci, fn, ln, ge, co;

        public Client()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string update = "update Client set F_Name = '" + fn + "', L_Name = '" + ln + "' , Gender = '" + ge + "', Contact = '"+co+"'  where Client_ID = '" + ci + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client Update successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                string delete = "Delete From Client where Client_ID = '" + ci + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client delete Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

        private void txtci_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string search = "select * from Client Where Client_ID = '" + ci + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    txtCI.Text = read["Client_ID"].ToString();
                    txtFN.Text = read["F_Name"].ToString();
                    txtLN.Text = read["L_Name"].ToString();

                    if (read["Gender"].ToString() == "Male")
                    {
                        rdbM.Checked = true;
                    }
                    else
                    {
                        rdbF.Checked = true;
                    }

                    txtCN.Text = read["Contact"].ToString();
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

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quiet_Attic_Film_ProductionDataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.quiet_Attic_Film_ProductionDataSet1.Client);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loaddata();
                string insert = "insert into Client values ('" + ci + "','" + fn + "','" + ln + "','" + ge + "','"+co+"')";
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
            ci = txtCI.Text;
            fn = txtFN.Text;
            ln = txtLN.Text;
            
            if (rdbM.Checked == true)
            {
               ge = "Male";
            }
            else
            {
                ge = "Female";
            }
            co = txtCN.Text;
        }

        private void Clear()
        {
            txtCI.Clear();
            txtFN.Clear();
            txtLN.Clear();
            rdbM.Checked = false;
            rdbF.Checked = false;
            txtCN.Clear();
            txtCI.Focus();
        }

        private void loadgridview()
        {
            con.Open();
            string data = "select * from Client";
            SqlDataAdapter adpt = new SqlDataAdapter(data, con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dgvClient.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

    }
}
