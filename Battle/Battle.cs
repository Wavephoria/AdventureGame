namespace AdventureGame
{
    class Battle
    {
        // Need to check for who has initiative and what distance between hero and monster
        // and if anyone attack from distance, there will be no attack back unless the other also
        // has enough range
        public void BattlingEnemy(Hero hero, Monster monster)
        {
            if (monster.Life == 0)
            {
                return;
            }

            // Should print out on screen all information needed before engaging in the fight
            // Name, type, str, armor, hp but initiative needs to be hidden
            // idea is to make a few enemies having a chance for initiative like maybe ogre
            // but never slimes or snakes
            // Should give hero a choice of what to do before fighting
            // Fight, Run, Look in backpack
            bool HeroNotRunning = true;
            bool isHeroInitiative = true;
            do
            {
                Console.WriteLine($"{hero.Name} has {hero.Life} left \n" +
                                  $"Hero has {hero.Strength} strength and {hero.Protection} protection");
                Console.WriteLine($"{monster.Name} has {monster.Life} left \n" +
                                  $"Monster has {monster.Strength} strength and {monster.Protection} protection");
                Console.WriteLine("What do you want to do? [F]ight, [R]un or look at [I]tems");
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.F:
                        break;
                    case ConsoleKey.R:
                        HeroNotRunning = false;
                        break;
                }
                
                if (HeroNotRunning)
                {
                    if (isHeroInitiative)
                    {
                        HitByHero(hero, monster);
                        if (monster.Life != 0)
                            HitByMonster(hero, monster);
                    }
                    else
                    {
                        HitByMonster(hero, monster);
                        HitByHero(hero, monster);
                    }

                    Console.WriteLine($"Hero HP: {hero.Life}");
                    Console.WriteLine($"Monster HP: {monster.Life}");
                }
            } while (hero.Life > 0 && monster.Life > 0 && HeroNotRunning);
        }

        private void HitByMonster(Hero hero, Monster monster)
        {
            int hitPower = monster.Strength - hero.Protection;
            int lifeLeft = hero.Life - hitPower;
            hero.Life = lifeLeft;
        }

        private void HitByHero(Hero hero, Monster monster)
        {
            int hitPower = hero.Strength - monster.Protection;
            int lifeLeft = monster.Life - hitPower;
            if (lifeLeft <= 0)
            {
                monster.Life = 0;
                EnemyKilled(monster, hero);
            }
            else
                monster.Life = lifeLeft;
        }

        private void EnemyKilled(Monster monster, Hero hero)
        {
            int exp = monster.ExperiencePoints(hero);
            ExperienceGained(hero, exp);
        }

        private void ExperienceGained(Hero hero, int exp)
        {
            hero.ExperiencePoints += exp;
            if (hero.ExperiencePoints >= 100)
                hero.LevelUp();
        }
    }
}