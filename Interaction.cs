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
            System.Console.WriteLine("What do you want to do?");
            System.Console.WriteLine("I for Inventory, S for Stats, M for Movement");
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.I:
                    CheckInventory(player);
                    break;
                case ConsoleKey.S:
                    CheckStats(player);
                    break;
                case ConsoleKey.M:
                    CheckMovement(player, worldMap);
                    break;
                default:
                    break;
            }


        }

        private void CheckMovement(Hero player, WorldMap worldMap)
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
                default:
                    break;
            }
        }

        private void CheckStats(Hero player)
        {
            System.Console.WriteLine($"Name: {player.Name} \n Class: {player.HeroClass} \n Level: {player.Level} \n Exp: {player.ExperiencePoints} \n Life left: {player.Life} ");
        }

        private void CheckInventory(Hero player)
        {

        }
    }
}