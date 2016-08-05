using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinsesweeperProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(3, 3,2);
            var noOfInputs = 4;
            player.printPlaygroundState();
            
            CommandHelper helper = new CommandHelper();

            while (noOfInputs != 0)
            {
                Command command = helper.getCommandFromConsole();
                player.play(command.getPlayerXPosition(), command.getPlayerYPosition(), command.getPlayerState());
                Console.WriteLine("----");
                player.printPlaygroundState();              
            }
         
            Console.ReadLine();
        }
    }
}
