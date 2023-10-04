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
            Console.WriteLine($"Rasagast attacks Thorin with ⚔️ {Rasagast.AttackValue}");

            Thorin.ReceiveAttack(Rasagast.AttackValue);

            Console.WriteLine($"Thorin has ❤️ {Thorin.Health}");

            Thorin.Cure();

            Console.WriteLine($"Someone cured Thorin. Thorin now has ❤️ {Thorin.Health}");
        }
    }
}
