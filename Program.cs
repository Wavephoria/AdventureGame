namespace AdventureGame
{
    internal class Program
    {
        public List<Monster> monsters = new List<Monster>();
        public List<Hero> heroes = new List<Hero>();
        Battle battle = new Battle();

        private static void Main(string[] args)
        {
            Program program = new Program();
            program.GameLogic();
        }

        private void GameLogic()
        {
            WorldMap worldMap = new WorldMap();
            AddHero();
            // program.AddMonsters();

            Hero jeremiah = heroes[0];
            Monster blueSlime = new Slime();
            Monster redSlime = new Slime();
            Monster snake = new Snake();

            // System.Console.WriteLine(blueSlime.Name);
            // System.Console.WriteLine(blueSlime.Life + " hp");

            // System.Console.WriteLine(redSlime.Name);
            // System.Console.WriteLine(redSlime.Life + " hp");

            // System.Console.WriteLine(snake.Name);
            // System.Console.WriteLine(snake.Life + " hp");

            System.Console.WriteLine($"{jeremiah.Life} life left");
            battle.BattlingEnemy(jeremiah, snake, true);
            Console.WriteLine(redSlime.Life);
            battle.BattlingEnemy(jeremiah, redSlime, true);
            battle.BattlingEnemy(jeremiah, redSlime, true);
            System.Console.WriteLine(redSlime.Life);
            battle.BattlingEnemy(jeremiah, redSlime, true);
            battle.BattlingEnemy(jeremiah, redSlime, true);
            battle.BattlingEnemy(jeremiah, redSlime, true);
            battle.BattlingEnemy(jeremiah, redSlime, true);



            System.Console.WriteLine($"{jeremiah.Life} life left");
            System.Console.WriteLine(jeremiah.Level);
            System.Console.WriteLine(jeremiah.ExperiencePoints);

        }

        private void AddMonsters()
        {
            // string name = Console.ReadLine()!;
            // string type = Console.ReadLine()!;
            // int life = int.Parse(Console.ReadLine()!);

            // Monster newMonster = new Monster(name, type, life);

            // monsters.Add(new Slime(SlimeColor.Blue));
            // monsters.Add(new Slime(SlimeColor.Red));
            // monsters.Add(new Slime(SlimeColor.Green));
            // monsters.Add(new Slime(SlimeColor.Purple));
            // monsters.Add(new Slime(SlimeColor.White));
            // monsters.Add(new Slime(SlimeColor.Black));
            // monsters.Add(new Snake(MonsterAttributes.Dashing, MonsterTypes.Snake, 31));
            // monsters.Add(new Snake(MonsterAttributes.Sneaky, MonsterTypes.Snake, 35));

        }

        private void AddHero()
        {
            heroes.Add(new Hero(HeroClasses.Wizard, Elements.fire));
            heroes[0].Life = 120;
            heroes[0].Strength = 7;
        }
    }
}