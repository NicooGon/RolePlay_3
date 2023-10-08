using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace RoleplayGame
{
    public class Elfo: Personaje
    {
        public Elfo (string name) : base(name)
        {
            VP = 0;
            Health = 100;
            AddItem(new Arco());
            AddItem(new Traje());
        }
    }
}
       