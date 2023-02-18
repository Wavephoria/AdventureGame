namespace AdventureGame
{
    internal class Program
    {
        // public List<Monster> monsters = new List<Monster>();
        // public List<Hero> heroes = new List<Hero>();
        Battle battle = new Battle();

        private static void Main(string[] args)
        {
            Program program = new Program();
            program.GameLogic();
        }

        private void GameLogic()
        {
            WorldMap worldMap = new WorldMap();
            // heroes.Add(new Hero());
            // program.AddMonsters();

            Hero player = new Hero();
            System.Console.WriteLine(StoryTelling.BeginningAdventure(player));
            System.Console.WriteLine(player.pouch);

            Monster redSlime = new Slime(player.Level);
            Monster snake = new Snake(player.Level);

            // System.Console.WriteLine(blueSlime.Name);
            // System.Console.WriteLine(blueSlime.Life + " hp");

            // System.Console.WriteLine(redSlime.Name);
            // System.Console.WriteLine(redSlime.Life + " hp");

            // System.Console.WriteLine(snake.Name);
            // System.Console.WriteLine(snake.Life + " hp");

            System.Console.WriteLine($"{player.Life} life left");
            battle.BattlingEnemy(player, snake, true);
            Console.WriteLine(redSlime.Life);
            battle.BattlingEnemy(player, redSlime, true);
            battle.BattlingEnemy(player, redSlime, true);
            System.Console.WriteLine(redSlime.Life);
            battle.BattlingEnemy(player, redSlime, true);
            battle.BattlingEnemy(player, redSlime, true);
            battle.BattlingEnemy(player, redSlime, true);
            battle.BattlingEnemy(player, redSlime, true);



            System.Console.WriteLine($"{player.Life} life left");
            System.Console.WriteLine(player.Level);
            System.Console.WriteLine(player.ExperiencePoints);

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

        // private void AddHero()
        // {
        //     heroes.Add(new Hero());
        // }
    }
}