namespace AdventureGame
{
    class Item : IBag
    {
        public string Name { get; set; }

        public Item(string name)
        {
            Name = name;
        }
    }
}