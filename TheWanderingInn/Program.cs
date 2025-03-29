using TheWanderingInnLib;

namespace TheWanderingInnConsole
{
    public class Program
    {
        /// <summary>Adds a <see cref="Skill"/> to a <see cref="Character"/>.</summary>
        /// <param name="character">The <see cref="Character"/> learning the <see cref="Skill"/>.</param>
        /// <param name="skillName">The <see cref="Skill"/>'s name.</param>
        /// <param name="effectType">The <see cref="Skill"/>'s effect type.</param>
        /// <param name="learn">Is the <see cref="Character"/> learning the <see cref="Skill"/>?</param>
        private static void ObtainSkill(Character character, string skillName, EffectType effectType, bool learn = false) => Console.WriteLine(character.ObtainSkill(GenerateSkill(skillName, effectType), learn));

        /// <summary>Generates a <see cref="Skill"/> with a basic description./// </summary>
        /// <param name="name">The <see cref="Skill"/>'s name.</param>
        /// <param name="effectType">The <see cref="Skill"/>'s effect type.</param>
        /// <returns>Generated <see cref="Skill"/></returns>
        private static Skill GenerateSkill(string name, EffectType effectType) => new()
        {
            Name = name,
            Description = name,
            Effects =
                [
                    new Effect
                    {
                        Name = name,
                        Description = name,
                        Type = effectType,
                        Uses=0,
                        CooldownPerUse = 0,
                    }
                ],
            TargetCount = 0
        };

        /// <summary>Changes a <see cref="Skill"/>.</summary>
        /// <param name="character">The <see cref="Character"/> whose <see cref="Skill"/> is changing.</param>
        /// <param name="oldName">The <see cref="Skill"/>'s old name.</param>
        /// <param name="newName">The <see cref="Skill"/>'s new name.</param>
        private static void SkillChange(Character character, string oldName, string newName, EffectType effectType)
        {
            if (character.Skills.Where(skill => skill.Name == oldName).ToList().Count > 0)
                Console.WriteLine(character.SkillChange(character.Skills.FirstOrDefault(skill => skill.Name == oldName), GenerateSkill(newName, effectType)));
        }

        /// <summary>Generates a <see cref="Character"/> representing Erin Solstice.</summary>
        /// <returns>Eric Solstice</returns>
        private static Character GenerateErin()
        {
            Character Erin = new()
            {
                Name = "Erin Solstice",
                Description = "A human from Earth.",
                CurrentMana = 200,
                MaximumMana = 200,
                ManaRestoredPerHour = 20,
                Classes = [],
                Skills = [],
                Spells = [],
            };
            Console.WriteLine($"Character {Erin.Name} created.\n");
            return Erin;
        }

        /// <summary>Simulates the progression of a <see cref="Character"/> named Erin.</summary>
        /// <param name="Erin"><see cref="Character"/> to be simulated.</param>
        private static void SimulateProgressionErin(Character Erin)
        {
            Console.WriteLine(Erin.GainClass("Innkeeper", "A person who maintains an inn."));
            ObtainSkill(Erin, "Basic Cleaning", EffectType.BasicCleaning);
            ObtainSkill(Erin, "Basic Cooking", EffectType.BasicCooking);
            Console.WriteLine(Erin.LevelUp("Innkeeper", 3));
            Console.WriteLine(Erin.LevelUp("Innkeeper", 1));
            ObtainSkill(Erin, "Basic Crafting", EffectType.BasicCrafting);
            Console.WriteLine(Erin.LevelUp("Innkeeper", 1));
            Console.WriteLine(Erin.LevelUp("Innkeeper", 3));
            ObtainSkill(Erin, "Bar Fighting", EffectType.BarFighting);
            ObtainSkill(Erin, "Unerring Throw", EffectType.UnerringThrow);
            Console.WriteLine(Erin.LevelUp("Innkeeper", 1));
            ObtainSkill(Erin, "Alcohol Brewer", EffectType.AlcoholBrewer);
            ObtainSkill(Erin, "Dangersense", EffectType.Dangersense);
            Console.WriteLine(Erin.LevelUp("Innkeeper", 1)); // Level 10 Innkeeper
            ObtainSkill(Erin, "Lesser Strength", EffectType.LesserStrength);
            ObtainSkill(Erin, "Immortal Moment", EffectType.ImmortalMoment, true);
            Console.WriteLine(Erin.LevelUp("Innkeeper", 2));
            ObtainSkill(Erin, "Loud Voice", EffectType.LoudVoice);
            Console.WriteLine(Erin.LevelUp("Innkeeper", 2));
            ObtainSkill(Erin, "Power Strike", EffectType.PowerStrike);
            Console.WriteLine(Erin.LevelUp("Innkeeper", 3));
            ObtainSkill(Erin, "Immunity: Alcohol", EffectType.ImmunityAlcohol);
            ObtainSkill(Erin, "Quick Recovery", EffectType.QuickRecovery);
            Console.WriteLine(Erin.GainClass("Warrior", "A warrior.", 2));
            ObtainSkill(Erin, "Lesser Endurance", EffectType.LesserEndurance);
            Console.WriteLine(Erin.LevelUp("Innkeeper", 1));
            Console.WriteLine(Erin.LevelUp("Innkeeper", 2));
            ObtainSkill(Erin, "Advanced Cooking", EffectType.AdvancedCooking);
            ObtainSkill(Erin, "Advanced Crafting", EffectType.AdvancedCrafting);
            Console.WriteLine(Erin.GainClass("Singer", "A singer.", 6));
            ObtainSkill(Erin, "Perfect Recall", EffectType.PerfectRecall);
            ObtainSkill(Erin, "Control Pitch", EffectType.ControlPitch);
            Console.WriteLine(Erin.LevelUp("Innkeeper", 4));
            ObtainSkill(Erin, "Inn's Aura", EffectType.InnsAura);
            ObtainSkill(Erin, "Wondrous Fare", EffectType.WondrousFare, true);
        }

        private static void Main(string[] args)
        {
            Character Erin = GenerateErin();
            SimulateProgressionErin(Erin);
        }
    }
}