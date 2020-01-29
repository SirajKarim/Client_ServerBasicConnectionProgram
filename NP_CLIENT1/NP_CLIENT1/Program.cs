using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace NP_CLIENT1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Loopback;
            IPEndPoint ep = new IPEndPoint(ip,2000);
            Socket sk = new Socket(ip.AddressFamily,SocketType.Stream,ProtocolType.Tcp);
            sk.Connect(ep);
            Console.WriteLine("New Client Connected");
        }
    }
}
