using System.Threading.Channels;
using AdventureGame.WorldGeneration;

namespace AdventureGame
{
    class Interaction
    {
        // Movement WASD or ArrowKeys
        // I for Inventory
        // C for Character Sheet
        Encounter encounter;
        internal void UserInput(Hero player, WorldMap worldMap)
        {
            bool isMoving = false;
            Console.WriteLine("You look around you and you see: ");
            Console.WriteLine($"To the north you have {worldMap.Name(worldMap.MapGrid[player.X, player.Y - 1])}");
            Console.WriteLine($"To the east you have {worldMap.Name(worldMap.MapGrid[player.X + 1, player.Y])}");
            Console.WriteLine($"To the south you have {worldMap.Name(worldMap.MapGrid[player.X, player.Y + 1])}");
            Console.WriteLine($"To the west you have {worldMap.Name(worldMap.MapGrid[player.X - 1, player.Y])}");
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("W to move North, A to move West, S to move South, D to move East, I to check Inventory or C to check Stats");

            ConsoleKeyInfo input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.W:
                    player.Y -= 1;
                    isMoving = true;
                    break;
                case ConsoleKey.D:
                    player.X += 1;
                    isMoving = true;
                    break;
                case ConsoleKey.S:
                    player.Y += 1;
                    isMoving = true;
                    break;
                case ConsoleKey.A:
                    player.X -= 1;
                    isMoving = true;
                    break;
                case ConsoleKey.I:
                    CheckInventory(player);
                    break;
                case ConsoleKey.C:
                    CheckStats(player);
                    break;
            }

            if (isMoving)
            {
                switch (worldMap.MapGrid[player.X, player.Y])
                {
                    case "F":
                        encounter = new Forest();
                        encounter.CheckEncounter(player);
                        break;
                    case "M":
                        encounter = new Mountain();
                        encounter.CheckEncounter(player);
                        break;
                    case "Q":
                        encounter = new DeepForest();
                        encounter.CheckEncounter(player);
                        break;
                    case "W":
                        break;
                    case "G":
                        encounter = new Grasslands();
                        encounter.CheckEncounter(player);
                        break;
                    case "S":
                        encounter = new Sandlands();
                        encounter.CheckEncounter(player);
                        break;
                    case "H":
                        encounter = new Hill();
                        encounter.CheckEncounter(player);
                        break;
                    case "C":
                        encounter = new Cave();
                        encounter.CheckStatus(player, worldMap);
                        break;
                    case "T":
                        encounter = new Town();
                        encounter.CheckStatus(player, worldMap);
                        break;
                    case "D":
                        encounter = new Cave();
                        encounter.CheckStatus(player, worldMap);
                        break;
                    case "R":
                        encounter = new Road();
                        encounter.CheckEncounter(player);
                        break;
                }
            }
        }

        private void CheckStats(Hero player)
        {
            System.Console.WriteLine($"Name: {player.Name} \n Class: {player.HeroClass} \n " +
                                     $"Level: {player.Level} \n Exp: {player.ExperiencePoints} \n Life left: {player.Life} ");
            Console.ReadLine();
        }

        private void CheckInventory(Hero player)
        {
            foreach (var item in player.backpack.open)
            {
                Console.WriteLine($"You have {item.Name}");
            }

            Console.ReadLine();
        }
    }
}