using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using TencentCloud.Common;
using TencentCloud.Dnspod.V20210323;
using TencentCloud.Dnspod.V20210323.Models;

namespace TDNSService
{
    public partial class TDNSService : ServiceBase
    {
        public TDNSService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Logger logger = new Logger().Instance;
            logger.Write("进程启动");
            IpMoniter moniter = new IpMoniter();
            Thread td = new Thread(moniter.Start_Process);
            td.IsBackground = false;
            td.Start();
        }

        protected override void OnStop()
        {
            
        }

        
    }
}
