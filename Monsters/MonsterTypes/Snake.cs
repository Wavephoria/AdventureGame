namespace AdventureGame
{
    class Snake : Monster
    {
        // Snakes have higher hp than slimes but will be around the same str and no initiative
        public override MonsterAttributes MonsterAttribute { get; init; }
        public override MonsterTypes MonsterType { get; init; } = MonsterTypes.Snake;
        public override int LifeLower { get; set; } = 21;
        public override int LifeHigher { get; set; } = 34;
        public Snake()
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