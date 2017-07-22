using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
namespace Tavisca.Training2017.HandsOn.HttpRespOnCo
{
    class Program
    {
        public static void Main(string[] args)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp("http://codejam.tavisca.com/");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            /*
            using (Stream file = File.Create("C:\\Users\\hsoni\\Desktop\\f.html"))
            {
                CopyStream(receiveStream, file);
            }
            */
            Console.WriteLine("Response stream received.\n");
            Console.WriteLine(readStream.ReadToEnd());
            response.Close();
            readStream.Close();
            Console.ReadKey();
        }
        /*
        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }
        */
    }
}
