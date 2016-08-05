using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinsesweeperProject
{
   public class Player
    {
       Playground playground;

       public Player(int playgroundWidth, int playgroundHeight,int noOfMines)
       {
           playground = new Playground(playgroundWidth, playgroundHeight);
           playground.addMinesToPlayground(noOfMines);
       }

       public void printPlaygroundState()
       {
           playground.displayPlaygroundCurrentState();      
       }

       public void play(int row, int column, Playground.playgroundStates input)
       {
           if (playground.checkInputForMine(row, column))
           {
               Console.WriteLine("Game Over");
               playground.displayPlaygroundWithMines();
           }
           else if (input == Playground.playgroundStates.flagged || input == Playground.playgroundStates.opened)
           {
               playground.setUserInput(row, column, input);
           }
       }

    }
}
