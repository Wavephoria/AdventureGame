namespace AdventureGame
{
    class Slime : Monster
    {
        // Slimes are the basic enemy, low hp, low str, no initiative
        // Early enemy there for level up and some drops
        public override SlimeColor Color { get; init; }
        public override MonsterTypes MonsterType { get; init; }
        public override int LifeLower { get; set; } = 10;
        public override int LifeHigher { get; set; } = 19;
        public Slime(int level) : base(level)
        {
            Strength *= Modifier / 2;
            Life = RandomHP() * Modifier;
            Color = RandomColor();
            Name = GetName();
            MonsterType = MonsterTypes.Slime;
        }

        internal override string GetName()
        {
            return $"{Color} {MonsterType}";
        }


    }
}