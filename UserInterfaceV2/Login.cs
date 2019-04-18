using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceV2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();
        List<User> stuff = new List<User>();
        List<User> temp = new List<User>();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            stuff = handler.UserRead();
            bool validLog = false;
            foreach (var item in stuff)
            {
                if (txtUserName.Text == item.UserName.Trim() && txtPassword.Text == item.Password.Trim())
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Visible = false;
                    validLog = true;
                    break;
                }
            }
            if (!validLog)
            {
                MessageBox.Show("Invalid username and password combination", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void llForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }

    }
}
