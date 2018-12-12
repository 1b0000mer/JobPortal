namespace JobPortal
{
    partial class Education
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecripEdu = new System.Windows.Forms.TextBox();
            this.txtNameEdu = new System.Windows.Forms.TextBox();
            this.txtFromEdu = new System.Windows.Forms.TextBox();
            this.txtEduID = new System.Windows.Forms.TextBox();
            this.dataGridViewEducation = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEducation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(525, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(606, 268);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserID";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(84, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(256, 20);
            this.txtUserID.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDecripEdu);
            this.panel1.Controls.Add(this.txtNameEdu);
            this.panel1.Controls.Add(this.txtFromEdu);
            this.panel1.Controls.Add(this.txtEduID);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 123);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "FromEdu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "DecripEdu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NameEdu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EduID";
            // 
            // txtDecripEdu
            // 
            this.txtDecripEdu.Location = new System.Drawing.Point(424, 64);
            this.txtDecripEdu.Name = "txtDecripEdu";
            this.txtDecripEdu.Size = new System.Drawing.Size(211, 20);
            this.txtDecripEdu.TabIndex = 3;
            // 
            // txtNameEdu
            // 
            this.txtNameEdu.Location = new System.Drawing.Point(84, 67);
            this.txtNameEdu.Name = "txtNameEdu";
            this.txtNameEdu.Size = new System.Drawing.Size(256, 20);
            this.txtNameEdu.TabIndex = 3;
            // 
            // txtFromEdu
            // 
            this.txtFromEdu.Location = new System.Drawing.Point(424, 9);
            this.txtFromEdu.Name = "txtFromEdu";
            this.txtFromEdu.Size = new System.Drawing.Size(211, 20);
            this.txtFromEdu.TabIndex = 3;
            // 
            // txtEduID
            // 
            this.txtEduID.Location = new System.Drawing.Point(84, 35);
            this.txtEduID.Name = "txtEduID";
            this.txtEduID.Size = new System.Drawing.Size(256, 20);
            this.txtEduID.TabIndex = 3;
            // 
            // dataGridViewEducation
            // 
            this.dataGridViewEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEducation.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewEducation.Name = "dataGridViewEducation";
            this.dataGridViewEducation.Size = new System.Drawing.Size(669, 121);
            this.dataGridViewEducation.TabIndex = 5;
            // 
            // Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 298);
            this.Controls.Add(this.dataGridViewEducation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Education";
            this.Text = "Education";
            this.Load += new System.EventHandler(this.Education_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEducation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewEducation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecripEdu;
        private System.Windows.Forms.TextBox txtNameEdu;
        private System.Windows.Forms.TextBox txtFromEdu;
        private System.Windows.Forms.TextBox txtEduID;
    }
}