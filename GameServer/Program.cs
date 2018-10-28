using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace GameServer
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 15);
            Console.Title = "Game_Server";
            Console.WriteLine("Server created.");

            Socket ServerListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            const int PORT = 44644;
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, PORT);

            ServerListener.Bind(ep);
            ServerListener.Listen(100);
            Console.WriteLine("Server listening...");
            Socket clientSocket = default(Socket);
            int counter = 0;

            while (true)
            {
                clientSocket = ServerListener.Accept();
                counter++;
                Console.WriteLine(counter + " client connected");
                Thread userThread = new Thread(new ThreadStart(() => Program.User(clientSocket)));
                userThread.Start();
            }

        }
        public static void User(Socket client)
        {
            while (true)
            {
                byte[] msg = new byte[256];
                int size = client.Receive(msg);
                Console.WriteLine(((Encoding.UTF8.GetString(msg)).Split('\0')[0]));

                client.Send(msg);

            }
        }
    }
}