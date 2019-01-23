/*Project 1 - the Game of Nim 
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski
*This InternalBoardModel is used to process the state
 of the game, reset the game, and keep track of the 
 total marbles and how many marbles are in each row
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim
{
    class InternalBoardModel
    {
        int[] rowOnBoard;
        int totalMarblesCount;

        //number of marbles per row
        public InternalBoardModel(int maxRows)
        {
            totalMarblesCount = 0;
            rowOnBoard = new int[maxRows];
            for (int i = 0; i < maxRows; i++)
            {
                rowOnBoard[i] = (2 * i) + 1;
                totalMarblesCount += rowOnBoard[i];
            }
        }
        
        public int getBoardTotal()
        {
            return totalMarblesCount;
        }

        //resets the board for the next game to be played
        public void resetBoard(int maxRows)
        {
            totalMarblesCount = 0;
            rowOnBoard = new int[maxRows];
            for (int i = 0; i < maxRows; i++)
            {
                rowOnBoard[i] = (2 * i) + 1;
                totalMarblesCount += rowOnBoard[i];
            }
        }
        
        //how many marbles are left in row __?
        public int GetRowTotalMarbles(int rowID)
        {
            int marblesInRow = 0;
            if (rowID == 0)
            {
                marblesInRow = rowOnBoard[0];
                return marblesInRow;
            }
            if (rowID == 1)
            {
                marblesInRow = rowOnBoard[1];
                return marblesInRow;
            }
            if (rowID == 2)
            {
                marblesInRow = rowOnBoard[2];
                return marblesInRow;
            }
            if (rowID == 3)
            {
                marblesInRow = rowOnBoard[3];
                return marblesInRow;
            }

            else
            {
                return 0;
            }

        }
       //this will check if the game is over, or keeps continuing 
        public int checkBoardTotalMarbles()
        {
            if (totalMarblesCount == 0)
            {
                //Current Player loses
                //Opposite player wins
                return 0;
            }
            else if (totalMarblesCount == 1)
            {
                //Current player wins
                //Opposite player loses
                return 1;
            }
            else
            {
                //Game will continue, totalMarblesCount >1

                return -1;
            }
        }

        //when a playet selects a marble from a row:
        public void RemoveMarbles(int rowID, int numMarblesSelected)
        {
            int marblesInRow = 0;
            if (rowID == 0)
            {
                marblesInRow = rowOnBoard[0];
                rowOnBoard[0] = marblesInRow - numMarblesSelected;
                totalMarblesCount -= numMarblesSelected; 
            }
            if (rowID == 1)
            {
                marblesInRow = rowOnBoard[1];
                rowOnBoard[1] = marblesInRow - numMarblesSelected;
                totalMarblesCount -= numMarblesSelected;
            }
            if (rowID == 2)
            {
                marblesInRow = rowOnBoard[2];
                rowOnBoard[2] = marblesInRow - numMarblesSelected;
                totalMarblesCount -= numMarblesSelected;
            }
           
            if (rowID == 3)
            {
                marblesInRow = rowOnBoard[3];
                rowOnBoard[3] = marblesInRow - numMarblesSelected;
                totalMarblesCount -= numMarblesSelected;
            }
            numMarblesSelected = 0;
        }
        
        
    }
}
