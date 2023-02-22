namespace AdventureGame
{
    class Sandlands : Encounter
    {
        // Dingo, Skeleton, Wolf, Spider
        public override void CheckEncounter(Hero player)
        {
            int number = RandomNumber(1, 101);
            if (number < 20)
                System.Console.WriteLine("Nothing happens this time! Just move along!");
            else if (number < 65)
            {
                System.Console.WriteLine("A Monster is approaching you!");
                Monster slime = new Slime(1);
                battle.BattlingEnemy(player, slime);
            }
            else if (number < 90)
            {
                System.Console.WriteLine("A Monster is approaching you!");
                Monster snake = new Snake(1);
                battle.BattlingEnemy(player, snake);
            }
            else
                System.Console.WriteLine("A travelling salesman is standing on the road!");
        }
    }
}