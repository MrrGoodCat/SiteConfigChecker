using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NiceApplications.CommunicationLayer;
using NiceApplications.LoginUtils;
using NiceApplications.SystemAdministrator.CentralAdministration.Common;
using NiceApplications.SystemAdministrator.Common;
using NiceApplications.UsersAdministrator.Common;

namespace SiteConfigChecker
{
    public class Client
    {
        LoginToken m_loginInfo;
        public string tokenWithID;
        public Client(string appServerLocation, string username, string password)
        {
            string appServer = appServerLocation;
            string m_remotingHostAndPort = appServer + ":62070";
            string m_assembliesBin = "http://" + appServer + "/NiceApplications/ClientBin";

            NiceApplications.CommunicationLayer.TimeResolver.InitClient(m_remotingHostAndPort, m_assembliesBin);
            LoginHelper m_loginHelper = new LoginHelper(m_remotingHostAndPort, false);
            m_loginInfo = m_loginHelper.Login(username, password);
            tokenWithID = "1_" + m_loginInfo.Token;
            //Thread.Sleep(1000);
        }

        public Client(string appServerLocation, string username, string password, string domain)
        {
            string appServer = appServerLocation;
            string m_remotingHostAndPort = appServer + ":62070";
            string m_assembliesBin = "http://" + appServer + "/NiceApplications/ClientBin";

            NiceApplications.CommunicationLayer.TimeResolver.InitClient(m_remotingHostAndPort, m_assembliesBin);
            LoginHelper m_loginHelper = new LoginHelper(m_remotingHostAndPort, false);
            m_loginInfo = m_loginHelper.Login(username, password, domain);
            tokenWithID = "1_" + m_loginInfo.Token;
            //Thread.Sleep(1000);
        }


        public void GetComponents()
        {
            
        }
    }
}
