namespace AdventureGame
{
    abstract class Monster : BaseAttributesForAll
    {
        // Monster spawn should be in relation to hero level
        // When hero on level 1, it should be 90% chance for a slime, 10% for a snake
        // When hero on level 2, maybe around 75% slime, 20% snake, 5% skeleton
        // etc
        public virtual SlimeColor Color { get; init; }
        public virtual MonsterAttributes MonsterAttribute { get; init; } = MonsterAttributes.Tiny;
        public virtual MonsterTypes MonsterType { get; init; }
        public virtual int LifeLower { get; set; } = 0;
        public virtual int LifeHigher { get; set; } = 100;
        public int Modifier { get; set; }
        public abstract int ExperiencePoints(Hero hero);

        public Monster(int level)
        {
            int modifier = CheckHeroLevel(level);
            Modifier = modifier;
        }
        internal int CheckHeroLevel(int level)
        {
            double modifier;
            if (level > 1)
            {
                modifier = level * 0.75;
            }
            else
                modifier = 1.0;

            return (int)Math.Round(modifier);
        }
        internal int RandomHP()
        {
            int life = randomNumber.Next(LifeLower, LifeHigher);
            return life;
        }
        internal MonsterAttributes RandomAttribute()
        {
            Array values = Enum.GetValues(typeof(MonsterAttributes));
            MonsterAttributes randomAttribute = (MonsterAttributes)values.GetValue(randomNumber.Next(values.Length))!;
            return randomAttribute;
        }
        internal SlimeColor RandomColor()
        {
            Array values = Enum.GetValues(typeof(SlimeColor));
            SlimeColor randomColor = (SlimeColor)values.GetValue(randomNumber.Next(values.Length))!;
            return randomColor;
        }
    }
}