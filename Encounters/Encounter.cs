namespace AdventureGame
{
    class Encounter
    {
        public Random random = new Random();
        public Battle battle = new Battle();
        public int RandomNumber(int x, int y)
        {
            return random.Next(x, y);
        }
        public virtual void CheckStatus(Hero player, WorldMap worldMap)
        {

        }
        public virtual void CheckEncounter(Hero player)
        {

        }
    }
}