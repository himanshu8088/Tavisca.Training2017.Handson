using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Client
{
    public class Chat : ChatStream
    {
        private string remoteIP;
        private int remotePort;
        public Chat(string remoteIP, int remotePort)
        {
            this.remoteIP = remoteIP;
            this.remotePort = remotePort;
            Initialize();
        }
        private void Initialize()
        {
            try
            {
                TcpSocketPoint = new TcpClient(remoteIP,remotePort);
                StreamOfNetwork = TcpSocketPoint.GetStream();
            }
            catch (SocketException e)
            {
                throw new SocketException(int.Parse(e.Message));
            }
            catch (Exception e)
            {
                throw new Exception("Exception Occured");
            }
        }
        public void Start()
        {
            Task task = Task.Run(() =>
            {
                while (true)
                {
                    ClientChatConsoleApplication.ReceiveMessage(ReceiveMessageFromStream());
                }
            });

            while (true)
            {
                string msg = ClientChatConsoleApplication.SendMessage();
                if (msg.Equals("-1"))                
                    break;                
                else
                    WriteMessageOnStream(msg);
            }
            Stop();
        }
        private void Stop()
        {
            Dispose();
        }
    }

}

