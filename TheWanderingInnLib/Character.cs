namespace TheWanderingInnLib
{
    /// <summary>Represents a <see cref="Character"/> in the world.</summary>
    public class Character : Basic
    {
        #region Modifying Properties

        /// <summary>The amount of mana the <see cref="Character"/> currently has.</summary>
        public int CurrentMana { get; set; }

        /// <summary>The maximum amount of mana the <see cref="Character"/> can have.</summary>
        public int MaximumMana { get; set; }

        /// <summary>The amount of mana the <see cref="Character"/> restores per hour.</summary>
        public int ManaRestoredPerHour { get; set; }

        /// <summary>All the <see cref="CharacterClass"/>es the <see cref="Character"/> has.</summary>
        public List<CharacterClass> Classes { get; set; }

        /// <summary>All the <see cref="Skill"/>s the <see cref="Character"/> has.</summary>
        public List<Skill> Skills { get; set; }

        /// <summary>All the <see cref="Spell"/>s the <see cref="Character"/> has.</summary>
        public List<Spell> Spells { get; set; }

        #endregion Modifying Properties

        #region Methods

        /// <summary>Sorts the <see cref="CharacterClass"/>es in order by level.</summary>
        public void SortClassesByLevel() => Classes = Classes.OrderBy(c => c.Level).ToList();

        /// <summary>Adds a <see cref="CharacterClass"/> to the <see cref="Character"/>.</summary>
        /// <param name="name">Name of the <see cref="CharacterClass"/>.</param>
        /// <param name="description">Description of the <see cref="CharacterClass"/>.</param>
        /// <param name="startingLevel">Starting level of the <see cref="CharacterClass"/>.</param>
        /// <returns>Text about adding the <see cref="CharacterClass"/> to the <see cref="Character"/>.</returns>
        public string GainClass(string name, string description, int startingLevel = 1)
        {
            if (Classes.Where(c => c.Name == name).ToList().Count == 0)
            {
                Classes.Add(new CharacterClass(new CharacterClass
                {
                    Name = name,
                    Description = description,
                    Level = 1
                }));
                string classText = $"[{name} Class Obtained!]\n\n[{name} Level {startingLevel}]!\n";

                return classText;
            }
            return $"Character {Name} already has class {name}.";
        }

        /// <summary>Adds a <see cref="Skill"/> to the <see cref="Character"/>.</summary>
        /// <param name="skill">The <see cref="Skill"/> to be added.</param>
        /// <param name="learn">Is the <see cref="Character"/> learning the <see cref="Skill"/> instead of obtaining it?</param>
        /// <returns>Text about adding the <see cref="Skill"/> to the <see cref="Character"/>.</returns>
        public string ObtainSkill(Skill skill, bool learn = false)
        {
            if (!Skills.Contains(skill))
            {
                Skills.Add(new Skill(skill));
                if (!learn)
                    return $"[Skill – {skill.Name} obtained!]\n";
                return $"[Skill – {skill.Name} learned.]\n";
            }
            return $"Character {Name} already has skill {skill.Name}.";
        }

        /// <summary>Changes one of the <see cref="Character"/>'s <see cref="Skill"/>s.</summary>
        /// <param name="oldSkill">The <see cref="Skill"/> to be changed.</param>
        /// <param name="newSkill">The <see cref="Skill"/> that is replacing the old one.</param>
        /// <returns>Text about changing the <see cref="Skill"/>.</returns>
        public string SkillChange(Skill oldSkill, Skill newSkill)
        {
            string text = $"[Skill Change – {oldSkill.Name} → {newSkill.Name}]";
            Skills.Remove(oldSkill);
            return text + ObtainSkill(newSkill);
        }

        /// <summary>Activates a <see cref="Skill"/> which has no target.</summary>
        /// <returns>Text about activating the <see cref="Skill"/>.</returns>
        public string ActivateSkill()
        {
            //TODO Implement Skill activation with no target
            return "";
        }

        /// <summary>Activates a <see cref="Skill"/> which has a target.</summary>
        /// <param name="target">Target of the <see cref="Skill"/>.</param>
        /// <returns>Text about activating the <see cref="Skill"/>.</returns>
        public string ActivateSkill(Character target)
        {
            //TODO Implement Skill activation with a target
            return "";
        }

        /// <summary>Evolves a <see cref="CharacterClass"/> into a new one.</summary>
        /// <param name="charClass"><see cref="CharacterClass"/> to be evolved.</param>
        /// <param name="newName">New name of the <see cref="CharacterClass"/>.</param>
        /// <param name="newDescription">New description of the <see cref="CharacterClass"/>.</param>
        /// <returns>Text about the <see cref="CharacterClass"/> evolution.</returns>
        public static string ClassEvolution(CharacterClass charClass, string newName, string newDescription)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                charClass.Name = newName;
                charClass.Description = newDescription;
                return $"Conditions met to advance {charClass.Name} into {newName}.\n";
            }
            return "";
        }

        /// <summary>Levels up a <see cref="CharacterClass"/>.</summary>
        /// <param name="name">Name of the <see cref="CharacterClass"/> toe be leveled.</param>
        /// <param name="levelsGained">Number of levels gained</param>
        /// <returns>Text about the level up.</returns>
        public string LevelUp(string name, int levelsGained = 1)
        {
            if (Classes.Where(c => c.Name == name).ToList().Count != 0)
                return LevelUp(Classes.FirstOrDefault(c => c.Name == name), levelsGained);

            return $"Character {Name} does not have class {name}.";
        }

        /// <summary>Levels up a <see cref="CharacterClass"/>.</summary>
        /// <param name="charClass">Name of the <see cref="CharacterClass"/> toe be leveled.</param>
        /// <param name="levelsGained">Number of levels gained</param>
        /// <returns>Text about the level up.</returns>
        public static string LevelUp(CharacterClass charClass, int levelsGained = 1)
        {
            charClass.Level += levelsGained;
            string levelUpText = $"[{charClass.Name} Level {charClass.Level}!]\n";
            return levelUpText;
        }

        #endregion Methods

        #region Constructors

        /// <summary>Initializes a default instance of <see cref="Character"/>.</summary>
        public Character()
        {
        }

        /// <summary>Initializes an instance of <see cref="Character"/> using another instance.</summary>
        /// <param name="other">Other instance of <see cref="Character"/>.</param>
        public Character(Character other)
        {
            Name = other.Name;
            Description = other.Description;
            CurrentMana = other.CurrentMana;
            MaximumMana = other.MaximumMana;
            ManaRestoredPerHour = other.ManaRestoredPerHour;
            Classes = [.. other.Classes];
            Spells = [.. other.Spells];
            Skills = [.. other.Skills];
        }

        #endregion Constructors
    }
}