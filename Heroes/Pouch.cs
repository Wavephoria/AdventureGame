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
            return $"You have {Gold} gold and {Silver} silver";
        }
    }
}