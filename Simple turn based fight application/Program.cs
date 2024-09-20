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

            int playerhealth = 50; //how much health you have
            int enemyhealth = 40; //how much the npc has

            int playerattack = 10; //your damage attack regular
            int playerspell = 15;
            int enemyattack = 12; // their damage
            int enemyspell = 20; //spells hurt your enemy, you take restore amount damage as splash

            int restoreamount = 8;

            Random random = new Random(); //it should be 0 for attacking or 1 for restoring

            while (playerhealth > 0 && enemyhealth > 0)
            {
                //your turn so your input
                Console.WriteLine("It is your turn.");
                Console.WriteLine("Enter a to attack, r to restore health or s for spell.");
                string playerchoice = Console.ReadLine();
                if (playerchoice == "a")
                {
                    enemyhealth -= playerattack;//
                    Console.WriteLine($"You swing a heavy mace and deal {playerattack} damage! They now have {enemyhealth} hitpoints.");
                }
                else if (playerchoice == "r")
                {
                    playerhealth += restoreamount;
                    Console.WriteLine($"The sun shines brightly on you. You have restored {restoreamount} hitpoints! You now have {playerhealth} hitpoints.");
                }
                else if (playerchoice == "s")
                {
                    enemyhealth -= playerspell;
                    playerhealth -= restoreamount;
                    Console.WriteLine($"You shoot a lightning bolt at your foe dealing {playerspell} damage to them and take {restoreamount} damage from the splash! You now have {playerhealth} health and your enemy now has {enemyhealth} health!");
                }

                //now I have to focus on the enemy

                if (enemyhealth > 0) //somehow changing this from if to else if was what broke it, not sure how but I guess I'll find out in time
                {
                    Console.WriteLine("It is the enemie's turn.");
                    //now, since the enemy is not controlled by a person they must be able to act randomly. I will probably reference this basic npc behavior for a future project
                    int enemychoice = random.Next(0, 3);

                    if (enemychoice == 0) //zero is an attack
                    {
                        playerhealth -= enemyattack;
                        Console.WriteLine($"The enemy slashes at you wildly with their sword and deals {enemyattack} damage. You now have {playerhealth} hitpoints.");
                    }
                    else if (enemychoice == 1)
                    {
                        enemyhealth += restoreamount;
                        Console.WriteLine($"A purple light envelops the enemy. The enemy has restored {restoreamount} hitpoints. They now have {enemyhealth} hitpoints");
                    }
                    else if (enemychoice == 2)
                    {
                        playerhealth -= enemyspell;
                        enemyhealth -= restoreamount;
                        Console.WriteLine($"Your enemy shoot a lightning bolt at you dealing {playerspell} damage, they take {restoreamount} damage from the splash! You now have {playerhealth} health and your enemy now has {enemyhealth} health!");
                    }
                    {
                        
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
