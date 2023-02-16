class Battle
{

    // Need to check for who has initiative and what distance between hero and monster
    // and if anyone attack from distance, there will be no attack back unless the other also
    // has enough range
    public void BattlingEnemy(Hero hero, Monster monster, bool isHeroInitiative)
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

        if (isHeroInitiative)
        {
            HitByHero(hero, monster);
            HitByMonster(hero, monster);
        }
        else
        {
            HitByMonster(hero, monster);
            HitByHero(hero, monster);
        }

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
            int exp = EnemyKilled(monster);
            ExperienceGained(hero, exp);
        }
        else
            monster.Life = lifeLeft;
    }
    private int EnemyKilled(Monster monster)
    {
        int exp = 0;
        switch (monster.MonsterType)
        {
            case MonsterTypes.Slime:
                exp = 10;
                break;
            case MonsterTypes.Ogre:
                exp = 50;
                break;
            case MonsterTypes.Troll:
                exp = 30;
                break;
            case MonsterTypes.Snake:
                exp = 35;
                break;
        }
        return exp;
    }
    private void ExperienceGained(Hero hero, int exp)
    {
        hero.ExperiencePoints = hero.ExperiencePoints + exp;
        HeroCheckForLevelUp(hero);
    }
    private void HeroCheckForLevelUp(Hero hero)
    {
        if (hero.ExperiencePoints >= 100)
        {
            hero.Level++;
            int numberLeft = hero.ExperiencePoints % 100;
            hero.ExperiencePoints = hero.ExperiencePoints - 100;
        }
    }
}