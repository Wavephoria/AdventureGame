namespace AdventureGame
{
    class Hero : BaseAttributesForAll
    {
        public HeroClasses HeroClass { get; init; }
        public Elements Element { get; set; }
        public int ExperiencePoints { get; set; }
        public Backpack backpack;
        public Pouch pouch;
        public int FocusPercentage { get; set; }
        public int[,] Position = new int[64, 64];
        public int X { get; set; } = 15;
        public int Y { get; set; } = 45;
        public int StartPosition { get; private set; }
        public int StartingLife { get; set; }

        public Hero()
        {
            StartPosition = Position[X, Y];
            Name = GetName();
            Level = 1;
            HeroClass = HeroClasses.Adventurer;
            Life = randomNumber.Next(100, 151);
            StartingLife = Life;
            backpack = new Backpack($"{Name}s backpack");
            backpack.open.Add(new Item("Napkins"));
            pouch = new Pouch();
            Initiative = randomNumber.Next(50, 101);
            FocusPercentage = 100;
        }
        internal override string GetName()
        {
            string listOfMale = "Jeremiah;Abraham;Douglas;Edgar;Jonathan;Marcus;Benjamin;Sylvester;David;Jacob";
            string listOfFemale = "Maria;Jenny;Johanna;Angelina;Sarah;Michelle;Buffy";
            string[] names;
            if (randomNumber.Next(1, 3) == 1)
                names = listOfMale.Split(';');
            else
                names = listOfFemale.Split(';');
            return names[randomNumber.Next(1, names.Length)];
        }
        internal void ItemToBackpack(IBag item)
        {
            if (backpack.open.Count() == backpack.Storage)
                System.Console.WriteLine("Cant add more items!");
            backpack.open.Add(item);
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public void LevelUp()
        {
            Level++;
            ExperiencePoints -= 100;
            Strength += randomNumber.Next(2, 7);
            Protection += randomNumber.Next(3, 6);
            StartingLife += 10;
            Life = StartingLife;
            if (ExperiencePoints >= 100)
                LevelUp();
        }

    }
}
