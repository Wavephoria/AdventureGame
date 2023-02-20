namespace AdventureGame
{
    class Pouch
    {
        public int Gold { get; set; }
        public int Silver { get; set; }

        public Pouch()
        {
            Gold = 5;
            Silver = 25;
        }

        public override string ToString()
        {
            if (Gold == 0 && Silver == 0)
                return $"You have no gold or silver left!";
            else if (Gold == 0)
                return $"You have {Silver} left!";
            else if (Silver == 0)
                return $"You have {Gold} left!";
            else
                return $"You have {Gold} gold and {Silver} silver";
        }
    }
}