using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WSTestClientFileImport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Certificates
            this.FillCertificates();

            // Default Application
            this.cbApplication.SelectedIndex = 0;
        }

        #region Certificates
        private void FillCertificates()
        {
            // Clear
            this.cbCertificate.Items.Clear();

            // Open Certificate Store
            X509Store xs = new X509Store(StoreLocation.CurrentUser);
            xs.Open(OpenFlags.OpenExistingOnly | OpenFlags.ReadOnly);

            // Search by Issuer
            X509Certificate2Collection xcc = (X509Certificate2Collection)xs.Certificates.Find(X509FindType.FindByIssuerName, "XLEDGER.NET", true);

            // Close Certificate Store
            xs.Close();

            if (xcc.Count == 0)
            {
                // Add Empty Item
                this.cbCertificate.Items.Add(new CertificateWrapper());
            }
            else
            {
                // Add Certificates
                for (int i = 0; i < xcc.Count; i++)
                {
                    this.cbCertificate.Items.Add(new CertificateWrapper(xcc[i]));
                }

                // Default First
                this.cbCertificate.SelectedIndex = 0;
            }
        }
        #endregion

        #region Helpers
        private bool ValidateParams()
        {
            if (((CertificateWrapper)this.cbCertificate.SelectedItem).Certificate == null || this.txtUserName.Text.Trim().Length == 0 || this.txtPassword.Text.Trim().Length == 0 || this.txtImportCode.Text.Trim().Length == 0 || this.txtEntityCode.Text.Trim().Length == 0)
            {
                this.LogMessage("Missing Certificate, User Name, Password, Import Code or Entity Code");
                return false;
            }

            return true;
        }

        private void SetWaitCursor(bool bShow)
        {
            System.Windows.Forms.Cursor.Current = bShow ? System.Windows.Forms.Cursors.WaitCursor : System.Windows.Forms.Cursors.Default;
        }

        private void LogMessage(string sMessage)
        {
            this.txtResult.Text += sMessage + "\r\n";
        }
        #endregion

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            // Open File
            if (ofdFilePath.ShowDialog() == DialogResult.OK)
            {
                this.txtFilePath.Text = ofdFilePath.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            SetWaitCursor(true);

            try
            {
                if (ValidateParams())
                {
                    // Authenticate
                    X.Authentication.AuthenticationSoapClient ac = new WSTestClientFileImport.X.Authentication.AuthenticationSoapClient();
                    string sKey = ac.LogonKey(this.txtUserName.Text, this.txtPassword.Text, this.cbApplication.SelectedItem.ToString());

                    // File Upload Web Service
                    X.FileUpload.FileUploadSoapClient fc = new WSTestClientFileImport.X.FileUpload.FileUploadSoapClient();

                    // Set Certificate
                    fc.ClientCredentials.ClientCertificate.Certificate = ((CertificateWrapper)this.cbCertificate.SelectedItem).Certificate;

                    // Open File
                    using (FileStream fs = File.OpenRead(this.txtFilePath.Text))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            // Put File
                            long lReceipt = fc.ReceiveFile(this.txtUserName.Text, sKey, this.cbApplication.SelectedItem.ToString(), this.txtFilePath.Text, br.ReadBytes((int)fs.Length), this.txtImportCode.Text, int.Parse(this.txtEntityCode.Text));

                            // Log
                            this.LogMessage(string.Format("Successfully Uploaded File: {0}. Receipt: {1}", this.txtFilePath.Text, lReceipt));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.LogMessage(string.Format("Failed to Upload File: {0}. ", this.txtFilePath.Text) + ex.Message);
            }

            SetWaitCursor(false);
        }
    }
}
