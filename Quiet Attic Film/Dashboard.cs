using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_Attic_Film
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            this.Close();
            client.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            this.Close();
            order.Show();
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.Show();
            this.Close();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            Property property = new Property();
            property.Show();
            this.Close();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Show();
            this.Close();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
