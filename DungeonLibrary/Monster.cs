using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //Fields
        private int _minDamage;

        //Properties
        public int MaxDamage { get; set; }
        public string Description { get; set; } = null!;

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value <= MaxDamage ? value : MaxDamage; }
        }

        //CTORS/Constructors
        public Monster(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) : base(name, maxLife, hitChance, block)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + $"\nDamage: {MinDamage} to {MaxDamage}\nDescription: {Description}\n";
        }
        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
        public static Monster GetMonster()
        {
            //Create a variety of monsters
            Monster m1 = new("White Rabbit", 25, 50, 20, 8, 2, "Is that blood? And fangs?");
            Monster m2 = new("Dracula", 30, 70, 8, 8, 1, "Father of all the undead.");
            Monster m3 = new("Mikey", 25, 50, 10, 4, 1, "He is no longer a teenager, but he is still a mutant turtle.");
            Monster m4 = new("Smaug", 70, 65, 30, 15, 3, "The last great dragon.");
            //Add the monsters to a collection
            List<Monster> monsters = new()
            {
                m1,m1,//20%
                m2,m2,m2,m2,//40%
                m3,m3,m3,//30%
                m4,//10%
            };
            //Pick one at random to place in our dungeon room.
            return monsters[new Random().Next(monsters.Count)];
        }
    }

    //public enum Monsters
    //{
    //    Minotaur,
    //    Siren,
    //    White_Rabbit,
    //    Mini_Me,
    //    Spooder,
    //    Giant_Eggplant
    //}
}
