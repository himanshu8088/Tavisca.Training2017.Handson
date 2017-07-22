using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientChatConsoleApplication
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat("192.168.6.16", 500);
            Console.WriteLine("Press <-1> to Stop Application Any Time");
            chat.Start();
        }
        public static string SendMessage()
        {
            return Console.ReadLine();
        }
        public static void ReceiveMessage(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
