using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Get_Local_IP
{
    class Program
    {
        static void Main(string[] args)
        {
            String HostName = string.Empty;
            HostName = Dns.GetHostName();
            Console.WriteLine("Ten may cuc bo: " + HostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(HostName);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
