using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NP_SERVER1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Loopback;
            IPEndPoint ep = new IPEndPoint(ip, 2000);
            Socket sk = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sk.Bind(ep);
            Console.WriteLine("Server Waiting");
            sk.Listen(10);
            Socket clsk = sk.Accept();
            Console.WriteLine("Connected");
        }
    }
}
