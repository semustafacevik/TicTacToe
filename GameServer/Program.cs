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

        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 15);
            Console.Title = "Game_Server";
            Console.WriteLine("Server created.");

            Socket ServerListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            const int _PORT = 44566;
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
                    Console.WriteLine("ERROR! - Server is full"); // Server is full (Client more than 2)
            }

        }

        /// <summary>
        /// Definitions
        /// </summary>
        static string[] clientName = new string[2];
        static string[] clientChoice = new string[2];
        static string[] clientScore = new string[3];
        static string[] clientPlay = new string[2];
        static string[] gameLabelsXO = new string[10];


        static void User(Socket client)
        {
            byte[] message = null;
            clientPlay[0] = "-";
            clientPlay[1] = "-";
            clientScore[0] = "0";
            clientScore[1] = "0";
            clientScore[2] = "0";
            while (true)
            {
                message = new byte[256];

                client.Receive(message);

                string incommingMsg = IncommingMessage(message);

                if (incommingMsg.StartsWith(" Name="))
                {
                    Edit_Name(incommingMsg);
                }

                else if (incommingMsg.StartsWith(" Name?"))
                {
                    if (incommingMsg.EndsWith("P1"))
                        client.Send(Encoding.UTF8.GetBytes(clientName[0]));

                    else
                        client.Send(Encoding.UTF8.GetBytes(clientName[1]));
                }

                else if(incommingMsg.StartsWith(" Score="))
                {
                    Edit_Score(incommingMsg);
                }

                else if(incommingMsg.StartsWith(" Score?"))
                {
                    if (incommingMsg.EndsWith("P1"))
                        client.Send(Encoding.UTF8.GetBytes(clientScore[0]));

                    else if(incommingMsg.EndsWith("P2"))
                        client.Send(Encoding.UTF8.GetBytes(clientScore[1]));

                    else
                        client.Send(Encoding.UTF8.GetBytes(clientScore[2]));
                }

                else if (incommingMsg.StartsWith(" Client?"))
                {
                    client.Send(Encoding.UTF8.GetBytes(" C=" + numberOfClient.ToString()));
                }

                else if (incommingMsg.StartsWith(" lbl"))
                {
                    Edit_Label(incommingMsg);
                }

                else if (incommingMsg.StartsWith(" Label?"))
                {
                    string labelXO = Info_LabelXO();
                    client.Send(Encoding.UTF8.GetBytes(labelXO));
                }

                else if (incommingMsg.StartsWith(" Play?"))
                {
                    client.Send(Encoding.UTF8.GetBytes(clientPlay[0] + clientPlay[1]));
                }

                else if (incommingMsg.StartsWith(" Choice?"))
                {
                    if (incommingMsg.EndsWith("P1"))
                        client.Send(Encoding.UTF8.GetBytes(clientChoice[0]));

                    else
                        client.Send(Encoding.UTF8.GetBytes(clientChoice[1]));
                }

                else { }
            }
        }

        /// <summary>
        /// Edit messages
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        static string IncommingMessage(byte[] msg)
        {
            string incommingMsg = (Encoding.UTF8.GetString(msg));

            string editedMessage = Edit_IncommingMessage(incommingMsg);

            return editedMessage;
        }

        static string Edit_IncommingMessage(string msg)
        {
            int length = msg.IndexOf("\0");

            string editedMessage = msg.Substring(0, length);

            return editedMessage;
        }

        static void Edit_Name(string msg)
        {
            int index = msg.IndexOf("-");
            int length = index - 6;

            string editedMessage = msg.Substring(6, length);

            string playerName;
            string playerChoice;

            playerName = editedMessage;

            if (msg.EndsWith("P1"))
            {
                playerChoice = Edit_Choice(msg, playerName);
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

        static string Edit_Choice(string msg, string name)
        {
            int nameLength = name.Length;

            string editedMessage = msg.Substring(7 + nameLength, 1);

            return editedMessage;
        }

        static void Edit_Score(string msg)
        {
            string editedMessage = msg.Substring(7, 1);
            clientScore[0] = editedMessage;

            editedMessage = msg.Substring(8, 1);
            clientScore[1] = editedMessage;

            editedMessage = msg.Substring(9, 1);
            clientScore[2] = editedMessage;
        }

        static void Edit_Label(string msg)
        {
            string labelXO = msg.Substring(5, 1);

            string index = msg.Substring(4, 1);
            int labelIndex = Convert.ToInt32(index);

            gameLabelsXO[labelIndex] = labelXO;



            if(msg.EndsWith("P*"))
            {
                for (int i = 0; i < 9; i++)
                {
                    gameLabelsXO[i] = " ";
                }
            }

            else if (msg.EndsWith("P1"))
            {
                clientPlay[0] = "Y";
                clientPlay[1] = "N";
            }
            else if(msg.EndsWith("P2"))
            {
                clientPlay[0] = "N";
                clientPlay[1] = "Y";
            }
            else { }
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