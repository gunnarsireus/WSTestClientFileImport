namespace WSTestClientFileImport
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblImportCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImportCode = new System.Windows.Forms.TextBox();
            this.lblApplication = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtEntityCode = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbApplication = new System.Windows.Forms.ComboBox();
            this.cbCertificate = new System.Windows.Forms.ComboBox();
            this.lblCertificateSN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.ofdFilePath = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblImportCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtImportCode);
            this.groupBox1.Controls.Add(this.lblApplication);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtEntityCode);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.cbApplication);
            this.groupBox1.Controls.Add(this.cbCertificate);
            this.groupBox1.Controls.Add(this.lblCertificateSN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XLEDGER.NET Authentication";
            // 
            // lblImportCode
            // 
            this.lblImportCode.AutoSize = true;
            this.lblImportCode.Location = new System.Drawing.Point(6, 151);
            this.lblImportCode.Name = "lblImportCode";
            this.lblImportCode.Size = new System.Drawing.Size(64, 13);
            this.lblImportCode.TabIndex = 7;
            this.lblImportCode.Text = "Import Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Entity Code";
            // 
            // txtImportCode
            // 
            this.txtImportCode.Location = new System.Drawing.Point(112, 148);
            this.txtImportCode.Name = "txtImportCode";
            this.txtImportCode.Size = new System.Drawing.Size(248, 20);
            this.txtImportCode.TabIndex = 5;
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.Location = new System.Drawing.Point(6, 71);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(59, 13);
            this.lblApplication.TabIndex = 7;
            this.lblApplication.Text = "Application";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 100);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "User Name";
            // 
            // txtEntityCode
            // 
            this.txtEntityCode.Location = new System.Drawing.Point(112, 172);
            this.txtEntityCode.Name = "txtEntityCode";
            this.txtEntityCode.Size = new System.Drawing.Size(60, 20);
            this.txtEntityCode.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(112, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(248, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(248, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 126);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // cbApplication
            // 
            this.cbApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApplication.FormattingEnabled = true;
            this.cbApplication.Items.AddRange(new object[] {
            "XLEDGERTEST",
            "XLEDGERDEMO",
            "XLEDGER"});
            this.cbApplication.Location = new System.Drawing.Point(112, 68);
            this.cbApplication.Name = "cbApplication";
            this.cbApplication.Size = new System.Drawing.Size(376, 21);
            this.cbApplication.TabIndex = 2;
            // 
            // cbCertificate
            // 
            this.cbCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCertificate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCertificate.FormattingEnabled = true;
            this.cbCertificate.Location = new System.Drawing.Point(6, 37);
            this.cbCertificate.Name = "cbCertificate";
            this.cbCertificate.Size = new System.Drawing.Size(482, 21);
            this.cbCertificate.TabIndex = 1;
            // 
            // lblCertificateSN
            // 
            this.lblCertificateSN.AutoSize = true;
            this.lblCertificateSN.Location = new System.Drawing.Point(6, 21);
            this.lblCertificateSN.Name = "lblCertificateSN";
            this.lblCertificateSN.Size = new System.Drawing.Size(54, 13);
            this.lblCertificateSN.TabIndex = 4;
            this.lblCertificateSN.Text = "Certificate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FilePath";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(69, 229);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(393, 20);
            this.txtFilePath.TabIndex = 7;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilePath.Location = new System.Drawing.Point(469, 227);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(31, 23);
            this.btnFilePath.TabIndex = 8;
            this.btnFilePath.Text = "...";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 255);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(89, 23);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.Text = "&Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 284);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(497, 210);
            this.txtResult.TabIndex = 10;
            this.txtResult.WordWrap = false;
            // 
            // ofdFilePath
            // 
            this.ofdFilePath.Filter = "All Files|*.*";
            this.ofdFilePath.Title = "Select File to Upload";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 506);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtEntityCode;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cbCertificate;
        private System.Windows.Forms.Label lblCertificateSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.OpenFileDialog ofdFilePath;
        private System.Windows.Forms.Label lblImportCode;
        private System.Windows.Forms.TextBox txtImportCode;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.ComboBox cbApplication;
    }
}

