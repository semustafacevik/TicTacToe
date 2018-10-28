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
        static int numberOfClient = 0;
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 15);
            Console.Title = "Game_Server";
            Console.WriteLine("Server created.");

            Socket ServerListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            const int _PORT = 44644;
            IPEndPoint EndPoint = new IPEndPoint(IPAddress.Any, _PORT);
            ServerListener.Bind(EndPoint);
            ServerListener.Listen(100);
            Console.WriteLine("Server listening...");

            Socket clientSocket = default(Socket);
            while (true)
            {
                clientSocket = ServerListener.Accept();
                numberOfClient++;
                Console.WriteLine(numberOfClient + " client connected");
                if (numberOfClient <= 2)
                {
                    Thread userThread = new Thread(new ThreadStart(() => User(clientSocket)));
                    userThread.Start();
                }
                else
                    Console.WriteLine("Server is full");
            }

        }

        static string[] clientName = new string[2];
        static string[] clientChoice = new string[2];

        static byte[] lastMessage = null;


        static void User(Socket client)
        {

            while (true)
            {
                byte[] message = new byte[256];

                client.Receive(message);

                string incommingMsg = IncommingMessage(message);

                string playerName;
                string playerChoice;
                if (incommingMsg.StartsWith("Name="))
                {
                    playerName = Edited_Name(incommingMsg);

                    if (incommingMsg.EndsWith("P1"))
                    {
                        playerChoice = Edited_Choice(incommingMsg);
                        clientName[0] = playerName;
                        clientChoice[0] = playerChoice;

                        if (playerChoice == "X")
                            clientChoice[1] = "O";
                        else
                            clientChoice[1] = "X";
                    }

                    else
                    {
                        clientName[1] = playerName;
                    }
                }

                //////************



                if (!incommingMsg.StartsWith("Client ?") && !incommingMsg.StartsWith("Last ?") && !incommingMsg.StartsWith("Name ?"))                 
                    lastMessage = message;

                if(incommingMsg.StartsWith("Name ?"))
                {
                    if (incommingMsg.EndsWith("P1"))
                        client.Send(Encoding.UTF8.GetBytes(clientName[0]));

                    else
                        client.Send(Encoding.UTF8.GetBytes(clientName[1]));
                }

                if(incommingMsg.StartsWith("Choice ?"))
                {
                    if (incommingMsg.EndsWith("P1"))
                        client.Send(Encoding.UTF8.GetBytes(clientChoice[0]));

                    else
                        client.Send(Encoding.UTF8.GetBytes(clientChoice[1]));
                }

                if (incommingMsg.StartsWith("Client ?"))
                    client.Send(Encoding.UTF8.GetBytes("C=" + numberOfClient.ToString()));

                if (incommingMsg.StartsWith("Last ?"))
                    client.Send(lastMessage);

            }
        }


        static string IncommingMessage(byte[] msg)
        {
            string incommingMsg = (Encoding.UTF8.GetString(msg));

            string incommingMessage = Edited_IncommingMessage(incommingMsg);

            return incommingMessage;
        }

        static string Edited_IncommingMessage(string msg)
        {
            int index = msg.IndexOf("\0");

            string editedMessage = msg.Substring(0, index);

            return editedMessage;
        }

        static string Edited_Name(string msg)
        {
            int index = msg.IndexOf(" ");
            int length = index - 5;

            string editedMessage = msg.Substring(5, length);

            return editedMessage;
        }

        static string Edited_Choice(string msg)
        {
            string name = Edited_Name(msg);
            int length = name.Length;

            string editedMessage = msg.Substring(6 + length, 1);

            return editedMessage;
        }
    }
}