using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinsesweeperProject
{
   public class Playground
    {
       int playgroundWidth, playgroundHeight;
       int[][] playground;

       public enum playgroundStates { unopened, opened, Mine, flagged };
       public Playground(int playgroundWidth, int playgroundHeight)
       {
           this.playgroundHeight = playgroundHeight;
           this.playgroundWidth = playgroundWidth;
           createPlayground();
       }

       void createPlayground()
       {
           playground = new int[playgroundHeight][];
           for (int i = 0; i < playgroundHeight; i++)
           {
               playground[i] = new int[playgroundWidth];
           }        
       }      
       
       public void addMinesToPlayground(int noOfMines)
       {
           Random randomNo = new Random();
           for (int i = 0; i < noOfMines; i++)
           {
              var randomRow = randomNo.Next(playgroundHeight);
              var randomColumn = randomNo.Next(playgroundWidth);
              playground[randomRow][randomColumn] = (int)playgroundStates.Mine;
           }
       }

       public void displayPlaygroundWithMines()
       {
           for (int i = 0; i < playgroundHeight; i++)
           {
               for (int j = 0; j < playgroundWidth; j++)
               {
                   if (playground[i][j] == (int)playgroundStates.Mine)
                   {
                       Console.Write("M");
                   }
                   else
                   {
                       Console.Write("X");
                   }                              
               }
               Console.WriteLine(" ");
           }
       }

       public void displayPlaygroundCurrentState()
       {
           for (int i = 0; i < playgroundHeight; i++)
           {
               for (int j = 0; j < playgroundWidth; j++)
               {
                   if (playground[i][j] == (int)playgroundStates.opened)
                   {
                       Console.Write("O");
                   }
                   else if (playground[i][j] == (int)playgroundStates.flagged)
                   {
                       Console.Write("f");
                   }
                   else
                   {
                       Console.Write("X");
                   }
               }
               Console.WriteLine(" ");
           }
       }
       public void setUserInput(int row, int column, playgroundStates state){
           if (playground[row][column] != (int)playgroundStates.Mine)
           {
               playground[row][column] = (int)state;         
           }           
       }

       public bool checkInputForMine(int row, int column)
       {
           if (row <= playgroundHeight && column <= playgroundHeight)
           return (playground[row][column] == (int)playgroundStates.Mine);
           return false;
       }
    }
}
