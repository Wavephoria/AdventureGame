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