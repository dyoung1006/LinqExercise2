
namespace LinqExercise2
{
    internal class Program
    {
        private static string[] gameNames =
        {"Minecraft",
         "Grand Theft Auto V",
         "Tetris (EA)",
         "Wii sports",
         "PUBG: Battlegrounds"
        };

        static void Main(string[] args)
        {
            
            #region Instructions
            /*
             *Use the list of Linq methods for help
             *
             *Create a list of video game names
             *Order the list of games by length of the game name.
             *Use the lambda expression in this exercise as well.
             *use the method syntax for this exercise
             */
            #endregion

            var orderedListOfGames = gameNames.OrderBy(x => x.Length).ToList();

            Console.WriteLine("===Displaying Results===");
            foreach(var name in orderedListOfGames) 
            {
                Console.WriteLine(name.ToString());
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
