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
    public partial class InfoUser : Form
    {
        public InfoUser()
        {
            InitializeComponent();
        }
        private void dataGridViewInfoUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dataGridViewInfoUser.CurrentCell.RowIndex;
                txtUserId.Text = dataGridViewInfoUser.Rows[r].Cells[0].Value.ToString();
                txtUserName.Text = dataGridViewInfoUser.Rows[r].Cells[1].Value.ToString();
                txtPass.Text = dataGridViewInfoUser.Rows[r].Cells[2].Value.ToString();
                txtFullName.Text = dataGridViewInfoUser.Rows[r].Cells[3].Value.ToString();
                txtAboutMe.Text = dataGridViewInfoUser.Rows[r].Cells[4].Value.ToString();
                txtBirthday.Text = dataGridViewInfoUser.Rows[r].Cells[5].Value.ToString();
                txtLiveIn.Text = dataGridViewInfoUser.Rows[r].Cells[7].Value.ToString();
                txtGender.Text = dataGridViewInfoUser.Rows[r].Cells[8].Value.ToString();
                txtSkill.Text = dataGridViewInfoUser.Rows[r].Cells[9].Value.ToString();
                txtEmail.Text = dataGridViewInfoUser.Rows[r].Cells[10].Value.ToString();
            }
            catch { }
        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            dataGridViewInfoUser.DataSource = InfoUserBUL.getlist();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Search = txtSearch.Text;
            dataGridViewInfoUser.DataSource = InfoUserBUL.Search(Search);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.InfoUser db = new Model.InfoUser();
            db.USERNAME = txtUserName.Text;
            db.PASS = txtPass.Text;
            db.FULLNAME = txtFullName.Text;
            db.ABOUTME = txtAboutMe.Text;
            db.BIRTHDAY = Convert.ToDateTime(txtBirthday.Text);
            db.Livein = txtLiveIn.Text;
            db.Gender = txtGender.Text;
            db.Skill = txtSkill.Text;
            db.Email = txtEmail.Text;
            InfoUserBUL.Add(db);
            dataGridViewInfoUser.DataSource = InfoUserBUL.getlist();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Model.InfoUser db = new Model.InfoUser();
            db.USERID = Convert.ToInt32(txtUserId.Text);
            db.USERNAME = txtUserName.Text;
            db.PASS = txtPass.Text;
            db.FULLNAME = txtFullName.Text;
            db.ABOUTME = txtAboutMe.Text;
            db.BIRTHDAY = Convert.ToDateTime(txtBirthday.Text);
            db.Livein = txtLiveIn.Text;
            db.Gender = txtGender.Text;
            db.Skill = txtSkill.Text;
            db.Email = txtEmail.Text;
            InfoUserBUL.Edit(db);
            dataGridViewInfoUser.DataSource = InfoUserBUL.getlist();
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
           Education frmEdu = new Education();
           frmEdu.ShowDialog();
        }
    }
}
