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
using System.Threading;

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


            if (this.gameMode == enGameMode.Socket_Create || this.gameMode == enGameMode.Socket_Connect)
            {
                while (true)
                {
                    byte[] message = new byte[256];
                    string incomingMsg;
                    frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Client?"));
                    frmEntryForm.socket.Receive(message);
                    incomingMsg = Edited_IncomingMessage(message);

                    if (incomingMsg == " C=2")
                    {
                        if (this.gameMode == enGameMode.Socket_Create)
                        {
                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Name?P2"));
                            frmEntryForm.socket.Receive(message);
                            incomingMsg = Edited_IncomingMessage(message);
                            this.P2.name = incomingMsg;

                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Choice?P2"));
                            frmEntryForm.socket.Receive(message);
                            incomingMsg = Edited_IncomingMessage(message);
                            this.P2.choice = incomingMsg;

                        }

                        else if (this.gameMode == enGameMode.Socket_Connect)
                        {
                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Name?P1"));
                            frmEntryForm.socket.Receive(message);
                            incomingMsg = Edited_IncomingMessage(message);
                            this.P1.name = incomingMsg;

                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Choice?P1"));
                            frmEntryForm.socket.Receive(message);
                            incomingMsg = Edited_IncomingMessage(message);
                            this.P1.choice = incomingMsg;

                            if (incomingMsg == "X")
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
            lblChoiceP1.BackColor = Color.Transparent;
            lblChoiceP2.BackColor = Color.Transparent;

            Label[] allLabels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8 };

            foreach (Label label in allLabels)
            {
                label.Text = null;
                label.BackColor = Color.Transparent;
            }

            if (starting == enStarting.None || starting == enStarting.Player2)
            {
                playerTurn = enPlayerTurn.Player1;
                starting = enStarting.Player1;
                ShowTurn(playerTurn.ToString());
            }

            else if (starting == enStarting.Player1)
            {
                playerTurn = enPlayerTurn.Player2;
                starting = enStarting.Player2;
                ShowTurn(playerTurn.ToString());
            }

            else
            {
            }

            winner = enWinner.None;
        }

        /// <summary>
        /// ///////////*********
        /// </summary>
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
                        allWinningMoves[i].BackColor = Color.LimeGreen;
                        allWinningMoves[i + 1].BackColor = Color.LimeGreen;
                        allWinningMoves[i + 2].BackColor = Color.LimeGreen;

                       ******** //Thread th = new ThreadStart()

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
            ShowTurn(playerTurn.ToString());

        }

        bool refreshGame = false;
        bool startGame = false;

        private void OnClick(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string labelName = clickedLabel.Name;
            string labelText = clickedLabel.Text;

            if (gameMode == enGameMode.Socket_Connect || gameMode == enGameMode.Socket_Create)
            {
                if (refreshGame && startGame)
                {
                    if (playerTurn == enPlayerTurn.None || labelText != "")
                        return;
                    OnClick_Socket(clickedLabel);
                }

                else
                    MetroMessageBox.Show(this, "REFLESH");

                refreshGame = false;
                startGame = false;
            }

            else
            {
                if (playerTurn == enPlayerTurn.None || labelText != "")
                    return;

                else if (playerTurn == enPlayerTurn.Player1)
                {
                    clickedLabel.Text = P1.choice;

                    ShowTurn(playerTurn.ToString());
                }

                else
                {
                    clickedLabel.Text = P2.choice;

                    ShowTurn(playerTurn.ToString());
                }

                winner = GetWinner();


                labelText = clickedLabel.Text;
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
                            ShowTurn(playerTurn.ToString());

                        }
                        else
                        {
                            playerTurn = enPlayerTurn.None;
                            OnNewGame();
                        }

                        break;


                    case enGameMode.Socket_Create:

                        if (frmEntryForm.socket.Connected)
                        {
                            //LabelXOSelection();

                            byte[] incomingMsg = new byte[256];
                            string message = " " + labelName + labelText + "P1";

                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(message));
                        }

                        if (winner == enWinner.None)
                        {

                        }
                        else
                        {
                            playerTurn = enPlayerTurn.None;
                            OnNewGame();
                        }



                        break;


                    case enGameMode.Socket_Connect:

                        if (frmEntryForm.socket.Connected)
                        {
                            byte[] incomingMsg = new byte[256];
                            string message = " " + labelName + labelText + "P2";

                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(message));
                        }

                        if (winner == enWinner.None)
                        {
                        }

                        else
                        {
                            playerTurn = enPlayerTurn.None;
                            OnNewGame();
                        }



                        break;




                    default:
                        break;
                }
            }
        }



        private void OnClick_Socket(Label clickedLabel)
        {
            string labelName = clickedLabel.Name;
            string labelText = clickedLabel.Text;

            if (playerTurn == enPlayerTurn.Player1)
            {
                clickedLabel.Text = P1.choice;
            }

            else
            {
                clickedLabel.Text = P2.choice;
            }

            winner = GetWinner(); 


            labelText = clickedLabel.Text;

            switch (gameMode)
            {
                case enGameMode.Socket_Create:

                    if (frmEntryForm.socket.Connected)
                    {
                        string message_Create = " " + labelName + labelText + "P1";

                        frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(message_Create));
                    }

                    if (winner == enWinner.None)
                    {
                        LabelXO_Placement();
                        ShowTurn("Player2");
                        //lblChoiceP2.BackColor = Color.Red;
                        //lblChoiceP1.BackColor = Color.Transparent;
                    }
                    else
                    {
                        playerTurn = enPlayerTurn.None;
                        OnNewGame();
                    }


                    break;


                case enGameMode.Socket_Connect:
                    if (frmEntryForm.socket.Connected)
                    {
                        string message_Connect = " " + labelName + labelText + "P2";

                        frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(message_Connect));
                    }

                    if (winner == enWinner.None)
                    {
                        LabelXO_Placement();
                        ShowTurn("Player1");
                        //lblChoiceP1.BackColor = Color.Red;
                        //lblChoiceP2.BackColor = Color.Transparent;
                    }

                    else
                    {
                        playerTurn = enPlayerTurn.None;
                        OnNewGame();
                    }



                    break;


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
                    btnRefresh.Show();
                    break;

                case "CONNECT":
                    this.gameMode = enGameMode.Socket_Connect;
                    btnRefresh.Show();
                    break;

                default:
                    break;
            }
        }


        private string Edited_IncomingMessage(byte[] msg)
        {
            string incomingMsg = (Encoding.UTF8.GetString(msg));

            int index = incomingMsg.IndexOf("\0");

            string editedMessage = incomingMsg.Substring(0, index);

            return editedMessage;
        }

        private void LabelXO_Placement()
        {
            Label[] allLabels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8 };

            foreach (Label label in allLabels)
            {
                label.Text = null;
            }

            byte[] message = new byte[256];
            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" ?lbl?"));
            frmEntryForm.socket.Receive(message);

            string incomingMsg = Edited_IncomingMessage(message);


            string[] edited_XO = LabelXOSelection(incomingMsg);
            int index_XO = 0;

            foreach (Label label in allLabels)
            {
                label.Text = edited_XO[index_XO];
                index_XO++;
            }

        }

        private string[] LabelXOSelection(string XO)
        {
            string[] labelXO = new string[9];
            char[] labelXO_Char = XO.ToCharArray();

            for (int i = 0; i < 9; i++)
            {
                labelXO[i] = labelXO_Char[i].ToString();

                if (labelXO[i] == " ")
                    labelXO[i] = null;
            }

            return labelXO;
        }

        private void ShowTurn(string playerTurn)
        {
            switch (playerTurn)
            {
                case "Player1":
                    lblChoiceP1.BackColor = Color.Red;
                    lblChoiceP2.BackColor = Color.Transparent;
                    break;

                case "Player2":
                    lblChoiceP2.BackColor = Color.Red;
                    lblChoiceP1.BackColor = Color.Transparent;
                    break;

                default:
                    break;
            }
        }


        private void frmGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LabelXO_Placement();

            byte[] message = new byte[256];
            string incomingMsg;
            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Play?"));
            frmEntryForm.socket.Receive(message);
            incomingMsg = Edited_IncomingMessage(message);


            if (playerTurn == enPlayerTurn.Player1)
            {
                if (incomingMsg == "NY") // Y = Yes ; N = No
                {
                    startGame = true;
                    ShowTurn(playerTurn.ToString());
                }

                else if (gameMode == enGameMode.Socket_Create && incomingMsg == "--")
                {
                    startGame = true;
                    ShowTurn(playerTurn.ToString());
                    lblChoiceP1.BackColor = Color.Red;
                    lblChoiceP2.BackColor = Color.Transparent;
                }



                else if (gameMode == enGameMode.Socket_Connect && incomingMsg == "YN")
                {
                    startGame = true;
                    playerTurn = enPlayerTurn.Player2;
                    ShowTurn(playerTurn.ToString());
                }

                else if (gameMode == enGameMode.Socket_Connect && incomingMsg == "--")
                    MetroMessageBox.Show(this, "1 Henuz oynamadi");
                else
                    MetroMessageBox.Show(this, "2 OYNAMADI");
            }

            else if (playerTurn == enPlayerTurn.Player2)
            {
                if (incomingMsg == "YN")
                {
                    startGame = true;
                    ShowTurn(playerTurn.ToString());
                }

                else
                    MetroMessageBox.Show(this, "1 OYNAMADI");
            }

            


            refreshGame = true;
        }
    }
}
