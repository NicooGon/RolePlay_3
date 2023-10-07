using System.Collections.Generic;

namespace RoleplayGame
{
    public class Araña : Personaje
    {
        public override int VP {get; set;} = 3;
        public Araña (string name) : base(name)
        {
            Health = 70;
            AddItem(new Telaraña());
            AddItem(new Picadura());
        }
    }
}