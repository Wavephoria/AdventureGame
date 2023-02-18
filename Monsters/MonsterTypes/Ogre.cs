namespace AdventureGame
{
    class Ogre : Monster
    {
        // Ogre will be the first real challenge before meeting those early bosses
        // Very high hp and high str, will have enough initiative be sometimes be able to hit before hero
        public override MonsterAttributes MonsterAttribute { get; init; }
        public override MonsterTypes MonsterType { get; init; } = MonsterTypes.Ogre;
        public override int LifeLower { get; set; } = 55;
        public override int LifeHigher { get; set; } = 110;
        public Ogre(int level) : base(level)
        {
            Life = RandomHP();
            MonsterAttribute = RandomAttribute();
            Name = GetName();
        }

        internal override string GetName()
        {
            return $"{MonsterAttribute} {MonsterType}";
        }
    }
}