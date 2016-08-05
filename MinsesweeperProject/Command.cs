using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinsesweeperProject
{
   public class Command
    {
       int xPosition, yPosition;
       Playground.playgroundStates commandState;

       public Command(string command)
       {
           for (int i = 0; i < command.Length;i++)
           {
               if ('o' == command[i])
               {
                   commandState = Playground.playgroundStates.opened;
               }
               else if ('f' == command[i])
               {
                   commandState = Playground.playgroundStates.flagged;
               }
               else if (command[i] == '(')
               {
                   int.TryParse(command[i + 1].ToString(), out xPosition);
                   int.TryParse(command[i + 3].ToString(), out yPosition);
               }
           }
       }
       public int getPlayerXPosition()
       {
           return xPosition;
       }
       public int getPlayerYPosition()
       {
           return yPosition;
       }

       public Playground.playgroundStates getPlayerState()
       {
           return commandState;
       }
    }
}
