using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UserInterfaceV2
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();
        List<User> temp = new List<User>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = handler.UserRead();

            foreach (var item in temp)
            {
                if (item.UserName.Trim() == comboBox1.Text.Trim())
                {
                    if (this.txtPasswordDisplay.InvokeRequired)
                    {
                        Password dont = new Password(Display);
                        this.Invoke(dont);
                    }
                    else
                    {

                        txtPasswordDisplay.Text = item.Password.ToString();

                    }
                }
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            temp = handler.UserRead();
            foreach (var item in temp)
            {
                comboBox1.Items.Add(item.UserName);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            temp = handler.UserRead();
            Thread t1 = new Thread(() =>
            {
                Display();
                Check();
            });
            t1.Start();
        }

        delegate void Password();

        public void Display()
        {
            if (this.txtPasswordDisplay.InvokeRequired)
            {
                Password dont = new Password(Display);
                this.Invoke(dont);
            }
            else
            {
                foreach (var item in temp)
                {
                    if (txtUserName.Text.Trim() == item.UserName.Trim())
                    {
                        txtPasswordDisplay.Text = item.Password.ToString();
                    }
                }
            }
        }
        public void Check()
        {
            if (this.txtPasswordDisplay.InvokeRequired)
            {
                Password dont = new Password(Check);
                this.Invoke(dont);
            }
            else
            {
                if (txtUserName.Text.Trim() == string.Empty)
                {
                    txtPasswordDisplay.Text = string.Empty;
                }
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
