namespace JobPortal
{
    partial class Main
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
            this.btnCompanyInfo = new System.Windows.Forms.Button();
            this.btnInfoUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompanyInfo
            // 
            this.btnCompanyInfo.Location = new System.Drawing.Point(79, 97);
            this.btnCompanyInfo.Name = "btnCompanyInfo";
            this.btnCompanyInfo.Size = new System.Drawing.Size(94, 49);
            this.btnCompanyInfo.TabIndex = 0;
            this.btnCompanyInfo.Text = "CompanyInfo";
            this.btnCompanyInfo.UseVisualStyleBackColor = true;
            this.btnCompanyInfo.Click += new System.EventHandler(this.btnCompanyInfo_Click);
            // 
            // btnInfoUser
            // 
            this.btnInfoUser.Location = new System.Drawing.Point(269, 97);
            this.btnInfoUser.Name = "btnInfoUser";
            this.btnInfoUser.Size = new System.Drawing.Size(96, 49);
            this.btnInfoUser.TabIndex = 1;
            this.btnInfoUser.Text = "InfoUser";
            this.btnInfoUser.UseVisualStyleBackColor = true;
            this.btnInfoUser.Click += new System.EventHandler(this.btnInfoUser_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 491);
            this.Controls.Add(this.btnInfoUser);
            this.Controls.Add(this.btnCompanyInfo);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompanyInfo;
        private System.Windows.Forms.Button btnInfoUser;
    }
}