using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampgame
{
    class Program
    {
        public static Player currentPlayer= new Player();
        public static bool mainLoop= true;

        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
            while(mainLoop)
            {
                Encounters.RandomEncounter();
            }

        }

        static void Start()
        {
            Console.WriteLine("Bootcamp War");
            Console.WriteLine("What is your name?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            
            if(currentPlayer.name != ""){
                Console.WriteLine("You awake in a in your bedroom with your computer humming in the background. You feel trepidation as you begin your coding adventure. You remember that your name is "+ currentPlayer.name);
                Console.ReadKey();
            }else{
                Console.WriteLine("You wake up at a desk.You have no name....no history. All you know is that you are here to start a coding journey");
                Console.ReadKey();
            };

          Console.WriteLine("You find yourself sucked into the magical world of code via your computer. It is a green pasture and the sun is shining. You feel good that you have finally started the adventure but you have no idea what this adventure will bring."); 
          Console.ReadKey();










        }
    }
}
