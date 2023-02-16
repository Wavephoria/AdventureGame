namespace AdventureGame
{
    class Hero : BaseAttributesForAll
    {
        public HeroClasses HeroClass { get; init; }
        public Elements Element { get; set; }
        public int ExperiencePoints { get; set; }
        public Backpack backpack;

        public Hero(HeroClasses heroClass, Elements element)
        {
            Name = GetName();
            HeroClass = heroClass;
            Life = RandomHeroLife(heroClass);
            Element = element;
            backpack = new Backpack($"{Name}s backpack");
            Initiative = randomNumber.Next(50, 101);
        }
        private int RandomHeroLife(HeroClasses heroClass)
        {
            // int life = 100;
            // Random randomNumber = new Random();
            return 100;
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
    }
}
