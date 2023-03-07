namespace AdventureGame
{
    class Forest : Encounter
    {
        // Slime, Snake, Spider, Goblin, Wolf, Troll
        public override void CheckEncounter(Hero hero)
        {
            int number = RandomNumber(1, 101);
            if (number < 25)
                System.Console.WriteLine("Nothing happens this time! Just move along!");
            else if (number < 65)
            {
                Console.WriteLine("A Monster is approaching you!");
                Monster slime = new Slime(hero.Level);
                battle.BattlingEnemy(hero, slime);
            }
            else if (number < 85)
            {
                Console.WriteLine("You hear some sounds from the bush close to you!");
                Monster snake = new Snake(hero.Level);
                battle.BattlingEnemy(hero, snake);
            }
            else if (number < 90)
            {
                Console.WriteLine("You see a big shadow looming over you!");
                Monster ogre = new Ogre(hero.Level);
                battle.BattlingEnemy(hero, ogre);
            }
            else
                Console.WriteLine("A travelling salesman is standing on the road!");
        }
    }
}