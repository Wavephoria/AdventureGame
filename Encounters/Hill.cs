namespace AdventureGame
{
    class Hill : Encounter
    {
        // Slime, Goblin, Gorilla, Wolf
        public override void CheckEncounter(Hero player)
        {
            int number = RandomNumber(1, 101);
            if (number < 50)
                System.Console.WriteLine("Nothing happens this time! Just move along!");
            else if (number < 75)
            {
                System.Console.WriteLine("A Monster is approaching you!");
                Monster slime = new Slime(1);
                battle.BattlingEnemy(player, slime);
            }
            else
                System.Console.WriteLine("A travelling salesman is standing on the road!");
        }
    }
}