using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ChatStream: ConnectionResources
    {                
        public void WriteMessageOnStream(string MessageToSend)
        {             
                Byte[] buffer = Encoding.UTF8.GetBytes(MessageToSend);
                StreamOfNetwork.Write(buffer, 0, buffer.Length);                            
        }
        public string ReceiveMessageFromStream()
        {           
                byte[] buffer = new byte[TcpSocketPoint.ReceiveBufferSize];
                StreamOfNetwork.Read(buffer, 0, (int)TcpSocketPoint.ReceiveBufferSize);
                return Encoding.UTF8.GetString(buffer).Trim('\0');               
        }

    }
}
