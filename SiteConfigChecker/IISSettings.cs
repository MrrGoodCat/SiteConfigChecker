using Microsoft.Web.Administration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SiteConfigChecker
{
    class IISSettings
    {
        string certificateIISTambprint;


        public IISSettings()
        {

        }

        public void CheckSettings()
        {
            try
            {
                using (ServerManager serverManager = new ServerManager())
                {

                    Configuration config = serverManager.GetApplicationHostConfiguration();
                   // System.Windows.Forms.MessageBox.Show(String.Format("RootSectionGroup: {0}", config.GetSection()));
                    Site site = serverManager.Sites.FirstOrDefault(s => s.Name == "Default Web Site");
                    if (site != null)
                    {
                        Binding bindingHttp = site.Bindings.Where(b => b.Protocol == "http").FirstOrDefault();
                        //if(bindingHttp!=null)
                        //    System.Windows.Forms.MessageBox.Show("HTTP - Enable");

                        Binding bindingHttps = site.Bindings.Where(b => b.Protocol == "https").FirstOrDefault();
                        //if (bindingHttps != null)
                        //    System.Windows.Forms.MessageBox.Show("HTTPS - Enable");

                        certificateIISTambprint = BitConverter.ToString(bindingHttps.CertificateHash).Replace("-", "").ToLower().Trim();

                        System.Windows.Forms.MessageBox.Show("Certificate https valid:" + CheckDateValidationCertInfo(certificateIISTambprint).ToString());

                        Configuration configIIS=site.GetWebConfiguration();
                        foreach (var item in site.Applications)
                        {
                            System.Windows.Forms.MessageBox.Show(item.ToString());
                        }
                        //System.Windows.Forms.MessageBox.Show(configIIS.RootSectionGroup.Name);
                        //System.Windows.Forms.MessageBox.Show(configIIS.RootSectionGroup.SectionGroups.FirstOrDefault().Name);

                        //foreach (var item in configIIS.RootSectionGroup)
                        //{

                        //}
                    }
                }


            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
           
        }
        
        public X509Certificate2 GetCertificateInfo(string Thumbprint)
        {
            // stores and they friendly names
            var stores = new Dictionary<StoreName, string>()
            {
            {StoreName.My, "Personal"},
            {StoreName.Root, "Trusted roots"},
            {StoreName.TrustedPublisher, "Trusted publishers"}
            // and so on
            }.Select(s => new { store = new X509Store(s.Key, StoreLocation.CurrentUser), location = s.Value }).ToArray();

            foreach (var store in stores)
                store.store.Open(OpenFlags.ReadOnly); // open each store

            return stores.SelectMany(s => s.store.Certificates.Cast<X509Certificate2>()
            .Where(lmCert => lmCert.Thumbprint.Trim().ToLower() == Thumbprint.Trim().ToLower())).ToList().FirstOrDefault();

        }

        public void GetCertInfoPersonalLocalMachine()
        {
            // stores and they friendly names
            var stores = new Dictionary<StoreName, string>()
            {
            {StoreName.My, "Personal"},
            // and so on
            }.Select(s => new { store = new X509Store(s.Key, StoreLocation.LocalMachine), location = s.Value }).ToArray();

            foreach (var store in stores)
                store.store.Open(OpenFlags.ReadOnly); // open each store

            var list = stores.SelectMany(s => s.store.Certificates.Cast<X509Certificate2>()
                .Select(mCert => new CertificateDetails
                {
                    HasPrivateKey = mCert.HasPrivateKey,
                    Name = mCert.ToString(),
                    Location = s.location,
                    Issuer = mCert.Issuer,
                    IssuerName = mCert.GetSerialNumber().ToString(),
                    ValidFrom = mCert.NotBefore,
                    ValidTo = mCert.NotAfter,
                    Valid = ((mCert.NotBefore < DateTime.Now) && (mCert.NotAfter > DateTime.Now)) ? true : false,
                    Thumbprint = mCert.Thumbprint

                })).ToList();

        }

        public bool CheckDateValidationCertInfo(string Thumbprint)
        {
            bool result = false;

            // stores and they friendly names
            var storesLocalMachine = new Dictionary<StoreName, string>()
            {
            {StoreName.My, "Personal"},
            // and so on
            }.Select(s => new { store = new X509Store(s.Key, StoreLocation.LocalMachine), location = s.Value }).ToArray();

            foreach (var store in storesLocalMachine)
                store.store.Open(OpenFlags.ReadOnly); // open each store

            var listLocalMachine = storesLocalMachine.SelectMany(s => s.store.Certificates.Cast<X509Certificate2>()
                .Where(lmCert => lmCert.Thumbprint.Trim().ToLower() == Thumbprint.Trim().ToLower())).ToList();

            foreach (var cert in listLocalMachine)
            {
                //System.Windows.Forms.MessageBox.Show("Thumbprint LocalMachine -" + item.Thumbprint);
                //System.Windows.Forms.MessageBox.Show("Found LocalMachine");
                result = ((cert.NotBefore < DateTime.Now) && (cert.NotAfter > DateTime.Now)) ? true : false;
            }

            var storesCurrentUser = new Dictionary<StoreName, string>()
            {
            {StoreName.My, "Personal"},
            // and so on
            }.Select(s => new { store = new X509Store(s.Key, StoreLocation.CurrentUser), location = s.Value }).ToArray();

            foreach (var store in storesCurrentUser)
                store.store.Open(OpenFlags.ReadOnly); // open each store

            var listCurentUser = storesCurrentUser.SelectMany(s => s.store.Certificates.Cast<X509Certificate2>()
                .Where(lmCert => lmCert.Thumbprint.Trim().ToLower() == Thumbprint.Trim().ToLower())).ToList();

            foreach (var cert in listCurentUser)
            {
                //System.Windows.Forms.MessageBox.Show("Thumbprint CurentUser -" + item.Thumbprint);
                //System.Windows.Forms.MessageBox.Show("Found CurentUser");
                result = ((cert.NotBefore < DateTime.Now) && (cert.NotAfter > DateTime.Now)) ? true : false;
            }

           
                return result;
        }
    }
}

