namespace AdventureGame.WorldGeneration
{
    class WorldMap
    {

        public string[,] MapGrid { get; set; }

        public WorldMap()
        {
            // Making a world map with size of 64x64

            string[,] grid = GeneratingTheMap();
            MapGrid = grid;
        }

        private string[,] GeneratingTheMap()
        {
            string[,] grid = new string[64, 64];
            // Absolute path, should be relative path but can't get it to work
            string filepath = @"/Users/wavephoria/Library/CloudStorage/OneDrive-Personal/RiderProjects/AdventureGame/WorldGeneration/WorldMapExcelCSV.csv";
            string mapString = File.ReadAllText(filepath);
            string[] mapArray = mapString.Split(';', '\n');
            int x = 0;
            int y = 0;
            foreach (var line in mapArray)
            {
                if (line.Length > 1)
                    grid[x, y] = line.Substring(0, 1);
                else
                    grid[x, y] = line;
                y++;

                if (y == 64)
                {
                    x++;
                    y = 0;
                }
            }
            return grid;
        }

        internal string Name(string v)
        {
            switch (v)
            {
                case "F":
                    return "Forest";
                case "M":
                    return "Mountain";
                case "Q":
                    return "Deep Forest";
                case "W":
                    return "Water";
                case "G":
                    return "Grasslands";
                case "S":
                    return "Sandlands";
                case "H":
                    return "Hills";
                case "C":
                    return "Cave";
                case "T":
                    return "Town";
                case "D":
                    return "Dungeon";
                case "R":
                    return "Rocky road";
                default:
                    return "Error";
            }
        }
        // Planning to make a few cities where hero can visit and work for money

        // Making a random landscape outside of cities
        // There can be a few caves 1-3
        // There can be plains, wood and 1-2 bigger ponds

    }
}