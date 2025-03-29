using System.ComponentModel;

namespace TheWanderingInnLib
{
    /// <summary>Represents the various types of <see cref="Effect"/>s <see cref="Skill"/>s and <see cref="Spell"/>s can have.</summary>
    public enum EffectType
    {
        [Description("Basic Cleaning")]
        BasicCleaning,

        [Description("Basic Cooking")]
        BasicCooking,

        [Description("Basic Crafting")]
        BasicCrafting,

        [Description("Bar Fighting")]
        BarFighting,

        [Description("Unerring Throw")]
        UnerringThrow,

        [Description("Alcohol Brewer")]
        AlcoholBrewer,

        [Description("Dangersense")]
        Dangersense,

        [Description("Lesser Strength")]
        LesserStrength,

        [Description("Immortal Moment")]
        ImmortalMoment,

        [Description("Loud Voice")]
        LoudVoice,

        [Description("PowerStrike")]
        PowerStrike,

        [Description("Immunity: Alcohol")]
        ImmunityAlcohol,

        [Description("Quick Recovery")]
        QuickRecovery,

        [Description("Lesser Endurance")]
        LesserEndurance,

        [Description("Advanced Cooking")]
        AdvancedCooking,

        [Description("Advanced Crafting")]
        AdvancedCrafting,

        [Description("Perfect Recall")]
        PerfectRecall,

        [Description("ControlPitch")]
        ControlPitch,

        [Description("Inn's Aura")]
        InnsAura,

        [Description("Wondrous Fare")]
        WondrousFare,

        [Description("MinotaurPunch")]
        MinotaurPunch
    }
}