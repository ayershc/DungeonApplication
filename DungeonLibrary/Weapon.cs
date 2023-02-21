using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make it public!
    public class Weapon
    {
        //Fields
        /*
         * int for min damage (cannot be less than 0, or > max dmg)
         * int for max damage (cannot be less than 0) -- assign first in the ctor
         * string for the name of the weapon
         * int for bonusHitChance
         * bool isTwoHanded
         */
        private string _weaponName;
        private int _minDmg;
        private int _maxDmg;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //Properties - 1 for each field
        public string WeaponName
        {
            get { return _weaponName; }
            set { _weaponName = value; }
        }
        public int MinDmg
        {
            get { return _minDmg; }
            set { _minDmg = value; }
        }
        public int MaxDmg
        {
            get { return _maxDmg; }
            set { _maxDmg = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        //CTORS/Constructors - 1 qualified; and one unqualified (default) if you want Object Initialization Syntax
        public Weapon() { }//default

        public Weapon(string weaponName, int minDmg, int maxDmg, int bonusHitChance, bool isTwoHanded)
        {
            WeaponName = weaponName;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;          
        }

        //Methods
        //Nicely formatted ToString() override
        public override string ToString()
        {
            //return base.ToString();
            return $"Weapon: {WeaponName}\n" +
                $"{(IsTwoHanded ? "Two-" : "One-")}Handed\n" +
                $"Damage: {MinDmg} - {MaxDmg}\n" +
                $"Crit Chance: {BonusHitChance}\n";
        }
    }
}
