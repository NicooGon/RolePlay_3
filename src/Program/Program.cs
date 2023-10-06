using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroMagico book = new LibroMagico();
            book.AddSpell(new HechizoUno());
            book.AddSpell(new HechizoUno());

            Mago Rasagast = new Mago("Rasagast");

            Rasagast.AddItem(book);

            Enano Thorin = new Enano("Thorin");

            Console.WriteLine($"Thorin has ❤️ {Thorin.Health}");
            int staffDamage = Rasagast.AttackValue; 
            int spellDamage = Rasagast.GetTotalSpellDamage();
            int totalDamage = staffDamage + spellDamage;

            Console.WriteLine($"Rasagast attacks Thorin with ⚔️ {totalDamage} (Staff: {staffDamage}, Spell: {spellDamage})");

            Thorin.ReceiveAttack(totalDamage);

            Console.WriteLine($"Thorin has ❤️ {Thorin.Health}");

            Thorin.Cure();

            Console.WriteLine($"Someone cured Thorin. Thorin now has ❤️ {Thorin.Health}");

            Hobbit Gollum = new Hobbit("Gollum");
            
            Encuentro Encuentro1 = new Encuentro();
            Encuentro1.DoEncounter(); 
        }
    }
}