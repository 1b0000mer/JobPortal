namespace JobPortal
{
    partial class frmJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label comNameLabel;
            System.Windows.Forms.Label endDayLabel;
            System.Windows.Forms.Label startDayLabel;
            System.Windows.Forms.Label postDayLabel;
            System.Windows.Forms.Label salaryMaxLabel;
            System.Windows.Forms.Label salaryMinLabel;
            System.Windows.Forms.Label cityNameLabel;
            System.Windows.Forms.Label positionNameLabel;
            System.Windows.Forms.Label cataNameLabel;
            System.Windows.Forms.Label viewCountLabel;
            System.Windows.Forms.Label jobStatusLabel;
            System.Windows.Forms.Label jobDetailLabel;
            System.Windows.Forms.Label jobNameLabel;
            System.Windows.Forms.Label jobIDLabel;
            this.cataNameComboBox = new System.Windows.Forms.ComboBox();
            this.cityNameComboBox = new System.Windows.Forms.ComboBox();
            this.positionNameComboBox = new System.Windows.Forms.ComboBox();
            this.comNameComboBox = new System.Windows.Forms.ComboBox();
            this.jobDataGridView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.endDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salaryMaxTextBox = new System.Windows.Forms.TextBox();
            this.salaryMinTextBox = new System.Windows.Forms.TextBox();
            this.viewCountTextBox = new System.Windows.Forms.TextBox();
            this.jobStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.jobDetailTextBox = new System.Windows.Forms.TextBox();
            this.jobNameTextBox = new System.Windows.Forms.TextBox();
            this.jobIDTextBox = new System.Windows.Forms.TextBox();
            comNameLabel = new System.Windows.Forms.Label();
            endDayLabel = new System.Windows.Forms.Label();
            startDayLabel = new System.Windows.Forms.Label();
            postDayLabel = new System.Windows.Forms.Label();
            salaryMaxLabel = new System.Windows.Forms.Label();
            salaryMinLabel = new System.Windows.Forms.Label();
            cityNameLabel = new System.Windows.Forms.Label();
            positionNameLabel = new System.Windows.Forms.Label();
            cataNameLabel = new System.Windows.Forms.Label();
            viewCountLabel = new System.Windows.Forms.Label();
            jobStatusLabel = new System.Windows.Forms.Label();
            jobDetailLabel = new System.Windows.Forms.Label();
            jobNameLabel = new System.Windows.Forms.Label();
            jobIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comNameLabel
            // 
            comNameLabel.AutoSize = true;
            comNameLabel.Location = new System.Drawing.Point(205, 9);
            comNameLabel.Name = "comNameLabel";
            comNameLabel.Size = new System.Drawing.Size(45, 13);
            comNameLabel.TabIndex = 21;
            comNameLabel.Text = "Com ID:";
            // 
            // endDayLabel
            // 
            endDayLabel.AutoSize = true;
            endDayLabel.Location = new System.Drawing.Point(399, 115);
            endDayLabel.Name = "endDayLabel";
            endDayLabel.Size = new System.Drawing.Size(51, 13);
            endDayLabel.TabIndex = 31;
            endDayLabel.Text = "End Day:";
            // 
            // startDayLabel
            // 
            startDayLabel.AutoSize = true;
            startDayLabel.Location = new System.Drawing.Point(399, 81);
            startDayLabel.Name = "startDayLabel";
            startDayLabel.Size = new System.Drawing.Size(54, 13);
            startDayLabel.TabIndex = 28;
            startDayLabel.Text = "Start Day:";
            // 
            // postDayLabel
            // 
            postDayLabel.AutoSize = true;
            postDayLabel.Location = new System.Drawing.Point(12, 185);
            postDayLabel.Name = "postDayLabel";
            postDayLabel.Size = new System.Drawing.Size(53, 13);
            postDayLabel.TabIndex = 33;
            postDayLabel.Text = "Post Day:";
            // 
            // salaryMaxLabel
            // 
            salaryMaxLabel.AutoSize = true;
            salaryMaxLabel.Location = new System.Drawing.Point(12, 115);
            salaryMaxLabel.Name = "salaryMaxLabel";
            salaryMaxLabel.Size = new System.Drawing.Size(62, 13);
            salaryMaxLabel.TabIndex = 29;
            salaryMaxLabel.Text = "Salary Max:";
            // 
            // salaryMinLabel
            // 
            salaryMinLabel.AutoSize = true;
            salaryMinLabel.Location = new System.Drawing.Point(205, 115);
            salaryMinLabel.Name = "salaryMinLabel";
            salaryMinLabel.Size = new System.Drawing.Size(59, 13);
            salaryMinLabel.TabIndex = 30;
            salaryMinLabel.Text = "Salary Min:";
            // 
            // cityNameLabel
            // 
            cityNameLabel.AutoSize = true;
            cityNameLabel.Location = new System.Drawing.Point(207, 81);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new System.Drawing.Size(38, 13);
            cityNameLabel.TabIndex = 27;
            cityNameLabel.Text = "CityID:";
            // 
            // positionNameLabel
            // 
            positionNameLabel.AutoSize = true;
            positionNameLabel.Location = new System.Drawing.Point(399, 46);
            positionNameLabel.Name = "positionNameLabel";
            positionNameLabel.Size = new System.Drawing.Size(58, 13);
            positionNameLabel.TabIndex = 25;
            positionNameLabel.Text = "PositionID:";
            // 
            // cataNameLabel
            // 
            cataNameLabel.AutoSize = true;
            cataNameLabel.Location = new System.Drawing.Point(12, 81);
            cataNameLabel.Name = "cataNameLabel";
            cataNameLabel.Size = new System.Drawing.Size(60, 13);
            cataNameLabel.TabIndex = 26;
            cataNameLabel.Text = "JobCataID:";
            // 
            // viewCountLabel
            // 
            viewCountLabel.AutoSize = true;
            viewCountLabel.Location = new System.Drawing.Point(584, 9);
            viewCountLabel.Name = "viewCountLabel";
            viewCountLabel.Size = new System.Drawing.Size(64, 13);
            viewCountLabel.TabIndex = 22;
            viewCountLabel.Text = "View Count:";
            // 
            // jobStatusLabel
            // 
            jobStatusLabel.AutoSize = true;
            jobStatusLabel.Location = new System.Drawing.Point(205, 46);
            jobStatusLabel.Name = "jobStatusLabel";
            jobStatusLabel.Size = new System.Drawing.Size(60, 13);
            jobStatusLabel.TabIndex = 24;
            jobStatusLabel.Text = "Job Status:";
            // 
            // jobDetailLabel
            // 
            jobDetailLabel.AutoSize = true;
            jobDetailLabel.Location = new System.Drawing.Point(12, 150);
            jobDetailLabel.Name = "jobDetailLabel";
            jobDetailLabel.Size = new System.Drawing.Size(57, 13);
            jobDetailLabel.TabIndex = 32;
            jobDetailLabel.Text = "Job Detail:";
            // 
            // jobNameLabel
            // 
            jobNameLabel.AutoSize = true;
            jobNameLabel.Location = new System.Drawing.Point(12, 46);
            jobNameLabel.Name = "jobNameLabel";
            jobNameLabel.Size = new System.Drawing.Size(58, 13);
            jobNameLabel.TabIndex = 23;
            jobNameLabel.Text = "Job Name:";
            // 
            // jobIDLabel
            // 
            jobIDLabel.AutoSize = true;
            jobIDLabel.Location = new System.Drawing.Point(12, 9);
            jobIDLabel.Name = "jobIDLabel";
            jobIDLabel.Size = new System.Drawing.Size(41, 13);
            jobIDLabel.TabIndex = 20;
            jobIDLabel.Text = "Job ID:";
            // 
            // cataNameComboBox
            // 
            this.cataNameComboBox.FormattingEnabled = true;
            this.cataNameComboBox.Location = new System.Drawing.Point(90, 78);
            this.cataNameComboBox.Name = "cataNameComboBox";
            this.cataNameComboBox.Size = new System.Drawing.Size(29, 21);
            this.cataNameComboBox.TabIndex = 6;
            // 
            // cityNameComboBox
            // 
            this.cityNameComboBox.FormattingEnabled = true;
            this.cityNameComboBox.Location = new System.Drawing.Point(289, 78);
            this.cityNameComboBox.Name = "cityNameComboBox";
            this.cityNameComboBox.Size = new System.Drawing.Size(32, 21);
            this.cityNameComboBox.TabIndex = 7;
            // 
            // positionNameComboBox
            // 
            this.positionNameComboBox.FormattingEnabled = true;
            this.positionNameComboBox.Location = new System.Drawing.Point(483, 43);
            this.positionNameComboBox.Name = "positionNameComboBox";
            this.positionNameComboBox.Size = new System.Drawing.Size(29, 21);
            this.positionNameComboBox.TabIndex = 5;
            // 
            // comNameComboBox
            // 
            this.comNameComboBox.FormattingEnabled = true;
            this.comNameComboBox.Location = new System.Drawing.Point(289, 6);
            this.comNameComboBox.Name = "comNameComboBox";
            this.comNameComboBox.Size = new System.Drawing.Size(32, 21);
            this.comNameComboBox.TabIndex = 1;
            // 
            // jobDataGridView
            // 
            this.jobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataGridView.Location = new System.Drawing.Point(15, 205);
            this.jobDataGridView.Name = "jobDataGridView";
            this.jobDataGridView.Size = new System.Drawing.Size(668, 261);
            this.jobDataGridView.TabIndex = 14;
            this.jobDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobDataGridView_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(608, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(313, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(151, 472);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(232, 472);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(15, 473);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // endDayDateTimePicker
            // 
            this.endDayDateTimePicker.Location = new System.Drawing.Point(483, 109);
            this.endDayDateTimePicker.Name = "endDayDateTimePicker";
            this.endDayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDayDateTimePicker.TabIndex = 11;
            // 
            // startDayDateTimePicker
            // 
            this.startDayDateTimePicker.Location = new System.Drawing.Point(483, 75);
            this.startDayDateTimePicker.Name = "startDayDateTimePicker";
            this.startDayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDayDateTimePicker.TabIndex = 8;
            // 
            // postDayDateTimePicker
            // 
            this.postDayDateTimePicker.Location = new System.Drawing.Point(90, 179);
            this.postDayDateTimePicker.Name = "postDayDateTimePicker";
            this.postDayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.postDayDateTimePicker.TabIndex = 13;
            // 
            // salaryMaxTextBox
            // 
            this.salaryMaxTextBox.Location = new System.Drawing.Point(90, 112);
            this.salaryMaxTextBox.Name = "salaryMaxTextBox";
            this.salaryMaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryMaxTextBox.TabIndex = 9;
            // 
            // salaryMinTextBox
            // 
            this.salaryMinTextBox.Location = new System.Drawing.Point(289, 112);
            this.salaryMinTextBox.Name = "salaryMinTextBox";
            this.salaryMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryMinTextBox.TabIndex = 10;
            // 
            // viewCountTextBox
            // 
            this.viewCountTextBox.Location = new System.Drawing.Point(654, 6);
            this.viewCountTextBox.Name = "viewCountTextBox";
            this.viewCountTextBox.ReadOnly = true;
            this.viewCountTextBox.Size = new System.Drawing.Size(29, 20);
            this.viewCountTextBox.TabIndex = 2;
            // 
            // jobStatusCheckBox
            // 
            this.jobStatusCheckBox.Location = new System.Drawing.Point(289, 41);
            this.jobStatusCheckBox.Name = "jobStatusCheckBox";
            this.jobStatusCheckBox.Size = new System.Drawing.Size(104, 24);
            this.jobStatusCheckBox.TabIndex = 4;
            this.jobStatusCheckBox.Text = "Available";
            this.jobStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // jobDetailTextBox
            // 
            this.jobDetailTextBox.Location = new System.Drawing.Point(90, 147);
            this.jobDetailTextBox.Name = "jobDetailTextBox";
            this.jobDetailTextBox.Size = new System.Drawing.Size(593, 20);
            this.jobDetailTextBox.TabIndex = 12;
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.Location = new System.Drawing.Point(90, 43);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobNameTextBox.TabIndex = 3;
            // 
            // jobIDTextBox
            // 
            this.jobIDTextBox.Location = new System.Drawing.Point(90, 6);
            this.jobIDTextBox.Name = "jobIDTextBox";
            this.jobIDTextBox.ReadOnly = true;
            this.jobIDTextBox.Size = new System.Drawing.Size(29, 20);
            this.jobIDTextBox.TabIndex = 0;
            // 
            // frmJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 500);
            this.Controls.Add(this.cataNameComboBox);
            this.Controls.Add(this.cityNameComboBox);
            this.Controls.Add(this.positionNameComboBox);
            this.Controls.Add(this.comNameComboBox);
            this.Controls.Add(comNameLabel);
            this.Controls.Add(this.jobDataGridView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(endDayLabel);
            this.Controls.Add(this.endDayDateTimePicker);
            this.Controls.Add(startDayLabel);
            this.Controls.Add(this.startDayDateTimePicker);
            this.Controls.Add(postDayLabel);
            this.Controls.Add(this.postDayDateTimePicker);
            this.Controls.Add(salaryMaxLabel);
            this.Controls.Add(this.salaryMaxTextBox);
            this.Controls.Add(salaryMinLabel);
            this.Controls.Add(this.salaryMinTextBox);
            this.Controls.Add(cityNameLabel);
            this.Controls.Add(positionNameLabel);
            this.Controls.Add(cataNameLabel);
            this.Controls.Add(viewCountLabel);
            this.Controls.Add(this.viewCountTextBox);
            this.Controls.Add(jobStatusLabel);
            this.Controls.Add(this.jobStatusCheckBox);
            this.Controls.Add(jobDetailLabel);
            this.Controls.Add(this.jobDetailTextBox);
            this.Controls.Add(jobNameLabel);
            this.Controls.Add(this.jobNameTextBox);
            this.Controls.Add(jobIDLabel);
            this.Controls.Add(this.jobIDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmJob";
            this.Text = "Jobs List";
            this.Load += new System.EventHandler(this.frmJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cataNameComboBox;
        private System.Windows.Forms.ComboBox cityNameComboBox;
        private System.Windows.Forms.ComboBox positionNameComboBox;
        private System.Windows.Forms.ComboBox comNameComboBox;
        private System.Windows.Forms.DataGridView jobDataGridView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DateTimePicker endDayDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDayDateTimePicker;
        private System.Windows.Forms.DateTimePicker postDayDateTimePicker;
        private System.Windows.Forms.TextBox salaryMaxTextBox;
        private System.Windows.Forms.TextBox salaryMinTextBox;
        private System.Windows.Forms.TextBox viewCountTextBox;
        private System.Windows.Forms.CheckBox jobStatusCheckBox;
        private System.Windows.Forms.TextBox jobDetailTextBox;
        private System.Windows.Forms.TextBox jobNameTextBox;
        private System.Windows.Forms.TextBox jobIDTextBox;
    }
}