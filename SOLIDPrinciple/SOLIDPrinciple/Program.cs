using System;
using System.Collections.Generic;
using System.Net;
using SingleResponsibility;


namespace SOLIDPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            WrongMonitorIpAddressOfPC.GetIpAddress();
            WrongMonitorIpAddressOfPC.PrintIpAddrToConsole();

            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            var list = RightMonitorIpAddressOfPC.GetIpAddress();
            var print = new PrintData(list);
            print.PrintIpAddrToConsole();

        }
    }
}
