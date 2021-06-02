
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
            //first fight
            Console.WriteLine("Upon the horizon, an enormous bug comes running at you. You prepare to fight it with you wits and limited knowledge of coding.");
            Console.ReadKey();
            Combat(false, "bug",1,1);
        }

        public static void basicFightEncounter()
        {
            //just random monsters
            Console.WriteLine("You have encountered a new foe");
            Console.ReadKey();
            Combat(true,"",0,0);
        }

        public static void BardEncounter()
        {
            //first boss fight
            Console.Clear();
            Program.currentPlayer.health=10;
            Console.WriteLine("From the distance you can hear a faint melody");
            Console.WriteLine("As you get closer you can see a bearded man with long hair strumming on lute");
            Console.WriteLine($"As you get closer he is singing about 'getting oneself to the breakout rooms.'");
            Console.WriteLine("The bard notices you. He puts down his lute and introduces himself:'Hi, I am grandmaster man. I task you with a challange. I need you to find my students and defeat the great nemesis of this land. I am grnadmaster and the furious cohort 5. I have lost my cohortiers. Of which you are one. You need to assemble them and fight your way through the next 13 weeks to your ultimate prize of stable employment in a junior tech role. Firstly though, we shall do battle to assess your skill");
            Combat(false,"GrandMasterMan",2,4);
            Console.WriteLine("Well done, I will increase your base health, attack and defense to prepare you for your journey");
            Program.currentPlayer.baseHealth=20; //base health increase
            Program.currentPlayer.health=20;
            Console.WriteLine("You ask: 'Oh great bard. Do you have any advice for this hero as he sets out on his journey?");
            Console.WriteLine("The bard looks at the sky solemnly and answers: 'If you get stuck check the microsoft docs.'");
            Console.WriteLine("You take his advice and watch the bard leave as he sings a song about Javascript.");


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
                {   //attack
                    Console.WriteLine("The enemy attacks you");
                    int damage= p- Program.currentPlayer.armourValue;
                    int attack= rand.Next(0, Program.currentPlayer.weaponValue)+ rand.Next(1,4);
                    Console.WriteLine("You lose "+damage+" .And you deal "+attack+" damage" );
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "d"|| input.ToLower()=="defend")
                {
                    //defense
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
                    //potion sequence
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
                //victory sequence
                if(h<0){
                 int coinsReward= rand.Next(10,50);
                 Program.currentPlayer.coin+=coinsReward;
                Console.WriteLine("You defeated "+n+" and you find "+ coinsReward+" coins");
                Console.ReadKey();
                }
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