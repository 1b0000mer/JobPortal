using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;using BusinessLayer;
namespace JobPortal
{
    public partial class Form1 : Form
    {
        public class state
        {
            public static int login;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtboxUserName.Text;
            string pass = txtBoxPass.Text;
            if (LoginBUL.Login(user, pass) != null)
            {
                state.login = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập sai");
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignIn sign = new frmSignIn();
            sign.ShowDialog();
            
        }
    }
}
