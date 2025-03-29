namespace TheWanderingInnLib
{
    /// <summary>Represents an <see cref="Effect"/> a <see cref="Spell"/> or <see cref="Skill"/> can have.</summary>
    public class Effect : Basic
    {
        /// <summary>The type of the <see cref="Effect"/>.</summary>
        public EffectType Type { get; set; }

        /// <summary>The number of uses the <see cref="Effect"/> has before running out.</summary>
        public int Uses { get; set; }

        /// <summary>The amount of time between uses of the <see cref="Effect"/>.</summary>
        public int CooldownPerUse { get; set; }
    }
}