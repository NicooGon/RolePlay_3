using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace RoleplayGame
{
    public class Elfo: Personaje
    {
        public override int Health 
        {
            get {return 100;}
            set
            {
            }
            }
        public override int VP {get; set;} = 0;
        public Elfo (string name) : base(name)
        {
        AddItem(new Arco());
        AddItem(new Traje());
        }
    }
}
       