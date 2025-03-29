namespace TheWanderingInnLib
{
    /// <summary>Represents a <see cref="CharacterClass"/> a <see cref="Character"/> can have.</summary>
    public class CharacterClass : Basic
    {
        /// <summary>The level of the <see cref="CharacterClass"/>.</summary>
        public int Level { get; set; }

        /// <summary>Initializes a default instance of <see cref="CharacterClass"/>.</summary>
        public CharacterClass()
        {
        }

        /// <summary>Initializes an instance of <see cref="CharacterClass"/> using another instance.</summary>
        /// <param name="other">Other instance of <see cref="CharacterClass"/>.</param>
        public CharacterClass(CharacterClass other)
        {
            Name = other.Name;
            Description = other.Description;
            Level = other.Level;
        }
    }
}