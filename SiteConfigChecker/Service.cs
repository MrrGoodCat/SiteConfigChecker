using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteConfigChecker
{
    class Service
    {
        public string DisplayName { get; set; }
        public ServiceStatusEnum Status { get; set; }

        public Service(string name)
        {
            DisplayName = name;
        }
    }
}
