namespace AdventureGame
{
    class WorldMap
    {

        public int[,] MapGrid { get; set; }

        public WorldMap()
        {
            // Making a world map with size of 64x64
            int[,] grid = new int[64, 64];
            MapGrid = grid;
            RandomizeNature();
        }

        private void RandomizeNature()
        {

        }

        // Planning to make a few cities where hero can visit and work for money

        // Making a random landscape outside of cities
        // There can be a few caves 1-3
        // There can be plains, wood and 1-2 bigger ponds

    }
}