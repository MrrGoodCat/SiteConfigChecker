using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteConfigChecker
{
    public class CertificateDetails
    {
        public string Name { get; set; }
        public bool HasPrivateKey { get; set; }
        public string Location { get; set; }
        public string Issuer { get; set; }
        public string IssuerName { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool Valid { get; set; }
        public string Thumbprint { get; set; }
    }
}
