using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmGameForm : MetroForm
    {
        Player1 P1;
        Player2 P2;
        Drawing CS_Drawing;

        enum enGameMode { Computer, Friend, Timed, Socket_Create, Socket_Connect };
        enum enPlayerTurn { None, Player1, Player2 };
        enum enWinner { None, Player1, Player2, Draw };
        enum enStarting { None, Player1, Player2 };

        enGameMode gameMode;
        enPlayerTurn playerTurn;
        enWinner winner;
        enStarting starting;

        public frmGameForm(string gameMode, Player1 P1, Player2 P2)
        {
            InitializeComponent();
            GameModeSelection(gameMode);
            this.P1 = P1;
            this.P2 = P2;
            starting = enStarting.None;


            if (this.gameMode == enGameMode.Socket_Connect && this.gameMode == enGameMode.Socket_Create)
            {
                while (true)
                {
                    byte[] message = new byte[256];
                    string incommingMsg;
                    frmEntryForm.socket.Send(Encoding.UTF8.GetBytes("Client ?"));
                    frmEntryForm.socket.Receive(message);
                    incommingMsg = Edited_IncommingMessage(message);

                    if (incommingMsg == "C=2")
                    {
                        if (this.gameMode == enGameMode.Socket_Create)
                        {
                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes("Name ?P2"));
                            frmEntryForm.socket.Receive(message);
                            incommingMsg = Edited_IncommingMessage(message);
                            this.P2.name = incommingMsg;

                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes("Choice ?P2"));
                            frmEntryForm.socket.Receive(message);
                            incommingMsg = Edited_IncommingMessage(message);
                            this.P2.choice = incommingMsg;

                        }

                        else if (this.gameMode == enGameMode.Socket_Connect)
                        {
                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes("Name ?P1"));
                            frmEntryForm.socket.Receive(message);
                            incommingMsg = Edited_IncommingMessage(message);
                            this.P1.name = incommingMsg;

                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes("Choice ?P1"));
                            frmEntryForm.socket.Receive(message);
                            incommingMsg = Edited_IncommingMessage(message);
                            this.P1.choice = incommingMsg;

                            if (incommingMsg == "X")
                                this.P2.choice = "O";
                            else
                                this.P2.choice = "X";
                        }

                        else
                        { }

                        break;
                    }

                    else
                        MetroMessageBox.Show(this, "Waiting Player2");
                }

            }


            lblNameP1.Text = P1.name;
            lblNameP2.Text = P2.name;

            lblChoiceP1.Text = P1.choice;
            lblChoiceP2.Text = P2.choice;

            OnNewGame();
        }



        private void OnNewGame()
        {
            lblScoreP1.Text = P1.score.ToString();
            lblScoreP2.Text = P2.score.ToString();

            Label[] allLabels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8 };

            foreach (Label label in allLabels)
            {
                label.Text = null;
            }

            if (starting == enStarting.None || starting == enStarting.Player2)
            {
                playerTurn = enPlayerTurn.Player1;
                starting = enStarting.Player1;
            }

            else if (starting == enStarting.Player1)
            {
                playerTurn = enPlayerTurn.Player2;
                starting = enStarting.Player2;
            }

            else
            {
            }

            winner = enWinner.None;
        }


        int drawScore = 0;
        private enWinner GetWinner()
        {
            Label[] allWinningMoves = {
                                             //Check each row
                                             lbl0, lbl1, lbl2,
                                             lbl3, lbl4, lbl5,
                                             lbl6, lbl7, lbl8,
                                             //Columns
                                             lbl0, lbl3, lbl6,
                                             lbl1, lbl4, lbl7,
                                             lbl2, lbl5, lbl8,
                                             //Diagonal
                                             lbl0, lbl4, lbl8,
                                             lbl2, lbl4, lbl6
                                          };

            for (int i = 0; i < allWinningMoves.Length; i += 3)
            {
                if (allWinningMoves[i].Text != "")
                {
                    if (allWinningMoves[i].Text == allWinningMoves[i + 1].Text &&
                        allWinningMoves[i].Text == allWinningMoves[i + 2].Text)
                    {
                        if (allWinningMoves[i].Text == "X")
                        {
                            if (P1.choice == "X")
                            {
                                MetroMessageBox.Show(this, "WİN -> Player1");
                                P1.score++;
                                return enWinner.Player1;
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "WİN -> Player2");
                                P2.score++;
                                return enWinner.Player2;
                            }

                        }
                        else
                        {
                            if (P1.choice == "O")
                            {
                                MetroMessageBox.Show(this, "WİN -> Player1");
                                P1.score++;
                                return enWinner.Player1;
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "WİN -> Player2");
                                P2.score++;
                                return enWinner.Player2;
                            }
                        }
                    }
                }
            }

            Label[] allLabels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8 };

            foreach (Label label in allLabels)
            {
                if (label.Text == "")
                {
                    return enWinner.None;
                };
            }

            //it is definitely a draw
            MetroMessageBox.Show(this, "DRAW");
            lblScoreDraw.Text = (++drawScore).ToString();
            return enWinner.Draw;
        }


        private void Computer()
        {
            Label[] allLabels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8 };
            Label[] emptyLabels = new Label[9];
            int empty = -1;

            //Clear all game board cells
            foreach (Label label in allLabels)
            {
                if (label.Text == "")
                    emptyLabels[++empty] = label;
            }

            Random rand = new Random();
            if (empty != -1)
                emptyLabels[rand.Next(empty)].Text = P2.choice;

            winner = GetWinner();

            if (winner != enWinner.None)
            {
                playerTurn = enPlayerTurn.None;
                OnNewGame();
                if (starting == enStarting.Player2)
                    Computer();
            }

            playerTurn = enPlayerTurn.Player1;

        }

        private void OnClick(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string labelText = clickedLabel.Text;

            if (playerTurn == enPlayerTurn.None || labelText != "")
                return;

            else if (playerTurn == enPlayerTurn.Player1)
            {
                clickedLabel.Text = P1.choice;

                //if (gameMode != enGameMode.Computer)
                //{
                //    lblNameP2.BackColor = Color.Red;
                //    lblNameP1.BackColor = Color.Transparent;
                //}
            }


            else
            {
                clickedLabel.Text = P2.choice;
                //if (gameMode != enGameMode.Computer)
                //{
                //    lblNameP1.BackColor = Color.Red;
                //    lblNameP2.BackColor = Color.Transparent;
                //}
            }

            winner = GetWinner();


            switch (gameMode)
            {
                case enGameMode.Computer:

                    if (winner == enWinner.None)
                        Computer();

                    else if (winner != enWinner.None)
                    {
                        playerTurn = enPlayerTurn.None;
                        OnNewGame();
                        if (starting == enStarting.Player2)
                            Computer();
                    }

                    break;



                case enGameMode.Friend:

                    if (winner == enWinner.None)
                    {
                        //Change turns
                        playerTurn = (enPlayerTurn.Player1 == playerTurn) ? enPlayerTurn.Player2 : enPlayerTurn.Player1;

                    }
                    else
                    {
                        playerTurn = enPlayerTurn.None;
                        OnNewGame();
                    }

                    break;





                //case enGameMode.Socket_Creator:

                //    if (frmEntryForm.socket.Connected)
                //    {
                //        string gonder = clickedButton.Name + "-" + clickedButton.Text;

                //        // Ağ üzerinden gönderilecek her şey bytelara 
                //        // dönüştürülmüş olmalıdır.
                //        frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(gonder));
                //        MetroMessageBox.Show(this, gonder);

                //        byte[] msg = new byte[1024];
                //        int size = frmEntryForm.socket.Receive(msg);
                //        MetroMessageBox.Show(this, ((Encoding.UTF8.GetString(msg)).Split('\0')[0]));
                //    }

                //    if (winner == enWinner.None)
                //    {
                //        //Change turns
                //        playerTurn = (enPlayerTurn.Player1 == playerTurn) ? enPlayerTurn.Player2 : enPlayerTurn.Player1;

                //    }
                //    else
                //    {
                //        playerTurn = enPlayerTurn.None;
                //        OnNewGame();
                //    }



                //    break;


                //case enGameMode.Socket_Connected:

                //    if (frmEntryForm.socket.Connected)
                //    {
                //        string gonder = clickedButton.Name + "-" + clickedButton.Text;

                //        // Ağ üzerinden gönderilecek her şey bytelara 
                //        // dönüştürülmüş olmalıdır.
                //        frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(gonder));
                //        MetroMessageBox.Show(this, gonder);

                //        byte[] msg = new byte[1024];
                //        int size = frmEntryForm.socket.Receive(msg);
                //        MetroMessageBox.Show(this, ((Encoding.UTF8.GetString(msg)).Split('\0')[0]));
                //    }

                //if (winner == enWinner.None)
                //{
                //    //Change turns
                //    playerTurn = (enPlayerTurn.Player1 == playerTurn) ? enPlayerTurn.Player2 : enPlayerTurn.Player1;

                //}
                //else
                //{
                //    playerTurn = enPlayerTurn.None;
                //    OnNewGame();
                //}



                //break;




                default:
                    break;
            }
        }


    



        private void pnlGame_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics graphic = pnlGame.CreateGraphics();
            CS_Drawing = new Drawing(graphic);
        }

        private void GameModeSelection(string gameMode)
        {
            switch (gameMode)
            {
                case "COMPUTER":
                    this.gameMode = enGameMode.Computer;
                    break;

                case "FRIEND":
                    this.gameMode = enGameMode.Friend;
                    break;

                case "TIMED":
                    this.gameMode = enGameMode.Timed;
                    break;

                case "CREATE SERVER":
                    this.gameMode = enGameMode.Socket_Create;
                    break;

                case "CONNECT":
                    this.gameMode = enGameMode.Socket_Connect;
                    break;

                default:
                    break;
            }
        }


        private string Edited_IncommingMessage(byte[] msg)
        {
            string incommingMsg = (Encoding.UTF8.GetString(msg));

            int index = incommingMsg.IndexOf("\0");

            string editedMessage = incommingMsg.Substring(0, index);

            return editedMessage;
        }

        private void frmGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
