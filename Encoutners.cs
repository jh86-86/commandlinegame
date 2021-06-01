
using System;



namespace bootcampgame
{
    class Encounters
    {
        static Random rand= new Random();
        //encoutners generic



        //encounters

        public static void FirstEncounter()
        {
            Console.WriteLine("Upon the horizon, an enormous bug comes running at you. You prepare to fight it with you wits and limited knowledge of coding.");
            Console.ReadKey();
            Combat(false, "bug",1,1);
        }

        public static void basicFightEncounter()
        {
            Console.WriteLine("You have encountered a new foe");
            Console.ReadKey();
            Combat(true,"",0,0);
        }


        //encounter tools
        public static void RandomEncounter()
        {
            switch(rand.Next(0,1))
            {
                case 0:
                    basicFightEncounter();
                    break;
            }
        }

        public static void Combat(bool random, string name, int power, int health)
        {
            string n="";
            int p=rand.Next(1,5);
            int h= rand.Next(1,8);

            if(random)
            {
                n= GetName();

            }
            else
            {
                n= name;
                p=power;
                h=health;

            }

            while(h>0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("|  (A)ttack         (D)efend  |");
                Console.WriteLine("|    (R)un            (H)eal  |");
                Console.WriteLine("===============================");
                Console.WriteLine("Potions: "+Program.currentPlayer.potion+"  Health: "+Program.currentPlayer.health);
                Console.WriteLine(n + " has "+ h +" health");
                string input= Console.ReadLine();
                if(input.ToLower() == "a"|| input.ToLower()=="attack")
                {
                    Console.WriteLine("The enemy attacks you");
                    int damage= p- Program.currentPlayer.armourValue;
                    int attack= rand.Next(0, Program.currentPlayer.weaponValue)+ rand.Next(1,4);
                    Console.WriteLine("You lose "+damage+" .And you deal "+attack+" damage" );
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "d"|| input.ToLower()=="defend")
                {
                    Console.WriteLine("As"+n+" attack,You defend");
                    int damage= (p/4) - Program.currentPlayer.armourValue;
                    int attack= rand.Next(0, Program.currentPlayer.weaponValue)+ rand.Next(1,4);
                    Console.WriteLine("You lose "+damage+" .And you deal "+attack+" damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "r"|| input.ToLower()=="run")
                {
                    //run
                    if(rand.Next(0,2)==0)
                    {
                        Console.WriteLine("as you sprint away from the "+n+" pulls you back!");
                    }
                    else
                    {
                        Console.WriteLine("you managed to escape");
                    }
                }
                else if(input.ToLower() == "h"|| input.ToLower()=="heal")
                {
                   if(Program.currentPlayer.potion==0)
                   {
                       Console.WriteLine("You have no potions");
                   }
                   else
                   {
                       Console.WriteLine("You reach into your bag and use a potion");
                       int potionValue= 5;
                       Console.WriteLine("You gain "+potionValue+" health");
                       Program.currentPlayer.health+= potionValue;
                       
                   }

                  

                }
                //deathcode
                 Console.ReadKey();
                   if(Program.currentPlayer.health<=0)
                   {
                       Console.WriteLine("You have been defeated by "+n);
                       Console.ReadKey();
                       System.Environment.Exit(0);
                   }

                 int coinsReward= rand.Next(10,50);
                 Program.currentPlayer.coin+=coinsReward;
                Console.WriteLine("You defeated "+n+" and you find "+ coinsReward+" coins");
                Console.ReadKey();
            }
           
        }

        public static string GetName()
        {
            switch(rand.Next(0,5))
            {
                case 0:
                    return "Part time dev...monster";
                case 1:
                    return "Infinte loop....monster";
                case 2:
                    return "Confusing Microsoft docs answer...monster";
                case 3:
                    return "bug";
                case 4:
                    return "slow internet connection...monster";
                default:
                    return "some legacy code..monster";

            }
        }
        
    }
}