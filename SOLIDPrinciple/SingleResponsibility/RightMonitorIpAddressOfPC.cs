using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace SingleResponsibility
{
    public static class RightMonitorIpAddressOfPC
    {
        public static List<string> GetIpAddress()
        {
            var hostName = Dns.GetHostName();
            var ipHost = Dns.GetHostEntry(hostName);

            return ipHost.AddressList.Select(item => item.ToString()).ToList();
        }
    }

    public class PrintData
    {
        private static List<string> _data4Print;

        public PrintData(List<string> data4Print)
        {
            _data4Print = data4Print;
        }
        public void PrintIpAddrToConsole()
        {
            foreach (var item in _data4Print)
            {
                Console.WriteLine(item);
            }
        }

        public async Task PrintIpAddrToTextFile()
        {
            using (StreamWriter sw = new StreamWriter("IpAddress.txt"))
            {
                foreach (var item in _data4Print)
                {
                    await sw.WriteLineAsync(item);
                }
            }
        }
    }
}
