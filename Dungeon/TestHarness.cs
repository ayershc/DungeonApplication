using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            //Build and test the functionality of our Library

            //Build and test a weapon
            Console.WriteLine("*** Test Weapon ***");
            Weapon w1 = new("Excalibur", 4, 11, 2, false, 0);
            Console.WriteLine(w1);
            Console.WriteLine("*** *** *** *** ***\n");

            //Build and test a character - include (CalcBlock(), CalcHitChance(), CalcDamage()
            Console.WriteLine("*** Test Character ***");
            Player p1 = new("Desi", 50, 5, 2, Races.Dwarf, w1);
            Console.WriteLine(p1);
            Console.WriteLine($"Hit Chance: {p1.CalcHitChance()}\n" +
                              $"Block: {p1.CalcBlock()}\n" +
                              $"Damage: {p1.CalcDamage()}\n");
            Console.WriteLine("***  ***  ***  *** ***\n");

            //Test the monster

            Console.WriteLine(Monster.GetMonster());
            Monster monster = Monster.GetMonster();
        }
    }
}
