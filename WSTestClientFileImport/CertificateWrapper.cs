using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WSTestClientFileImport
{
    public class CertificateWrapper
    {
        private X509Certificate2 _cert;

        /// <summary>
        /// The Certificate
        /// </summary>
        public X509Certificate2 Certificate
        {
            get
            {
                return this._cert;
            }
        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public CertificateWrapper()
        {
        }

        /// <summary>
        /// Constructor for Displaying Certificates
        /// </summary>
        /// <param name="cert">The Certificate</param>
        public CertificateWrapper(X509Certificate2 cert)
        {
            this._cert = cert;
        }

        /// <summary>
        /// Text Representation
        /// </summary>
        /// <returns>The Certificate Text Representation</returns>
        public override string ToString()
        {
            if (this._cert == null)
            {
                return string.Empty;
            }
            else
            {
                string sSubject = this._cert.Subject;
                if (sSubject.Length > 70)
                {
                    sSubject = sSubject.Substring(0, 67) + "...";
                }

                return string.Format("{0} [Expires: {1}]", sSubject, this._cert.GetExpirationDateString());
            }
        }

        /// <summary>
        /// The Serial Number
        /// </summary>
        public string SerialNumber
        {
            get
            {
                if (this._cert == null)
                {
                    return "0";
                }
                else
                {
                    return this._cert.SerialNumber;
                }
            }
        }
    }
}
