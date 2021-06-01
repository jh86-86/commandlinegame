

namespace bootcampgame
{
    class Encounters
    {
        //encoutners generic



        //encounters

        public static void FirstEncounter()
        {
            Console.WriteLine("Upon the horizon, an enormous bug comes running at you. You prepare to fight it with you wits and limited knowledge of coding.");
            Console.ReadKey();
        }


        //encounter tools

        public static void Combat(bool random, string name, int power, int health)
        {
            string n="";
            int p=0;
            int h= 0;

            if(random)
            {

            }
            else
            {
                n= name;
                p=power;
                h=health

            }

            while(h>0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("|  (A)ttack         (D)efend  |");
                Console.WriteLine("|    (R)un            (H)eal  |");
                Console.WriteLine("===============================");
                Console.WriteLine("Potions: "+Program.currentPlayer.potion+"  Health: "+Program.currentPlayer.health);
                string input= Console.ReadLine();
                if(input.ToLower() == "a"|| input.ToLower()=="attack")
                {
                    //attack
                }
                else if(input.ToLower() == "d"|| input.ToLower()=="defend")
                {
                    //defend
                }
                else if(input.ToLower() == "r"|| input.ToLower()=="run")
                {
                    //run
                }
                else if(input.ToLower() == 'h'|| input.ToLower()=="heal")
                {
                    //heal
                }
            }
        }

        
    }
}