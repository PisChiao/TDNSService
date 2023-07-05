using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Dnspod.V20210323.Models;
using TencentCloud.Dnspod.V20210323;
using System.Threading;

namespace TDNSService
{
    public class IpMoniter
    {
        public DomainConfig config = new DomainConfig();
        public Logger logger = new Logger().Instance;
        public bool runing = true;
        public void Start_Process()
        {
            config.Read();
            while (runing)
            {
                checkIp();
                Thread.Sleep(int.Parse(config.interval.ToString()));
            }
        }
        public void Stop_Process() 
        { 
            runing = false;
        }

        public void checkIp()
        {
            string localIp = GetIP();
            if (localIp == "")
            {
                logger.Write("获取到的IP为空");
                return;
            }
            DescribeRecordListResponse dnsIpResponse = GetDnsIp();
            if (dnsIpResponse is null)
            {
                logger.Write("无法获取到当前解析IP");
                return;
            }
            try
            {
                if (localIp != dnsIpResponse.RecordList[0].Value)
                {
                    SetDnsIp(dnsIpResponse.RecordList[0].RecordId, localIp);
                    checkIp();
                }
                return;
            }
            catch
            {
                return;
            }
        }
        //获取实时的本地公网IP
        public string GetIP()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string url = "https://ifconfig.me/";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                string responseBodystr = response.Content.ReadAsStringAsync().Result;
                return responseBodystr;
            }
            catch (Exception ex)
            {
                logger.Write(ex.Message);
                return "";
            }
        }
        //获取当前DNS解析的IP地址
        public DescribeRecordListResponse GetDnsIp()
        {
            try
            {
                // 实例化一个认证对象，入参需要传入腾讯云账户secretId，secretKey,此处还需注意密钥对的保密
                // 密钥可前往https://console.cloud.tencent.com/cam/capi网站进行获取
                Credential cred = new Credential
                {
                    SecretId = config.secretId,
                    SecretKey = config.secretKey
                };
                // 实例化要请求产品的client对象
                DnspodClient client = new DnspodClient(cred, "");
                // 实例化一个请求对象,用于请求解析记录列表
                DescribeRecordListRequest req = new DescribeRecordListRequest();
                req.Domain = config.domainName;
                req.Subdomain = config.hostName;
                // 返回的resp是一个DescribeRecordListResponse的实例，与请求对象对应
                DescribeRecordListResponse resp = client.DescribeRecordListSync(req);
                return resp;
            }
            catch (Exception ex)
            {
                logger.Write(ex.Message);
                return null;
            }
        }
        //设置DNSIP
        public void SetDnsIp(ulong? recordId, string newIp)
        {
            try
            {
                if (recordId is null)
                {
                    return;
                }
                Credential cred = new Credential
                {
                    SecretId = config.secretId,
                    SecretKey = config.secretKey
                };

                DnspodClient client = new DnspodClient(cred, "");
                ModifyDynamicDNSRequest req = new ModifyDynamicDNSRequest();
                req.Domain = config.domainName;
                req.SubDomain = config.hostName;
                req.RecordId = recordId;
                req.RecordLine = "默认";
                req.Value = newIp;
                ModifyDynamicDNSResponse resp = client.ModifyDynamicDNSSync(req);
            }
            catch (Exception ex)
            {
                logger.Write(ex.Message);
                return;
            }
        }
    }
}
