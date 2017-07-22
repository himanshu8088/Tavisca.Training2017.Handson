using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace Client
{
    public class ConnectionResources : IDisposable
    {
        public TcpClient TcpSocketPoint { get; set; }
        public NetworkStream StreamOfNetwork { get; set; }        

        public void Dispose()
        {
            TcpSocketPoint.Close();
            StreamOfNetwork.Close();            
        }
    }
}
