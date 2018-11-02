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
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmGameForm : MetroForm
    {
        Player1 P1;
        Player2 P2;
        Drawing CS_Drawing;

        /// <summary>
        /// Enum Descriptions
        /// </summary>
        enum enGameMode { Computer, Friend, Timed, Socket_Create, Socket_Connect };
        enum enPlayerTurn { None, Player1, Player2 };
        enum enWinner { None, Player1, Player2, Draw };
        enum enStarting { None, Player1, Player2 };

        enGameMode gameMode;
        enPlayerTurn playerTurn;
        enWinner winner;
        enStarting starting;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gameMode">Selected game mode</param>
        /// <param name="P1">Player1 information</param>
        /// <param name="P2">Player2 information</param>
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
                    incomingMsg = Edit_IncomingMessage(message);

                    if (incomingMsg == " C=2")
                    {
                        if (this.gameMode == enGameMode.Socket_Create)
                        {
                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Name?P2"));
                            frmEntryForm.socket.Receive(message);
                            incomingMsg = Edit_IncomingMessage(message);
                            this.P2.name = incomingMsg;

                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Choice?P2"));
                            frmEntryForm.socket.Receive(message);
                            incomingMsg = Edit_IncomingMessage(message);
                            this.P2.choice = incomingMsg;

                        }

                        else if (this.gameMode == enGameMode.Socket_Connect)
                        {
                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Name?P1"));
                            frmEntryForm.socket.Receive(message);
                            incomingMsg = Edit_IncomingMessage(message);
                            this.P1.name = incomingMsg;

                            message = new byte[256];
                            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Choice?P1"));
                            frmEntryForm.socket.Receive(message);
                            incomingMsg = Edit_IncomingMessage(message);
                            this.P1.choice = incomingMsg;

                            if (incomingMsg == "X")
                                this.P2.choice = "O";
                            else
                                this.P2.choice = "X";
                        }

                        else
                        { }

                        break;
                    }//(Number of client = 2)?

                    else
                    {
                        DialogResult dr;
                        dr = MetroMessageBox.Show(this, "Waiting Player2", "", MessageBoxButtons.OKCancel, 100);
                        if (dr == DialogResult.Cancel)
                        {
                            this.Close();
                            break;
                        }
                    }
                }
            }// Socket game mode control

            lblNameP1.Text = P1.name;
            lblNameP2.Text = P2.name;

            lblChoiceP1.Text = P1.choice;
            lblChoiceP2.Text = P2.choice;

            OnNewGame();
        }

        /// <summary>
        /// Start new game
        /// </summary>
        private void OnNewGame()
        {
            if(gameMode == enGameMode.Socket_Create || gameMode == enGameMode.Socket_Connect) 
            {
                byte[] message = new byte[256];
                string incomingMsg;
                frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Score?P1"));
                frmEntryForm.socket.Receive(message);
                incomingMsg = Edit_IncomingMessage(message);

                P1.score = Convert.ToInt32(incomingMsg);

                message = new byte[256];
                frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Score?P2"));
                frmEntryForm.socket.Receive(message);
                incomingMsg = Edit_IncomingMessage(message);

                P2.score = Convert.ToInt32(incomingMsg);

            } // Socket game mode control

            LabelRegulations();

            Label[] allLabels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8 };

            foreach (Label label in allLabels)
            {
                label.Text = null;
                label.BackColor = Color.LightGreen;
            } // Label reset
            switch (starting)
            {
                case enStarting.None:
                case enStarting.Player2:
                    playerTurn = enPlayerTurn.Player1;
                    starting = enStarting.Player1;
                    ShowTurn(playerTurn.ToString());
                    break;

                case enStarting.Player1:
                    playerTurn = enPlayerTurn.Player2;
                    starting = enStarting.Player2;
                    ShowTurn(playerTurn.ToString());
                    break;

                default:
                    break;
            }

            if (gameMode == enGameMode.Timed)
            {
                timer.Start();
                timer.Interval = 500;
                timer_countdown.Start();
                timer_countdown.Interval = 1000; // timer settings
                pnlTime.Show();
            } // Timed gamed control

            winner = enWinner.None;
        }

        int drawScore = 0;

        /// <summary>
        /// Winner control
        /// </summary>
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
                                          }; //All winning moves X-O

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

                        if (allWinningMoves[i].Text == "X")
                        {
                            if (P1.choice == "X")
                            {
                                lblNameP1.BackColor = Color.LimeGreen;
                                P1.score++;
                                winner = enWinner.Player1;
                            }
                            else
                            {
                                lblNameP2.BackColor = Color.LimeGreen;
                                P2.score++;
                                winner = enWinner.Player2;
                            }

                        }
                        else
                        {
                            if (P1.choice == "O")
                            {
                                lblNameP1.BackColor = Color.LimeGreen;
                                P1.score++;
                                winner = enWinner.Player1;
                            }
                            else
                            {
                                lblNameP2.BackColor = Color.LimeGreen;
                                P2.score++;
                                winner = enWinner.Player2;
                            }
                        }

                        pnlTime.Hide();
                        timer.Stop();
                        timer_countdown.Stop();

                        if (gameMode == enGameMode.Computer && winner == enWinner.Player2)
                            MetroMessageBox.Show(this, "Computer", "WINNER", 90);
                        else
                            MetroMessageBox.Show(this, winner.ToString(), "WINNER", 90);

                        lblScoreP1.Text = P1.score.ToString();
                        lblScoreP2.Text = P2.score.ToString();

                        return winner;

                    } // Winner
                }
            } // X-O controls

            Label[] allLabels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8 };

            foreach (Label label in allLabels)
            {
                if (label.Text == "")
                {
                    return enWinner.None; 
                }; // None
            } // Is empty controls

            // Draw
            lblScoreDraw.Text = (++drawScore).ToString();
            lblScoreDraw.BackColor = Color.LimeGreen;
            pnlTime.Hide();
            timer.Stop();
            timer_countdown.Stop();

            MetroMessageBox.Show(this, "DRAW", "RESULT", 90);
            return enWinner.Draw;
        }

        /// <summary>
        /// Computer game mode
        /// </summary>
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

        /// <summary>
        /// Clicking X-Os
        /// </summary>
        /// <param name="sender">Clicked label</param>
        /// <param name="e">Event args</param>
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
                    MetroMessageBox.Show(this, "Please click the \"Refresh\" button", "", 90);

                refreshGame = false;
                startGame = false;
            } // Socket game mode control

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

                    case enGameMode.Timed:
                        time = -1;
                        time_countdown = 6;

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


                    default:
                        break;
                }// controls
            } // Other game modes control
        }

        /// <summary>
        /// Socket game mode
        /// </summary>
        /// <param name="clickedLabel">Clicked label information</param>
        private void OnClick_Socket(Label clickedLabel)
        {
            string labelName = clickedLabel.Name;
            string labelText = clickedLabel.Text;

            if (playerTurn == enPlayerTurn.Player1)
                clickedLabel.Text = P1.choice;

            else
                clickedLabel.Text = P2.choice;
            

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
                    }
                    else
                    {
                        playerTurn = enPlayerTurn.None;
                        frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" lbl9-P*"));
                        frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Score=" + P1.score + P2.score + drawScore));
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
                    }

                    else
                    {
                        playerTurn = enPlayerTurn.None;
                        frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" lbl9-P*"));
                        frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Score=" + P1.score + P2.score + drawScore));
                        OnNewGame();
                    }

                    break;


                default:
                    break;

            }

        }

        /// <summary>
        /// Clicking refres button
        /// </summary>
        /// <param name="sender">Clicked button(refresh button)</param>
        /// <param name="e">Event args</param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            winner = GetWinner();
            LabelXO_Placement();

            if (winner != enWinner.None)
            {
                Label[] allLabels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8 };

                foreach (Label label in allLabels)
                {
                    label.Text = null;
                }
                OnNewGame();
            }

            byte[] message = new byte[256];
            string incomingMsg;
            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Play?"));
            frmEntryForm.socket.Receive(message);
            incomingMsg = Edit_IncomingMessage(message);


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
                    lblChoiceP1.BackColor = Color.IndianRed;
                    lblChoiceP2.BackColor = Color.Transparent;
                }

                else if (gameMode == enGameMode.Socket_Connect && incomingMsg == "YN")
                {
                    startGame = true;
                    playerTurn = enPlayerTurn.Player2;
                    ShowTurn(playerTurn.ToString());
                }

                else if (gameMode == enGameMode.Socket_Connect && incomingMsg == "--")
                    MetroMessageBox.Show(this, "Player1 hasn't played yet", "WAITING...", 90);
                else
                    MetroMessageBox.Show(this, "Player2 hasn't played yet", "WAITING...", 90);
            }

            else if (playerTurn == enPlayerTurn.Player2)
            {
                if (incomingMsg == "YN")
                {
                    startGame = true;
                    ShowTurn(playerTurn.ToString());
                }

                else
                    MetroMessageBox.Show(this, "Player1 hasn't played yet", "WAITING...", 90);
            }

            refreshGame = true;
        }
        
        /// <summary>
        /// Game mode pairing (string -> enum)
        /// </summary>
        /// <param name="gameMode">Selected game mode</param>
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
                    circularProgressBar.Value = 0;
                    lblTime.Text = "";
                    circularProgressBar.Minimum = 0;
                    circularProgressBar.Maximum = 10;
                    this.Size = new Size(458, 510);
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

        /// <summary>
        /// Edit the incomming message from the server
        /// </summary>
        /// <param name="msg">Incomming message from the server (type:byte)</param>
        /// <returns>Edited Message</returns>
        private string Edit_IncomingMessage(byte[] msg)
        {
            string incomingMsg = (Encoding.UTF8.GetString(msg));

            int index = incomingMsg.IndexOf("\0");

            string editedMessage = incomingMsg.Substring(0, index);

            return editedMessage;
        }

        /// <summary>
        /// X-O Placement
        /// </summary>
        private void LabelXO_Placement()
        {
            Label[] allLabels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8 };

            foreach (Label label in allLabels)
            {
                label.Text = null;
            }

            byte[] message = new byte[256];
            frmEntryForm.socket.Send(Encoding.UTF8.GetBytes(" Label?"));
            frmEntryForm.socket.Receive(message);

            string incomingMsg = Edit_IncomingMessage(message);


            string[] edited_XO = LabelXOSelection(incomingMsg);
            int index_XO = 0;

            foreach (Label label in allLabels)
            {
                label.Text = edited_XO[index_XO];
                index_XO++;
            }
        }

        /// <summary>
        /// Label's X-O
        /// </summary>
        /// <param name="XO">X-O information</param>
        /// <returns>Labels X-O informations</returns>
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

        /// <summary>
        /// Show player turn
        /// </summary>
        /// <param name="playerTurn">Player turn information</param>
        private void ShowTurn(string playerTurn)
        {
            switch (playerTurn)
            {
                case "Player1":
                    lblChoiceP1.BackColor = Color.IndianRed;
                    lblChoiceP2.BackColor = Color.Transparent;
                    lblNameP1.FontWeight = MetroLabelWeight.Bold;
                    lblNameP2.FontWeight = MetroLabelWeight.Regular;
                    break;

                case "Player2":
                    lblChoiceP2.BackColor = Color.IndianRed;
                    lblChoiceP1.BackColor = Color.Transparent;
                    lblNameP2.FontWeight = MetroLabelWeight.Bold;
                    lblNameP1.FontWeight = MetroLabelWeight.Regular;
                    break; 

                default:
                    break;
            }
        }

        /// <summary>
        ///  Required Label Regulations
        /// </summary>
        private void LabelRegulations()
        {
            lblScoreP1.Text = P1.score.ToString();
            lblScoreP2.Text = P2.score.ToString();
            lblChoiceP1.BackColor = Color.Transparent;
            lblChoiceP2.BackColor = Color.Transparent;
            lblNameP1.BackColor = Color.Transparent;
            lblNameP2.BackColor = Color.Transparent;
            lblScoreDraw.BackColor = Color.Transparent;
            lblNameP1.FontWeight = MetroLabelWeight.Regular;
            lblNameP2.FontWeight = MetroLabelWeight.Regular;
        }

        /// <summary>
        /// Coloring 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = pnlGame.CreateGraphics();
            CS_Drawing = new Drawing(graphic);
        }

        /// <summary>
        /// Coloring -> label's X-O
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_Paint(object sender, PaintEventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string labelText = clickedLabel.Text;

            switch (labelText)
            {
                case "X":
                    clickedLabel.ForeColor = Color.DimGray;
                    break;

                case "O":
                    clickedLabel.ForeColor = Color.White;
                    break;

                default:
                    break;
            }
        }

        int time = -1;
        /// <summary>
        /// Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            circularProgressBar.Value = time;
            
            if (time == 10)
            {
                timer.Stop();
                time = -1;
            }
        }

        int time_countdown = 6;
        /// <summary>
        /// Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_countdown_Tick(object sender, EventArgs e)
        {
            time_countdown--;
            lblTime.Text = time_countdown.ToString();          

            if (time_countdown == 0)
            {
                timer_countdown.Stop();
                time_countdown = 6;

                if (playerTurn == enPlayerTurn.Player1)
                {
                    lblNameP2.BackColor = Color.LimeGreen;
                    P2.score++;
                    winner = enWinner.Player2;
                }

                else if (playerTurn == enPlayerTurn.Player2)
                {
                    lblNameP1.BackColor = Color.LimeGreen;
                    P1.score++;                 
                    winner = enWinner.Player1;
                }

                MetroMessageBox.Show(this, winner.ToString(), "WINNER", 90);
                OnNewGame();
            }    
        }

        /// <summary>
        /// This form closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gameMode == enGameMode.Socket_Create || gameMode == enGameMode.Socket_Connect)
            {
                try
                {
                    foreach (var server in System.Diagnostics.Process.GetProcessesByName("GameServer"))
                    {
                        server.Kill();
                    }

                    MetroMessageBox.Show(this, "Server shut down!", "", 90);
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
    }
}
