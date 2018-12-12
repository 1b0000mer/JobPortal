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
    public partial class Education : Form
    {
        public Education()
        {
            InitializeComponent();
        }

        private void Education_Load(object sender, EventArgs e)
        {
            dataGridViewEducation.DataSource = EducationBUL.getlist();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Model.Education db = new Model.Education();
            db.USERID = Convert.ToInt32(txtUserID.Text);
            db.EduID = Convert.ToInt32(txtEduID.Text);
            db.NameEdu = txtNameEdu.Text;
            db.FromEdu = txtFromEdu.Text;
            db.DecripEdu = txtDecripEdu.Text;
            EducationBUL.Update(db);
            dataGridViewEducation.DataSource = EducationBUL.getlist();
        }
    }
}
