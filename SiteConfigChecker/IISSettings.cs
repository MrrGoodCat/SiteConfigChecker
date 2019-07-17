using Microsoft.Web.Administration;
using NiceApplications.SystemAdministrator.CentralAdministration.Common;
using SiteConfigChecker.Enums;
using SiteConfigChecker.Validation_Infrastructure;
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
        bool httpsEnable = false;
        string siteName = "Default Web Site";


        public IISSettings()
        {

        }

        public void CheckSettings()
        {
            try
            {
                //string site = System.Environment.GetEnvironmentVariable("COMPUTERNAME");

                string vdRelativePath = "NiceApplications";

                using (ServerManager serverManager = new ServerManager())
                {
                    Configuration config = serverManager.GetApplicationHostConfiguration();
                    System.Windows.Forms.MessageBox.Show(String.Concat(config.GetLocationPaths()));

                    ConfigurationSection windowsAuthenticationSection = config.GetSection("system.webServer/security/authentication/windowsAuthentication", siteName + "/" + vdRelativePath);
                    var temp1= windowsAuthenticationSection["enabled"];
                    ConfigurationSection anonymousAuthenticationSection = config.GetSection("system.webServer/security/authentication/anonymousAuthentication", siteName + "/" + vdRelativePath);
                    var temp2 = anonymousAuthenticationSection["enabled"];
                    ConfigurationSection digestAuthenticationSection = config.GetSection("system.webServer/security/authentication/digestAuthentication", siteName + "/" + vdRelativePath);
                    var temp3 = digestAuthenticationSection["enabled"];
                    ConfigurationSection basicAuthenticationSection = config.GetSection("system.webServer/security/authentication/basicAuthentication", siteName + "/" + vdRelativePath);
                    var temp4 = basicAuthenticationSection["enabled"];
                    System.Windows.Forms.MessageBox.Show(temp1.ToString());
                    System.Windows.Forms.MessageBox.Show(temp2.ToString());
                    System.Windows.Forms.MessageBox.Show(temp3.ToString());
                    System.Windows.Forms.MessageBox.Show(temp4.ToString());

                    Site site = serverManager.Sites.FirstOrDefault(s => s.Name == "Default Web Site");
                    //site.GetCollection
                    if (site != null)
                    {

                        //Binding bindingHttp = site.Bindings.Where(b => b.Protocol == "http").FirstOrDefault();
                        ////if(bindingHttp!=null)
                        ////    System.Windows.Forms.MessageBox.Show("HTTP - Enable");

                        //Binding bindingHttps = site.Bindings.Where(b => b.Protocol == "https").FirstOrDefault();
                        ////if (bindingHttps != null)
                        ////    System.Windows.Forms.MessageBox.Show("HTTPS - Enable");

                        //certificateIISTambprint = BitConverter.ToString(bindingHttps.CertificateHash).Replace("-", "").ToLower().Trim();

                        //System.Windows.Forms.MessageBox.Show("Certificate https valid:" + CheckDateValidationCertPersonalInfo(certificateIISTambprint).ToString());

                        //Configuration configIIS = site.GetWebConfiguration();
                        //Application app = site.Applications.Where(appPath => appPath.Path.ToLower().Trim() == "/niceapplications").FirstOrDefault();
                        //if (app == null)
                        //{
                        //    System.Windows.Forms.MessageBox.Show("App null");
                        //    return;
                        //}


                        //foreach (var item in app.ChildElements.FirstOrDefault().)
                        //{

                        //    System.Windows.Forms.MessageBox.Show(item.Name.ToString());
                        //}
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

        public List<KeyValuePair<string, string>> CheckAuthentification()
        {
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();
            result = CheckAuthentification("");
            foreach (var item in result)
            {
                System.Windows.Forms.MessageBox.Show("Root - " + item.Key + ":" + item.Value);
            }

            result =CheckAuthentification("Nice");
            foreach (var item in result)
            {
                System.Windows.Forms.MessageBox.Show("Nice - "+item.Key+":"+ item.Value);
            }

            result = CheckAuthentification("NiceApplications");
            foreach (var item in result)
            {
                System.Windows.Forms.MessageBox.Show("NiceApplications - "+item.Key + ":" + item.Value);
            }
            //CheckAuthentification("NiceApplications");
            return result;
        }

        private List<KeyValuePair<string, string>> CheckAuthentification(string applicationName)
        {
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();

            bool windowsAuthentication = false;
            bool anonymousAuthentication = false;
            bool digestAuthentication = false;
            bool basicAuthentication = false;
            string sslFlags=String.Empty;
            try
            {
                using (ServerManager serverManager = new ServerManager())
                {
                    Configuration config = serverManager.GetApplicationHostConfiguration();

                    ConfigurationSection windowsAuthenticationSection = config.GetSection("system.webServer/security/authentication/windowsAuthentication", siteName + "/" + applicationName);
                    if(windowsAuthenticationSection!=null)
                        Boolean.TryParse(windowsAuthenticationSection["enabled"].ToString(),out windowsAuthentication);

                    ConfigurationSection anonymousAuthenticationSection = config.GetSection("system.webServer/security/authentication/anonymousAuthentication", siteName + "/" + applicationName);
                    if (anonymousAuthenticationSection != null)
                        Boolean.TryParse(anonymousAuthenticationSection["enabled"].ToString(), out anonymousAuthentication);

                    ConfigurationSection digestAuthenticationSection = config.GetSection("system.webServer/security/authentication/digestAuthentication", siteName + "/" + applicationName);
                    if (digestAuthenticationSection != null)
                        Boolean.TryParse(digestAuthenticationSection["enabled"].ToString(), out digestAuthentication);

                    ConfigurationSection basicAuthenticationSection = config.GetSection("system.webServer/security/authentication/basicAuthentication", siteName + "/" + applicationName);
                    if(basicAuthenticationSection != null)
                        Boolean.TryParse(basicAuthenticationSection["enabled"].ToString(), out basicAuthentication);

                    ConfigurationSection accessSection = config.GetSection("system.webServer/security/access", siteName + "/" + applicationName);
                    if (accessSection != null)
                        sslFlags= accessSection["sslFlags"].ToString();

                }

                result.Add(new KeyValuePair<string, string>("windowsAuthentication", windowsAuthentication.ToString()));
                result.Add(new KeyValuePair<string, string>("anonymousAuthentication", anonymousAuthentication.ToString()));
                result.Add(new KeyValuePair<string, string>("digestAuthentication", digestAuthentication.ToString()));
                result.Add(new KeyValuePair<string, string>("basicAuthentication", basicAuthentication.ToString()));
                result.Add(new KeyValuePair<string, string>("sslFlags", sslFlags));
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return result;
        }



        public ValidationResult GetBindings()
        {

            List<KeyValuePair<string,string>> resultDetailed=new List<KeyValuePair<string, string>>();
            ValidationResult result;
            
            try
            {
                using (ServerManager serverManager = new ServerManager())
                {

                    Configuration config = serverManager.GetApplicationHostConfiguration();

                    Site site = serverManager.Sites.FirstOrDefault(s => s.Name == "Default Web Site");
                    if (site != null)
                    {

                        foreach (var bind in site.Bindings)
                        {
                            resultDetailed.Add(new KeyValuePair<string, string>(bind.Protocol, bind.BindingInformation));
                            if(bind.Protocol.ToLower().Contains("https"))
                                httpsEnable=true;
                        }
                    }
                }
                result = new ValidationResult(Result.Successful, resultDetailed);
            }
            catch (Exception ex)
            {
                resultDetailed.Add(new KeyValuePair<string, string>("Exception", ex.Message));
                result = new ValidationResult(Result.Failed, resultDetailed);
            }
            return result;
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
                    Name = mCert.Subject,
                    Location = s.location,
                    Issuer = mCert.Issuer,
                    IssuerName = mCert.GetSerialNumber().ToString(),
                    ValidFrom = mCert.NotBefore,
                    ValidTo = mCert.NotAfter,
                    Valid = ((mCert.NotBefore < DateTime.Now) && (mCert.NotAfter > DateTime.Now)) ? true : false,
                    Thumbprint = mCert.Thumbprint

                })).ToList();

        }

        public bool CheckDateValidationCertPersonalInfo(string Thumbprint, string HostName=null)
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
                if ((HostName == null) | (!String.IsNullOrWhiteSpace(HostName) && cert.Subject.ToLower().Contains(HostName.ToLower())))
                {
                    result = ((cert.NotBefore < DateTime.Now) && (cert.NotAfter > DateTime.Now)) ? true : false;
                }
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
                if ((HostName == null) | (!String.IsNullOrWhiteSpace(HostName) && cert.Subject.ToLower().Contains(HostName.ToLower())))
                {
                    result = ((cert.NotBefore < DateTime.Now) && (cert.NotAfter > DateTime.Now)) ? true : false;
                }
                
            }
           
            return result;
        }
    }
}

