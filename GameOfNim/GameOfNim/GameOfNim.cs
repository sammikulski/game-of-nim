/*Project 1 - the Game of Nim 
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski with panel board generation code provided by Professor Frank Friedman
* 
* This project is an interactive and visual implementation of the Game of Nim,
  in which two players pick marbles from only one row (per turn) containing different
  amounts of marbles. The objective of the game is to leave only 1 marble remaining
  at the end of your turn. If you pick the last one, the other player wins.
  This implementation keeps track of 2 player objects, the number of games each have won,
  and the total number of games that have been played. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfNim
{
    public partial class frmGameOfNim : Form
    {
        private InternalBoardModel game = new InternalBoardModel(maxRows);

        // Convert a charcter to its equivalent integer
        public int convertCharToInt(Char c)
        {
            return ((int)(c) - (int)('0'));
        }  // end convertCharToInt


        //1 list is created with 2 player objects
        private List<PlayerModel> playersList = new List<PlayerModel>(2);
        private PlayerModel currentPlayer;

        //these values are kept constant so that they do not changed, and can eaily be referenced
        private const int maxRows = 4;
        private const int maxCols = 7;


        int marblesSelectedCount = 0; //keeps track of the number of marbles a player has selected during their turn
        int gameCount = 0;            //keeps track of the totoal number of games played during one run 
        int rowID;                    //the unique identifier for each row (starts at row 0)

        //strings private to this class that store the names of the two players
        private string player1Name;
        private string player2Name;

        //constructor used to make the new row buttons and the marble buttons
        private Button[,] newButton = new Button[maxRows, maxCols];
        private Button[] newRowButton = new Button[maxRows];

        public frmGameOfNim()
        {
            InitializeComponent();
        }

        private void frmGameOfNim_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Game of Nim...Here we go...."); //Message box to show that the game has loaded
            prepareForNames();      //sets the intial properties of the gameboard upon startup 
        }

        private void prepareForNames()
        {
            //Sets the cursor to start on the FirstPlayerNameBox
            //Disable buttons that the player should not be able to click yet
            //clears any possible text that could be in the textboxes
            //Enables panelBoard
            //displays the instructions for the two players to start the game
            txtFirstPlayerName.Focus();
            txtFirstPlayerName.Select();
            panelBoard.Enabled = true;
            lblInstructions.Visible = false;
            txtSecondPlayerName.Enabled = false;
            btnSecondPlayerOK.Enabled = false;
            lblReadyMessage.Visible = false;
            txtCurrentPlayer.Visible = false;
            lblTurnIndicator.Visible = false;
            btnLetsPlay.Visible = false;
            btnLetsPlay.Enabled = false;
            btnPlayAgain.Visible = false;
            btnPlayAgain.Enabled = false;
            txtFirstPlayerName.ResetText();
            txtSecondPlayerName.ResetText();
            btnTurnComplete.Visible = false;

        }

        //Checks that player 1's name is valid, if valid, then player 2 enters their name 
        
        private void btnFirstPlayerOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstPlayerName.Text) || (String.IsNullOrWhiteSpace(txtFirstPlayerName.Text)))
            {
                //if name is not valid:
                MessageBox.Show("Please enter a name. This field cannot be blank", "Error");
                txtFirstPlayerName.ResetText();
                txtFirstPlayerName.Focus();
                txtFirstPlayerName.Select();
            }
            else
            {
                //if name is valid, enable player 2 to enter their name
                txtSecondPlayerName.Enabled = true;
                btnSecondPlayerOK.Enabled = true;
                txtFirstPlayerName.Enabled = false;
                btnFirstPlayerOK.Enabled = false;
                txtSecondPlayerName.Focus();
                txtSecondPlayerName.Select();

            }//end else
        }
        

        //checks that player 2's name is valid,
        private void btnSecondPlayerOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSecondPlayerName.Text) || (String.IsNullOrWhiteSpace(txtSecondPlayerName.Text)))
            {
                //if name is not valid:
                MessageBox.Show("Please enter a name. This field cannot be blank", "Error");
                txtSecondPlayerName.ResetText();
                txtSecondPlayerName.Focus();
                txtSecondPlayerName.Select();
            }
            else if (txtFirstPlayerName.Text == txtSecondPlayerName.Text)
            {
                //if name is the same as player 1's name:
                MessageBox.Show("Player2: Please enter a unique name. You must have a different name from PLayer 1", "Error");
                txtSecondPlayerName.ResetText();
                txtSecondPlayerName.Focus();
                txtSecondPlayerName.Select();
            }


            //if both names are valid/pass all checks:
            else
            {
                //instructions appear, game is now ready to play
                txtSecondPlayerName.Enabled = false;
                lblReadyMessage.Visible = true;
                btnSecondPlayerOK.Enabled = false;
                btnLetsPlay.Enabled = true;
                btnLetsPlay.Visible = true;


                if (gameCount > 0)
                {
                    currentPlayer = playersList[0];
                    displayGameBoard();

                    return;
                }
                player1Name = txtFirstPlayerName.Text;
                player2Name = txtSecondPlayerName.Text;

                //if names are OK, instances of each player are created
                PlayerModel p;
                p = new PlayerModel(player1Name);
                playersList.Add(p);
                p = new PlayerModel(player2Name);
                playersList.Add(p); ;

                currentPlayer = playersList[0];

            }//end else
        }//end btnSecondPlayerOK_Click

        private void btnLetsPlay_Click(object sender, EventArgs e)
        {
            //board is displayed when the user clicks Lets Play
            //displays the current players turn
            displayGameBoard();
            lblInstructions.Visible = true;
            txtCurrentPlayer.Visible = true;
            lblTurnIndicator.Visible = true;
            btnTurnComplete.Visible = true;
            btnLetsPlay.Enabled = false;
        }

        public void displayGameBoard()
        {
            //sets the Board to display inside our panel
            panelBoard.Location = new System.Drawing.Point(21, 337);
            txtCurrentPlayer.Text = player1Name;
            panelBoard.Visible = true;
            panelBoard.Enabled = true;
            createBoard();
        }

        // Creates the Nim Board for play
        private void createBoard()
        {
            panelBoard.Visible = true; ;

            Size size = new Size(50, 50);
            Point loc = new Point(0, 0);
            int padding = 10;
            int topMargin = 20;

            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < maxRows; row++)
            {
                // For each new row, insert at left the Row i Button
                loc.Y = (topMargin + 5) + row * (size.Height + padding);
                int rowBtnExtraLeftPadding = 0;
                newRowButton[row] = new System.Windows.Forms.Button();
                newRowButton[row].Location = new Point(rowBtnExtraLeftPadding, loc.Y);
                newRowButton[row].Size = new Size(70, 23);
                newRowButton[row].Text = "Row " + (row + 1) + " -->";
                newRowButton[row].Visible = true;


                newRowButton[row].Name = "rowBtn" + row;
                newRowButton[row].Click += new EventHandler(RowButton_Click);
                newRowButton[row].Enabled = true;

                // Add row button to the form
                panelBoard.Controls.Add(newRowButton[row]);

                //grid of buttons is created, with spacing/padding in between
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 100;
                for (int col = 0; col < maxCols; col++)
                {
                    newButton[row, col] = new System.Windows.Forms.Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col *
                                                   (size.Width + padding), loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Text = "";


                    newButton[row, col].Enabled = false;
                    newButton[row, col].Visible = true;
                    newButton[row, col].Name = "btn" + row + col;

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);


                    // Add button to the form
                    panelBoard.Controls.Add(newButton[row, col]);
                } // end for col
            } // end for row

            lblTurnIndicator.Visible = true;
            txtCurrentPlayer.Visible = true;

            //fills in the board with X's to represent our marbles
            newButton[0, maxCols / 2].Text = "X";
            for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
            {
                newButton[1, i].Text = "X";
            }

            for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++)
            {
                newButton[2, i].Text = "X";
            }


            for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)
            {
                newButton[3, i].Text = "X";
            }

        } // end createBoard



        private void RowButton_Click(object sender, EventArgs e)
        {
            rowID = convertCharToInt(((Button)sender).Name[6]);
            //MessageBox.Show("Row Button [" + (rowID + 1) + "] has been selected!");
            ((Button)sender).BackColor = System.Drawing.Color.Orange;

            for (int i = 0; i < maxRows; i++)

                newRowButton[i].Enabled = false;
            if (rowID == 0)
                newButton[rowID, maxCols / 2].Enabled = true;
            btnTurnComplete.Enabled = true;

            if (rowID == 1) for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
                    newButton[rowID, i].Enabled = true;
            btnTurnComplete.Enabled = true;

            if (rowID == 2) for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++)
                    newButton[rowID, i].Enabled = true;
            btnTurnComplete.Enabled = true;

            if (rowID == 3) for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)

                    newButton[rowID, i].Enabled = true;
            btnTurnComplete.Enabled = true;
        } // end button clickhandler

        //when the current player is done their turn, it is now the other player's turn
        private void btnTurnComplete_Click(object sender, EventArgs e)
        {
            //since the player must select at least one marble, an error will appear if they do not select a marble
            if (marblesSelectedCount == 0)
            {
                MessageBox.Show("Please take at least one marble", "Error");
            }
            //when the player selects a particular marble
            else
            {
                game.RemoveMarbles(rowID, marblesSelectedCount);
            }
            
            //when marbles are currently selected
            if (marblesSelectedCount > 0)
            {
                for (int currentRow = 0; currentRow < maxRows; currentRow++)
                {
                    //the row button will only appear orange when it is selected, goes back to grey if it is not selected
                    newRowButton[currentRow].BackColor = Button.DefaultBackColor;

                    //if there are still marbles left in the row, the row button can be selected
                    if (game.GetRowTotalMarbles(currentRow) != 0)
                    {
                        newRowButton[currentRow].Enabled = true;
                    }
                    //if there are no marbles left in that row, the row button cannot be selected
                    else if (game.GetRowTotalMarbles(currentRow) == 0)
                    {
                        newRowButton[currentRow].Enabled = false;
                    }

                    //for the other player's turn, all buttons will grey out (until the next player selects a row)
                    for (int currentCol = 0; currentCol < maxCols; currentCol++)
                    {
                        newButton[currentRow, currentCol].Enabled = false;
                    }
                }
            }

            //after each turn, the status of the overall game will be checked
            int gameDone = game.checkBoardTotalMarbles();
            if (gameDone == 0)
            {
                //Game is over, current player loses, opposite player wins:
                if (txtCurrentPlayer.Text == player1Name)
                {
                    playersList[1].incrementWins();
                    MessageBox.Show(playersList[1].getPlayerName() + " is a Winner!");
                    MessageBox.Show(playersList[1].getPlayerName() + " has won " + playersList[1].getCountOfWins() + " games" + "\n"
                                  + playersList[0].getPlayerName() + " has won " + playersList[0].getCountOfWins() + " games", "Game Complete");
                }
                else if (txtCurrentPlayer.Text == player2Name)
                {
                    playersList[0].incrementWins();
                    MessageBox.Show(playersList[0].getPlayerName() + " is a Winner!");
                    MessageBox.Show(playersList[0].getPlayerName() + " has won " + playersList[0].getCountOfWins() + " games" + "\n"
                                  + playersList[1].getPlayerName() + " has won " + playersList[1].getCountOfWins() + " games", "Game Complete");
                }

                
                panelBoard.Enabled = false;
                btnPlayAgain.Visible = true;
                btnPlayAgain.Enabled = true;

            }
            else if (gameDone == 1)
            {
                //Game is over, Current player wins, opposite player loses:
                if (txtCurrentPlayer.Text == player1Name)
                {
                    playersList[0].incrementWins();
                    MessageBox.Show(playersList[0].getPlayerName() + " is a Winner!");
                    MessageBox.Show(playersList[0].getPlayerName() + " has won " + playersList[0].getCountOfWins() + " games" + "\n"
                                  + playersList[1].getPlayerName() + " has won " + playersList[1].getCountOfWins() + " games", "Game Complete");

                }
                else if (txtCurrentPlayer.Text == player2Name)
                {
                    playersList[1].incrementWins();
                    MessageBox.Show(playersList[1].getPlayerName() + " is a Winner!");
                    MessageBox.Show(playersList[1].getPlayerName() + " has won " + playersList[1].getCountOfWins() + " games" + "\n"
                                  + playersList[0].getPlayerName() + " has won " + playersList[0].getCountOfWins() + " games", "Game Complete");
                }
                panelBoard.Enabled = false;
                btnPlayAgain.Visible = true;
                btnPlayAgain.Enabled = true;
            }

            //if there are not 0 or 1 marbles left, the game continues, it is now the opposite player's turn
            else if (gameDone == -1)
            {
                if (txtCurrentPlayer.Text == player1Name)
                {
                    txtCurrentPlayer.Text = player2Name;
                }
                else if (txtCurrentPlayer.Text == player2Name)
                {
                    txtCurrentPlayer.Text = player1Name;
                }
            }
            marblesSelectedCount = 0;

        }

        //when a player selects a button, the program counts each selected button
        private void Button_Click(object sender, EventArgs e)
        {
            marblesSelectedCount++;
            btnTurnComplete.Enabled = true;
            ((Button)sender).Visible = false;
        } // end button clickhandler         


        //closes the form and quits the game
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //panelBoard is reset back to the way it was, gameCount increments, players play the game again
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            txtCurrentPlayer.Text = player1Name;
            for (int i = 0; i < newRowButton.Length; i++)
            {
                panelBoard.Controls.Remove(newRowButton[i]);
                for (int j = 0; j < maxCols; j++)
                {
                    panelBoard.Controls.Remove(newButton[i, j]);

                }
            }
            game.resetBoard(maxRows);
            panelBoard.Controls.Clear();
            panelBoard.Refresh();

            displayGameBoard();
            marblesSelectedCount = 0;
            panelBoard.Enabled = true;
            gameCount++;
        }
    }
}
