﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.ServiceProcess;
//using System.Text;
//using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using SKT.Common;
using System.Configuration;

namespace SKT.PUSHService
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new PushService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
