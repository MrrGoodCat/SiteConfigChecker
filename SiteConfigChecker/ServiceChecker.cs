using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace SiteConfigChecker
{
    internal class ServiceChecker
    {
        internal ServiceStatusEnum Check(string serviceDisplayName, string serverLocation = null)
        {
            if (serverLocation == null)
            {
                serverLocation = Environment.MachineName;
            }
            ServiceStatusEnum serviceStatus = ServiceStatusEnum.Undefined;

            ServiceController[] services = ServiceController.GetServices();
            foreach (var service in services)
            {
                if (service.DisplayName == serviceDisplayName)
                {
                    serviceStatus = Parse(service.Status);
                }
            }
            return serviceStatus;
        }

        private ServiceStatusEnum Parse(ServiceControllerStatus status)
        {
            switch (status)
            {
                case ServiceControllerStatus.ContinuePending:
                    {
                        return ServiceStatusEnum.ContinuePending;
                    }
                case ServiceControllerStatus.Paused:
                    {
                        return ServiceStatusEnum.Paused;
                    }
                case ServiceControllerStatus.PausePending:
                    {
                        return ServiceStatusEnum.PausePending;
                    }
                case ServiceControllerStatus.Running:
                    {
                        return ServiceStatusEnum.Running;
                    }
                case ServiceControllerStatus.StartPending:
                    {
                        return ServiceStatusEnum.StartPending;
                    }
                case ServiceControllerStatus.Stopped:
                    {
                        return ServiceStatusEnum.Stopped;
                    }
                case ServiceControllerStatus.StopPending:
                    {
                        return ServiceStatusEnum.StopPending;
                    }
                default:
                    {
                        return ServiceStatusEnum.Undefined;
                    }
            }
        }
    }
}
