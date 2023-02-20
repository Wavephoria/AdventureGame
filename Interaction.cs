namespace AdventureGame
{
    class Interaction
    {
        // Movement WASD or ArrowKeys
        // I for Inventory
        // C for Character Sheet
        Encounter encounter;
        internal void UserInput(WorldMap worldMap, Hero player)
        {
            System.Console.WriteLine($"To the north you have {worldMap.Name(worldMap.MapGrid[player.X, player.Y - 1])}");
            System.Console.WriteLine($"To the east you have {worldMap.Name(worldMap.MapGrid[player.X + 1, player.Y])}");
            System.Console.WriteLine($"To the south you have {worldMap.Name(worldMap.MapGrid[player.X, player.Y + 1])}");
            System.Console.WriteLine($"To the west you have {worldMap.Name(worldMap.MapGrid[player.X - 1, player.Y])}");


            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.W:
                    player.Y -= 1;
                    break;
                case ConsoleKey.D:
                    player.X += 1;
                    break;
                case ConsoleKey.S:
                    player.Y += 1;
                    break;
                case ConsoleKey.A:
                    player.X -= 1;
                    break;
            }

            switch (worldMap.MapGrid[player.X, player.Y])
            {
                case "F":
                    break;
                case "M":
                    break;
                case "Q":
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
                    break;
                case "C":
                    break;
                case "T":
                    encounter = new Town();
                    encounter.CheckStatus(player, worldMap);
                    break;
                case "D":
                    break;
                case "R":
                    encounter = new Road();
                    encounter.CheckEncounter(player);
                    break;
                default:
                    break;
            }
        }

    }
}