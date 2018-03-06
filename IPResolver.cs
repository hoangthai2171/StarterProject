using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace IPResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Nhap IP Address: ");
            string ip = Console.ReadLine();
            IPHostEntry Iphe = Dns.Resolve(ip);
            Console.WriteLine("IP Address: "+ip);
            Console.WriteLine("Ten Host: "+Iphe.HostName);
        }
    }
}
