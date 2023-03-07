using AdventureGame.WorldGeneration;

namespace AdventureGame
{
    internal class Program
    {
        Interaction input = new Interaction();

        private static void Main(string[] args)
        {
            Program program = new Program();
            program.GameLogic();
        }

        private void GameLogic()
        {
            WorldMap worldMap = new WorldMap();

            Hero player = new Hero();
            System.Console.WriteLine(StoryTelling.BeginningAdventure(player));
            System.Console.WriteLine(player.Pouch);
            bool isNotDone = true;
            do
            {
                input.UserInput(player, worldMap);

            } while (isNotDone);
        }
    }
}