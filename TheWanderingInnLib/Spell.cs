namespace TheWanderingInnLib
{
    /// <summary>Represents a <see cref="Spell"/> a <see cref="Character"/> can cast.</summary>
    public class Spell : Basic
    {
        /// <summary>The mana cost of the <see cref="Spell"/>.</summary>
        public int ManaCost { get; set; }

        /// <summary>All the <see cref="Effect"/>s of the <see cref="Spell"/>.</summary>
        public List<Effect> Effects { get; set; } = [];

        /// <summary>The number of targets the <see cref="Spell"/> can effect</summary>
        public int TargetCount { get; set; }

        /// <summary>Initializes a default instance of <see cref="Spell"/>.</summary>
        public Spell()
        { }

        /// <summary>Initializes an instance of <see cref="Spell"/> using another instance.</summary>
        /// <param name="other">Other instance of <see cref="Spell"/>.</param>
        public Spell(Spell other)
        {
            Name = other.Name;
            Description = other.Description;
            ManaCost = other.ManaCost;
            Effects = [.. other.Effects];
            TargetCount = other.TargetCount;
        }
    }
}