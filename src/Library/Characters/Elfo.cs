using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace RoleplayGame
{
    public class Elfo: Personaje, Heroe
    {
        public override int Health 
        {
            get {return 100;}
            set
            {
            }
            }
        public int Puntos {get;}
        public Elfo (string name) : base(name)
        {
        AddItem(new Arco());
        AddItem(new Traje());
        }
    }
}
       