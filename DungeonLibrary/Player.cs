using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //Fields

        //Properties
        public Races PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        //CTORS/Constructors
        public Player(string name, int maxLife, int hitChance, int block, Races playerRace, Weapon equippedWeapon) : base(name, maxLife, hitChance, block)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Races.Human:
                    break;
                case Races.Orc:
                    break;
                case Races.Elf:
                    HitChance += 5;
                    break;
                case Races.Centaur:
                    break;
                case Races.Dwarf:
                    break;
                case Races.Lupine:
                    break;
                case Races.Felidae:
                    break;
            }
            #endregion
        }

        //Methods
        public override string ToString()
        {
            //create a string, switch on Player Race, and write some description about that race.
            string description = PlayerRace.ToString();
            switch (PlayerRace)
            {
                case Races.Human:
                    description = $"{Name} is a common human.";
                    break;
                case Races.Orc:
                    break;
                case Races.Elf:
                    break;
                case Races.Centaur:
                    break;
                case Races.Dwarf:
                    description = $"{Name} is an angry shortstack.";
                    break;
                case Races.Lupine:
                    break;
                case Races.Felidae:
                    break;
            }
            return base.ToString() + $"\nEquipped {EquippedWeapon}\n" +
                $"Description: {description}";
        }
        public override int CalcDamage()
        {
            //Create a random object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(EquippedWeapon.MinDmg, EquippedWeapon.MaxDmg + 1);
            //return the damage
            return damage;
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
    }
}
