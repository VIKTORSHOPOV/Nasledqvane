using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Players_and_Monsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "Hero": Hero hero = new Hero(Console.ReadLine(), int.Parse(Console.ReadLine())); Console.WriteLine(hero.ToString()); break;
                case "Elf": Elf elf = new Elf(Console.ReadLine(), int.Parse(Console.ReadLine())); Console.WriteLine(elf.ToString()); break;
                case "MuseElf": MuseElf museElf = new MuseElf(Console.ReadLine(), int.Parse(Console.ReadLine())); Console.WriteLine(museElf.ToString()); break;
                case "Wizard": Wizard wizard = new Wizard(Console.ReadLine(), int.Parse(Console.ReadLine())); Console.WriteLine(wizard.ToString()); break;
                case "DarkWizard": DarkWizard darkWizard = new DarkWizard(Console.ReadLine(), int.Parse(Console.ReadLine())); Console.WriteLine(darkWizard.ToString()); break;
                case "SoulMaster": SoulMaster soulMaster = new SoulMaster(Console.ReadLine(), int.Parse(Console.ReadLine())); Console.WriteLine(soulMaster.ToString()); break;
                case "Knight": Knight knight = new Knight(Console.ReadLine(), int.Parse(Console.ReadLine())); Console.WriteLine(knight.ToString()); break;
                case "DarkKnight": DarkKnight darkKnight = new DarkKnight(Console.ReadLine(), int.Parse(Console.ReadLine())); Console.WriteLine(darkKnight.ToString()); break;
                case "BladeKnight": BladeKnight bladeKnight = new BladeKnight(Console.ReadLine(), int.Parse(Console.ReadLine())); Console.WriteLine(bladeKnight.ToString()); break;
                default: Hero def = new Hero("0", 0); Console.WriteLine(def.ToString()); break;
            }
        }
    }
}
