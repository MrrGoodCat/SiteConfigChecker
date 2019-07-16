using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteConfigChecker
{
    internal enum ServiceStatusEnum
    {
        //
        // Summary:
        //     The service is not running. This corresponds to the Win32 SERVICE_STOPPED constant,
        //     which is defined as 0x00000001.
        Stopped,
        //
        // Summary:
        //     The service is starting. This corresponds to the Win32 SERVICE_START_PENDING
        //     constant, which is defined as 0x00000002.
        StartPending,
        //
        // Summary:
        //     The service is stopping. This corresponds to the Win32 SERVICE_STOP_PENDING constant,
        //     which is defined as 0x00000003.
        StopPending,
        //
        // Summary:
        //     The service is running. This corresponds to the Win32 SERVICE_RUNNING constant,
        //     which is defined as 0x00000004.
        Running,
        //
        // Summary:
        //     The service continue is pending. This corresponds to the Win32 SERVICE_CONTINUE_PENDING
        //     constant, which is defined as 0x00000005.
        ContinuePending,
        //
        // Summary:
        //     The service pause is pending. This corresponds to the Win32 SERVICE_PAUSE_PENDING
        //     constant, which is defined as 0x00000006.
        PausePending,
        //
        // Summary:
        //     The service is paused. This corresponds to the Win32 SERVICE_PAUSED constant,
        //     which is defined as 0x00000007.
        Paused,
        //
        // Summary:
        //     The service status is undefined. This custom service status.
        Undefined
    }
}
