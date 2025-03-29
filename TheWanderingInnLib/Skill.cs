namespace TheWanderingInnLib
{
    /// <summary>Represents a <see cref="Skill"/> a <see cref="Character"/> can use.</summary>
    public class Skill : Basic
    {
        /// <summary>All the <see cref="Effect"/>s of the <see cref="Skill"/>.</summary>
        public List<Effect> Effects { get; set; } = [];

        /// <summary>The number of targets the <see cref="Skill"/> can effect</summary>
        public int TargetCount { get; set; }

        /// <summary>Initializes a default instance of <see cref="Skill"/>.</summary>
        public Skill()
        { }

        /// <summary>Initializes an instance of <see cref="Skill"/> using another instance.</summary>
        /// <param name="other">Other instance of <see cref="Skill"/>.</param>
        public Skill(Skill other)
        {
            Name = other.Name;
            Description = other.Description;
            Effects = [.. other.Effects];
            TargetCount = other.TargetCount;
        }
    }
}