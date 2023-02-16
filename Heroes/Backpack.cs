class Backpack : IBag
{
    public string Name { get; set; }
    public int Storage { get; set; }
    public List<IBag> open;

    public Backpack(string name)
    {
        Name = name;
        Storage = 10;
        open = new List<IBag>();
    }
}