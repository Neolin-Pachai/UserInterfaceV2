using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserInterfaceV2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegisterSubmit_Click(object sender, EventArgs e)
        {
            if (txtRePassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Please re-enter password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connection = "Data Source=NEOLIN-MAC;Initial Catalog=dbUni;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                string insert = "INSERT INTO tblUser (UserName,Password) VALUES ( '" + txtUserName.Text + "','" + txtPassword.Text + "' )"; //allows input from an external control
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User Successfully Added");
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }
    }
}
