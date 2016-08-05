using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinsesweeperProject
{
   public class CommandHelper
    {
       Command command;
      public Command getCommandFromConsole()
       {
           var userInput = Console.ReadLine();
           command = new Command(userInput);
           return command;
       }
    }
}
