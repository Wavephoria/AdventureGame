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
        string listOfName = File.ReadAllText("Heroes/HeroNamesMale.txt");
        string[] names = listOfName.Split(';');
        int number = randomNumber.Next(1, names.Length);
        return names[number];
    }
    internal void ItemToBackpack(IBag item)
    {
        if (backpack.open.Count() == backpack.Storage)
            System.Console.WriteLine("Cant add more items!");
        backpack.open.Add(item);
    }
}
