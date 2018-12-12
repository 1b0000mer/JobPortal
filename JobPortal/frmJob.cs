using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Model;
using BusinessLayer;
using System.Data.SqlServerCe;

namespace JobPortal
{
    public partial class frmJob : Form
    {
        //SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.JobsConnectionString);
        //SqlCeCommand cmd;
        public frmJob()
        {
            InitializeComponent();
        }

        private void hidesuff()
        {
            jobDataGridView.Columns["City"].Visible = false;
            jobDataGridView.Columns["JobCatalog"].Visible = false;
            jobDataGridView.Columns["CompanyListAppylies"].Visible = false;
            jobDataGridView.Columns["Position"].Visible = false;
        }
        private void loadsuff()
        {
            try
            {
                this.jobDataGridView.DataSource = JobBUL.getlist();
                cataNameComboBox.DataSource = JobCatalogBUL.getlist();
                cityNameComboBox.DataSource = CityBUL.getlist();
                comNameComboBox.DataSource = CompanyInfoBUL.getlist();
                positionNameComboBox.DataSource = PositionBUL.getlist();
                cataNameComboBox.DisplayMember = "JobCataID";
                cityNameComboBox.DisplayMember = "CityID";
                comNameComboBox.DisplayMember = "ComID";
                positionNameComboBox.DisplayMember = "PositionID";
                postDayDateTimePicker.Enabled = false;
                startDayDateTimePicker.Value = DateTime.Now;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối với CSDL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmJob_Load(object sender, EventArgs e)
        {
            try
            {
                loadsuff();
                hidesuff();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối với CSDL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jobDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = jobDataGridView.CurrentCell.RowIndex;
                jobIDTextBox.Text = jobDataGridView.Rows[r].Cells[0].Value.ToString();
                comNameComboBox.Text = jobDataGridView.Rows[r].Cells[1].Value.ToString();
                jobNameTextBox.Text = jobDataGridView.Rows[r].Cells[2].Value.ToString();
                jobDetailTextBox.Text = jobDataGridView.Rows[r].Cells[3].Value.ToString();
                if (Convert.ToBoolean(jobDataGridView.Rows[r].Cells[4].Value) == true)
                    jobStatusCheckBox.Checked = true;
                else
                    jobStatusCheckBox.Checked = false;
                viewCountTextBox.Text = jobDataGridView.Rows[r].Cells[5].Value.ToString();
                cataNameComboBox.Text = jobDataGridView.Rows[r].Cells[6].Value.ToString();
                positionNameComboBox.Text = jobDataGridView.Rows[r].Cells[7].Value.ToString();
                cityNameComboBox.Text = jobDataGridView.Rows[r].Cells[8].Value.ToString();
                salaryMinTextBox.Text = jobDataGridView.Rows[r].Cells[9].Value.ToString();
                salaryMaxTextBox.Text = jobDataGridView.Rows[r].Cells[10].Value.ToString();
                postDayDateTimePicker.Value = Convert.ToDateTime(jobDataGridView.Rows[r].Cells[11].Value.ToString());
                startDayDateTimePicker.Value = Convert.ToDateTime(jobDataGridView.Rows[r].Cells[12].Value.ToString());
                endDayDateTimePicker.Value = Convert.ToDateTime(jobDataGridView.Rows[r].Cells[13].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Không thực hiện được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadsuff();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Job db = new Model.Job();
                db.JobID = Convert.ToInt32(jobIDTextBox.Text);
                db.ComID = Convert.ToInt32(comNameComboBox.Text);
                db.JobName = jobNameTextBox.Text;
                db.JobDetail = jobDetailTextBox.Text;
                if (Convert.ToBoolean(jobStatusCheckBox.Checked) == true)
                    db.JobStatus = true;
                else
                    db.JobStatus = false;
                db.ViewCount = Convert.ToInt32(viewCountTextBox.Text);
                db.JobCatID = Convert.ToInt32(cataNameComboBox.Text);
                db.PositionID = Convert.ToInt32(positionNameComboBox.Text);
                db.CityID = Convert.ToInt32(cityNameComboBox.Text);
                db.SalaryMin = Convert.ToInt32(salaryMinTextBox.Text);
                db.SalaryMax = Convert.ToInt32(salaryMaxTextBox.Text);
                db.PostDay = DateTime.Now;
                db.StartDay = startDayDateTimePicker.Value;
                db.EndDay = endDayDateTimePicker.Value;
                JobBUL.Add(db);
                this.jobDataGridView.DataSource = JobBUL.getlist();
            }
            catch
            {
                MessageBox.Show("Không thể thêm vào CSDL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Job db = new Model.Job();
                db.JobID = Convert.ToInt32(jobIDTextBox.Text);
                db.ComID = Convert.ToInt32(comNameComboBox.Text);
                db.JobName = jobNameTextBox.Text;
                db.JobDetail = jobDetailTextBox.Text;
                if (Convert.ToBoolean(jobStatusCheckBox.Checked) == true)
                    db.JobStatus = true;
                else
                    db.JobStatus = false;
                db.ViewCount = Convert.ToInt32(viewCountTextBox.Text);
                db.JobCatID = Convert.ToInt32(cataNameComboBox.Text);
                db.PositionID = Convert.ToInt32(positionNameComboBox.Text);
                db.CityID = Convert.ToInt32(cityNameComboBox.Text);
                db.SalaryMin = Convert.ToInt32(salaryMinTextBox.Text);
                db.SalaryMax = Convert.ToInt32(salaryMaxTextBox.Text);
                db.PostDay = postDayDateTimePicker.Value;
                db.StartDay = startDayDateTimePicker.Value;
                db.EndDay = endDayDateTimePicker.Value;
                JobBUL.Edit(db);
                this.jobDataGridView.DataSource = JobBUL.getlist();
            }
            catch
            {
                MessageBox.Show("Không thể sửa dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Job db = new Model.Job();
                db.JobID = Convert.ToInt32(jobIDTextBox.Text);
                db.ComID = Convert.ToInt32(comNameComboBox.Text);
                db.JobName = jobNameTextBox.Text;
                db.JobDetail = jobDetailTextBox.Text;
                if (Convert.ToBoolean(jobStatusCheckBox.Checked) == true)
                    db.JobStatus = true;
                else
                    db.JobStatus = false;
                db.ViewCount = Convert.ToInt32(viewCountTextBox.Text);
                db.JobCatID = Convert.ToInt32(cataNameComboBox.Text);
                db.PositionID = Convert.ToInt32(positionNameComboBox.Text);
                db.CityID = Convert.ToInt32(cityNameComboBox.Text);
                db.SalaryMin = Convert.ToInt32(salaryMinTextBox.Text);
                db.SalaryMax = Convert.ToInt32(salaryMaxTextBox.Text);
                db.PostDay = postDayDateTimePicker.Value;
                db.StartDay = startDayDateTimePicker.Value;
                db.EndDay = endDayDateTimePicker.Value;
                JobBUL.Delete(db);
                this.jobDataGridView.DataSource = JobBUL.getlist();
            }
            catch
            {
                MessageBox.Show("Không thể xoá dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
