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

        public Hero()
        {
            StartPosition = Position[X, Y];
            Name = GetName();
            Level = 10;
            HeroClass = HeroClasses.Adventurer;
            Life = randomNumber.Next(100, 151);
            backpack = new Backpack($"{Name}s backpack");
            pouch = new Pouch();
            Initiative = randomNumber.Next(50, 101);
            FocusPercentage = 100;
        }
        internal override string GetName()
        {
            string listOfMale = File.ReadAllText("Heroes/HeroNamesMale.txt");
            string listOfFemale = File.ReadAllText("Heroes/HeroNamesFemale.txt");
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

    }
}
