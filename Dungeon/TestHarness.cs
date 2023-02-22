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
            //Build and test a character - include (CalcBlock(), CalcHitChance(), CalcDamage()
            Character c1 = new("Desi", 50, 5, 2);
            Console.WriteLine(c1);
            //Build and test a weapon
            Weapon w1 = new("Excalibur", 4, 11, 2, false, 0);
            Console.WriteLine(w1);

            Console.WriteLine($"{c1.Name}\n" +
                $"Hit: {c1.CalcHitChance()}\n" +
                $"Block: {c1.CalcBlock()}\n" +
                $"Damage: {c1.CalcDamage()}\n");
        }
    }
}
