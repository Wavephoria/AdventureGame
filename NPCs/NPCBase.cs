namespace AdventureGame
{
    abstract class NPCBase : BaseAttributesForAll
    {
        public abstract string Profession { get; set; }
        internal override string GetName()
        {
            return $"Edward the {Profession}";
        }
    }
}