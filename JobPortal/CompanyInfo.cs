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
    public partial class CompanyInfo : Form
    {
        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            dataGridViewCompany.DataSource = CompanyInfoBUL.getlist();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Search = txtSearch.Text;
            dataGridViewCompany.DataSource = CompanyInfoBUL.search(Search);
        }

        private void dataGridViewCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dataGridViewCompany.CurrentCell.RowIndex;
                txtComId.Text = dataGridViewCompany.Rows[r].Cells[0].Value.ToString();
                txtComPass.Text = dataGridViewCompany.Rows[r].Cells[1].Value.ToString();
                txtComName.Text = dataGridViewCompany.Rows[r].Cells[2].Value.ToString();
                txtComStatus.Text = dataGridViewCompany.Rows[r].Cells[3].Value.ToString();
                txtEmail.Text = dataGridViewCompany.Rows[r].Cells[4].Value.ToString();
                txtAboutUs.Text = dataGridViewCompany.Rows[r].Cells[5].Value.ToString();
                txtAddress.Text = dataGridViewCompany.Rows[r].Cells[6].Value.ToString();
                txtPhone.Text = dataGridViewCompany.Rows[r].Cells[7].Value.ToString();
                txtWebsite.Text = dataGridViewCompany.Rows[r].Cells[9].Value.ToString();

                if (dataGridViewCompany.Rows[r].Cells[3].Value.ToString().ToLower() == "true")
                {
                    checkBoxComStatus.Checked = true;
                }
                else
                    checkBoxComStatus.Checked = false;
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.CompanyInfo db = new Model.CompanyInfo();
            db.ComName = txtComName.Text;
            db.ComPass = txtComPass.Text;
            db.EmailCom = txtEmail.Text;
            db.AddressCom = txtAddress.Text;
            db.Phone1Com = txtPhone.Text;
            db.ComStatus = true;
            if (checkBoxComStatus.Checked == true)
            {
                db.ComStatus = true;
            }
            else
                db.ComStatus = false;
            CompanyInfoBUL.Add(db);
            dataGridViewCompany.DataSource = CompanyInfoBUL.getlist();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Model.CompanyInfo db = new Model.CompanyInfo();
            db.ComID = Convert.ToInt32(txtComId.Text);
            db.ComName = txtComName.Text;
            db.ComPass = txtComPass.Text;
            db.EmailCom = txtEmail.Text;
            db.AddressCom = txtAddress.Text;
            db.Phone1Com = txtPhone.Text;
            db.ComStatus = true;
            if (checkBoxComStatus.Checked == true)
            {
                db.ComStatus = true;
            }
            else
                db.ComStatus = false;
            CompanyInfoBUL.Edit(db);
            dataGridViewCompany.DataSource = CompanyInfoBUL.getlist();
        }
    }
}
