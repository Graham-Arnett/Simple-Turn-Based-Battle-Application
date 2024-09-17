namespace Simple_turn_based_fight_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fight!");
            //this is a very simple exercise, I want to eventually build on this for something more substantial

            //ok so this has the damage, health, and restore values
            //random for the npc behavior, and handling for when one of you loses, I think this simple exercise is finished

            int playerhealth = 16; //how much health you have
            int enemyhealth = 10; //how much the npc has

            int playerattack = 2; //your damage
            int enemyattack = 3; // their damage

            int restoreamount = 3;

            Random random = new Random(); //it should be 0 for attacking or 1 for restoring

            while (playerhealth > 0 && enemyhealth > 0)
            {
                //your turn so your input
                Console.WriteLine("It is your turn.");
                Console.WriteLine("Enter a to attack or r to restore health.");
                string attackrestore = Console.ReadLine();
                if (attackrestore == "a")
                {
                    enemyhealth -= playerattack;//
                    Console.WriteLine($"You have dealt {playerattack} damage. They now have {enemyhealth} hitpoints.");
                }
                else if (attackrestore == "r")
                {
                    playerhealth += restoreamount;
                    Console.WriteLine($"You have restored {restoreamount} hitpoints. You now have {playerhealth} hitpoints.");
                }

                //now I have to focus on the enemy

                if (enemyhealth > 0) //somehow changing this from if to else if was what broke it, not sure how but I guess I'll find out in time
                {
                    Console.WriteLine("It is the enemie's turn.");
                    //now, since the enemy is not controlled by a person they must be able to act randomly. I will probably reference this basic npc behavior for a future project
                    int enemychoice = random.Next(0, 2);

                    if (enemychoice == 0) //zero is an attack
                    {
                        playerhealth -= enemyattack;
                        Console.WriteLine($"The enemy has dealt {enemyattack} damage. You now have {playerhealth} hitpoints.");
                    }
                    else if (enemychoice == 1)
                    {
                        enemyhealth += restoreamount;
                        Console.WriteLine($"The enemy has restored {restoreamount} hitpoints. They now have {enemyhealth} hitpoints");
                    }
                    if (playerhealth <= 0)
                    {
                        Console.WriteLine("You have lost.");
                    }
                    if (enemyhealth <= 0)
                    {
                        Console.WriteLine("You have won, your enemy is defeated.");
                    }

                }
               
            }

        }
    }
}
