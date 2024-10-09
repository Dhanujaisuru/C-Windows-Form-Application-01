using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiet_Attic_Film
{
    public partial class Login : Form
    {
        string username, password;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
            if (username != "Admin" && password != "1234")
            {
                MessageBox.Show("Your username and password is incorrect", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else if (username == "Admin" && password != "1234")
            {
                MessageBox.Show("Your password is incorrect", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else if (username != "Admin" && password == "1234")
            {
                MessageBox.Show("Your username is incorrect", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else
            {
                MessageBox.Show("Login Success!", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard db = new Dashboard();
                this.Hide();
                db.Show();
            }
        }

        private void loaddata()
        {
            username = txtun.Text;
            password = txtpw.Text;
        }

        private void clear()
        {
            txtun.Clear();
            txtpw.Clear();
            txtun.Focus();
        }
    }
}
