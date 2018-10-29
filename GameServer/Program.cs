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
        static string[] clientPlay = new string[2];
        static string[] gameLabelsXO = new string[9];

        static byte[] lastMessage = null;


        static void User(Socket client)
        {
            clientPlay[0] = "-";
            clientPlay[1] = "-";
            while (true)
            {
                byte[] message = new byte[256];

                client.Receive(message);

                string incommingMsg = IncommingMessage(message);

                if (incommingMsg.StartsWith(" Name="))
                    Edited_Name(incommingMsg);

                //////************

                if (incommingMsg.StartsWith(" lbl"))
                    Edited_Label(incommingMsg);


                //if (!incommingMsg.StartsWith("Client ?") && !incommingMsg.StartsWith("Last ?") && !incommingMsg.StartsWith("Name ?"))                 
                //    lastMessage = message;

                if (incommingMsg.StartsWith(" ?lbl?"))
                {
                    string labelXO = Info_LabelXO();
                    client.Send(Encoding.UTF8.GetBytes(labelXO));
                }

                if (incommingMsg.StartsWith(" Play?"))
                    client.Send(Encoding.UTF8.GetBytes(clientPlay[0] + clientPlay[1]));

                if (incommingMsg.StartsWith(" Name?"))
                {
                    if (incommingMsg.EndsWith("P1"))
                        client.Send(Encoding.UTF8.GetBytes(clientName[0]));

                    else
                        client.Send(Encoding.UTF8.GetBytes(clientName[1]));
                }

                if (incommingMsg.StartsWith(" Choice?"))
                {
                    if (incommingMsg.EndsWith("P1"))
                        client.Send(Encoding.UTF8.GetBytes(clientChoice[0]));

                    else
                        client.Send(Encoding.UTF8.GetBytes(clientChoice[1]));
                }

                if (incommingMsg.StartsWith(" Client?"))
                    client.Send(Encoding.UTF8.GetBytes(" C=" + numberOfClient.ToString()));

                if (incommingMsg.StartsWith(" Last?"))
                    client.Send(lastMessage);

            }
        }



        static string IncommingMessage(byte[] msg)
        {
            string incommingMsg = (Encoding.UTF8.GetString(msg));

            string editedMessage = Edited_IncommingMessage(incommingMsg);

            return editedMessage;
        }

        static string Edited_IncommingMessage(string msg)
        {
            int length = msg.IndexOf("\0");

            string editedMessage = msg.Substring(0, length);

            return editedMessage;
        }

        static void Edited_Name(string msg)
        {
            int index = msg.IndexOf("-");
            int length = index - 6;

            string editedMessage = msg.Substring(6, length);

            string playerName;
            string playerChoice;

            playerName = editedMessage;

            if (msg.EndsWith("P1"))
            {
                playerChoice = Edited_Choice(msg, playerName);
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

        static string Edited_Choice(string msg, string name)
        {
            int nameLength = name.Length;

            string editedMessage = msg.Substring(7 + nameLength, 1);

            return editedMessage;
        }

        static void Edited_Label(string msg)
        {
            string labelXO = msg.Substring(5, 1);

            string index = msg.Substring(4, 1);
            int labelIndex = Convert.ToInt32(index);

            gameLabelsXO[labelIndex] = labelXO;

            if (msg.EndsWith("P1"))
            {
                clientPlay[0] = "Y";
                clientPlay[1] = "N";
            }
            else
            {
                clientPlay[0] = "N";
                clientPlay[1] = "Y";
            }
        }

        static string Info_LabelXO()
        {
            string allLabelsXO = "";

            for (int i = 0; i < 9; i++)
            {
                if (gameLabelsXO[i] == null)
                    gameLabelsXO[i] = " ";

                allLabelsXO += gameLabelsXO[i];
            }

            return allLabelsXO;
        }
    }
}