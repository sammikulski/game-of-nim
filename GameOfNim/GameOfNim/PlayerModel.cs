/*Project 1 - the Game of Nim 
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski
*This PlayerModel class is used to keep track
 of the number of wins and each player's names
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim
{
    class PlayerModel
    {
        string playerName;
        int countOfWins;
        
        
        public PlayerModel(String inputName)
        {
            playerName = inputName;
            countOfWins = 0;
        }
        public String getPlayerName()
        {
            return playerName;
        }
      
        //after a player wins:
        public int incrementWins()
        {
            return countOfWins++;
        }
        public int getCountOfWins()
        {
            return countOfWins;
        }
    }
}
