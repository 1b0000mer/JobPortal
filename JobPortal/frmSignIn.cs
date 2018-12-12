using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BusinessLayer;
namespace JobPortal
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxConfilmPass.Text == txtBoxPass.Text)
            {
                try
                {
                    SignInBUL.SignIn(txtBoxName.Text, txtBoxPass.Text, txtBoxPhone.Text, txtBoxEmail.Text);
                    MessageBox.Show("Thành công");
                    this.Close();
                    Form frm = new Form1();
                    frm.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form1();
            frm.ShowDialog();
        }
    }
}
