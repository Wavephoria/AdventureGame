namespace AdventureGame
{
    class Grasslands : Encounter
    {
        // Slime, Snake, Skeleton, Troll, Spider
        public override void CheckEncounter(Hero hero)
        {
            int number = RandomNumber(1, 101);
            if (number < 20)
                Console.WriteLine("Nothing happens this time! Just move along!");
            else if (number < 90)
            {
                MonsterSpawn(hero);
            }
            else
                Console.WriteLine("A travelling salesman is standing on the road!");
        }
        private void MonsterSpawn(Hero hero)
        {
            int number = RandomNumber(1, 101);
            Monster monster;
            if (number < 65)
            {
                monster = new Slime(hero.Level);
                Console.WriteLine(monster.EncounterText());
            }
            else if (number < 80)
            {
                monster = new Snake(hero.Level);
                Console.WriteLine(monster.EncounterText());
            }
            else if (number < 95)
            {
                monster = new Skeleton(hero.Level);
                Console.WriteLine(monster.EncounterText());
            }
            else
            {
                monster = new Ogre(hero.Level);
                Console.WriteLine(monster.EncounterText());
            }
            
            battle.BattlingEnemy(hero, monster);
        }
    }
}