﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        //private static Client instance;

        //private Client()
        //{ }

        //public static Client getInstance()
        //{
        //    if (instance == null)
        //        instance = new Client();
        //    return instance;
        //}

        LoginToken m_loginInfo;
        string tokenWithID;
        public Client(string appServerLocation, string domain, string username, string password)
        {
            string appServer = appServerLocation;
            string m_remotingHostAndPort = appServer + ":62070";
            string m_assembliesBin = "http://" + appServer + "/NiceApplications/ClientBin";



            NiceApplications.CommunicationLayer.TimeResolver.InitClient(m_remotingHostAndPort, m_assembliesBin);
            LoginHelper m_loginHelper = new LoginHelper(m_remotingHostAndPort, false);
            m_loginInfo = m_loginHelper.Login(username, password, domain);
            tokenWithID = "1_" + m_loginInfo.Token;
            // Thread.Sleep(1000);
        }
    }
}
