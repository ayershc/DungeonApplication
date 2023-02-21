namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.Title = "Dungeon of Doom!";
            Console.WriteLine("Your journey begins...\n");
            #endregion

            #region Player Creation
            //TODO Variable to keep score
            int score = 0;
            //TODO Weapon creation

            //TODO Player Object Creation
            #endregion

            #region Main Game Loop
            bool exit = false;
            int innerCount = 0;
            int outerCount = 0;
            do
            {
                //Console.WriteLine("Outer " + ++outerCount);
                //TODO Generate a random room
                Console.WriteLine(GetRoom());
                //TODO Select a random monster to inhabit the room
                Console.WriteLine("Here's a monster!");
                #region Gameplay Menu Loops
                bool reload = false;
                do
                {
                    //Console.WriteLine("Inner " + ++innerCount);
                    //TODO Gameplay menu
                    #region Menu
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO Attack
                            break;

                        case ConsoleKey.R:
                            //TODO Combat
                            Console.WriteLine("Run away!");
                            reload = true;
                            break;

                        case ConsoleKey.P:
                            //TODO Player info
                            Console.WriteLine("Player info: ");
                            break;
                        case ConsoleKey.M:
                            //TODO Monster info
                            Console.WriteLine("Monster info: ");
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            break;

                        default:
                            break;
                    }//end switch

                    #endregion
                    //TODO Check player health
                                        
                } while (!reload && !exit); //if either exit or reload is true, the inner loop will exit.
                #endregion
            } while (!exit);//if exit is true, the outer loop will exit as well.

            //Show the score
            Console.WriteLine("You defeated " + score + "monster" +
                (score == 1 ? "." : "s."));

            #endregion

        }//end Main

        private static string GetRoom()
        {
            string[] rooms =
            {
                "1","2","3","4","5"
            };

            Random rand = new Random();

            int index = rand.Next(rooms.Length);

            string room = rooms[index];

            return room;
            //possible refactor
            //return rooms[new Random().Next(rooms.Length)];
        }//end GetRoom()

    }//end class
}//end namespace