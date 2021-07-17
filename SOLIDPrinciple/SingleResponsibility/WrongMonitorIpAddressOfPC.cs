using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public static class WrongMonitorIpAddressOfPC
    {
        private static List<string> _ipAddres = new List<string>();

        public static void GetIpAddress()
        {
            var hostName = Dns.GetHostName();
            var ipHost = Dns.GetHostEntry(hostName);

            foreach (var item in ipHost.AddressList)
            {
                _ipAddres.Add(item.ToString());
            }
        }

        //PrintBlock
        public static void PrintIpAddrToConsole()
        {
            foreach (var item in _ipAddres)
            {
                Console.WriteLine(item);
            }
        }

        public static async Task PrintIpAddrToTextFile()
        {
            using (StreamWriter sw = new StreamWriter("IpAddress.txt"))
            {
                foreach (var item in _ipAddres)
                {
                    await sw.WriteLineAsync(item);
                }
            }
        }
    }
}
